using System.Collections.Generic;
using System.IO;
using Luca.Prg;
using Luca.Prg.Visitors;
using Luca.Prg.Visitors.IronRuby;
using NUnit.Framework;

namespace Luca.Specs.Prg
{
	[TestFixture]
	public class Luca_Prg_CSharp_Visitors_Tests
	{
		[Test]
		public void Given_a_foreach_node_replace_the_line_with_the_right_code()
		{
			const string line = "<!--#{foreach movie in movies}-->";
			const string expectedResult = "var movies = Model.Data.GetIEnumerable(\"movies\");\r\n if (movies != null){\r\n foreach(var movie in movies){\r\n";
			var visitors = new List<INodeVisitor>
			                   {
			                       new ForEachNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		[Test]
		public void Given_a_text_node_encapsulate_the_line_in_a_stream_write()
		{
			const string line = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">";
			const string expectedResult = "writer.Write(\"<!DOCTYPE HTML PUBLIC \\\"-//W3C//DTD HTML 4.0 Transitional//EN\\\">\");\r\n";
			var visitors = new List<INodeVisitor>
			                   {
			                       new TextNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(),Is.EqualTo(expectedResult));
		}

		[Test]
		public void Given_a_text_node_with_a_variable_in_it_creates_a_line_of_code()
		{
			const string line = "<div>#{movie}</div>";
			const string expectedResult = "writer.Write( string.Format(\"<div>{0}</div>\",Model.Data.GetString(\"movie\")) );\r\n";
			var visitors = new List<INodeVisitor>
			                   {
			                       new TextNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		[Test]
		public void Given_a_text_node_with_a_variable_with_propeties_it_call_GetString_object_property_path()
		{
			const string line = "<div>#{movie.Title}</div>";
			const string expectedResult = "writer.Write( string.Format(\"<div>{0}</div>\",Model.Data.GetString(movie,\"movie.Title\")) );\r\n";
			var visitors = new List<INodeVisitor>
			                   {
			                       new TextNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		[Test]
		public void Given_a_text_node_with_more_than_one_variable_in_it_creates_a_line_of_code()
		{
			const string line = "<div>#{movie}<img src=\"#{imgSrc}\" border=\"0\"/></div><p>#{movie}</p>";
			const string expectedResult = "writer.Write( string.Format(\"<div>{0}<img src=\\\"{1}\\\" border=\\\"0\\\"/></div><p>{0}</p>\",Model.Data.GetString(\"movie\"),Model.Data.GetString(\"imgSrc\")) );\r\n";
			var visitors = new List<INodeVisitor>
			                   {
			                       new TextNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		[Test]
		public void Given_an_area_variable_TextVisitor_ignores_it()
		{
			const string line = "<tr><td>#{area.LeftNavBar}</td></tr>";
			const string expectedResult = "<tr><td>#{area.LeftNavBar}</td></tr>";
			var visitors = new List<INodeVisitor>
			                   {
			                       new TextNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		[Test]
		public void Given_an_array_of_metaTags_pass_it_to_the_view_meta_renderer()
		{
			const string line = "<!--#{metatags}-->";
			const string expectedResult = "RenderCollection((IList<IRenderable>)Model.MetaTags, writer);\r\n";

			var visitors = new List<INodeVisitor>
			                   {
			                       new MetaNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		[Test]
		public void Given_an_array_of_scripts_pass_it_to_the_view_scripts_renderer()
		{
			const string line = "<!--#{scripts}-->";
			const string expectedResult = "RenderScripts(writer);\r\n";
			var visitors = new List<INodeVisitor>
			                   {
			                       new ScriptNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		[Test]
		public void Given_an_array_of_styles_pass_it_to_the_view_style_renderer()
		{
			const string line = "<!--#{styles}-->";
			const string expectedResult = "RenderCss(writer);\r\n";
			var visitors = new List<INodeVisitor>
			                   {
			                       new StyleNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		[Test]
		public void Given_an_end_foreach_node_replace_the_line_with_the_right_code()
		{
			const string line = "<!--#{endforeach}-->";
			const string expectedResult = "}\r\n }\r\n";
			var visitors = new List<INodeVisitor>
			                   {
			                       new ForEachNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		[Test]
		public void Given_an_ifnodeEnd_replace_the_line_with_the_right_code()
		{
			const string line = "<!--#{endif}-->";
			const string expectedResult = "}\r\n";
			var visitors = new List<INodeVisitor>
			                   {
			                       new IfNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		[Test]
		public void Given_an_ifnode_replace_the_line_with_the_right_code()
		{
			const string line = "<!--#{if display}-->";
			const string expectedResult = "if (Model.Data.IsTrue(\"display\")){\r\n";
			var visitors = new List<INodeVisitor>
			                   {
			                       new IfNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		[Test]
		public void Given_just_an_area_convert_it_in_a_foreach_and_call_Render_on_the_IWidgets()
		{
			const string line = "#{area.LeftNavBar}";
			const string expectedResult = "var arealeftnavbar = Model.Areas.FirstOrDefault(a=>a.Name.ToLower() == \"leftnavbar\");\r\nRenderCollection((IList<IRenderable>)arealeftnavbar.Layout, writer);\r\n";
			var visitors = new List<INodeVisitor>
			                   {
			                       new AreaNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		[Test]
		public void Parsing_the_Title_Should_call_Model_dot_Title()
		{
			const string line = "<title>#{title}</title>";
			const string expectedResult = "writer.Write( string.Format(\"<title>{0}</title>\",Model.PageTitle) );\r\n";
			var visitors = new List<INodeVisitor>
			                   {
			                       new TextNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

	}
}