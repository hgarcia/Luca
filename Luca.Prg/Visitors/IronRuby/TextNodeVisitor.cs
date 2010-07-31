using System.Text.RegularExpressions;

namespace Luca.Prg.Visitors.IronRuby
{
	public class TextNodeVisitor : INodeVisitor
	{
		public int Order
		{
			get { return 1; }
		}
		private static string parse(string line)
		{
			if (isStatement(line)) return line;
			return parseString(line);
		}
		private static bool isStatement(string line)
		{
			return line.Contains("<!--#{");
		}


		private static MatchCollection getMatchCollection(string line)
		{
			const string regexPattern = "\".*?\"";
			return Regex.Matches(line, regexPattern, RegexOptions.None);
		}

		private static string parseString(string line)
		{
			var matches = getMatchCollection(line);
			line = parseStringSections(line, matches);
			return string.Format("self.output += \"{0}\\r\\n\"\r\n", line);
		}

		private static string parseStringSections(string line, MatchCollection matches)
		{
			foreach (var match in matches)
			{
				var stringSection = fixStringSection(match.ToString());
				line = line.Replace(match.ToString(), stringSection);
			}
			return line;
		}

		private static string fixStringSection(string stringSection)
		{
			return stringSection.Replace("\"", "\\\"");
		}

		public void Visit(INodeParser nodeParser)
		{
			nodeParser.Line = parse(nodeParser.Line);
		}
	}
}