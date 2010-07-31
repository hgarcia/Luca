using System.Text;

namespace Luca.Prg.Visitors.IronRuby
{
	public class AreaNodeVisitor : INodeVisitor
	{
		public int Order
		{
			get { return 5; }
		}
		private const string VariableStart = "#{area.";

		private static bool isArea(string line)
		{			
			return line.Contains(VariableStart);
		}

		private static string parse(string line)
		{
			if (!isArea(line)) return line;
			return parseArea(line);
		}

		private static string parseArea(string line)
		{
			var areaName = line.Replace(VariableStart, "").Replace("}", "").Trim().ToLower();
			var sb = new StringBuilder();
			sb.AppendLine(string.Format("var area{0} = Model.Areas.FirstOrDefault(a=>a.Name.ToLower() == \"{0}\");", areaName));
			sb.AppendLine(string.Format("RenderCollection((IList<IRenderable>)area{0}.Layout, writer);", areaName));
			return sb.ToString();
		}

		public void Visit(INodeParser nodeParser)
		{
			nodeParser.Line = parse(nodeParser.Line);
		}
	}
}