// See https://aka.ms/new-console-template for more information
namespace Program
{
    class console
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter First number");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            double num2 = double.Parse(Console.ReadLine());

            double v;
            for (double i = 2; i <= num2; i++)
            {
                if (Check(i) == true)
                {
                    v = ((Math.Pow(2, i) - 1) * Math.Pow(2, i - 1));

                    if (v >= num1 && v <= num2)
                    {

                        Console.WriteLine(v + " is a perfect.");
                    }

                }

            }

        }

        public static bool Check(double i)
        {
            bool prime = true;

            if (i == 0 || i == 1)
                prime = false;

            for (double k = 2; k <= i / 2; k++)
            {


                if ((i % k) == 0) prime = false;
            }
            return prime;
        }

    }


}
