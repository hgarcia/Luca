using System.Text.RegularExpressions;

namespace Luca.Prg.Visitors.IronRuby
{
	public class PhraseNodeVisitor : INodeVisitor
	{
		public int Order
		{
			get { return 2; }
		}
		private const string VariableStart = "#{phrases.";

		private static MatchCollection getMatchCollection(string line)
		{
			const string regexPattern = "#{phrases.*?}";
			return Regex.Matches(line, regexPattern, RegexOptions.None);
		}
		private static bool isPhrase(string line)
		{
			return line.Contains(VariableStart);
		}

		private static string parse(string line)
		{
			if (!isPhrase(line)) return line;
			var matches = getMatchCollection(line);
			return parsePhrase(line, matches);
		}

		private static string parsePhrase(string line, MatchCollection matches)
		{
			foreach (var match in matches)
			{
				var phrase = parseObjectWithProperty(match);
				line = line.Replace( match.ToString(),phrase);
			}
			return line;
		}
		private static string getPhraseKey(string line)
		{
			var phraseKey = line.Replace(VariableStart, "").Replace("}", "").Trim();
			phraseKey = fixEnding(phraseKey);
			phraseKey = phraseKey.Replace("_", " ");		//underscore
			return phraseKey;
		}

		private static string parseObjectWithProperty(object match)
		{
			return string.Format("\" + localization.GetPhrase(\"{0}\",lang) + \"", getPhraseKey(match.ToString()));
		}


		private static string fixEnding(string phraseKey)
		{
			if (phraseKey.EndsWith("__"))return phraseKey.Remove(phraseKey.Length - 2) + "++";
			if (phraseKey.EndsWith("_")) return phraseKey.Remove(phraseKey.Length - 1) + "+";
			return phraseKey;
		}

		public void Visit(INodeParser nodeParser)
		{
			nodeParser.Line = parse(nodeParser.Line);
		}
	}
}