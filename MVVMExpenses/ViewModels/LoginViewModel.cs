﻿using DevExpress.Mvvm.POCO;
using MVVMExpenses.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMExpenses.ViewModels
{
    public class LoginViewModel
    {
        //public IEnumerable<string> LookUpUsers
        //{
        //    get { return CredentialsSource.GetUserNames(); }
        //}
        public virtual User CurrentUser { get; set; }
        public bool IsCurrentUserCredentialsValid { get; private set; }
        ////
        //[DevExpress.Mvvm.DataAnnotations.Command(false)]
        //public void Init()
        //{
        //    this.CurrentUser = new User();
        //}
        //public void Update()
        //{
        //    IsCurrentUserCredentialsValid = CredentialsSource.Check(CurrentUser.Login, CurrentUser.Password);
        //}
        public static LoginViewModel Create()
        {
            return ViewModelSource.Create<LoginViewModel>();
        }
    }
}
