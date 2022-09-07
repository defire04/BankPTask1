using System;
using System.Collections;
using BankPTask1;
using BankPTask1.models;

namespace BankPTask1
{
    /*
     У банку зберігається наступна інформація про кожен платіж: дата платежу, номер картки відправника та отримувача, сума операції, код валюти (UAH, USD, EUR) та поточний статус 
       (завершено, помилка, в обробці). За даними про n платежів дізнайтеся:
        1) скільки операцій виконано із заданого номера картки? Виведіть інформацію про кожну із них;
        2) яка загальна сума усіх успішних операцій для кожної картки?
        3) який відсоток успішних операцій серед усіх операцій?
    */  
    class Program {
        static void Main(string[] args){


            User Max = new User(1234);
            User Bob = new User(2345);
            User Mary = new User(9676);
            User Serg = new User(7654);


            Payment mb = Bank.creatingPayment(Max, Bob, 55.56, CurrencyCode.USD);
            Payment mm = Bank.creatingPayment(Max, Mary, 122, CurrencyCode.USD);
            Payment ms = Bank.creatingPayment(Max, Serg, 432.5, CurrencyCode.USD);
            Payment sm = Bank.creatingPayment(Serg, Max, 185, CurrencyCode.USD);

            Bank.infoAvoutPerson(Max);

            Bank.payPayment(mb);
            Bank.payPayment(sm);

            Bank.infoAvoutPerson(Max);


            Console.ReadLine();

        }
    }
}



