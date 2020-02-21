
using System;
namespace Classes_and_Objects_Assignments
{
    class StudentS
    {
        public String name { get; set; }
        public int DateofBirth { get; set; }
        public string Class { get; set; }
        string Contact;
        public string Mobile { get { return Contact; } set { Contact = "91" + value; } }
        public string Section { get; set; }
        public string School { get { return "chitkara"; } }

        public StudentS()
        {
            name = "shivam";
            DateofBirth = 10 / 10 / 1999;
            Class = "10th";
            Mobile = "+917807248671";
            Section = "A";
        }

     
    }
    class Test
    {
        public static void Main(string[] args)
        {
            StudentS s = new StudentS();
            System.Diagnostics.Debug.WriteLine("Name of Student is:" + s.name);

            System.Diagnostics.Debug.WriteLine("DOB of Student is:" + s.DateofBirth);
            System.Diagnostics.Debug.WriteLine("Class of Student is:" + s.Class);
            System.Diagnostics.Debug.WriteLine("Mobile of Student is:" + s.Mobile);
            System.Diagnostics.Debug.WriteLine("Section of Student is:" + s.Section);

        }
    }
}

