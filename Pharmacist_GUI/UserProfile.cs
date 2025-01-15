using DevExpress.XtraEditors;
using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacistUI
{
    public partial class frm_UserProfile : DevExpress.XtraEditors.XtraForm
    {
        private readonly NHANVIEN currentEmployee;
        public frm_UserProfile(NHANVIEN employee)
        {
            InitializeComponent();
            currentEmployee = employee;
        }
    }
}