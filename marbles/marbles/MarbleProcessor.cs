using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marbles
{
	public static class MarbleProcessor
	{
		public static List<Marble> SortAndFilter(List<Marble> inputMarbles)
		{
			List<Marble> returnMarbles = new List<Marble>();

			foreach (Marble marble in inputMarbles)
			{
				if (marble.Weight >= 0.5 && StringHelper.IsPalindrome(marble.Name) == true)
				{
					returnMarbles.Add(marble);
				}
			}

			returnMarbles = returnMarbles.OrderBy(marble => marble.Ordering).ToList();
			return returnMarbles;
		}
	}
}

