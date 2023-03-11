/*
EXERCISE 5-3: Fitbyte
The Karvonen method allows you to calculate your target heart rate for physical exercise. 
The target heart rate is calculated with the formula 
(maximum heart rate - resting heart rate) * (target heart rate percentage) + resting heart rate 
where the target heart rate is given as a percentage of the maximum heart rate.

For example if a person has a maximum heart rate of 200 a resting heart rate of 50 and a target heart rate of 75% of the maximum heart rate.
The target heart rate should be about ((200-50) * (0.75) + 50) = 162.5 beats per minute.

Create an “exercise assistant” class called Fitbyte. Its constructor takes both an age and a resting heart rate as its parameters.
The exercise assistant should provide a method TargetHeartRate, 
which is passed a number of type double as a parameter that represents a percentual portion of the maximum heart rate. 
The proportion is given as a number between zero and one.

The class should have:

A constructor public Fitbyte(int age, int restingHeartRate)
A method public double TargetHeartRate(double percentageOfMaximum) that calculates and returns the target heart rate.
Use the formula 206.3 - (0.711 * age) to calculate the maximum heart rate. 
Use the formula (maxHeartRate - restingHeartRate) * percentageOfMaximum + restingHeartRate to calculate the target heart rate
*/


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









