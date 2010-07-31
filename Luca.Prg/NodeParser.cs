using System.Collections.Generic;
using System.IO;
using System.Linq;
using Luca.Prg.Visitors;

namespace Luca.Prg
{
	public class NodeParser : INodeParser
	{
		private string _line;
		private readonly IList<INodeVisitor> _visitors;


		public NodeParser(string line, IList<INodeVisitor> visitors)
		{
			Line = line;
			_visitors = visitors;
		}

		public string Line
		{
			get { return _line; }
			set { _line = value; }
		}

		public void Parse(TextWriter writer)
		{
			_visitors.OrderBy(v => v.Order)
				.ToList()
				.ForEach(visitor => visitor.Visit(this));
			writer.Write(_line);
		}
	}
}