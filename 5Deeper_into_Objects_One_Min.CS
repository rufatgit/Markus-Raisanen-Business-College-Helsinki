//Part 5 - Deeper into Objects   https://raisanenmarkus.github.io/csharp/part5/5/
//EX One Minute

using System.Timers;
using System.Diagnostics;

namespace deeper_into_Objects
{
    public class My_Timer
    {
        public Stopwatch timer { get; set; }


        public My_Timer()
        {
            timer = new Stopwatch();
            timer.Start();
        }

        public void Check_Time_stop(int millieseconds_interval_a)
        {
            while (true)
            {
                if (timer.ElapsedMilliseconds >= millieseconds_interval_a)
                {
                    timer.Stop();
                    Console.WriteLine("Elapsed time with stopwatch format: " + timer.Elapsed);
                    string elapsed_minutes_seconds = string.Format("{0:00}:{1:00}",
                        timer.Elapsed.Seconds, timer.Elapsed.Milliseconds);
                    //0 and 1 before columns show that placeholders to show in output

                    Console.WriteLine("Timer stopped at: " + elapsed_minutes_seconds);
                    break;
                }

            }
        }

    }


    public class Timer
    {
        private ClockHand Hundredths;
        private ClockHand Seconds;

        public Timer()
        {
            Hundredths = new ClockHand(100);
            Seconds = new ClockHand(60);
        }


        public void Advance()
        {
            Hundredths.Advance();

            if (Hundredths.Value == 0)
            {
                Seconds.Advance();
            }
        }


        public override string ToString()
        {
            string seconds_string=Seconds.ToString().PadLeft(2, '0');
            string hundredths_string=Hundredths.ToString().PadLeft(2, '0');
            return seconds_string + ":" + hundredths_string;


        }



    }

    public class ClockHand
    {
        public int Value { get; set; }
        public int Limit { get; }

        public ClockHand(int limit)
        {
            Limit = limit;
            Value = 0;
        }

        public void Advance()
        {
            Value++;
            if (Value >= Limit)
            {
                Value = 0;
            }
        }


        public override string ToString()
        {
            return Value.ToString();
        }



    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Time limit in milllieseconds: 555");
            //int limit = int.Parse(Console.ReadLine());

            My_Timer my_timer = new My_Timer();
             
            my_timer.Check_Time_stop(555);

            Console.WriteLine("elapsed time: " + my_timer.timer.ElapsedMilliseconds);

            Console.WriteLine("#############################");
            
            
            Timer timer = new Timer();

            for (int i = 0; i < 6000; i++)
            {
                Console.WriteLine(timer.ToString());
                timer.Advance();
                System.Threading.Thread.Sleep(10); //pause execution for 10 millieseconds
                Console.SetCursorPosition(0, Console.CursorTop - 1); //deletes last line in the output 

            }



        }
    }
}














