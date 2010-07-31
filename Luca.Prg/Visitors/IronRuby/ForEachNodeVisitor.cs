using System.Text;

namespace Luca.Prg.Visitors.IronRuby
{
	public class ForEachNodeVisitor : INodeVisitor
	{
		public int Order
		{
			get { return 4; }
		}
		private const string _startForEach = "<!--#{foreach";

		private static string _endforeach = "<!--#{endforeach}-->";

		private static bool isForEach(string line)
		{
			return line.Contains(_startForEach);
		}

		private static bool isForEachEnd(string line)
		{
			return line.Contains(_endforeach);
		}

		private static string parseEnd(string line)
		{
			if (!isForEachEnd(line)) return line;
			return "end\r\n";
		}

		private static string parseStart(string line)
		{
			if (!isForEach(line)) return line;

			const string end = "}-->";
			var feArray = line.Replace(_startForEach, "").Replace(end, "").Trim().Split(' ');

			var builder = new StringBuilder();
			builder.AppendFormat("for {0} {1} {2}\r\n",feArray[0],feArray[1], feArray[2]);

			return builder.ToString();
		}

		public void Visit(INodeParser nodeParser)
		{
			nodeParser.Line = parseStart(nodeParser.Line);
			nodeParser.Line = parseEnd(nodeParser.Line);
		}
	}
}