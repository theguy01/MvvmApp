﻿using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using MVVMExpenses.MyDbContextDataModel;
using MVVMExpenses.Common;
using MVVMExpenses.DataModels;

namespace MVVMExpenses.ViewModels {

    /// <summary>
    /// Represents the Transactions collection view model.
    /// </summary>
    public partial class TransactionCollectionViewModel : CollectionViewModel<Transaction, long, IMyDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TransactionCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TransactionCollectionViewModel Create(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TransactionCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TransactionCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TransactionCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TransactionCollectionViewModel(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Transactions) {
        }
    }
}