using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Islands
{
    public partial class NewUnit : Form
    {
        public NewUnit()
        {
            InitializeComponent();
        }

        private void NewUnit_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 100; i++)
            {
                Units.Rows.Insert(i, DataGridViewRow);
            }
        }
    }
}
