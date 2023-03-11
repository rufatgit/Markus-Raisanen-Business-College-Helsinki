/*
EXERCISE 5-5: Overloaded Counter
Implement a class called Counter. The class contains a number, whichs value can be increased and decreased. The class must have the following constructors.

public Counter(int startValue) sets the start value of the counter to startValue.
public Counter() sets the start value of the counter to 0.
And the following methods and properties.

public int value { get; set; }
public void Increase() increases the value by 1
public void Decrease() decreases the value by 1
public void Increase(int increaseBy) increases the value of the counter by the value of increaseBy. If the value of increaseBy is negative,
the value of the counter does not change.
public void Decrease(int decreaseBy) decreases the value of the counter by the value of decreaseBy. If the value of decreaseBy is negative,
the value of the counter does not change.

*/


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

