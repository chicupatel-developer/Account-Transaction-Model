﻿using EFCore_Transaction.Context;
using EFCore_Transaction.Models;
using Microsoft.EntityFrameworkCore;
using Service_Transaction.Contracts;
using Service_Transaction.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Transaction.Services
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ApplicationDbContext appDbContext;

        public TransactionRepository(ApplicationDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<List<Transaction>> GetAllTransactions()
        {
            return await appDbContext.Transactions.ToListAsync();
        }


        public Transaction AddTransaction(Transaction transaction, AccountBalance accountBalance)
        {
            try
            {
                var account = appDbContext.Accounts
                      .Where(x => x.AccountId == accountBalance.AccountId).FirstOrDefault();
                if (account != null)
                {
                    // 1
                    account.Balance = accountBalance.Balance;

                    // 2
                    var result = appDbContext.Transactions.Add(transaction);
                    
                    appDbContext.SaveChanges();
                    return result.Entity;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                return null;
            }     
        }

        public Transaction GetTransaction(int transactionId)
        {
            return appDbContext.Transactions.Where(x => x.TransactionId == transactionId).FirstOrDefault();
        }

        public List<string> GetAllTransactionTypes()
        {
            List<string> transactionTypes = new List<string>();
            foreach (string transactionType in Enum.GetNames(typeof(TransactionType)))
            {
                transactionTypes.Add(transactionType);
            }
            return transactionTypes;
        }
    }
}