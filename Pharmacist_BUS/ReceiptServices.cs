using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacist_BUS
{
    public class ReceiptServices
    {
        private PharmacyManagementDB db = new PharmacyManagementDB();
        

        public string GenerateReceiptID()
        {
            string datePart = DateTime.Now.ToString("ddMMyy");
            //int sequenceNumber = GetNextSequenceNumberForToday();
            //string sequencePart = sequenceNumber.ToString("D3");

            //return $"{datePart}-{sequencePart}";
        }
    }
}
