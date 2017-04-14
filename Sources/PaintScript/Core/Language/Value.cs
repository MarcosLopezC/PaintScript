namespace PaintScript.Core.Language
{
	public struct Value
	{
		private decimal innerValue;
		private object innerReference;

		public ValueType Type { get; private set; }
	}
}
