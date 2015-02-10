using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2ast.Writer
{
	class XMLWriter: Writer
	{
		private int indent;
		private StringBuilder result = new StringBuilder();
		public override void Write(Node node)
		{
			for (int i = 0; i < indent; i++)
			{
				result.Append("\t");
			}
			if (node.children.Count == 0)
			{

				result.AppendFormat("<{0} value=\"{1}\" />\n", node.kind.ToString(), (node.content != null) ? node.content.ToString() : "");
			}
			else
			{
				result.AppendFormat("<{0} value=\"{1}\">\n", node.kind.ToString(), (node.content != null)? node.content.ToString(): "");
				indent++;
				foreach (var e in node.children)
				{
					Write(e);
				}
				indent--;
				for (int i = 0; i < indent; i++)
				{
					result.Append("\t");
				}
				result.AppendFormat("</{0}>\n", node.kind.ToString());
			}
		}

		public override string GetResult()
		{
			return result.ToString();
		}
	}
}
