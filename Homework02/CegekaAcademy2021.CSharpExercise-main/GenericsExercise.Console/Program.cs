using System;

namespace GenericsExercise.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\t\tCegeka Homework02 !");
            /*
            Student S = new Student
            {
                Id = "1234",
                FisrtName = "Giani",
                LastName = "PApa"

            };
            University U = new University
            {
                Id = "234",
                Address = "strada",
                Name = "Fabrica de smecheri"
            };
            CollegeStudent<Student, University> C = new CollegeStudent<Student,University>("rrr",S,U);

            Persistence baza = new Persistence();

            baza.InsertAsync(C);
            */
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
            
           
        }
        private static bool MainMenu()
        {
            //System.Console.Clear();
            System.Console.WriteLine("Choose an option:");
            System.Console.WriteLine("1) Insert a Student in a University");
            System.Console.WriteLine("2) View a Student using the ID Tag");
            System.Console.WriteLine("3) ShowInfo");
            System.Console.WriteLine("4) Exit");
            
            System.Console.Write("\r\nSelect an option: ");

            switch (System.Console.ReadLine())
            {
                case "1":
                    InsertStudentInUniversity();
                    return true;
                case "2":
                    
                    return true;
                case "3":
                    ShowInfo();
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }

        private static void ShowInfo()
        {
            System.Console.Write("First, both of the object Student and University has to have a property 'Id' that should be a valid string :");
            System.Console.Write("\n ->non-null");
            System.Console.Write("\n ->max 10 characters");
            System.Console.Write("\n ->should not contain the character '%' ");
            System.Console.Write("\n \n");
        }

        private static void InsertStudentInUniversity()
        {
            try
            {
                string str=null;
                System.Console.Write("Input the Student ID : ");
                str = System.Console.ReadLine();
                if (str =="")
                    throw new CustomException("Invalid ID");
            }
            catch(CustomException ex)
            {
                System.Console.WriteLine(ex.Message);

            }
           // System.Console.WriteLine(str);


        }
    }
}