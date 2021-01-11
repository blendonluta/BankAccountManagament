﻿using BankAccountManagament.Utils;
using BankAccountManagamentLibrary.Models.AccountModel;
using Controller;

namespace BankAccountManagament.CommonViews {
    public abstract class MainAccountView : Menu {


        public abstract Account Account {
            get;
        }


        public Account ViewTransactions() {
            //TODO Fix viewing Transactions
            //Console.WriteLine(Container.GetDependency(typeof(TransactionServices)).InvokeMethod("GetAll", Account));
            return Account;
        }

        public void SendMoney() {
            ClientUtils.SendingMoney(Account, 0);            
        }
    }
}