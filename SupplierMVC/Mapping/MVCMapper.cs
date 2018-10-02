using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NORTHWNDSupplier_DAL;
using NORTHWNDSupplier_DAL.Models;
using SupplierMVC.Models;
using System.Data.SqlClient;

namespace SupplierMVC.Mapping
{
    public static class MVCMapper
    {
        public static List<Supplier> FromDoToPo(List<SupplierDO> from)
        {
            List<Supplier> newSuppList = new List<Supplier>();

            for (int field = 0; field < from.Count; field++)
            {
                Supplier suppInfo = new Supplier();

                suppInfo.SupplierID = from[field].SupplierID;
                suppInfo.CompanyName = from[field].CompanyName;
                suppInfo.ContactName = from[field].ContactName;
                suppInfo.ContactTitle = from[field].ContactTitle;
                suppInfo.Address = from[field].Address;
                suppInfo.City = from[field].City;
                suppInfo.Region = from[field].Region;
                suppInfo.PostalCode = from[field].PostalCode;
                suppInfo.Country = from[field].Country;
                suppInfo.Phone = from[field].Phone;
                suppInfo.Fax = from[field].Fax;
                suppInfo.HomePage = from[field].HomePage;

                newSuppList.Add(suppInfo);
            }
            return newSuppList;
        }

        public static SupplierDO PoToDo(Supplier from)
        {
            SupplierDO suppInfo = new SupplierDO();

            suppInfo.SupplierID = from.SupplierID;
            suppInfo.CompanyName = from.CompanyName;
            suppInfo.ContactName = from.ContactName;
            suppInfo.ContactTitle = from.ContactTitle;
            suppInfo.Address = from.Address;
            suppInfo.City = from.City;
            suppInfo.Region = from.Region;
            suppInfo.PostalCode = from.PostalCode;
            suppInfo.Country = from.Country;
            suppInfo.Phone = from.Phone;
            suppInfo.Fax = from.Fax;
            suppInfo.HomePage = from.HomePage;

            return suppInfo;
        }

        public static Supplier DoToPo(SupplierDO from)
        {
            Supplier suppInfo = new Supplier();

            suppInfo.SupplierID = from.SupplierID;
            suppInfo.CompanyName = from.CompanyName;
            suppInfo.ContactName = from.ContactName;
            suppInfo.ContactTitle = from.ContactTitle;
            suppInfo.Address = from.Address;
            suppInfo.City = from.City;
            suppInfo.Region = from.Region;
            suppInfo.PostalCode = from.PostalCode;
            suppInfo.Country = from.Country;
            suppInfo.Phone = from.Phone;
            suppInfo.Fax = from.Fax;
            suppInfo.HomePage = from.HomePage;

            return suppInfo;
        }

        public static SupplierDO ReaderToSupplier(SqlDataReader from)
        {
            SupplierDO to = new SupplierDO();

            to.SupplierID = from.GetInt32(0);
            to.CompanyName = from.GetValue(1) as string;
            to.ContactName = from.GetValue(2) as string;
            to.ContactTitle = from.GetValue(3) as string;
            to.Address = from.GetValue(4) as string;
            to.City = from.GetValue(5) as string;
            to.Region = from.GetValue(6) as string;
            to.PostalCode = from.GetValue(7) as string;
            to.Country = from.GetValue(8) as string;
            to.Phone = from.GetValue(9) as string;
            to.Fax = from.GetValue(10) as string;
            to.HomePage = from.GetValue(11) as string;

            return to;
        }
    }
}
