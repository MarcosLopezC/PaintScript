using System;
using System.Collections.Generic;

namespace PaintScript.Core.Language
{
	public class Object
	{
		private Dictionary<string, Value> properties;

		public Object()
		{
			this.properties = new Dictionary<string, Value>(StringComparer.Ordinal);
		}
	}
}
