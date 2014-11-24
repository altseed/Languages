using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2ast
{

	enum Token
	{

	}


	abstract class Node
	{
		public Token Token { get; protected set; }
	}

	class Class : Node
	{
		protected string name;
		public List<Member> Childs { get; protected set; }
	}


	enum Accessor
	{
		Private,
		Protected,
		Public
	}
	abstract class Member : Node
	{
		public Accessor Accessor { get; protected set; }
	}

	class Method : Member
	{
		public List<Argument> Arguments { get; protected set; }
	}

	class Argument: Node
	{

	}

	class Block: Node
	{
		public List<Expression> Expressions { get; protected set; }

	}
	class Expression: Node
	{
		
	}
}
