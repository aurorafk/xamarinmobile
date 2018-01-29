using System;
using System.Collections.Generic;
using System.Text;
using HRMobile.Model;

namespace HRMobile.ViewModels
{
    public class Policy1viewModel
    {
        public TaskModel TaskModel
        {
            get;
            set;
        }
        public Policy1viewModel()
        {
            //class taskmdel in model folder
            TaskModel = new TaskModel
            {//initializing the methods
                Title = "Application Name",
                Info = "Wapic People",
               
        };

        }
    }
}
