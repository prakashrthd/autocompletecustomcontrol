using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoCompleteCustomControl.Models
{
    public class ContactPartialViewModel
    {
        //fields
        public string ContactMode_First { get; set; }
        public string CountryCode_First { get; set; }
        public string InputText_First { get; set; }
        public string Extension_First { get; set; }

        public string ContactMode_Second { get; set; }
        public string CountryCode_Second { get; set; }
        public string InputText_Second { get; set; }
        public string Extension_Second { get; set; }

        public string ContactMode_Third { get; set; }
        public string CountryCode_Third { get; set; }
        public string InputText_Third { get; set; }
        public string Extension_Third { get; set; }

        public string First_CM_Mask { get; set; }
        public string Second_CM_Mask { get; set; }
        public string Third_CM_Mask { get; set; }

        //list fields
        public List<System.Web.Mvc.SelectListItem> ContactModeList { get; set; }
        public List<System.Web.Mvc.SelectListItem> CountryCodeList { get; set; }

        //Default value fields
        public string Default_Country { get; set; }
        public string Default_ContactMode_First { get; set; }
        public string Default_ContactMode_Second { get; set; }
        public string Default_ContactMode_Third { get; set; }


        //variables to perform actions
        public bool Is_First_Contact_Mode_Visible { get; set; }
        public bool Is_First_Contact_Mode_Enabled { get; set; }
        public bool Is_Second_Contact_Mode_Visible { get; set; }
        public bool Is_Second_Contact_Mode_Enabled { get; set; }
        public bool Is_Third_Contact_Mode_Visible { get; set; }
        public bool Is_Third_Contact_Mode_Enabled { get; set; }

        public bool Is_First_CM_Extension_Visible { get; set; }
        public bool Is_First_CM_Extension_Enabled { get; set; }
        public bool Is_Second_CM_Extension_Visible { get; set; }
        public bool Is_Second_CM_Extension_Enabled { get; set; }
        public bool Is_Third_CM_Extension_Visible { get; set; }
        public bool Is_Third_CM_Extension_Enabled { get; set; }


        public ContactPartialViewModel()
        {
            Default_Country = "+91";
            Default_ContactMode_First = "Phone";
            Default_ContactMode_Second = "Business";
            Default_ContactMode_Third = "E-Mail";

            Is_First_Contact_Mode_Visible = true;
            Is_First_Contact_Mode_Enabled = true;
            Is_Second_Contact_Mode_Visible = true;
            Is_Second_Contact_Mode_Enabled = true;
            Is_Third_Contact_Mode_Visible = true;
            Is_Third_Contact_Mode_Enabled = true;
            Is_First_CM_Extension_Visible = true;
            Is_First_CM_Extension_Enabled = true;
            Is_Second_CM_Extension_Visible = true;
            Is_Second_CM_Extension_Enabled = true;
            Is_Third_CM_Extension_Visible = true;
            Is_Third_CM_Extension_Enabled = true;


            CountryCodeList = new List<System.Web.Mvc.SelectListItem>();
            CountryCodeList.Add(new System.Web.Mvc.SelectListItem() { Text="Select", Value="Select" });

            ContactModeList = new List<System.Web.Mvc.SelectListItem>();
            ContactModeList.Add(new System.Web.Mvc.SelectListItem() { Text="Select", Value="Select" });
        }

    }

    public class CountryDetailModel
    {
        public string CountryCode { get; set; }
        public string Mask { get; set; }
    }

    public class DropdownViewModel
    {
        public string DataValueField { get; set; }
        public string DataTextField { get; set; }
        public string SelectedValue { get; set; }
    }
}