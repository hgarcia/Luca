using System;
using System.Collections.Generic;
using System.IO;
using Luca.Prg.Visitors;
using Luca.Prg.Visitors.IronRuby;

namespace Luca.Prg
{
	public class IronRubyViewParser : IViewParser
	{
		public string Parse(string templateLocation)
		{
			var source = readPrecompiledView(templateLocation);
			if (source.Length > 0) return source;			
			compileTemplate(templateLocation);
			return readPrecompiledView(templateLocation);
		}

		private void compileTemplate(string templateLocation)
		{
			var lines = File.ReadAllLines(templateLocation + ".htm");
			using (var file = File.CreateText(templateLocation + ".rhtml"))
			{
				foreach (var line in lines)
				{
					var node = new NodeParser(line, getVisitors());
					node.Parse(file);
				}
				file.Close();
			}
		}

		private List<INodeVisitor> getVisitors()
		{
			return new List<INodeVisitor>
			       	{
			       		new ForEachNodeVisitor(),
						new IfNodeVisitor(),
						//new PhraseNodeVisitor(),
						new TextNodeVisitor(),
						new AreaNodeVisitor()
			       	};
		}

		private string readPrecompiledView(string templateLocation)
		{
			DateTime templateWriteDate = File.GetLastWriteTimeUtc(templateLocation + ".htm");
			DateTime compiledWriteDate = File.GetLastWriteTimeUtc(templateLocation + ".rhtml");
			if (templateWriteDate < compiledWriteDate) return File.ReadAllText(templateLocation + ".rhtml");
			return string.Empty;
		}
	}
}