﻿using EFCore_Transaction.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service_Transaction.Contracts
{
    public interface IPayeeRepository
    {
        Task<List<Payee>> GetAllPayees();
        Payee AddPayee(Payee payee);
        Payee GetPayee(int payeeId);
        List<string> GetAllPayeeTypes();
        int GetRandomPayeeId();
    }
}
