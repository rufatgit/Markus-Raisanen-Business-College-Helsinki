

namespace raisanenmarkus_classes_First_account
{
    public class Account
    {
        public string Name_account { get; set; }
        public double Balance_account { get; set; }


        public Account()
        {
            Name_account = "";
            Balance_account = 0.00;


        }

        public Account(string name, double balance)
        {
            Name_account = name;
            Balance_account = balance;

        }


        public void Withdrawal(double amount)
        {
            if (Balance_account - amount > 0)
            {
                Balance_account = Balance_account - amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance in " + Name_account + " account");
            }
        }

        public double Balance()
        {
            return Balance_account;
        }

        public void Deposit(double deposit)
        {
            Balance_account = Balance_account + deposit;
        }

        public string Get_name_account()
        {
            return Name_account;
        }
    }


    public class Dog
    {
        private string name;
        private string breed;
        private int age;
    }

    public class Room
    {
        private string code;
        private int seats;

        public Room(string ClassCode, int number_of_Seats)
        {
            code = ClassCode;
            seats = number_of_Seats;
        }
    }

    public class Whistle
    {
        private string sound;

        public Whistle(string whistle_Sound)
        {
            sound = whistle_Sound;
        }

        public void Sound()
        {
            Console.WriteLine(sound);
        }


    }

