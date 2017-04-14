namespace PaintScript.Core.Language
{
	public enum ValueType : byte
	{
		Null = default(byte),

		Boolean,

		Natural,
		Integer,
		Real,

		Object,

		Function
	}
}
