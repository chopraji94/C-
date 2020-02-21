using System;

public abstract class Procedures
{

    public int procedure1()
    {
        return 2;
    }

    public int procedure2()
    {
        return 3;
    }
}

public class Department1 : Procedures
{
    public int total = 0;
    public void calculate(int procedTotal)
    {
        System.Diagnostics.Debug.WriteLine("Total Cost of bill is : " + procedTotal);
    }

}

public class Department2 : Procedures
{
    public int total = 0;
    public void calculate(int procedTotal)
    {
        System.Diagnostics.Debug.WriteLine("Total Cost of bill is : " + procedTotal);
    }
}

public class Department3 : Procedures
{
    public int total = 0;
    public void calculate(int procedTotal)
    {
        System.Diagnostics.Debug.WriteLine("Total Cost of bill is : " + procedTotal);
    }
}

public class HelloWorld
{
    public static String proced_Name,
    room_Type;
    public static int duration;

    public static void dpartment1_get_data(Department1 objc)
    {
        System.Diagnostics.Debug.WriteLine("Enter the room type as general or icu: "+room_Type);
        room_Type = Console.ReadLine().ToLower();
        if (room_Type.Equals("general"))
        {
            System.Diagnostics.Debug.WriteLine("Enter the duration in only hours "+duration);
            duration = Convert.ToInt32(Console.ReadLine());
            objc.total = (objc.total + 30) * duration;
            System.Diagnostics.Debug.WriteLine("Enter the proced name as p1 or p2 can select only one: "+proced_Name);
            proced_Name = Console.ReadLine().ToLower();
            if (proced_Name.Equals("p1"))
            {
                objc.total = objc.total + objc.procedure1();
                objc.calculate(objc.total);
            }
            else if (proced_Name.Equals("p2"))
            {
                objc.total = objc.total + objc.procedure2();
                objc.calculate(objc.total);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("No Procdure");
            }
        }
        else if (room_Type.Equals("icu"))
        {
            System.Diagnostics.Debug.WriteLine("Enter the duration in only hours");
            duration = Convert.ToInt32(Console.ReadLine());
            objc.total = (objc.total + 50) * duration;
            System.Diagnostics.Debug.WriteLine("Enter the proced name as p1 or p2 can select only one");
            proced_Name = Console.ReadLine().ToLower();
            if (proced_Name.Equals("p1"))
            {
                objc.total = objc.total + objc.procedure1();
                objc.calculate(objc.total);
            }
            else if (proced_Name.Equals("p2"))
            {
                objc.total = objc.total + objc.procedure2();
                objc.calculate(objc.total);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("No Procdure");
            }
        }
        else
        {
            System.Diagnostics.Debug.WriteLine("Not a room Type");
        }
    }

    public static void dpartment2_get_data(Department2 objc)
    {
        if (room_Type.Equals("general"))
        {
            System.Diagnostics.Debug.WriteLine("Enter the duration in only hours");
            duration = Convert.ToInt32(Console.ReadLine());
            objc.total = (objc.total + 30) * duration;
            System.Diagnostics.Debug.WriteLine("Enter the proced name as p1 or p2 can select only one");
            proced_Name = Console.ReadLine().ToLower();
            if (proced_Name.Equals("p1"))
            {
                objc.total = objc.total + objc.procedure1();
                objc.calculate(objc.total);
            }
            else if (proced_Name.Equals("p2"))
            {
                objc.total = objc.total + objc.procedure2();
                objc.calculate(objc.total);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("No Procdure");
            }
        }
        else if (room_Type.Equals("icu"))
        {
            Console.WriteLine("Enter the duration in only hours");
            duration = Convert.ToInt32(Console.ReadLine());
            objc.total = (objc.total + 50) * duration;
            System.Diagnostics.Debug.WriteLine("Enter the proced name as p1 or p2 can select only one");
            proced_Name = Console.ReadLine().ToLower();
            if (proced_Name.Equals("p1"))
            {
                objc.total = objc.total + objc.procedure1();
                objc.calculate(objc.total);
            }
            else if (proced_Name.Equals("p2"))
            {
                objc.total = objc.total + objc.procedure2();
                objc.calculate(objc.total);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("No Procdure");
            }
        }
        else
        {
            System.Diagnostics.Debug.WriteLine("Not a room Type");
        }

    }

    public static void dpartment3_get_data(Department3 objc)
    {
        if (room_Type.Equals("general"))
        {
            System.Diagnostics.Debug.WriteLine("Enter the duration in only hours");
            duration = Convert.ToInt32(Console.ReadLine());
            objc.total = (objc.total + 30) * duration;
            System.Diagnostics.Debug.WriteLine("Enter the proced name as p1 or p2 can select only one");
            proced_Name = Console.ReadLine().ToLower();
            if (proced_Name.Equals("p1"))
            {
                objc.total = objc.total + objc.procedure1();
                objc.calculate(objc.total);
            }
            else if (proced_Name.Equals("p2"))
            {
                objc.total = objc.total + objc.procedure2();
                objc.calculate(objc.total);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("No Procdure");
            }
        }
        else if (room_Type.Equals("icu"))
        {
            System.Diagnostics.Debug.WriteLine("Enter the duration in only hours");
            duration = Convert.ToInt32(Console.ReadLine());
            objc.total = (objc.total + 50) * duration;
            System.Diagnostics.Debug.WriteLine("Enter the proced name as p1 or p2 can select only one");
            proced_Name = Console.ReadLine().ToLower();
            if (proced_Name.Equals("p1"))
            {
                objc.total = objc.total + objc.procedure1();
                objc.calculate(objc.total);
            }
            else if (proced_Name.Equals("p2"))
            {
                objc.total = objc.total + objc.procedure2();
                objc.calculate(objc.total);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("No Procdure");
            }
        }
        else
        {
            System.Diagnostics.Debug.WriteLine("Not a room Type");
        }

    }

    public static void Main()
    {
        String depart_Name;
        Console.WriteLine("Enter the department name");
        depart_Name = Console.ReadLine();
        depart_Name = depart_Name.ToLower();
        if (depart_Name.Equals("d1"))
        {
            Department1 d1 = new Department1();
            dpartment1_get_data(d1);
        }
        else if (depart_Name.Equals("d2"))
        {
            Department2 d2 = new Department2();
            dpartment2_get_data(d2);
        }
        else if (depart_Name.Equals("d3"))
        {
            Department3 d3 = new Department3();
            dpartment3_get_data(d3);
        }
        else
        {
            System.Diagnostics.Debug.WriteLine("Department not found");
        }

    }
}