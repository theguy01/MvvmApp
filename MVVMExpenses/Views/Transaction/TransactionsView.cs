﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVMExpenses.Views.Transaction
{
    [DevExpress.Utils.MVVM.UI.ViewType("TransactionCollectionView")]
    public partial class TransactionsView : UserControl
    {
        public TransactionsView()
        {
            InitializeComponent();
        }
    }
}
