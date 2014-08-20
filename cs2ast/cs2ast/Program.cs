using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
namespace cs2ast
{
	class Walker : SyntaxWalker
	{
		private SemanticModel sema;
		public Walker(SemanticModel s) { sema = s; }
		public override void Visit(SyntaxNode node)
		{
			if (node != null)
			{
				Console.WriteLine("[Node  - Type: {0}, Kind: {1}]\n{2}\n", node.GetType().Name, ((SyntaxKind)node.RawKind).ToString(), node);

				var si = sema.GetSymbolInfo(node);
				var n = si.Symbol;
				if (n != null)
				{
					Console.WriteLine("Definition: {0}\n", n.OriginalDefinition.ToDisplayString());
				}

			}


			base.Visit(node);
		}

		protected override void VisitToken(SyntaxToken token)
		{
			base.VisitToken(token);
		}

		protected override void VisitTrivia(SyntaxTrivia trivia)
		{
			base.VisitTrivia(trivia);
		}
	}

	

	class Program
	{
		static void Main(string[] args)
		{
			var code = System.IO.File.ReadAllText("Program.cs");

			var syntaxTree = CSharpSyntaxTree.ParseText(code);
			var rootNode = syntaxTree.GetRoot();


			var assemblyPath = System.IO.Path.GetDirectoryName(typeof(object).Assembly.Location);
			var mscorelib = new MetadataFileReference(System.IO.Path.Combine(assemblyPath, "mscorlib.dll"));

			var compilation = Microsoft.CodeAnalysis.CSharp.CSharpCompilation.Create(
						"Compilation",
						syntaxTrees: new[] { syntaxTree },
						references: new[] { mscorelib },
						options: new Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions(
												  Microsoft.CodeAnalysis.OutputKind.ConsoleApplication));

			var semanticModel = compilation.GetSemanticModel(syntaxTree);

			var decl = semanticModel.GetDeclarationDiagnostics();
			var methodBodies = semanticModel.GetMethodBodyDiagnostics();

			var type = compilation.GetTypeByMetadataName("cs2ast.Program");

			var walker = new XMLWalker(semanticModel);
			walker.Visit(semanticModel.SyntaxTree.GetRoot());

			System.Console.ReadKey(false);

		}
	}
}
