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
		Expression,
		Class,
		Function,
		Interface,
		Variable,

	}

	abstract class NodeContent
	{
		
	}


	class ExpressionContent: NodeContent
	{
		public string Operator = "";
	}

	class FunctionContent: NodeContent
	{
		public string Name = "";
		public Node RetrunType;
		public List<Node> Arguments;
	}

	class Node
	{
		public NodeKind kind { private set; get; }
		Node(NodeKind kind_):this() { kind = kind; }
		Node()
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
