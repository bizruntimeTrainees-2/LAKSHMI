﻿using System;

namespace Static
{
    public class Account
    {
        public int accno;
        public String name;
        public static float rateOfInterest = 9.5f;
        public Account(int accno, String name)
        {
            this.accno = accno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(accno + " " + name);
        }
    }
    class TestAccount
    {       
        public static void Main(string[] args)
        {
           Account a1 = new Account(101, "lakky");
            Account a2 = new Account(102, "nandu");
            a1.display();
            a2.display();
        }
    }
}
