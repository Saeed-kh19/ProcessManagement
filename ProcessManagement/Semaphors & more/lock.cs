using System;
using System.Dynamic;
using System.Threading;


public class LOCK
{
    public static void Main(string[] args)
    {
        //Welcomization
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("<Lock Exercise>\n\n");
        Console.ResetColor();

        //Creating new account class!
        Account account = new Account(3750);

        //Creating 10 Threads!
        Thread[] threads = new Thread[10];

        for (int i = 0; i < 10; i++)
        {
            Thread t = new Thread(() =>
            {
                for (int j = 0; j < 5; j++)
                {
                    //Withdraw some money!
                    account.Withdraw(250);
                }
            });

            //Naming Threads!
            t.Name = $"Thread{i + 1}";
            threads[i] = t;
        }

        for (int i = 0; i < 10; i++)
        {
            //Starting Threads!
            threads[i].Start();
        }

        //For stopping program from quiting!
        Console.ReadKey();
    }
    public class Account
    {
        //Create new lock object
        private object lockObject = new object();

        //Create new balance property!
        public int Balance { get; private set; }

        //Account Class constructor for initializing the balance
        public Account(int initialBalance)
        {
            Balance = initialBalance;
        }

        //a Functions for withdrawing some money from Balance!
        public void Withdraw(int amount)
        {
            if (Balance < amount)
            {
                Console.WriteLine("Insufficient Balance!\n");
                return;
            }

            else
            {
                //The main usage of the lock process!
                lock (lockObject)
                {
                    if (Balance >= amount)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("{0} is Withdrawing\n", Thread.CurrentThread.Name);
                        Console.ResetColor();

                        Balance = Balance - amount; 

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0} Completes Witdrawal. The balance now is: {1}\n", Thread.CurrentThread.Name, Balance);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("{0} Failed to withdraw due to insufficient balance. The balance now is {1}\n", Thread.CurrentThread.Name, Balance);
                    }
                }
            }
        }
    }
}
