using System;
namespace P06_Static.Helper
{
	public static class HelperMethods
	{
		public static string EditText(string text)
			{
			string result = text.Replace("?", " ");
			return result;
			}
		
	}
}

