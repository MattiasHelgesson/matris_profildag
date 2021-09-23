using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixVerifyer;

namespace Matrix
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /*
             * Där finns tester tillgängliga genom att skriva
             * MatrixChecker.CheckAddition
             * MatrixChecker.CheckMultiplication
             * MatrixChecker.CheckRotationMatrix
             * 
             * Observera att testerna inte är noga testade.
             * 
             * De tar emot argument enligt följande standard:
             * CheckAddition tar emot alla Matris-värden 00, 01, 10, 11 för matris A
             * och alla Matris-värden 00, 01, 10, 11 för matris B, och den sista är
             * då det uträknade resultatet av A + B, som då är en matris 00, 01, 10, 11
             * 
             * CheckMultiplication liknar CheckAddition, den tar emot tre matriser,
             * A, B och sedan resultatet av A * B. Sen kommer den att jämföra och se
             * ifall matrisen har blivit rätt
             * 
             * CheckRotationMatrix tar emot antalet radianer du roterat en matris av,
             * och sedan en rotationsmatris som du har skapat. Den jämför sedan värden
             * för att se ifall matriserna stämmer överens.
             */

            /*
             * Där finns ett inbyggt verktyg för att rita ut matriser i två format.
             * Den första tar emot alla matrisvärden, 00, 01, 10, 11 och den andra
             * tar emot en float[,] (en float 2D-array) och skriver sedan ut matrisen
             * formaterat, och endast med 2 decimaler.
             */

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A + B
            // Exempel: MatrixChecker.CheckAddition(1, 2, 3, 4, 1, 2, 3, 4, 2, 4, 6, 8);

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A * B
            // Exempel: MatrixChecker.CheckMultiplication(1, 2, 3, 4, 1, 2, 3, 4, 7, 10, 15, 22);


            // Byt ut detta anropet med dina matrisvärden, så kommer programmet att rita ut dem istället :)

            //adition
            float a00 = 1, a01 = 2, a10 = 3, a11 = 4;
            float b00 = 3, b01 = 4, b10 = 5, b11 = 6;
            float c00, c01, c10, c11;
            float radians = 3.14f;

            c00 = a00 + b00;
            c01 = a01 + b01;
            c10 = a10 + b10;
            c11 = a11 + b11;

            MatrixChecker.CheckAddition(a00, a01, a10, a11, b00, b01, b10, b11, c00, c01, c10, c11);

            Draw2x2Matrix(c00,c01, c10, c11);
            
            Console.WriteLine();

            //rotation
            float D = (float)Math.Cos(radians);
            float D2 = (float)Math.Sin(radians);
            float D3 = (float)Math.Sin(-radians);

            MatrixChecker.CheckRotationMatrix(radians, D, D2, D3, D);
            Draw2x2Matrix(D, D2, D3, D);

            Console.WriteLine();

            //multipilikation
            float Matteskit = 1;
            float Matteskit2 = 2;
            float Matteskit3 = 3;
            float Matteskit4 = 4;

            float Matteskit5 = 5;
            float Matteskit6 = 6;
            float Matteskit7 = 7;
            float Matteskit8 = 8;

            float C = Matteskit * Matteskit5 + Matteskit2 * Matteskit7;
            float C2 = Matteskit * Matteskit6 + Matteskit2 * Matteskit8;
            float C3 = Matteskit3 * Matteskit5 + Matteskit4 * Matteskit7;
            float C4 = Matteskit3 * Matteskit6 + Matteskit4 * Matteskit8;
            
            MatrixChecker.CheckMultiplication(Matteskit, Matteskit2, Matteskit3, Matteskit4, Matteskit5, Matteskit6, Matteskit7, Matteskit8, C, C2, C3, C4);
            Draw2x2Matrix(C, C2, C3, C4);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Vänligen skriv in första Rotations matrisen");

            Console.WriteLine("Skriv in ett tal för att utföra fösta matrisen");
            float.TryParse(Console.ReadLine(), out radians);
            
            float radians2;

            Console.WriteLine("Skriv in ett tal för att utföra andra matrisen");
            float.TryParse(Console.ReadLine(), out radians2);


            a00 = (float)Math.Cos(radians);
            a01 = (float)Math.Sin(radians);
            a10 = (float)Math.Sin(-radians);
            a11 = (float)Math.Cos(radians);

            b00 = (float)Math.Cos(radians2);
            b01 = (float)Math.Sin(radians2);
            b10 = (float)Math.Sin(-radians2);
            b11 = (float)Math.Cos(radians2);

            c00 = a00 * b00 + a01 * b10;
            c01 = a00 * b01 + a01 * b11;
            c10 = a10 * b00 + a11 * b10;
            c11 = a10 * b01 + a11 * b11;


            Draw2x2Matrix(c00, c01, c10, c11);

            Console.ReadKey();



        }
    }
}
