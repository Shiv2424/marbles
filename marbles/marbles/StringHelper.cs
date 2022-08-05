using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marbles
{
	public static class StringHelper
	{
		public static bool IsPalindrome(String input)
		{
			string LowerCaseTest = input.ToLower();
			char[] chars = LowerCaseTest.ToCharArray();
			StringBuilder sb = new StringBuilder();

			foreach (char c in chars)
			{
				if (char.IsLetter(c))
				{
					sb.Append(c);
				}
			}
			String cleanedAndLowerString = sb.ToString();

			char[] cleanedChars = cleanedAndLowerString.ToCharArray();
			Array.Reverse(cleanedChars);
			String reversed = new string(cleanedChars);

			if (reversed == cleanedAndLowerString)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
