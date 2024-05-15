using System;
using System.Threading;


public class LOCK
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("<Lock Exercise>\n\n");
        Console.ResetColor();

        Account account = new Account(3750);

        //Creating 10 Threads!
        Thread[] threads = new Thread[10];

        for (int i = 0; i < 10; i++)
        {
            Thread t = new Thread(() =>
            {
                for (int j = 0; j < 5; j++)
                {
                    account.Withdraw(250);
                }
            });

            t.Name = $"Thread{i + 1}";
            threads[i] = t;
        }

        for (int i = 0; i < 10; i++)
        {
            threads[i].Start();
        }
        Console.ReadKey();
    }
    public class Account
    {
        private object lockObject = new object();
        public int Balance { get; private set; }

        public Account(int initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(int amount)
        {
            if (Balance < amount)
            {
                Console.WriteLine("Insufficient Balance!\n");
                return;
            }

            else
            {

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
