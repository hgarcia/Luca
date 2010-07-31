using System.Collections.Generic;
using IronRuby;
using System;
using Microsoft.Scripting.Hosting;

namespace Luca.Prg
{
	public class IronRubyViewExecutor : IViewExecutor
	{
		private ScriptEngine _engine;
		private ScriptScope _scope;
		private readonly string _outputVariableName;
		private IDictionary<string,object> _globalVars = new Dictionary<string, object>();

		public IronRubyViewExecutor():this("output"){}

		public IronRubyViewExecutor(string outputVariableName)
		{
			if (string.IsNullOrEmpty(outputVariableName)) throw new ArgumentNullException("outputVariableName");
			_outputVariableName = outputVariableName;
		}

		public void SetGlobalVariables(string variableName, object value)
		{
			_globalVars.Add(variableName, value);
		}

		private void loadModel(dynamic model)
		{
			//var propertiesInfos = model.GetType().GetProperties();
			_scope.SetVariable("__", model);
		}

		private void startEngine()
		{
			_engine = Ruby.CreateEngine();
			_scope = _engine.CreateScope();
			_scope.SetVariable(_outputVariableName, "");
		}

		public string Execute(string code, dynamic model)
		{
			startEngine();
			loadModel(model);
			loadGlobalVars();
			
			code += @"  def method_missing(id, *args)
	return ""___METHOD_MISSING__""
  end";
			_engine.Execute(code, _scope);
			return _scope.GetVariable(_outputVariableName).ToString();
		}

		private void loadGlobalVars()
		{
			foreach (var globalVar in _globalVars)
			{
				_scope.SetVariable(globalVar.Key,globalVar.Value);
			}
		}
	}
}