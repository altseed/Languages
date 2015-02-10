using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
namespace cs2ast
{


	class Program
	{
		static void Main(string[] args)
		{
			var code = System.IO.File.ReadAllText("Profiler.cs");

			Parser p = new Parser();
			var n = p.Parse(code);
			var w = new Writer.XMLWriter();
			w.Write(n);
			Console.WriteLine(w.GetResult());
			System.Console.ReadKey(false);


		}
	}
}
