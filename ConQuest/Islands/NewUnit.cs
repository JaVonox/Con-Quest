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
            Units.ColumnCount = 9;
            Units.RowCount = 100;

            Units.Rows[98].Cells[4].Style.BackColor = Color.Yellow;
            Units.Rows[98].Cells[4].Value = "Peasant : 10P";
        }

        private void Units_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == 98)
            {
                if(e.ColumnIndex == 4)
                {
                    BuyUnit Buy = new BuyUnit();
                    Buy.Show();
                }
            }
        }
    }
}
