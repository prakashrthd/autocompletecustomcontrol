using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoCompleteCustomControl.Models
{
    public class ContactModel
    {
        public ContactPartialViewModel ContactPartialVM { get; set; }

        public ContactModel()
        {
            ContactPartialVM = new ContactPartialViewModel();
        }
    }
}