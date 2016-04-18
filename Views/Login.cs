using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTI.Views;

namespace WTI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Zaloguj
            this.Hide();


            var view = new MainWindow();
            view.Closed += (s, args) => this.Close();
            view.Show();           
        }
    }
}
