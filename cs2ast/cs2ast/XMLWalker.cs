using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace cs2ast
{
	class XMLWalker: CSharpSyntaxWalker
	{
		private int depth = 0;
		private SemanticModel sema;

		public XMLWalker(SemanticModel s) { sema = s; }
		private void GenerateOpenTag(string name, params KeyValuePair<string, string>[] attr) 
		{
			for (int i = 0; i < depth; i++)
			{
				Console.Write("  ");
			}
			
			Console.Write("<{0} ", name);

			foreach (var pair in attr)
			{
				Console.Write("{0}=\"{1}\" ", pair.Key, pair.Value);
			}
			Console.WriteLine(">");
		}

		private void GenerateCloseTag(string name)
		{
			for (int i = 0; i < depth; i++)
			{
				Console.Write("  ");
			}
			Console.Write("</{0} >", name);
		}
		public override void DefaultVisit(SyntaxNode node)
		{
			base.DefaultVisit(node);
		}

		public override void VisitBinaryExpression(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax node)
		{
			GenerateOpenTag("BinaryExpr", new KeyValuePair<string, string>("operator", node.CSharpKind().ToString()));
			depth++;
			base.Visit(node.Left);
			base.Visit(node.Right);
			depth--;
			GenerateCloseTag("BinaryExpr");
		}
	}
}
