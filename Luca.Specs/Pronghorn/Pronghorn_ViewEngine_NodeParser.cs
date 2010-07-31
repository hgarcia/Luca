using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using Pronghorn.ViewEngine;
using Pronghorn.ViewEngine.Visitors;

namespace Specs
{
	[TestFixture]
	public class Pronghorn_ViewEngine_NodeParser
	{
		[Test]
		public void Given_a_collection_of_visitors_Should_run_them_in_the_visitors_order()
		{
			var line = string.Empty;
			var expectedResult = "First Visitor\nSecond Visitor\nThird Visitor\n";
			var visitors = new List<INodeVisitor>
			                   {
								   new ThirdVisitor(),
									new SecondVisitor(),
			                       new FirstVisitor() 
			                   };
			var node = new NodeParser(line, visitors);
			var sw = new StringWriter();
			node.Parse(sw);

			Assert.That(sw.ToString(), Is.EqualTo(expectedResult));
		}

		public class FirstVisitor : INodeVisitor
		{
			public void Visit(INodeParser nodeParser)
			{
				nodeParser.Line += "First Visitor\n";
			}

			public int Order
			{
				get { return 1; }
			}
		}
		public class SecondVisitor : INodeVisitor
		{
			public void Visit(INodeParser nodeParser)
			{
				nodeParser.Line += "Second Visitor\n";
			}

			public int Order
			{
				get { return 2; }
			}
		}
		public class ThirdVisitor : INodeVisitor
		{
			public void Visit(INodeParser nodeParser)
			{
				nodeParser.Line += "Third Visitor\n";
			}

			public int Order
			{
				get { return 3; }
			}
		}
	}
}