using System;
using System.Collections.Generic;
using System.Text;

namespace HRMobile.Model
{
    public class MasterPageItem
    {//model for the menu drawer
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get;set; }
    }
}
