using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2ast.Writer
{
	class JavaWriter: Writer
	{
		private int indent = 0;
		private void MakeIndent()
		{
			res.Append('\t', indent);
		}

		private string Modifier2String(NodeModifier mod)
		{
			switch (mod)
			{
				case NodeModifier.Constant:
					return "final ";
				case NodeModifier.ReadOnly:
					return "final ";
				case NodeModifier.Static:
					return "static ";
				case NodeModifier.Public:
					return "public ";
				case NodeModifier.Protected:
					return "protected ";
				case NodeModifier.Private:
					return "private ";
				case NodeModifier.Internal:
					return "";
				default:
					throw new Exception("unknown modifier");
			}
		}
		private StringBuilder res = new StringBuilder();
		public override void Write(Node node)
		{
			switch (node.kind)
			{
				case NodeKind.None:
					break;
				case NodeKind.Code:
					node.children.ForEach(e => Write(e));
					break;
				case NodeKind.Block:
					MakeIndent(); res.AppendLine("{");
					indent++;
					node.children.ForEach(e => Write(e));
					indent--;
					MakeIndent(); res.AppendLine("}");
					break;
				case NodeKind.Using:
					break;
				case NodeKind.Namespace:
					res.AppendFormat("package {0};\n", node.content);
					node.children.ForEach(e => Write(e));
					break;
				case NodeKind.Expression:
					if (((ExpressionContent)node.content).kind == ExpressionKind.Binary)
					{
						Write(node.children[0]);
						res.AppendFormat(" {0} ", node.content.ToString());
						Write(node.children[1]);
					}
					else
					{
						res.AppendFormat(" {0}", node.content.ToString());
						Write(node.children[0]);
					}
					
					break;
				case NodeKind.Apply:
					Write(node.children[0]);
					res.Append("(");
					Write(node.children[1]);
					res.Append(")");
					break;
				case NodeKind.ApplyArguments:
					var isFirst = true;
					foreach (var e in node.children)
					{
						if (isFirst)
						{
							isFirst = false;
						}
						else
						{
							res.Append(", ");
						}
						Write(e);
					}
					break;
				case NodeKind.Class:
					MakeIndent();
					res.AppendFormat("class {0} {{\n", node.content);
					indent++;
					node.children.ForEach(e => Write(e));
					indent--;
					MakeIndent();
					res.AppendLine("{");
					break;
				case NodeKind.Ctor:
					res.AppendFormat("public {0}", node.content);
					node.children.ForEach(e => Write(e));
					break;
				case NodeKind.This:
					res.Append("this");
					break;
				case NodeKind.MemberAccess:
					Write(node.children[0]);
					res.Append(".");
					Write(node.children[1]);
					break;
				case NodeKind.Function:
					var cont = (FunctionContent)node.content;
					var mod = cont.Modifiers.Select(Modifier2String).Aggregate((s1, s2) => s1 + s2);
					MakeIndent();
					res.AppendFormat("{0} {1} {2}", mod, cont.ReturnType, cont.Name);
					Write(cont.Params);
					res.AppendLine(" {");
					indent++;
					node.children.ForEach(Write);
					indent--;
					MakeIndent();
					res.AppendLine("}");

					break;
				case NodeKind.Params:

					foreach (var e in node.children)
					{
						
					}
					break;
				case NodeKind.Interface:
					break;
				case NodeKind.Identifier:
					res.Append(node.content);
					break;
				case NodeKind.VarDecl:
					break;
				case NodeKind.FieldDecl:
					break;
				case NodeKind.ControlSyntax:
					break;
				case NodeKind.ArrayType:
					break;
				case NodeKind.Type:
					break;
				default:
					throw new NotImplementedException();
			}
		}

		public override string GetResult()
		{
			return res.ToString();
		}
	}
}
