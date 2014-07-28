using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2ast
{
	class Walker : Microsoft.CodeAnalysis.SyntaxWalker
	{
		public override void Visit(Microsoft.CodeAnalysis.SyntaxNode node)
		{
			if (node != null)
			{
				Console.WriteLine("[Node  - Type: {0}, Kind: {1}]\n{2}\n", node.GetType().Name, node.RawKind, node);
			}
			
			base.Visit(node);
		}

		protected override void VisitToken(Microsoft.CodeAnalysis.SyntaxToken token)
		{
			base.VisitToken(token);
		}

		protected override void VisitTrivia(Microsoft.CodeAnalysis.SyntaxTrivia trivia)
		{
			base.VisitTrivia(trivia);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var code = System.IO.File.ReadAllText("Program.cs");

			var syntaxTree = Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParseText(code);
			var rootNode = syntaxTree.GetRoot();
			var walker = new Walker();
			walker.Visit(rootNode);
		}
	}
}
