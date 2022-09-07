using BankPTask1.models;
using System;
using System.Collections;

namespace BankPTask1
{
    class Bank {

        private static ArrayList payments = new ArrayList();

        public static Payment creatingPayment(User creditors, User repicient, double amountOfPayment, CurrencyCode currencyCode)
        {

            Payment newPayment = new Payment(creditors, repicient, amountOfPayment, currencyCode, CurrentStatus.PROCESSING);
            payments.Add(newPayment);

            return newPayment;
        }

        public static void payPayment(Payment payment)
        {
            payment.setCurrentStatus(CurrentStatus.COMPLETED);
        }

        public static void infoAvoutPerson(User user)
        {
            Console.WriteLine("Количество сделаных операций пользователя = " + numberOfUsersTransactions(user) +
                "\nКоличество успешных операций пользователя = " + numberOfSuccessfulPayments(user) +
                "\nПроцент успешных операций среди всех операций = " + percentagOfSuccessfulOperations(user) + 
                " %\n-----------------------------------");
        }

        public static long numberOfUsersTransactions(User user)
        {
            long numberOfTransactions = 0L;
            foreach (Payment payment in payments)
            {
                if (payment.getCreditors().Equals(user) || payment.getRepicient().Equals(user))
                {
                    numberOfTransactions++;
                }
            }
            return numberOfTransactions;
        }

        public static long numberOfSuccessfulPayments(User user)
        {
            long numberOfSuccessfulPayments = 0L;
            foreach (Payment payment in payments)
            {
                if ((payment.getCreditors().Equals(user) || payment.getRepicient().Equals(user)) && payment.getCurrentStatus().Equals(CurrentStatus.COMPLETED))
                {
                    numberOfSuccessfulPayments++;
                }
            }
            return numberOfSuccessfulPayments;
        }

        public static double percentagOfSuccessfulOperations(User user)
        {
            return numberOfSuccessfulPayments(user) * 100.0 / numberOfUsersTransactions(user);
        }

    }
}
