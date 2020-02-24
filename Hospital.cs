using System;

public abstract class CheckSchedule {
	public abstract void Calculate(int totalCost);

	public int proced1() {
		return 2;
	}

	public int proced2() {
		return 3;
	}
}

public class Department1: CheckSchedule {
	public override void Calculate(int totalCost) {
		Console.WriteLine("Department1 Total is -: " + totalCost);
	}
}

public class Department2: CheckSchedule {
	public override void Calculate(int totalCost) {
		Console.WriteLine("Department2 Total is -: " + totalCost);
	}
}

public class Department3: CheckSchedule {
	public override void Calculate(int totalCost) {
		Console.WriteLine("Department3 Total is -: " + totalCost);
	}
}

public class HelloWorld {

	public static String proced_Name,
	room_Type;
	public static int duration;
	public static int total = 0;

	public static void getClassUse(CheckSchedule objc) {
		//objc.Calculate(1);
		Console.WriteLine("Enter the room type as general or icu");
		room_Type = Console.ReadLine().ToLower();
		if (room_Type.Equals("general")) {
			Console.WriteLine("Enter the duration in only hours");
			duration = Convert.ToInt32(Console.ReadLine());
			total = (total + 30) * duration;
			Console.WriteLine("Enter the proced name as p1 or p2 can select only one");
			proced_Name = Console.ReadLine().ToLower();
			if (proced_Name.Equals("p1")) {
				total = total + objc.proced1();
				objc.Calculate(total);
			} else if (proced_Name.Equals("p2")) {
				total = total + objc.proced2();
				objc.Calculate(total);
			} else {
				Console.WriteLine("No Procdure");
			}
		} else if (room_Type.Equals("icu")) {
			Console.WriteLine("Enter the duration in only hours");
			duration = Convert.ToInt32(Console.ReadLine());
			total = (total + 50) * duration;
			Console.WriteLine("Enter the proced name as p1 or p2 can select only one");
			proced_Name = Console.ReadLine().ToLower();
			if (proced_Name.Equals("p1")) {
				total = total + objc.proced1();
				objc.Calculate(total);
			} else if (proced_Name.Equals("p2")) {
				total = total + objc.proced2();
				objc.Calculate(total);
			} else {
				Console.WriteLine("No Procdure");
			}
		} else {
			Console.WriteLine("Not a room Type");
		}
	}

	public static void Main() {
		CheckSchedule ch1;
		String depart_Name;
		Console.WriteLine("Enter the department name as department1 , department2, or department3");
		depart_Name = Console.ReadLine().ToLower();
		switch (depart_Name) {

		case "department1":
			ch1 = new Department1();
			getClassUse(ch1);
			break;
		case "department2":
			ch1 = new Department2();
			getClassUse(ch1);
			break;
		case "department3":
			ch1 = new Department3();
			getClassUse(ch1);
			break;
		default:
			Console.WriteLine("Not having the class named");
			break;
		}
	}
}