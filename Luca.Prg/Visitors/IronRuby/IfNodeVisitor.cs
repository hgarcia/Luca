namespace Luca.Prg.Visitors.IronRuby
{
	public class IfNodeVisitor : INodeVisitor
	{
		public int Order
		{
			get { return 3; }
		}
		private static string _ifStart = "<!--#{if";

		private static bool isIf(string line)
		{
			return line.Contains(_ifStart);
		}

		private bool isIfEnd(string line)
		{
			return line.Contains("<!--#{endif}-->");
		}

		private bool isIfElse(string line)
		{
			return line.Contains("<!--#{else}-->");
		}
		private string parseEnd(string line)
		{
			if (!isIfEnd(line)) return line; 
			return "end\r\n";
		}

		private string parseStart(string line)
		{
			if (!isIf(line)) return line;
			var item = line.Replace(_ifStart, "").Replace("}-->", "").Trim();
			return string.Format("if {0}\r\n",item);
		}

		public void Visit(INodeParser nodeParser)
		{
			nodeParser.Line = parseStart(nodeParser.Line);
			nodeParser.Line = parseElse(nodeParser.Line);
			nodeParser.Line = parseEnd(nodeParser.Line);
		}

		private string parseElse(string line)
		{
			if (!isIfElse(line)) return line;
			return "else\r\n";
		}

	}
}