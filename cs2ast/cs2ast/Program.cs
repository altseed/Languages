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

			var assemblyPath = System.IO.Path.GetDirectoryName(typeof(object).Assembly.Location);
			var mscorelib = new Microsoft.CodeAnalysis.MetadataFileReference(System.IO.Path.Combine(assemblyPath, "mscorlib.dll"));

			var compilation = Microsoft.CodeAnalysis.CSharp.CSharpCompilation.Create(
						"Compilation",
						syntaxTrees: new[] { syntaxTree },
						references: new[] { mscorelib },
						options : new Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions(
                                                  Microsoft.CodeAnalysis.OutputKind.ConsoleApplication));

			var semanticModel = compilation.GetSemanticModel(syntaxTree);
			var decl = semanticModel.GetDeclarationDiagnostics();
			var methodBodies = semanticModel.GetMethodBodyDiagnostics();

			var type = compilation.GetTypeByMetadataName("cs2ast.Program");
			
		}
	}
}
