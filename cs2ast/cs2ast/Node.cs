using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2ast
{	
	enum NodeKind
	{
		None,
		Code,
		Block,
		Using,
		Namespace,
		Expression,
		Apply,
		ApplyArguments,
		Class,
		Ctor,
		This,
		MemberAccess,
		Function,
		Params,
		Interface,
		Identifier,
		VarDecl,
		FieldDecl,
		ControlSyntax,
		ArrayType,
		Type,
	}

	enum NodeSyntax
	{
		If,
		While,
	}

	enum NodeModifier
	{
		Constant,
		ReadOnly,
		Static,
		Public,
		Protected,
		Private,
		Internal,
	}

	enum ExpressionKind
	{
		Unary,
		Binary,
	}

	abstract class NodeContent
	{
		
	}

	class StringContent: NodeContent
	{
		public string Content = "";
		public StringContent(string cont)
		{
			Content = cont;
		}
		public override string ToString()
		{
			return Content;
		}
	}

	class ExpressionContent: NodeContent
	{
		public string Operator = "";
		public ExpressionKind kind = ExpressionKind.Unary;
		public ExpressionContent(string oprator)
		{
			Operator = oprator;
		}
		public override string ToString()
		{
			return Operator;
		}
	}

	class FunctionContent: NodeContent
	{
		public string Name = "";
		public string ReturnType = "void";
		public Node Params = new Node(NodeKind.Params);
		public List<NodeModifier> Modifiers = new List<NodeModifier>();
		public override string ToString()
		{
			return Name;
		}
	}

	class IdentifierContent: NodeContent
	{
		public string Name = "";
		public string DetailInfo = "";
		public override string ToString()
		{
			return Name;
		}
	}

	class Node
	{
		public NodeKind kind { private set; get; }
		public Node(NodeKind kind_):this() { kind = kind_; }
		public Node()
		{
			kind = NodeKind.None;
			content = null;
			children = new List<Node>();
		}
		public NodeContent content { set; get; }

		public List<Node> children {private set; get;}

		public void AddChild(Node node) { children.Add(node); }
	}
}
