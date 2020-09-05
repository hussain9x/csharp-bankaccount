﻿using System;

namespace csharp_bankaccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("new account created with 0 balance");
            account.deposit(20);
            Console.WriteLine("deposited 20 Riyals");
            account.withdraw(15);
            Console.WriteLine("withdrawed 15 Riyals");
            Console.Write("the balance is : ");
            Console.WriteLine(account.getBalance());

            BankAccount account2 = new BankAccount(50);
            Console.WriteLine("new account created with 50 Riyals balance");
            account.deposit(20);
            Console.WriteLine("deposited 20 Riyals");
            account.withdraw(15);
            Console.WriteLine("withdrawed 15 Riyals");
            Console.Write("the balance is : ");
            Console.WriteLine(account.getBalance());



        }
    }


    class BankAccount{
        double balance = 0;
        public BankAccount(){

        }

        public BankAccount(double balance){
            this.balance=balance;

        }

        public double getBalance(){
            return balance;
        }

        public void deposit(double amount){
            this.balance+=amount;
        }
        public void withdraw(double amount){
            this.balance-=amount;
        }



    }




}
