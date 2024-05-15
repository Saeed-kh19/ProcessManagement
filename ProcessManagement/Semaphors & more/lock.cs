using System;
using System.Threading;
public class LOCK
{
    public static void Main(string[] args)
    {
        Account account = new Account(1000);

        //Creating 10 Threads!
        Thread[] threads = new Thread[10];

        for (int i = 0; i < 10; i++)
        {
            Thread t = new Thread(() =>
            {
                for (int j = 0; j < 5; j++)
                {
                    account.Withdraw(200);
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
                Console.WriteLine("Insufficient balance!");
                return;
            }

            else
            {

                lock (lockObject)
                {
                    if (Balance >= amount)
                    {
                        Console.WriteLine("Thread {0} is withdrawing", Thread.CurrentThread.Name);
                        Balance = Balance - amount;
                        Console.WriteLine("Thread {0} completes withdrawal. The balance now is {1}", Thread.CurrentThread.Name, Balance);
                    }
                    else
                    {
                        Console.WriteLine("Thread {0} failed to withdraw due to insufficient balance. The balance now is {1}", Thread.CurrentThread.Name, Balance);
                    }
                }
            }
        }
    }
}
