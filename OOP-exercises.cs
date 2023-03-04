//﻿Part 4

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
            
      /*    This exercise is worth 2 sections.
            Write a program that first reads book information from the user.
            The details to be asked for each book include the title, the number of pages and the publication year.
            Entering an empty string as the name of the book ends the reading process.
            After this the user is asked for what is to be printed.
            If the user inputs “everything” all the details are printed: the book titles, the numbers of pages, and the publication years.
            However if the user enters the string “title” only the book titles are printed.
            If something else than “everything” or “title” is given the program should not print anything.
            Implement the class Book.
            Implement the functionality in the Main method.
            Example of how the program in Main should work.    */
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

   /*       In the exercise template there is a ready made class TelevisionProgram representing a television program.
            The class has object variables name and duration, a constructor and few methods.
            Implement a program that begins by reading television programs from the user.
            When the user inputs an empty string as the name of the program the program stops reading programs.
            After this the user is queried for a maximum duration.
            Once the maximum is given the program proceeds to list all the programs whose duration is smaller or equal to the specified maximum duration.  */
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



 /*         The program described here should be implemented in the class Main. Do not modify the class PersonalInformation.
            After the user has entered the last set of details, by entering an empty first name, exit the repeat statement.
            Print one empty line here for reading clarity.
            Then print the collected personal information so that each entered object is printed in the following format.
            First and last names separated by a space. You don’t print the identification number.
            An example of the working program is given below.
            NOTICE! You can and should ask the identification number as a string. */

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


           


            //In this exercise series a class called PaymentCard is created which aims to mimic a cafeteria’s payment process.
            //The template includes the Program.cs file. You have to create the PaymentCard.cs yourself.
            //Add a new class to the project called PaymentCard by creating the file mentioned above.
            //Create the PaymentCard object’s constructor, which is passed the opening balance of the card and
            //which then stores that balance in the object’s internal variable.
            //Write the ToString method, which will return the card’s balance in the form “The card has a balance of X euros”.
            //Here is the template for the PaymentCard.
            
            /*    Using Card
            Expand your answer from the exercise 106 by adding two methods.
            Method public void EatLunch()
            Method public void DrinkCoffee()
            The method EatLunch() should decrease the card’s balance by 10.60 euros.
            The method DrinkCoffee should decrease the card’s balance by 2.0 euros.
            The following main program tests the class. */
            
            /*   Checking Balance
            Expand your previous answers, so that when an item is bought the balance is checked.
            If there is not enough money to buy the balance does not change.
            NOTICE! See how EatLunch() method did not change the balance when there was not enough money. DrinkCoffee() method still worked as it should.
            
                Charging Card
            Expand your previous answers, so that you can charge money on your card.
                
            The purpose of the method is to increase the card’s balance by the amount of money given as a parameter.
            However the card’s balance may not exceed 150 euros.
            As such, if the amount to be topped up exceeds this limit the balance should become exactly 150 euros.
            The following main program tests the class.
            NOTICE! You cannot add negative money!   */
    
            PaymentCard card = new PaymentCard(10);
            Console.WriteLine(card.ToString());
            card.EatLunch();
            Console.WriteLine(card.ToString());
            card.DrinkCoffee();
            Console.WriteLine(card.ToString());
            card.AddMoney(200);
            Console.WriteLine(card.ToString());

            //Expand the class as follows. When a number is added, count is increased by one.
            //When a number is added, sum is increased by the number’s value.
            Statistics stat = new Statistics();
            stat.AddNumber(3);
            stat.AddNumber(5);
            stat.AddNumber(1);
            stat.AddNumber(2);

            Console.WriteLine("Count: " + stat.Count_numbers());
            Console.WriteLine("Sum: " + stat.Sum_numbers());


            //Create a class Multiplier as following.
            //Constructor public Multiplier(int number).
            //Method public int Multiply(int number) which returns the value number passed to it multiplied by the number provided to the constructor.
            //You also need to create a instance variable in this exercise. When you call the method Multiply store the changed value into the instance variable!
            //NOTICE! The value stored in the objects is changed during the first calls! The calculations are actually.
       /*   3 * 2 = 6
            4 * 2 = 8
            6 * 1 = 6
            8 * 1 = 8
            8 * 3 = 24           */
            
            Multiplier multiplier_bullshit = new Multiplier(3);
            Console.WriteLine(multiplier_bullshit.Multiplier_value + " times 2: " + multiplier_bullshit.Multiply(2));
            Console.WriteLine(multiplier_bullshit.Multiplier_value + " times 3: " + multiplier_bullshit.Multiply(3));

            Multiplier starts_with_four = new Multiplier(4);
            Console.WriteLine(starts_with_four.Multiplier_value + " times 2: " + starts_with_four.Multiply(2));
            Console.WriteLine(starts_with_four.Multiplier_value + " times 1: " + starts_with_four.Multiply(1));
            Console.WriteLine(starts_with_four.Multiplier_value + " times 3: " + starts_with_four.Multiply(3));

            Console.WriteLine("==================================");

            //The exercise template comes with a ready made class named Account. The Account object represents a bank account that has balance. 
            //Account that has some amount of money in it. The accounts are used as follows.
            //Write a program that creates an account with a balance of 100.0, deposits 20.0 in it and finally prints the balance.
            
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

            //Create a class named Whistle. Add the variable private string sound to the class.
            //After that create the constructor public Whistle(string whistleSound), which is used to create a new whistle that’s given a sound.
            //Create a method public void Sound() which prints out the sound (using Console.WriteLine).
            Whistle duck = new Whistle("Kvaak");
            Whistle rooster = new Whistle("Peef");
            duck.Sound();
            rooster.Sound();

            //Create a class Product that represents a store product. The product should have a price (double), quantity (int) and name (string).
            //The class should have the constructor *public Product(string name, double price, int quantity).*
            //And a method public void PrintProduct() that prints product information in the following format.
            Product product = new Product("Banana", 1.1, 13);
            product.PrintProduct();

            //This exercise consists of multiple sections. Each section corresponds to one exercise point.
            //The exercise template comes with a partially executed class DecreasingCounter.
            
            //SECTION 1: IMPLEMENTATION OF THE DECREMENT() METHOD
            //Implement the Decrement() method in the class body in such a way that it decrements the value variable of the object.
            //The main program of the previous example should work to produce the example output.
            
            //SECTION 2: THE COUNTER’S VALUE CANNOT BE NEGATIVE
            //Improve the Decrement() in such a way that the counter’s value never becomes negative. 
            //This means that if the value of the counter is 0 it cannot be decremented. A conditional statement is useful here.
            
            //SECTION 3: RESETTING THE COUNTER VALUE
            //Create the method public void Reset() for the counter that resets the value of the counter to 0.
            
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

            //Create the class Debt that has double type instance variables balance and interestRate.
            //The balance and the interest rate are passed to the constructor as parameters public Debt(double initialBalance, double initialInterestRate).
            //In addition create the methods public void PrintBalance() and public void WaitOneYear() for the class.
            //The method PrintBalance prints the current balance and the WaitOneYear method grows the debt amount.
            //The debt is increased by multiplying the balance by the interest rate.
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

            //Create a class called Dalmatian. The dalmatian has instance variables string name and int spots.
            //Both are set in the public Dalmatian(string name, int spots) constructor.
            //Give the variables ability for get and set Make the variables public rather than private and add { get; set; } on the declaring lines!
            
            Dalmation spotty = new Dalmation("Spot", 306);
            Console.WriteLine(spotty.Name + "is a very good dog. He has " + spotty.Spots + " darker spots in his fur.");

            //Create the class Gauge. The gauge has the variable public int value and a constructor without parameters.
            //Constructor sets the initial value of the meter variable to 0. The class has following three methods.
            //Firstly public void Increase() grows the value instance variable’s value by one. It does not grow the value beyond five.
            //Secondly public void Decrease() decreases the value instance variable’s value by one. It does not decrease the value to negative values.
            //Thirdly public bool Full() returns True if the instance variable value has the value five. Otherwise, it returns False.
            //Give the value ability for get and set: Make the value public rather than private, and add { get; set; } on the declaring lines!
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





