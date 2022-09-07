using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
          

            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            foreach(string s in myAL){
                Console.Write(s + " ");
            }

            Console.ReadLine();

        }
        
        
        
    }

    
}

enum CurrencyCode {
    UAH, USD, EUR
}

class Payment{
    private DateTime paymentDate;
    private User creditors;
    private User repicient;
    private decimal amountOfPayment;
    private CurrencyCode currencyCode;
    private string currentStatus;

    Payment(DateTime paymentDate, User creditors, User repicient, decimal amountOfPayment, CurrencyCode currencyCode, string currentStatus) {
        this.paymentDate = DateTime.Now;
        this.creditors = creditors;
        this.repicient = repicient;
        this.amountOfPayment = amountOfPayment;
        this.currencyCode = currencyCode;
        this.currentStatus = currentStatus;
    }


    public DateTime getPaymentDate()
    {
        return paymentDate;
    }

    public void setPaymentDate(DateTime paymentDate)
    {
        this.paymentDate = paymentDate;
    }

    public User getCreditors() {
        return creditors;
    }

    public void setCreditors(User creditors)
    {
        this.creditors = creditors;
    }

    public User getRepicient()
    {
        return repicient;
    }

    public void setRepicient(User repicient)
    {
        this.repicient = repicient;
    }

    public decimal getAmountOfPayment()
    {
        return amountOfPayment;
    }

    public void setAmountOfPayment(decimal amountOfPayment)
    {
        this.amountOfPayment = amountOfPayment;
    }

    public CurrencyCode getCurrencyCode()
    {
        return currencyCode;
    }

    public void setCurrencyCode(CurrencyCode currencyCode)
    {
        this.currencyCode = currencyCode;
    }

    public String getCurrentStatus()
    {
        return currentStatus;
    }

    public void setCurrentStatus(String currentStatus)
    {
        this.currentStatus = currentStatus;
    }


    public String toString()
    {
        return "creditors=" + creditors +
                ", repicient=" + repicient +
                ", amountOfPayment=" + amountOfPayment +
                ", currencyCode=" + currencyCode +
                ", currentStatus='" + currentStatus + '\'' +
                '}';
    }





}


class User{
    private int cardNumber;
    private long numberOfPayments;
    private int numberOfSuccessfulOperations;
    private int percentageOfSuccessfulOperations;

    public User(int cardNumber, long numberOfPayments, int numberOfSuccessfulOperations, int percentageOfSuccessfulOperations)
    {
        this.cardNumber = cardNumber;
        this.numberOfPayments = numberOfPayments;
        this.numberOfSuccessfulOperations = numberOfSuccessfulOperations;
        this.percentageOfSuccessfulOperations = percentageOfSuccessfulOperations;
    }

    public int getCardNumber()
    {
        return cardNumber;
    }

    public void setCardNumber(int cardNumber)
    {
        this.cardNumber = cardNumber;
    }

    public long getNumberOfPayments()
    {
        return numberOfPayments;
    }

    public void setNumberOfPayments(long numberOfPayments)
    {
        this.numberOfPayments = numberOfPayments;
    }

    public int getNumberOfSuccessfulOperations()
    {
        return numberOfSuccessfulOperations;
    }

    public void setNumberOfSuccessfulOperations(int numberOfSuccessfulOperations)
    {
        this.numberOfSuccessfulOperations = numberOfSuccessfulOperations;
    }

    public int getPercentageOfSuccessfulOperations()
    {
        return percentageOfSuccessfulOperations;
    }

    public void setPercentageOfSuccessfulOperations(int percentageOfSuccessfulOperations)
    {
        this.percentageOfSuccessfulOperations = percentageOfSuccessfulOperations;
    }
}

class Bank {
   
}