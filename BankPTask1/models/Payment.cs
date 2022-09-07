using System;


namespace BankPTask1.models
{

    class Payment
    {
        private DateTime paymentDate;
        private User creditors;
        private User repicient;
        private double amountOfPayment;
        private CurrencyCode currencyCode;
        private CurrentStatus currentStatus;

        public Payment(User creditors, User repicient, double amountOfPayment, CurrencyCode currencyCode, CurrentStatus currentStatus)
        {
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

        public User getCreditors()
        {
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

        public double getAmountOfPayment()
        {
            return amountOfPayment;
        }

        public void setAmountOfPayment(double amountOfPayment)
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

        public CurrentStatus getCurrentStatus()
        {
            return currentStatus;
        }

        public void setCurrentStatus(CurrentStatus currentStatus)
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
}
