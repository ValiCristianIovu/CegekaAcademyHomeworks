using System;

namespace GenericsExercise.Console
{
    public delegate void DelegateMethod<T>(T p);
    public class Program
    {
      
        static void Main(string[] args)
        {
            System.Console.WriteLine("\t\tCegeka Homework02 !");            
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
                string strCollegeStudentID;

                string strStudentId;
                string strStudentFirstName;
                string strStudentLastName;

                string strUniversityId;
                string strUniversityName;
                string strUniversityAddress;

                System.Console.Write("Input the College Student ID : ");
                strCollegeStudentID = System.Console.ReadLine();
                ValidateId(strCollegeStudentID);
                System.Console.Write("\n");

                System.Console.Write("Input the Student ID : ");
                strStudentId = System.Console.ReadLine();
                ValidateId(strStudentId);

                System.Console.Write("Input the Student First Name : ");
                strStudentFirstName = System.Console.ReadLine();

                System.Console.Write("Input the Student First Name : ");
                strStudentLastName = System.Console.ReadLine();
                System.Console.Write("\n");

                System.Console.Write("Input the University ID:");
                strUniversityId = System.Console.ReadLine();
                ValidateId(strUniversityId);

                System.Console.Write("Input the University Name:");
                strUniversityName = System.Console.ReadLine();

                System.Console.Write("Input the University Address:");
                strUniversityAddress= System.Console.ReadLine();
                Student S = new Student { Id = strStudentId, FisrtName = strStudentFirstName, LastName = strStudentLastName };
                University U = new University { Id = strUniversityId, Name = strUniversityName, Address = strUniversityAddress };
                CollegeStudent<Student, University> C= new CollegeStudent<Student, University>(strCollegeStudentID, S, U);

              

                System.Console.Write("\n \n");
            }
            catch(InvalidIDException ex)
            {
                System.Console.WriteLine(ex.Message);

            }
           // System.Console.WriteLine(str);


        }

        private static void ValidateId(string str)
        {
            if (str == "")
                throw new InvalidIDException(str);
            else if (str.Length > 10)
                throw new InvalidIDException(str.Length);
            else if (str.ToLower().Contains('%'))
                throw new InvalidIDException('%');
        }
    }
}