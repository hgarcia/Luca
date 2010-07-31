namespace Luca.Prg.Visitors.IronRuby
{
	public class ScriptNodeVisitor : INodeVisitor
	{
		public int Order
		{
			get { return 3; }
		}
		private bool isScript(string line)
		{
			return line.Contains("<!--#{scripts}-->");
		}

		private string parse(string line)
		{
			if(!isScript(line)) return line;
			return "RenderScripts(writer);\r\n";
		}

		public void Visit(INodeParser nodeParser)
		{
			nodeParser.Line = parse(nodeParser.Line);
		}
	}
}