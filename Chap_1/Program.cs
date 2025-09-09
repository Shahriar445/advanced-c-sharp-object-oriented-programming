// called the first class and pass parameter 
//Rectangel obj = new Rectangel(10, 20);

//Rectangel obj2 = new Rectangel(30);

//Console.WriteLine("Area of Rectangel height and width: " + obj.getArea());
//Console.WriteLine("Area of Rectangel with side: " + obj2.getArea());


//// operate on the propertied
//obj.BorderSize = 5;
//Console.WriteLine($"{obj.BorderSize} ");
//obj.width = 5;
//obj.height = 6;

//Console.WriteLine("After chang height and width: " + obj.getArea());


//using Chap_1;

//Person person = new Person();
//person.Name = "Shahrier";


//person.Process();

// bkash oop 

using System;

namespace bKashSystem
{
    // Base Transaction class
    abstract class Transaction
    {
        public string TransactionId { get; private set; }
        public DateTime TransactionTime { get; private set; }
        public decimal Amount { get; protected set; }

        public Transaction(decimal amount)
        {
            TransactionId = Guid.NewGuid().ToString();
            TransactionTime = DateTime.Now;
            Amount = amount;
        }

        // Each transaction must implement this
        public abstract void Process(Customer customer);
    }

    // Cash In Transaction
    class CashIn : Transaction
    {
        public CashIn(decimal amount) : base(amount) { }

        public override void Process(Customer customer)
        {
            customer.Deposit(Amount);
            Console.WriteLine($"Cash In Successful! Amount: {Amount:C}, Current Balance: {customer.GetBalance():C}");
        }
    }

    // Cash Out Transaction
    class CashOut : Transaction
    {
        public CashOut(decimal amount) : base(amount) { }

        public override void Process(Customer customer)
        {
            if (customer.Withdraw(Amount))
            {
                Console.WriteLine($"Cash Out Successful! Amount: {Amount:C}, Current Balance: {customer.GetBalance():C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance for Cash Out!");
            }
        }
    }

    // Send Money Transaction
    class SendMoney : Transaction
    {
        public string ReceiverNumber { get; private set; }

        public SendMoney(string receiverNumber, decimal amount) : base(amount)
        {
            ReceiverNumber = receiverNumber;
        }

        public override void Process(Customer customer)
        {
            if (customer.Withdraw(Amount))
            {
                Console.WriteLine($"Money Sent Successfully!");
                Console.WriteLine($"Amount: {Amount:C}");
                Console.WriteLine($"Receiver: {ReceiverNumber}");
                Console.WriteLine($"Transaction ID: {TransactionId}");
                Console.WriteLine($"Date/Time: {TransactionTime}");
                Console.WriteLine($"Current Balance: {customer.GetBalance():C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance for sending money!");
            }
        }
    }

    // Customer class
    class Customer
    {
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        private decimal balance; // private to prevent direct modification

        public Customer(string name, string phoneNumber, decimal initialBalance)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            balance = initialBalance;
        }

        // Encapsulated balance methods
        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        // Print Customer info (answers Q1)
        public override string ToString()
        {
            return $"Name: {Name}, Phone: {PhoneNumber}, Balance: {balance:C}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a customer
            Customer customer = new Customer("Shipon Haque", "017XXXXXXXX", 1000m);
            Console.WriteLine(customer); // Q1

            // Cash In
            CashIn cashIn = new CashIn(500m);
            cashIn.Process(customer);

            // Send Money
            SendMoney sendMoney = new SendMoney("018YYYYYYYY", 300m);
            sendMoney.Process(customer); // Q2

            // Cash Out
            CashOut cashOut = new CashOut(200m);
            cashOut.Process(customer); // Q3

            // Attempt to access balance directly (not possible)
            // customer.balance = 10000; // ❌ This will give a compile-time error
        }
    }
}

