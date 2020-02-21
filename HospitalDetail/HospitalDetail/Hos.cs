using System;
using System.Collections.Generic;
using System.Linq;


public abstract class Hospital
{
    public abstract void Calculate(int totalCost);

    public int proced1()
    {
        return 2;
    }

    public int proced2()
    {
        return 3;
    }
}

public class Department1 : Hospital
{
    public override void Calculate(int totalCost)
    {
        System.Diagnostics.Debug.WriteLine("Department1 Total is : " + totalCost);
    }
}

public class Department2 : Hospital
{
    public override void Calculate(int totalCost)
    {
        System.Diagnostics.Debug.WriteLine("Department2 Total is : " + totalCost);
    }
}

public class Department3 : Hospital
{
    public override void Calculate(int totalCost)
    {
        System.Diagnostics.Debug.WriteLine("Department3 Total is : " + totalCost);
    }
}

public class Patient_Report
{
    public static String proced_Name,
    room_Type;
    public static int duration;
    public static int total = 0;

    public static void getData(String dept_name)
    {
        Hospital h1;
        if (dept_name.Equals("d1"))
        {
            h1 = new Department1();
            System.Diagnostics.Debug.WriteLine("Enter the room type as general or icu: "+room_Type);
            room_Type = Console.ReadLine().ToLower();
            if (room_Type.Equals("general"))
            {
                System.Diagnostics.Debug.WriteLine("Enter the duration in only hours: "+duration);
                duration = Convert.ToInt32(Console.ReadLine());
                total = (total + 30) * duration;
                System.Diagnostics.Debug.WriteLine("Enter the proced name as p1 or p2 can select only one: "+proced_Name);
                proced_Name = Console.ReadLine().ToLower();
                if (proced_Name.Equals("p1"))
                {
                    total = total + h1.proced1();
                    h1.Calculate(total);
                }
                else if (proced_Name.Equals("p2"))
                {
                    total = total + h1.proced2();
                    h1.Calculate(total);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("No Procdure");
                }
            }
            else if (room_Type.Equals("icu"))
            {
                System.Diagnostics.Debug.WriteLine("Enter the duration in only hours: "+duration);
                duration = Convert.ToInt32(Console.ReadLine());
                total = (total + 50) * duration;
                System.Diagnostics.Debug.WriteLine("Enter the proced name as p1 or p2 can select only one: "+proced_Name);
                proced_Name = Console.ReadLine().ToLower();
                if (proced_Name.Equals("p1"))
                {
                    total = total + h1.proced1();
                    h1.Calculate(total);
                }
                else if (proced_Name.Equals("p2"))
                {
                    total = total + h1.proced2();
                    h1.Calculate(total);
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
        else if (dept_name.Equals("d2"))
        {
            h1 = new Department2();
            System.Diagnostics.Debug.WriteLine("Enter the room type as general or icu: "+room_Type);
            room_Type = Console.ReadLine().ToLower();
            if (room_Type.Equals("general"))
            {
                System.Diagnostics.Debug.WriteLine("Enter the duration in only hours: "+duration);
                duration = Convert.ToInt32(Console.ReadLine());
                total = (total + 30) * duration;
                System.Diagnostics.Debug.WriteLine("Enter the proced name as p1 or p2 can select only one: "+proced_Name);
                proced_Name = Console.ReadLine().ToLower();
                if (proced_Name.Equals("p1"))
                {
                    total = total + h1.proced1();
                    h1.Calculate(total);
                }
                else if (proced_Name.Equals("p2"))
                {
                    total = total + h1.proced2();
                    h1.Calculate(total);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("No Procdure");
                }
            }
            else if (room_Type.Equals("icu"))
            {
                System.Diagnostics.Debug.WriteLine("Enter the duration in only hours: "+duration);
                duration = Convert.ToInt32(Console.ReadLine());
                total = (total + 50) * duration;
                System.Diagnostics.Debug.WriteLine("Enter the proced name as p1 or p2 can select only one: "+proced_Name);
                proced_Name = Console.ReadLine().ToLower();
                if (proced_Name.Equals("p1"))
                {
                    total = total + h1.proced1();
                    h1.Calculate(total);
                }
                else if (proced_Name.Equals("p2"))
                {
                    total = total + h1.proced2();
                    h1.Calculate(total);
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
        else if (dept_name.Equals("d3"))
        {
            h1 = new Department3();
            System.Diagnostics.Debug.WriteLine("Enter the room type as general or icu: "+room_Type);
            room_Type = Console.ReadLine().ToLower();
            if (room_Type.Equals("general"))
            {
                System.Diagnostics.Debug.WriteLine("Enter the duration in only hours :"+room_Type);
                duration = Convert.ToInt32(Console.ReadLine());
                total = (total + 30) * duration;
                System.Diagnostics.Debug.WriteLine("Enter the proced name as p1 or p2 can select only one: "+proced_Name);
                proced_Name = Console.ReadLine().ToLower();
                if (proced_Name.Equals("p1"))
                {
                    total = total + h1.proced1();
                    h1.Calculate(total);
                }
                else if (proced_Name.Equals("p2"))
                {
                    total = total + h1.proced2();
                    h1.Calculate(total);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("No Procdure");
                }
            }
            else if (room_Type.Equals("icu"))
            {
                System.Diagnostics.Debug.WriteLine("Enter the duration in only hours: "+duration);
                duration = Convert.ToInt32(Console.ReadLine());
                total = (total + 50) * duration;
                System.Diagnostics.Debug.WriteLine("Enter the proced name as p1 or p2 can select only one: "+proced_Name);
                proced_Name = Console.ReadLine().ToLower();
                if (proced_Name.Equals("p1"))
                {
                    total = total + h1.proced1();
                    h1.Calculate(total);
                }
                else if (proced_Name.Equals("p2"))
                {
                    total = total + h1.proced2();
                    h1.Calculate(total);
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
        else
        {
            System.Diagnostics.Debug.WriteLine("Department noit found");
        }
    }

    public static void Main()
    {
        //Hospital_Labs h1;
        String Name;
        System.Diagnostics.Debug.WriteLine("Enter the department name of department :");
        Name = Console.ReadLine().ToLower();
        getData(Name);
        //h1 = new Department1();

    }
}
