using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marbles
{
	public class Marble
	{
		public int Id { get; set; }
		public string Color { get; set; }
		public string Name { get; set; }
		public double Weight { get; set; }
		public int Ordering
		{
			get
			{
				if (Color == ("red"))
				{
					return 0;
				}
				else if (Color == ("orange"))
				{
					return 1;
				}
				else if (Color == ("yellow"))
				{
					return 2;
				}
				else if (Color == ("green"))
				{
					return 3;
				}
				else if (Color == ("blue"))
				{
					return 4;
				}
				else if (Color == ("indigo"))
				{
					return 5;
				}
				else if (Color == ("violet"))
				{
					return 6;
				}
				else
				{
					return -1;
				}
			}
		}
				public Marble(int id, string color, string name, double weight)
		{
			Id = id;
			Color = color;
			Name = name;
			Weight = weight;
		}


		public override string ToString()
		{
			return "Id: " + Id + ", Color:" + Color + ", Name: " + Name + ", Weight:" + Weight;
		}
	}
}
