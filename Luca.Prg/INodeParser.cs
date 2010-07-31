using System.IO;

namespace Luca.Prg
{
	public interface INodeParser
	{
		string Line
		{
			get; set;
		}

		void Parse(TextWriter writer);
	}
}