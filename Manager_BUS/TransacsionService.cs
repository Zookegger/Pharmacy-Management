using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Manager_BUS
{

    public class TransactionService
    {
        private PharmacyManagementDB context = new PharmacyManagementDB();



        public List<GIAODICH> GetTransactionList()
        {
            return context.GIAODICH.ToList();
        }
        public class NhaCungCapService
        {
            private PharmacyManagementDB context = new PharmacyManagementDB();

            public NHACUNGCAP GetSupplierById(string maNhaCungCap)
            {
                return context.NHACUNGCAP.FirstOrDefault(s => s.MaNhaCungCap == maNhaCungCap);
            }
        }

    }

}

