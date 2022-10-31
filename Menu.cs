using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void LogOutButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new Thread(() => Application.Run(new Auth())).Start();
        }
    }
}
