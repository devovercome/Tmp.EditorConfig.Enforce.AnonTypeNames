namespace EditorConfig.Enforce.AnonTypeNames
{
	class Program
	{
		static void Main(string[] args)
		{
			var dateTime = System.DateTime.Now;
			// dotnet_style_prefer_inferred_anonymous_type_member_names = false:error
			var foo = new
			{
				Second = dateTime.Second, // muted this suggestion, but
				dateTime.Month // this should raise error.
			};
		}
	}
}
