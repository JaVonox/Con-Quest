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
    public partial class BuyUnit : Form
    {
        public BuyUnit()
        {
            InitializeComponent();
        }

        private void BuyUnit_Btn_Click(object sender, EventArgs e)
        {
            if (Form1.productionval >= 10)
            {
                if(Form1.Map[Form1.BlueposCell,Form1.Blueposrow].Tag == "Unit")
                {
                    //write something that tells the user that they dont have enough production to complete the action here
                }
                else
                {
                    Form1.productionval = Form1.productionval - 10;
                    if(Form1.indexsender == -1)
                    {

                    }
                    else if (Form1.indexsender == 0)
                    {
                        Form1.createunit("Unit " + Convert.ToString(Form1.Unit_Names.Count() + 1), Form1.Blueposrow, Form1.BlueposCell, 0, "Peasant", 2, 1, 1, 1, 25, 25, 0, 0, 0, "Blu", 1, 2);
                    }
                    else
                    {
                        Form1.createunit("Unit " + Convert.ToString(Form1.Unit_Names.Count() + 1), Form1.Cl_row[Form1.indexsender], Form1.Cl_cell[Form1.indexsender], 0, "Peasant", 2, 1, 1, 1, 25, 25, 0, 0, 0, "Blu", 1, 2);
                    }
                    Form1.updatevalues();
                }
            }
            else
            {
                //write something that tells the user that they dont have enough production to complete the action here
            }
        }

    }
}
