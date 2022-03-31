using System;

namespace BMI
{
    class Program
    {
        //Obliczanie BMI
        static void Main(string[] args)
        {
            double bmi, kg, cm, m;
            Console.WriteLine("Podaj swój wzrost: ");
            cm = double.Parse(Console.ReadLine());
            m = cm / 100;
            Console.WriteLine("Podaj swoją wagę: ");
            kg = double.Parse(Console.ReadLine());
            bmi = kg / (m * m);
            Console.WriteLine("Twoje BMI równa się " + bmi);

            if (bmi < 16.0)
            {
                Console.WriteLine("Interpretacja BMI: wygłodzenie");
            }
            else if (16.0 < bmi & bmi < 17.0)
            {
                Console.WriteLine("Interpretacja BMI: wychudzenie");
            }
            else if (17.0 <= bmi & bmi < 18.5)
            {
                Console.WriteLine("Interpretacja BMI: niedowaga");
            }
            else if (18.5 <= bmi & bmi < 25)
            {
                Console.WriteLine("Interpretacja BMI: waga prawidłowa");
            }
            else if (25 <= bmi & bmi < 30)
            {
                Console.WriteLine("Interpretacja BMI: nadwaga");
            }
            else if (30 <= bmi & bmi < 35)
            {
                Console.WriteLine("Interpretacja BMI: otyłość I stopnia");
            }
            else if (35 <= bmi & bmi < 40)
            {
                Console.WriteLine("Interpretacja BMI: otyłość II stopnia");
            }
            else
            {
                Console.WriteLine("Interpretacja BMI: otyłość III stopnia");
            }

            Console.ReadKey();
        }
    }
}
