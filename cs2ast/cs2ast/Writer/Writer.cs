using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2ast.Writer
{
	abstract class Writer
	{
		public abstract void Write(Node node);
		public abstract string GetResult();
	}

}
