using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOO_CLIENT
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // NEED TO CALL AUTHENTICATION SERVICE HERE
            Authenticate auth = new Authenticate();
            bool res = auth.LoginUser(username.Text,password.Text);

            if (res == false)
            {
                MessageBox.Show("Invalid username/password", "Response from service");
            }
            else {
                SERVICE_ORCHESTRATION service_orchestration = new SERVICE_ORCHESTRATION();
                service_orchestration.Show();
                this.Hide();
            }
        }
    }
}
