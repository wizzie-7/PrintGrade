using System;

namespace PrintGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            GradePrint GP = new GradePrint();
            GP.AcceptMarks();
            GP.PerCalculation();
            GP.DisplayGrade();
        }
    }
    public class GradePrint
    {
        int Phy, Che, Bio, Maths, Eng, Comp;
        double per;
        string FName,LName;
        public void AcceptMarks()
        {
            Console.WriteLine("Enter Your First Name :");
            FName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name :");
            LName = Console.ReadLine();
            Console.WriteLine("*****Enter your Marks out of 100*****");
            Console.Write("Physics :");
            Phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Chemistry :");
            Che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Biology :");
            Bio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mathematics :");
            Maths = Convert.ToInt32(Console.ReadLine());
            Console.Write("English :");
            Eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("Computer :");
            Comp = Convert.ToInt32(Console.ReadLine());
        }
        public void PerCalculation()
        {
            per = ((Phy + Che + Bio + Maths + Eng + Comp) / 500) * 100;
        }
        public void DisplayGrade()
        {
            Console.WriteLine("Student Name :" + FName + " " + LName);
            Console.Write("Your Marks :\n");
            Console.Write("Physics :" + Phy + "\tChemistry :" + Che + "\tBiolgy :" + Bio + "\tMathematics :" + Maths + "\tEnglish :" + Eng + "\tComputer :" + Comp+"\n");
            if(per>40)
            {
                Console.WriteLine("Grade: Fail");
            }
            else if(per>=40 || per<45)
            {
                Console.WriteLine("Grade: D");
            }
            else if (per >= 45 || per < 50)
            {
                Console.WriteLine("Grade: C");
            }
            else if (per >= 50 || per < 55)
            {
                Console.WriteLine("Grade: C+");
            }
            else if (per >= 55 || per < 60)
            {
                Console.WriteLine("Grade: B-");
            }
            else if (per >= 60 || per < 65)
            {
                Console.WriteLine("Grade: B");
            }
            else if (per >= 65 || per < 70)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (per >= 70 || per < 75)
            {
                Console.WriteLine("Grade: A-");
            }
            else if (per >= 75 || per < 80)
            {
                Console.WriteLine("Grade: A");
            }
            else if (per >= 80 || per < 100)
            {
                Console.WriteLine("Grade: A+");
            }
        }
    }
}
