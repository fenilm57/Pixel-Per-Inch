using System;

namespace ExamPreWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            int intOption = 0;
            Program p = new Program();
            do
            {
                Console.WriteLine("1. Enter Screen Dimensions");
                Console.WriteLine("2. Exit");
                Console.Write(": ");
                option = Console.ReadLine();
            } while (!int.TryParse(option, out intOption) || (intOption < 1 || intOption > 2));

            switch (intOption)
            {
                case 1:
                    p.takeInput();
                    break;

                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            Console.ReadKey();
        }


        public void takeInput()
        {
            string height="";
            string width="";
            string diagnol="";
            int heightInt = 0;
            int widthInt = 0;
            double diagnolInt = 0;
            
            do
            {
                Console.Write("Enter Height: ");
                height = Console.ReadLine();
            } while(!int.TryParse(height, out heightInt) || !(heightInt > 0));

            do
            {
                Console.Write("Enter Width: ");
                width = Console.ReadLine();
            } while (!int.TryParse(width, out widthInt) || !(widthInt > 0));

            do
            {
                Console.Write("Enter Diagnol: ");
                diagnol = Console.ReadLine();
            } while (!double.TryParse(diagnol, out diagnolInt) || !(diagnolInt > 0));

            PixelCalc.ppi(heightInt,widthInt,diagnolInt);
        }
    }
}
