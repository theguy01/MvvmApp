﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMExpenses.DataModels
{
    public enum TransactionType
    {
        Expense,
        Income
    }
    public class Transaction
    {
        [Key, Display(AutoGenerateField = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Display(AutoGenerateField = false)]
        public long AccountID { get; set; }

        [Display(Name = "ACCOUNT")]
        [ForeignKey("AccountID")]
        public virtual Account Account { get; set; }

        [Display(AutoGenerateField = false)]
        public long CategoryID { get; set; }

        [Display(Name = "CATEGORY")]
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "DATE")]
        public DateTime Date { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "AMOUNT")]
        public decimal Amount { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "COMMENT")]
        public string Comment { get; set; }
    }
}
