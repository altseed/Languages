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
			Parser p = new Parser();
			p.Parse();

		}
	}
}
