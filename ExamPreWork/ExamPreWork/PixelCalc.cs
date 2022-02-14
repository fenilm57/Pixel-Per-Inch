using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreWork
{
    public static class PixelCalc
    {
        public static double diagnolPixels = 0.0;
        public static double ppiAnswer = 0.0;
        public static double dotPitch = 0.0;
        public static void ppi(int height, int width, double diagnol)
        {
            long heightSquare = (long)Math.Pow(height, 2);
            long widthSquare = (long)Math.Pow(width, 2);

            

            diagnolPixels = Math.Round(Math.Sqrt(heightSquare + widthSquare),2);
            ppiAnswer = Math.Round((diagnolPixels / diagnol),2);
            dotPitch = Math.Round(((diagnol/diagnolPixels) * 25.4),4);

            Console.WriteLine("");
            Console.WriteLine($"PPI = {ppiAnswer}");
            Console.WriteLine($"Diagnol (Pixels) = {diagnolPixels}");
            Console.WriteLine($"Dot pitch = {dotPitch}");
        }
    }
}
