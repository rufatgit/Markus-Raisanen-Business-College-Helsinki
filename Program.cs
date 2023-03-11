

namespace ex_5_Overloaded_counter
{
    public class Counter
    {
        public int Value { get; set; }


        public Counter(int start_value)
        {
            Value = start_value;
        }

        public Counter()
        {
            Value=0;
        }

        public void Increase()
        {
            ++Value;
        }

        public void Decrease()
        {
            --Value;
        }

        public void Increase(int increaseBy)
        {
            if (increaseBy > 0)
            {
                Value += increaseBy;
            }
        }

        public void Decrease(int decreaseBy)
        {
            if (decreaseBy > 0)
            {
                Value -= decreaseBy;
            }
        }

    }

    internal class Program
    {
        public static void Main(string[] vs)
        {
            Counter counter = new Counter(10);
            counter.Increase();
            counter.Increase(10);
            counter.Decrease(5);
            Console.WriteLine(counter.Value);
            counter.Decrease(-20);
            Console.WriteLine(counter.Value);

        }
    }
}

