



namespace ex_3_FitByte
{
    public class FitByte
    {
        public double Resting_Heart_Rate { get; set; }
        public int Age { get; set; }
        public double Max_Heart_Rate { get; set; }

        public FitByte(int age, double resting_heart_rate)
        {
            Age = age;
            Resting_Heart_Rate = resting_heart_rate;
            Max_Heart_Rate = 206.3 - (0.711 * Age);
        }

        public double Target_Heart_Rate(double Percentage_ofMaximum)
        {

            return (Max_Heart_Rate-Resting_Heart_Rate)*Percentage_ofMaximum+Resting_Heart_Rate;

        }





    }

    internal class Program
    {
        public static void Main(string[] args)
        {

            FitByte assistant = new FitByte(30, 60);
            double percentage = 0.5;

            while (percentage < 1.0)
            {
                double target = assistant.Target_Heart_Rate(percentage);
                Console.WriteLine(("Target "+(percentage*100).ToString("F1"))+"% of maximum: "+target);
                percentage = percentage + 0.1;


            }



        }
    }
}









