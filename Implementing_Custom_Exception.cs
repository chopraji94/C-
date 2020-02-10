using System;

namespace implementingMultiple {
	
	public class SetDimensions {
		public int height;
		public int width;
		
		public void setWidth( int w ) {
			
			width = w;
		}
		
		public void setHeight( int h ) {
			height = h;
		}
	}
	
	public interface CalculateArea {
		 int getArea();
	}
	
	public class Rectangle: SetDimensions , CalculateArea {
		
		public int total;
		public int getArea() {
			int area = height * width;
			return area;
		}
		
		public int CalcualteArea( int area ) {
			total = area * 60;
			/*try {
			
			} catch ( Exception ex ) {
				Console.WriteLine(ex);
			}*/
			return total;
			
		}
	}
	
	public class FaultyData : Exception {
		
		public override string Message
		{
			get
			{
				return "Faulty data provided";
			}
		}
	}
	
	public class Rectangletester {
		public static void Main() {
			Rectangle rc = new Rectangle();
			Console.Write("Enter the height");
			rc.setHeight(Convert.ToInt32(Console.ReadLine()));
			Console.WriteLine("Enter the width");
			rc.setWidth(Convert.ToInt32(Console.ReadLine()));
			Console.WriteLine("The area of the rectangle is " + rc.getArea());
			//Console.WriteLine("The Cost of the repanting is " + rc.CalcualteArea(rc.getArea()));
			int result = rc.CalcualteArea(rc.getArea());
			
			try {
				if ( result <= 0 ) {
					throw new FaultyData();
				} else {
					Console.WriteLine("The Cost of the repanting is " + rc.CalcualteArea(rc.getArea()));
				}
			} catch ( FaultyData fd ) {
				Console.WriteLine(fd.Message);
			}
		}
	}
}