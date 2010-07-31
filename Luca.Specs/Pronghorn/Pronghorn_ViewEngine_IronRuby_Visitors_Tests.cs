using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using Pronghorn.ViewEngine;
using Pronghorn.ViewEngine.Visitors;
using Pronghorn.ViewEngine.Visitors.IronRuby;

namespace Specs
{
	[TestFixture]
	public class Pronghorn_ViewEngine_IronRuby_Visitors_Tests
	{

		[Test]
		public void Given_a_text_node_Should_convert_the_line_to_a_string_and_assign_to_self_dot_output()
		{
			const string line = @"<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.0 Transitional//EN"">";
			const string expectedResult = @"self.output += ""<!DOCTYPE HTML PUBLIC \""-//W3C//DTD HTML 4.0 Transitional//EN\"">\r\n""
";
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
		public void Given_a_foreach_node_replace_the_line_with_the_right_code()
		{
			const string line = "<!--#{foreach movie in movies}-->";
			const string expectedResult = "for movie in movies\r\n";
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
		public void Given_an_end_foreach_node_replace_the_line_with_the_right_code()
		{
			const string line = "<!--#{endforeach}-->";
			const string expectedResult = "end\r\n";
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
			const string expectedResult = "end\r\n";
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
			const string expectedResult = "if display\r\n";
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
		public void Given_an_ifnode_else_replace_the_line_with_the_right_code()
		{
			const string line = "<!--#{else}-->";
			const string expectedResult = "else\r\n";
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

		/*[Test]
		public void Given_a_phrase_Should_use_the_localization_service_to_call_the_phrase()
		{
			const string line = "#{phrases.Themes}";
			const string expectedResult = "\" + localization.GetPhrase(\"Themes\",lang) + \"";
			var visitors = new List<INodeVisitor>
			                   {
			                       new PhraseNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		[Test]
		public void Given_a_phrase_with_underscores_in_the_middle_Should_replace_them_with_spaces()
		{
			const string line = "#{phrases.Hunk_Of_the_day}";
			const string expectedResult = "\" + localization.GetPhrase(\"Hunk Of the day\",lang) + \"";
			var visitors = new List<INodeVisitor>
			                   {
			                       new PhraseNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		[Test]
		public void Given_a_phrase_with_2_underscores_at_the_end_Should_replace_them_with_2_plus_signs()
		{
			const string line = "#{phrases.Themes__}";
			const string expectedResult = "\" + localization.GetPhrase(\"Themes++\",lang) + \"";
			var visitors = new List<INodeVisitor>
			                   {
			                       new PhraseNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		[Test]
		public void Given_a_phrase_with_1_underscore_at_the_end_Should_replace_them_with_1_plus_signs()
		{
			const string line = "#{phrases.Themes_}";
			const string expectedResult = "\" + localization.GetPhrase(\"Themes+\",lang) + \"";
			var visitors = new List<INodeVisitor>
			                   {
			                       new PhraseNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}


		[Test]
		public void Given_a_line_with_a_phrase_Should_replace_the_phrase_and_leave_the_rest_of_the_line_as_it_was()
		{
			const string line = "<div>#{property} #{phrases.Themes_}</div>";
			const string expectedResult = "<div>#{property} \" + localization.GetPhrase(\"Themes+\",lang) + \"</div>";
			var visitors = new List<INodeVisitor>
			                   {
			                       new PhraseNodeVisitor()
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}*/
	}
}