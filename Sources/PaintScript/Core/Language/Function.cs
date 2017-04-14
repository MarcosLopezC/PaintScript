using System.Collections.Generic;

namespace PaintScript.Core.Language
{
	public sealed class Function
	{
		private List<Statement> statementList;

		public Function()
		{
			this.statementList = new List<Statement>();
		}
	}
}