    public class Product
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void PrintProduct()
        {
            Console.WriteLine(Name + " \nPrice: " + Price + "\nQuantity: " + Quantity + " pcs");
        }

    }

    public class Decreasing_Counter
    {
        public int Value { get; set; }

        public Decreasing_Counter(int value)
        {
            Value = value;
        }

        public void PrintValue()
        {
            Console.WriteLine("Value: " + Value);
        }

        public void Decrement()
        {
            if (Value == 0)
            {

            }
            else
            {
                Value--;
            }
        }

        public void Reset()
        {
            Value = 0;
        }



    }


    public class Debt
    {
        public double Balance { get; set; }
        public double InteresetRate { get; set; }

        public Debt(double balance, double initial_interest_rate)
        {
            Balance = balance;
            InteresetRate = initial_interest_rate;
        }

        public string PrintBalance()
        {
            return "Balance: " + Balance;
        }

        public void WaitOneYear()
        {
            Balance = Balance * InteresetRate;
        }

    }

    public class Dalmation
    {
        public string Name { get; set; }
        public int Spots { get; set; }

        public Dalmation(string name, int spots)
        {
            Name = name;
            Spots = spots;
        }


    }


    public class Gauge
    {
        public int Value { get; set; }

        public Gauge()
        {
            Value = 0;
        }

        public void Increase()
        {
            if (Value < 5)
            {
                ++Value;
            }
        }

        public void Decrease()
        {
            if (Value > 0)
            {
                --Value;
            }
        }


        public bool Full()
        {
            return Value == 5;
        }

    }

    public class Multiplier
    {
        public int Multiplier_value { get; set; }

        public Multiplier(int number)
        {
            Multiplier_value = number;
        }

        public int Multiply(int n)
        {
            Multiplier_value = n * Multiplier_value;
            return Multiplier_value;
        }
    }

    public class Statistics
    {
        public int Count { get; set; }
        public int Sum { get; set; }

        public List<int> list { get; set; }

        public Statistics()
        {
            list = new List<int>();
        }

        public void AddNumber(int a)
        {
            list.Add(a);
            ++Count;
        }

        public int Count_numbers()
        {
            return Count;
        }

        public int Sum_numbers()
        {
            return list.Sum();
        }
    }

    public class PaymentCard
    {
        public double Balance { get; set; }

        public PaymentCard(double balance)
        {
            Balance = balance;
        }


        public override string ToString()
        {
            return "The card has a balance of " + Balance + " euros";
        }

        public void EatLunch()
        {
            if (Balance - 10.60 > 0)
            {
                Balance = Balance - 10.60;
            }
        }
        public void DrinkCoffee()
        {
            if (Balance - 2.0 > 0)
            {
                Balance = Balance - 2.0;
            }
        }

        public void AddMoney(double m)
        {
            if (m > 0)
            {


                if (Balance + m > 150)
                {
                    Balance = 150;
                }
                else
                {
                    Balance = Balance + m;
                }
            }
            else
            {
                Console.WriteLine("ADded money cannot be negative.");
            }
        }

    }


    public class Item
    {
        public List<string> Names { get; set; }
        public List<string> Times { get; set; }
        public List<string> Combine { get; set; }

        public Item(List<string> list1, List<string> list2, List<string> list3)
        {
            Names = list1;
            Times = list2;
            Combine = list3;
        }

        public void Combine_Lists()
        {
            for (int i = 0; i < Names.Count; i++)
            {
                Combine.Add(Names[i] + " " + Times[i]);
            }
        }


        public void ToString()
        {
            foreach (string s in Combine)
            {
                Console.WriteLine(s);
            }
        }
    }

    public class PersonalInformation
    {
        public List<string> Name { get; set; }
        public List<string> Surname { get; set; }
        public List<string> Combine_Name_Surname { get; set; }
        public List<int> ID_number { get; set; }

        public PersonalInformation()
        {
            Name = new List<string>();
            Surname = new List<string>();
            Combine_Name_Surname = new List<string>();
            ID_number = new List<int>();
        }

        public void Enter_Name(string name)
        {
            Name.Add(name);
        }

        public void Enter_Surname(string surname)
        {
            Surname.Add(surname);
        }

        public void Combine_Names_Surnames()
        {
            for (int i = 0; i < Name.Count; i++)
            {
                Combine_Name_Surname.Add(Name[i]+" "+Surname[i]);
            }
        }

        public void ID(int id)
        {
            ID_number.Add(id);
        }

        public void Print()
        {
            foreach (string s in Combine_Name_Surname)
            {
                Console.WriteLine(s);
            }
        }


    }


    public class Television_Guide
    {
        List<string> Name { get; set; }
        List<int> Duration { get; set; }

        public Television_Guide()
        {
            Name = new List<string>();
            Duration = new List<int>();
        }

        public void Addname(string name)
        {
            Name.Add(name);
        }

        public void AddDuration(int duration)
        {
            Duration.Add(duration);
        }


        public void Show_Programs(int program_duration)
        {
            for (int i = 0; i < Duration.Count; i++)
            {
                if (Duration[i]<=program_duration)
                {
                    Console.WriteLine(Name[i]+", "+Duration[i]);
                }
            }
        }
    }


    public class Book
    {
        List<string> Everything { get; set; }
        List<string> Name { get; set; }
        List<int> Pages { get; set; }
        List<int> Publication_Year { get; set; }


        public Book()
        {
            Everything = new List<string>();
            Name = new List<string>();
            Pages = new List<int>();
            Publication_Year = new List<int>();
        }


        public void AddName(string title)
        {
            Name.Add(title);
        }

        public void AddPages(int pages)
        {
            Pages.Add(pages);
        }

        public void AddYear(int year)
        {
            Publication_Year.Add(year);
        }

        public void Combine()
        {
            for (int i = 0; i < Name.Count; i++)
            {
                Everything.Add(Name[i]+", "+Pages[i]+" pages, "+Publication_Year[i]);
            }
        }

        public void PrintAll()
        {
            foreach (string s in Everything)
            {
                Console.WriteLine(s);
            }
        }

        public void PrintTitle()
        {
            foreach (string s in Name)
            {
                Console.WriteLine(s);
            }

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();


            while (true)
            {
                Console.WriteLine("Name: ");
                string name=Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    break;
                }
                book.AddName(name);

                Console.WriteLine("Pages: ");
                int page= int.Parse(Console.ReadLine());
                book.AddPages(page);

                Console.WriteLine("Publication Year: ");
                int year= int.Parse(Console.ReadLine());    
                book.AddYear(year);
            }

            book.Combine();


            string every = "everything";
            string title = "title";
            Console.WriteLine("What information will be printed?");
            string input=Console.ReadLine();
            if (input==every)
            {
                book.PrintAll();

            }

            if (input==title)
            {
                book.PrintTitle();
            }

            Console.WriteLine("=========================================");


            Television_Guide tele=new Television_Guide();

            while (true)
            {
                Console.WriteLine("Name: ");
                string name=Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    break;
                }
                tele.Addname(name);


                Console.WriteLine("Duration: ");
                int duration = int.Parse(Console.ReadLine());
                
                tele.AddDuration(duration);
            }

            Console.WriteLine("Program's maximum duration? ");
            tele.Show_Programs(int.Parse(Console.ReadLine()));





            PersonalInformation per_info = new PersonalInformation();


            while (true)
            {
                Console.WriteLine("First Name: ");
                string name=Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    break;
                }
                per_info.Enter_Name(name);

                Console.WriteLine("Surname: ");
                string surname = Console.ReadLine();
                if (string.IsNullOrEmpty(surname))
                {
                    break;
                }
                per_info.Enter_Surname(surname);


                Console.WriteLine("ID number: ");
                int id = int.Parse(Console.ReadLine());

                per_info.ID(id);

            }

            per_info.Combine_Names_Surnames();
            Console.WriteLine("List of Persons: ");
            per_info.Print();

            Console.WriteLine("============================================"); 


            List<string> list_names = new List<string>();
            List<string> list_time = new List<string>();
            List<string> list_combine = new List<string>();

            for (int i = 0; i < 1000000000; ++i)
            {
                Console.Write("Name: ");
                string check = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(check))
                {
                    break;
                }

                list_names.Add(check);
                list_time.Add("(Created at: " + DateTime.Now.ToString() + ")");
            }

            Item names_items = new Item(list_names, list_time, list_combine);
            names_items.Combine_Lists();
            names_items.ToString();


           



            PaymentCard card = new PaymentCard(10);
            Console.WriteLine(card.ToString());
            card.EatLunch();
            Console.WriteLine(card.ToString());
            card.DrinkCoffee();
            Console.WriteLine(card.ToString());
            card.AddMoney(200);
            Console.WriteLine(card.ToString());


            Statistics stat = new Statistics();
            stat.AddNumber(3);
            stat.AddNumber(5);
            stat.AddNumber(1);
            stat.AddNumber(2);

            Console.WriteLine("Count: " + stat.Count_numbers());
            Console.WriteLine("Sum: " + stat.Sum_numbers());


            Multiplier multiplier_bullshit = new Multiplier(3);
            Console.WriteLine(multiplier_bullshit.Multiplier_value + " times 2: " + multiplier_bullshit.Multiply(2));
            Console.WriteLine(multiplier_bullshit.Multiplier_value + " times 3: " + multiplier_bullshit.Multiply(3));

            Multiplier starts_with_four = new Multiplier(4);
            Console.WriteLine(starts_with_four.Multiplier_value + " times 2: " + starts_with_four.Multiply(2));
            Console.WriteLine(starts_with_four.Multiplier_value + " times 1: " + starts_with_four.Multiply(1));
            Console.WriteLine(starts_with_four.Multiplier_value + " times 3: " + starts_with_four.Multiply(3));

            Console.WriteLine("==================================");


            Account Heikki = new Account("Heikki", 1000.00);
            Account Heikkis_Swiss = new Account("Heikki's account in Switerland", 1000000.00);
            Account personal = new Account("Personal", 0);

            Console.WriteLine("Initial: ");
            Console.WriteLine(Heikki.Get_name_account());
            Console.WriteLine(Heikkis_Swiss.Get_name_account());
            Console.WriteLine("==================================");

            Heikki.Withdrawal(20);
            Console.WriteLine("Heikki's balance: " + Heikki.Balance());
            Heikkis_Swiss.Deposit(200);
            Console.WriteLine("The balance of Heikki's other account: " + Heikkis_Swiss.Balance());

            Console.WriteLine("==================================");



            Heikki.Withdrawal(100);
            personal.Deposit(100);


            Console.WriteLine("Heikki's account balance: " + Heikki.Balance());
            Console.WriteLine("Personal account balance: " + personal.Balance());


            Whistle duck = new Whistle("Kvaak");
            Whistle rooster = new Whistle("Peef");
            duck.Sound();
            rooster.Sound();


            Product product = new Product("Banana", 1.1, 13);
            product.PrintProduct();

            Decreasing_Counter counter = new Decreasing_Counter(1);
            counter.PrintValue();

            counter.Decrement();
            counter.PrintValue();

            counter.Decrement();
            counter.PrintValue();

            counter.Value = 5;
            counter.PrintValue();
            counter.Reset();
            counter.PrintValue();

            Debt mortgage = new Debt(120000, 1.01);

            Console.WriteLine(mortgage.PrintBalance());

            mortgage.WaitOneYear();
            Console.WriteLine(mortgage.PrintBalance());

            int years = 0;

            while (years < 20)
            {
                mortgage.WaitOneYear();
                ++years;
            }

            Console.WriteLine(mortgage.PrintBalance());

            Dalmation spotty = new Dalmation("Spot", 306);
            Console.WriteLine(spotty.Name + "is a very good dog. He has " + spotty.Spots + " darker spots in his fur.");


            Gauge g = new Gauge();
            while (!g.Full())
            {
                Console.WriteLine("Null full value: " + g.Value);
                g.Increase();
            }

            Console.WriteLine("Full Value: " + g.Value);
            g.Decrease();
            Console.WriteLine("Not full! Value: " + g.Value);









        }


    }


}





