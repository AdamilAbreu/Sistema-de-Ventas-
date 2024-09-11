using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escritorioforms;

namespace FormsUser
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ViewFo vi = new ViewFo();
            this.Hide();
            vi.ShowDialog();
            this.Show();
        }
    }
}
