﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCT
{
    public class ExpenseCategory
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }

        public double Spent { get; set; }

        public double Balance { get; set; }

        public double Budget { get; set; }

        public double Percentage { get; set; }

        [Ignore]
        public List<TransactionDetail> Transactions { get; set; }
    }
}
