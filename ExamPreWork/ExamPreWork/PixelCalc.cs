using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreWork
{
    public static class PixelCalc
    {
        public static void ppi(int height, int width, int diagnol)
        {
            long heightSquare = (long)Math.Pow(height, 2);
            long widthSquare = (long)Math.Pow(width, 2);

            double diagnolPixels=0.0;
            double ppiAnswer = 0.0;
            double dotPitch = 0.0;

            diagnolPixels = (Math.Sqrt(heightSquare + widthSquare));
            ppiAnswer = Math.Round((diagnolPixels / diagnol),2);
            dotPitch = Math.Round(((diagnol/diagnolPixels) * 25.4),4);

            Console.WriteLine("");
            Console.WriteLine($"PPI = {ppiAnswer}");
            Console.WriteLine($"Diagnol (Pixels) = {Math.Round(diagnolPixels,2)}");
            Console.WriteLine($"Dot pitch = {dotPitch}");


        }
    }
}
