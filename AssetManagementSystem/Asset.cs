using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetManagementSystem.AssetClass
{
    public class Asset
    {
        private string name = "computer";
        private int purchaseDate;
        private int amount; 
        private int serviceDates;
        private string sort;
        private string custodyDepartment;
        private string ifLoan;
        private string loanDepartment;
        private string storageDepartment;

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual int PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }

        public virtual int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public virtual int ServiceDates
        {
            get { return serviceDates; }
            set { serviceDates = value; }
        }
        public virtual string Sort
        {
            get { return sort; }
            set { sort = value; }
        }
        public virtual string CustodyDepartment
        {
            get { return custodyDepartment; }
            set { custodyDepartment = value; }
        }
        public virtual string IfLoan
        {
            get { return ifLoan; }
            set { ifLoan = value; }
        }
        public virtual string LoanDepartment
        {
            get { return loanDepartment; }
            set { loanDepartment = value; }
        }
        public virtual string StorageDepartment
        {
            get { return storageDepartment; }
            set { storageDepartment = value; }
        }

        public void AddName(string p)
        {
            Name = p;
        }
        public void AddAmount(int p)
        {
            Amount = p;
        }
        public void AddPurchaseDate(int p)
        {
            PurchaseDate = p;
        }

        public void AddServiceDates(int p)
        {
            ServiceDates = p;
        }
        public void AddSort(string p)
        {
            Sort = p;
        }
        public void AddCustodyDepartment(string p)
        {
            CustodyDepartment = p;
        }
        public void AddIfLoan(string p)
        {
            IfLoan = p;
        }
        public void AddLoanDepartment(string p)
        {
            LoanDepartment = p;
        }
        public void AddStorageDepartment(string p)
        {
            StorageDepartment = p;
        }
    }
}
