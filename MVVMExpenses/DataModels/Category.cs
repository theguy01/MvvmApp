﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMExpenses.DataModels
{
    public class Category
    {
        [Key, Display(AutoGenerateField = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        [Required, StringLength(30, MinimumLength = 5)]
        [Display(Name = "CATEGORY")]
        public string Name { get; set; }
        [EnumDataType(typeof(TransactionType))]
        [Display(Name = "TRANSACTION TYPE")]
        public TransactionType Type { get; set; }
        public override string ToString()
        {
            return Name + " (" + Type.ToString() + ")";
        }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
