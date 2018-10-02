using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NORTHWNDSupplier_DAL.Models;
using System.Data.SqlClient;

namespace NORTHWNDSupplier_DAL
{
    public static class Mapper
    {
        public static SupplierDO ReaderToSupplier(SqlDataReader from)
        {
            SupplierDO to = new SupplierDO();

            to.SupplierID = from.GetInt32(0);
            to.CompanyName = from.GetValue(1) as string;
            to.ContactName = from.GetValue(2) as string;
            to.ContactTitle = from.GetValue(3 )as string;
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
