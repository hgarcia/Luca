namespace Luca.Prg
{
	public interface IViewExecutor
	{
		string Execute(string code, dynamic model);

		void SetGlobalVariables(string variableName, object value);
	}
}