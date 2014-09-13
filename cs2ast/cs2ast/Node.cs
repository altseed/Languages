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
		protected Token Token { public get; protected set; }
	}

	class Class : Node
	{
		protected string name;
		protected List<Member> Childs { public get; protected set; }
	}


	enum Accessor
	{
		Private,
		Protected,
		Public
	}
	abstract class Member : Node
	{
		protected Accessor Accessor { public get; protected set; }
	}

	class Method : Member
	{
		protected List<Argument> Arguments { public get; protected set; }
	}

	class Argument: Node
	{

	}

	class Block: Node
	{
		protected List<Expression> Expressions { public get; protected set; }

	}
	class Expression: Node
	{
		
	}
}
