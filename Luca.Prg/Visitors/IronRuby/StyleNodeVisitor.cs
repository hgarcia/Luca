namespace Luca.Prg.Visitors.IronRuby
{
	public class StyleNodeVisitor : INodeVisitor
	{
		public int Order
		{
			get { return 3; }
		}
		private bool isStyle(string line)
		{
			return line.Contains("<!--#{styles}-->");
		}

		private string parse(string line)
		{
			if (!isStyle(line)) return line;
			return "RenderCss(writer);\r\n";
		}

		public void Visit(INodeParser nodeParser)
		{
			nodeParser.Line = parse(nodeParser.Line);
		}
	}
}