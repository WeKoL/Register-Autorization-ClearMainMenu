using Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR_Michalev
{
    public partial class WarehouseWorker : Form
    {
        public WarehouseWorker()
        {
            InitializeComponent();
        }
        public void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm autorizationForm = new AutorizationForm();
            autorizationForm.Show();
        }
    }
}
