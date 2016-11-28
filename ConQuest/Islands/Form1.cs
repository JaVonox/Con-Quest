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


using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

public partial class Form1 : Form //add partial?
{
	//the horizontal position of the map
	int mapsizehor = 100;
	//the vertical position of the map
	int mapsizever = 100;
    int landtiles = 0;
    int oceeantiles = 0;
	string maptype = "4islands";

    int Blueposrow = 0;
    int BlueposCell = 0;
    int reload = 1;
    //global images
    Icon Village_Unclaimed = Properties.Resources.Village_Unclaimed;
	Random randomizar = new Random();
    DataGridViewImageColumn imageCol0 = new DataGridViewImageColumn();

    bool movemode = false;

    //RAM values
    //Unit Assignment
    List<string> Unit_Names = new List<string>();
    List<int> Unit_Row = new List<int>();
    List<int> Unit_Cell = new List<int>();
    List<int> Unit_Lvl = new List<int>();
    List<int> Unit_inf = new List<int>();
    List<string> Unit_Class = new List<string>();
    List<string> Unit_aff = new List<string>();
    int unitnum = 0;
    //Unit Permenant values
    List<int> Unit_Att = new List<int>();
    List<int> Unit_Def = new List<int>();
    List<int> UNit_Crit = new List<int>();
    List<int> Unit_Dodge = new List<int>();
    //Unit Bonus values
    List<int> Unit_Att_B = new List<int>();
    List<int> Unit_Def_B = new List<int>();
    List<int> UNit_Crit_B = new List<int>();
    List<int> Unit_Dodge_B = new List<int>();
    //Unit Equipment
    List<int> Unit_Weapon = new List<int>();
    List<int> Unit_Armor = new List<int>();
    List<int> Unit_Soul = new List<int>();
    //Unit stats
    List<int> Unit_Health = new List<int>();
    List<int> Unit_MaxHealth = new List<int>();
    List<int> Unit_Movesleft = new List<int>(); //max is 2

    int movesleftplayer = 10;
    int movesleftplayertotal = 10;
    int productionval = 0;
    int gold = 0;
    public Form1()
   { 
        InitializeComponent();

    }

	private void Form1_Load(object sender, EventArgs e)
	{

        for (int i = 0; i <= mapsizehor; i++)
        {
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            Map.Columns.Insert(i, imageCol);
        }
            //Map.ColumnCount = mapsizehor;
		Map.RowCount = mapsizever;

		for (int i = 0; i <= Map.Rows.Count - 1; i++) {
			DataGridViewRow r = Map.Rows[i];
			r.Height = 25;
		}

		for (int i = 0; i <= Map.Columns.Count - 1; i++) {
			DataGridViewColumn c = Map.Columns[i];
			c.Width = 25;
		}

		for (int i = 0; i <= Map.Rows.Count - 1; i++) {
			for (int ColNo = 0; ColNo <= Map.ColumnCount - 1; ColNo++) {

				if ((!object.ReferenceEquals(Map.Rows[i].Cells[ColNo].Value, DBNull.Value))) {
					Map.Rows[i].Cells[ColNo].Style.BackColor = Color.Blue;
				}
			}
		}
        
        //this will do the map generation

        generatemap(10);
        generatemap(100);
        generatemap(1000);
        generatemap(10000);
        generatemap(100000);
        //generatemap(1000000);
        //generatemap(10000000);
        layer2();

        if (reload == 1)
        {
        minimap();
        layer3();
        loadgame();
        this.Map.CurrentCell = this.Map[BlueposCell, Blueposrow];
        }
        else
        {
            reload = 1;
        }
	}

    public void minimap()
    {
        //generate minimap here
        InUse_lbl.RowCount = Map.RowCount;
        InUse_lbl.ColumnCount = Map.ColumnCount;

        for (int i = 0; i <= InUse_lbl.Rows.Count - 1; i++) {
            DataGridViewRow r = InUse_lbl.Rows[i];
            r.Height = 1;
        }

        for (int i = 0; i <= InUse_lbl.Columns.Count - 1; i++) {
            DataGridViewColumn c = InUse_lbl.Columns[i];
            c.Width = 1;
        }

        for (int colcount = 1; colcount <= mapsizever; colcount++) {
            for (int rocount = 1; rocount <= mapsizehor; rocount++) {
                //bug here
                InUse_lbl.Rows[rocount - 1].Cells[colcount - 1].Style.BackColor = Map.Rows[rocount - 1].Cells[colcount - 1].Style.BackColor;
            }
        }


    }


    public void generatemap(int msize)
	{
		//snake method of generation
		//Me.Map.CurrentCell = Me.Map(y1, x1)

		int i1x = 0;
		int i1y = 0;
		List<int> snkx = new List<int>();
		List<int> snky = new List<int>();
		List<int> allx = new List<int>();
		List<int> ally = new List<int>();

		i1x = randomizar.Next(10, mapsizehor - 9);
		i1y = randomizar.Next(10, mapsizever - 9);

		snkx.Insert(0, i1x);
		snky.Insert(0, i1y);

		Map.Rows[snkx[0]].Cells[snky[0]].Style.BackColor = Color.DarkGreen;

		//10 is tiny island
        //100 is small island
        //1000 is large island
        //10000 is continent
        //100000 is large continent
        //1000000 is Mega-Continent
        //10000000 is Planetary Land Bridge

		//results may vary. alot.

        int i = Convert.ToInt32(msize);
		int rand = 0;
		dynamic count = 1;
		int lastrand = 0;

		//     rand 2
		//rand 1    rand 3
		//     rand 4


		try {
			while (i > 0) {
				rand = randomizar.Next(1, 5);
				if (rand == 1) {
					if (lastrand == 1) {
						i = i + 1;
					} else {
						snkx.Insert(count, snkx[count - 1] - 1);
						snky.Insert(count, snky[count - 1]);
						lastrand = rand;
						Map.Rows[snkx[count]].Cells[snky[count]].Style.BackColor = Color.Green;
						count = count + 1;
					}
				} else if (rand == 2) {
					if (lastrand == 2) {
						i = i + 1;
					} else {
						snky.Insert(count, snky[count - 1] + 1);
						snkx.Insert(count, snkx[count - 1]);
						lastrand = rand;
						Map.Rows[snkx[count]].Cells[snky[count]].Style.BackColor = Color.Green;
						count = count + 1;
					}
				} else if (rand == 3) {
					if (lastrand == 3) {
						i = i + 1;
					} else {
						snkx.Insert(count, snkx[count - 1] + 1);
						snky.Insert(count, snky[count - 1]);
						lastrand = rand;
						Map.Rows[snkx[count]].Cells[snky[count]].Style.BackColor = Color.Green;
						count = count + 1;
					}
				} else if (rand == 4) {
					if (lastrand == 4) {
						i = i + 1;
					} else {
						snky.Insert(count, snky[count - 1] - 1);
						snkx.Insert(count, snkx[count - 1]);
						lastrand = rand;
						Map.Rows[snkx[count]].Cells[snky[count]].Style.BackColor = Color.Green;
						count = count + 1;
					}
				}
				i = i - 1;
			}

		} catch (Exception ex) {
			goto Exitry1; // TODO: might not be correct. Was : Exit Try
		}

        Exitry1:

		//add 3/2 blocks in all directions

		int b = snkx.Count() - 1;
		int lm = 0;

		while (b > 0) {
			allx.Insert(lm, snkx[b]);
			ally.Insert(lm, snky[b]);
			b = b - 1;
			lm = lm + 1;
		}

		dynamic m = 0;


		try {
			while (snkx.Count() != m) {
				allx.Insert(allx.Count, snkx[m] + 1);
				Map.Rows[allx[allx.Count() - 1]].Cells[ally[ally.Count() - 1]].Style.BackColor = Color.Green;
				allx.Insert(allx.Count, snkx[m] + 2);
				Map.Rows[allx[allx.Count() - 1]].Cells[ally[ally.Count() - 1]].Style.BackColor = Color.Green;
				allx.Insert(allx.Count, snkx[m] + 3);
				Map.Rows[allx[allx.Count() - 1]].Cells[ally[ally.Count() - 1]].Style.BackColor = Color.Green;
				allx.Insert(allx.Count, snkx[m] - 1);
				Map.Rows[allx[allx.Count() - 1]].Cells[ally[ally.Count() - 1]].Style.BackColor = Color.Green;
				allx.Insert(allx.Count, snkx[m] - 2);
				Map.Rows[allx[allx.Count() - 1]].Cells[ally[ally.Count() - 1]].Style.BackColor = Color.Green;
				allx.Insert(allx.Count, snkx[m] - 3);
				Map.Rows[allx[allx.Count() - 1]].Cells[ally[ally.Count() - 1]].Style.BackColor = Color.Green;
				ally.Insert(ally.Count, snky[m] + 1);
				Map.Rows[ally[ally.Count() - 1]].Cells[allx[allx.Count() - 1]].Style.BackColor = Color.Green;
				ally.Insert(ally.Count, snky[m] + 2);
				Map.Rows[ally[ally.Count() - 1]].Cells[allx[allx.Count() - 1]].Style.BackColor = Color.Green;
				ally.Insert(ally.Count, snky[m] + 3);
				Map.Rows[ally[ally.Count() - 1]].Cells[allx[allx.Count() - 1]].Style.BackColor = Color.Green;
				ally.Insert(ally.Count, snky[m] - 1);
				Map.Rows[ally[ally.Count() - 1]].Cells[allx[allx.Count() - 1]].Style.BackColor = Color.Green;
				ally.Insert(ally.Count, snky[m] - 2);
				Map.Rows[ally[ally.Count() - 1]].Cells[allx[allx.Count() - 1]].Style.BackColor = Color.Green;
				ally.Insert(ally.Count, snky[m] - 3);
				Map.Rows[ally[ally.Count() - 1]].Cells[allx[allx.Count() - 1]].Style.BackColor = Color.Green;

				m = m + 1;
			}

		} catch (Exception ex) {
			goto Exitry2; // TODO: might not be correct. Was : Exit Try
		}

        Exitry2:

		this.Map.CurrentCell = this.Map[i1y, i1x];
	}

    public void layer3()
    {
        foreach (DataGridViewRow row in Map.Rows)
        {
            foreach(DataGridViewCell cell in row.Cells)

            {
                if (cell.Style.BackColor == Color.Green)
                {
                    cell.Value = Properties.Resources.Green;
                }
                else if (cell.Style.BackColor == Color.Blue)
                {
                    cell.Value = Properties.Resources.Blue;
                }
                else if (cell.Style.BackColor == Color.Peru)
                {
                    cell.Value = Properties.Resources.Village_Unclaimed1;
                }
                else if (cell.Style.BackColor == Color.SaddleBrown)
                {
                    cell.Value = Properties.Resources.Horse_Unclaimed;
                }
                else if (cell.Style.BackColor == Color.Purple)
                {
                    cell.Value = Properties.Resources.MythHorse_Unclaimed;
                }
                else if (cell.Style.BackColor == Color.IndianRed)
                {
                    cell.Value = Properties.Resources.Dragonstone_Unclaimed;
                }
                else if (cell.Style.BackColor == Color.Gold)
                {
                    cell.Value = Properties.Resources.Gold_Unclaimed;
                }
                else if (cell.Style.BackColor == Color.Red)
                {
                    cell.Value = Properties.Resources.Castle_Red;
                }
                else if (cell.Style.BackColor == Color.ForestGreen)
                {
                    cell.Value = Properties.Resources.Castle_Green;
                }
                else if (cell.Style.BackColor == Color.LightBlue)
                {
                    cell.Value = Properties.Resources.Castle_Blue;
                }
                else if (cell.Style.BackColor == Color.Gray)
                {
                    cell.Value = Properties.Resources.Mountain;
                }
            }
        }
    }
    public void layer2()
    {
        foreach(DataGridViewRow row in Map.Rows)
        {
           foreach(DataGridViewCell cell in row.Cells)
           {
               if (cell.Style.BackColor == Color.Green)
               {
                   landtiles += 1;
               }
               else
               {
                   oceeantiles += 1;
               }
           }
        }


        if (landtiles > (mapsizehor * mapsizever) * 0.4)
        {
            // small islands

            int rando1 = randomizar.Next(7, Convert.ToInt16(oceeantiles / 300)); //bug can occur here if oceantiles goes too low

            for (int i = 0; i <= rando1; i++)
            {
                Map.Rows[randomizar.Next(1, mapsizever)].Cells[randomizar.Next(1, mapsizehor)].Style.BackColor = Color.Green;
            }

            // generate villages
            int rando2 = randomizar.Next(70, 90);

            for (int i = 0; i <= rando2; i++)
            {
                int rand1;
                int rand2;

                rand1 = randomizar.Next(1, mapsizehor);
                rand2 = randomizar.Next(1, mapsizever);

                if (Map.Rows[rand2].Cells[rand1].Style.BackColor.Equals(Color.Green))
                {
                    Map.Rows[rand2].Cells[rand1].Style.BackColor = Color.Peru;
                }
                else
                {
                    i = i - 1;
                }
            }

            //generate horses
            int rando3 = randomizar.Next(10, 30);

            for (int i = 0; i <= rando3; i++)
            {
                int rand1;
                int rand2;

                rand1 = randomizar.Next(1, mapsizehor);
                rand2 = randomizar.Next(1, mapsizever);

                if (Map.Rows[rand2].Cells[rand1].Style.BackColor.Equals(Color.Green))
                {
                    Map.Rows[rand2].Cells[rand1].Style.BackColor = Color.SaddleBrown;
                }
                else
                {
                    i = i - 1;
                }
            }
            
            //generate mythicals
            int rando5 = randomizar.Next(1, 2);

            for (int i = 0; i <= rando5; i++)
            {
                int rand1;
                int rand2;

                rand1 = randomizar.Next(1, mapsizehor);
                rand2 = randomizar.Next(1, mapsizever);

                if (Map.Rows[rand2].Cells[rand1].Style.BackColor.Equals(Color.Green))
                {
                    Map.Rows[rand2].Cells[rand1].Style.BackColor = Color.Purple;
                }
                else
                {
                    i = i - 1;
                }
            }

            //generate dragonstone

            for (int i = 0; i <= 0; i++)
            {
                int rand1;
                int rand2;

                rand1 = randomizar.Next(1, mapsizehor);
                rand2 = randomizar.Next(1, mapsizever);

                if (Map.Rows[rand2].Cells[rand1].Style.BackColor.Equals(Color.Green))
                {
                    Map.Rows[rand2].Cells[rand1].Style.BackColor = Color.IndianRed;
                }
                else
                {
                    i = i - 1;
                }
            }

            //generate native gold
            for (int i = 0; i <= 1; i++)
            {
                int rand1;
                int rand2;

                rand1 = randomizar.Next(1, mapsizehor);
                rand2 = randomizar.Next(1, mapsizever);

                if (Map.Rows[rand2].Cells[rand1].Style.BackColor.Equals(Color.Green))
                {
                    Map.Rows[rand2].Cells[rand1].Style.BackColor = Color.Gold;
                }
                else
                {
                    i = i - 1;
                }
            }

            //red base
            for (int i = 0; i == 0; i++)
            {
                int rand1;
                int rand2;

                rand1 = randomizar.Next(1, mapsizehor);
                rand2 = randomizar.Next(1, mapsizever);

                if (Map.Rows[rand2].Cells[rand1].Style.BackColor.Equals(Color.Green))
                {
                    Map.Rows[rand2].Cells[rand1].Style.BackColor = Color.Red;
                }
                else
                {
                    i = i - 1;
                }
            }

            //blue base
            for (int i = 0; i == 0; i++)
            {
                int rand1;
                int rand2;

                rand1 = randomizar.Next(1, mapsizehor);
                rand2 = randomizar.Next(1, mapsizever);

                if (Map.Rows[rand2].Cells[rand1].Style.BackColor.Equals(Color.Green))
                {
                    Map.Rows[rand2].Cells[rand1].Style.BackColor = Color.LightBlue;
                    Blueposrow = rand2;
                    BlueposCell = rand1;
                }
                else
                {
                    i = i - 1;
                }
            }

            //green base
            for (int i = 0; i == 0; i++)
            {
                int rand1;
                int rand2;

                rand1 = randomizar.Next(1, mapsizehor);
                rand2 = randomizar.Next(1, mapsizever);

                if (Map.Rows[rand2].Cells[rand1].Style.BackColor.Equals(Color.Green))
                {
                    Map.Rows[rand2].Cells[rand1].Style.BackColor = Color.ForestGreen;
                }
                else
                {
                    i = i - 1;
                }
            }

            //generate mountains
            int rando4 = randomizar.Next(30, 60);

            for (int i = 0; i <= rando4; i++)
            {
                int rand1;
                int rand2;

                rand1 = randomizar.Next(1, mapsizehor);
                rand2 = randomizar.Next(1, mapsizever);

                if (Map.Rows[rand2].Cells[rand1].Style.BackColor.Equals(Color.Green))
                {
                    Map.Rows[rand2].Cells[rand1].Style.BackColor = Color.Gray;
                }
                else
                {
                    i = i - 1;
                }
            }
        }
        else
        {
            Map.Rows.Clear();
            Map.Columns.Clear();
            landtiles = 0;
            oceeantiles = 0;
            reload = 0;
            Form1_Load("MAP", new System.EventArgs()); //this reloads form1 so it can be regenerated
        }
    }

    public void applyimage(int row,int cell)
    {
        try
        {
            if (Map.Rows[row].Cells[cell].Tag == "Unit")
            {

            }
            else
            {
                if (Map.Rows[row].Cells[cell].Style.BackColor == Color.Green)
                {
                    Map.Rows[row].Cells[cell].Value = Properties.Resources.Green;
                }
                else if (Map.Rows[row].Cells[cell].Style.BackColor == Color.Blue)
                {
                    Map.Rows[row].Cells[cell].Value = Properties.Resources.Blue;
                }
                else if (Map.Rows[row].Cells[cell].Style.BackColor == Color.Peru)
                {
                    Map.Rows[row].Cells[cell].Value = Properties.Resources.Village_Unclaimed1;
                }
                else if (Map.Rows[row].Cells[cell].Style.BackColor == Color.SaddleBrown)
                {
                    Map.Rows[row].Cells[cell].Value = Properties.Resources.Horse_Unclaimed;
                }
                else if (Map.Rows[row].Cells[cell].Style.BackColor == Color.Purple)
                {
                    Map.Rows[row].Cells[cell].Value = Properties.Resources.MythHorse_Unclaimed;
                }
                else if (Map.Rows[row].Cells[cell].Style.BackColor == Color.IndianRed)
                {
                    Map.Rows[row].Cells[cell].Value = Properties.Resources.Dragonstone_Unclaimed;
                }
                else if (Map.Rows[row].Cells[cell].Style.BackColor == Color.Gold)
                {
                    Map.Rows[row].Cells[cell].Value = Properties.Resources.Gold_Unclaimed;
                }
                else if (Map.Rows[row].Cells[cell].Style.BackColor == Color.Red)
                {
                    Map.Rows[row].Cells[cell].Value = Properties.Resources.Castle_Red;
                }
                else if (Map.Rows[row].Cells[cell].Style.BackColor == Color.ForestGreen)
                {
                    Map.Rows[row].Cells[cell].Value = Properties.Resources.Castle_Green;
                }
                else if (Map.Rows[row].Cells[cell].Style.BackColor == Color.LightBlue)
                {
                    Map.Rows[row].Cells[cell].Value = Properties.Resources.Castle_Blue;
                }
                else if (Map.Rows[row].Cells[cell].Style.BackColor == Color.Gray)
                {
                    Map.Rows[row].Cells[cell].Value = Properties.Resources.Mountain;
                }
                Map.Rows[row].Cells[cell].Tag = null;
            }
        }
    catch
{
 goto imnotokay;
}
    imnotokay:
        Console.WriteLine("this is bad form.");
    }

    private void MinMap_SelectionChanged(object sender, EventArgs e)
    {
        InUse_lbl.ClearSelection();
    }

    private void THEALLSEEINGEYE_Click(object sender, EventArgs e)
    {
        if(InUse_lbl.Visible == false)
        {
            InUse_lbl.Visible = true;
        }
        else
        {
            InUse_lbl.Visible = false;
        }
    }

    public void loadgame()
    {

        Map.Rows[Blueposrow].Cells[BlueposCell + 1].Value = Properties.Resources.TestSprite;
        Map.Rows[Blueposrow].Cells[BlueposCell + 1].Tag = "Unit";

        Unit_Names.Insert(Unit_Names.Count, "Unit 1");

        Unit_Row.Insert(Unit_Row.Count, Blueposrow);
        Unit_Cell.Insert(Unit_Cell.Count, BlueposCell + 1);
        Unit_Lvl.Insert(Unit_Lvl.Count, 0);
        Unit_Class.Insert(Unit_Class.Count, "Peasant");
        Unit_Att.Insert(Unit_Att.Count, 2);
        Unit_Def.Insert(Unit_Def.Count, 0);
        UNit_Crit.Insert(UNit_Crit.Count, 1);
        Unit_Dodge.Insert(Unit_Dodge.Count, 0);
        Unit_MaxHealth.Insert(Unit_MaxHealth.Count, 25);
        Unit_Health.Insert(Unit_Health.Count, 25);
        Unit_Weapon.Insert(Unit_Weapon.Count, 0);
        Unit_Armor.Insert(Unit_Armor.Count, 0);
        Unit_Soul.Insert(Unit_Soul.Count, 0);
        Unit_aff.Insert(Unit_aff.Count, "Blu");
        Unit_inf.Insert(Unit_inf.Count, 1);
        Unit_Movesleft.Insert(Unit_Movesleft.Count, 2);

        Map.Rows[Blueposrow].Cells[BlueposCell - 1].Value = Properties.Resources.TestSprite;
        Map.Rows[Blueposrow].Cells[BlueposCell - 1].Tag = "Unit";

        Unit_Names.Insert(Unit_Names.Count, "Unit 2");
        Unit_Row.Insert(Unit_Row.Count, Blueposrow);
        Unit_Cell.Insert(Unit_Cell.Count, BlueposCell - 1);
        Unit_Lvl.Insert(Unit_Lvl.Count, 0);
        Unit_Class.Insert(Unit_Class.Count, "Peasant");
        Unit_Att.Insert(Unit_Att.Count, 2);
        Unit_Def.Insert(Unit_Def.Count, 0);
        UNit_Crit.Insert(UNit_Crit.Count, 1);
        Unit_Dodge.Insert(Unit_Dodge.Count, 0);
        Unit_MaxHealth.Insert(Unit_MaxHealth.Count, 25);
        Unit_Health.Insert(Unit_Health.Count, 25);
        Unit_Weapon.Insert(Unit_Weapon.Count, 0);
        Unit_Armor.Insert(Unit_Armor.Count, 0);
        Unit_Soul.Insert(Unit_Soul.Count, 0);
        Unit_aff.Insert(Unit_aff.Count, "Blu");
        Unit_inf.Insert(Unit_inf.Count, 1);
        Unit_Movesleft.Insert(Unit_Movesleft.Count, 2);

        Gold_lbl.Text = Convert.ToString(gold);
        Movesleft.Text = movesleftplayer + "/" + movesleftplayertotal;
        production.Text = Convert.ToString(productionval);

    }
     
    private void Map_CellClick(object sender, DataGridViewCellEventArgs e)
    {

        if (Map.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.LightBlue)
        {
            InUse.Visible = true;
            InUse.Text = "Castle";
            Shop_btn.Visible = true;
            Shop_btn.Enabled = false;
            Armory_Btn.Visible = true;
            Armory_Btn.Enabled = true;
        }

        if (movemode == true)
        {

            if(Map.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag == "Gh")
            {
                if (Unit_Movesleft[unitnum] > 0 && movesleftplayer > 0)
                {
                    // A LOT OF BUGS HERE
                    // So for some reason, when you move a unit then switch units, you cant reuse the first unit
                    //the unit generator is duplicating units for some reason

                    Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum]].Tag = null;

                    applyimage(Unit_Row[unitnum], Unit_Cell[unitnum]);
                    applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] + 1);
                    applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] + 2);
                    applyimage(Unit_Row[unitnum] - 1, Unit_Cell[unitnum]);
                    applyimage(Unit_Row[unitnum] + 1, Unit_Cell[unitnum] + 1);
                    applyimage(Unit_Row[unitnum] - 1, Unit_Cell[unitnum] + 1);
                    applyimage(Unit_Row[unitnum] - 1, Unit_Cell[unitnum] - 1);
                    applyimage(Unit_Row[unitnum] + 1, Unit_Cell[unitnum]);
                    applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] - 1);
                    applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] - 2);
                    applyimage(Unit_Row[unitnum] + 1, Unit_Cell[unitnum] - 1);
                    applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] - 1);
                    applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] - 2);
                    applyimage(Unit_Row[unitnum] - 1, Unit_Cell[unitnum]);
                    applyimage(Unit_Row[unitnum] + 2, Unit_Cell[unitnum]);
                    applyimage(Unit_Row[unitnum] - 2, Unit_Cell[unitnum]);

                    Map.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = "Unit";
                    Map.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.TestSprite;


                    Unit_Row.RemoveAt(unitnum);
                    Unit_Row.Insert(unitnum, e.RowIndex);

                    Unit_Cell.RemoveAt(unitnum);
                    Unit_Cell.Insert(unitnum, e.ColumnIndex);

                    int temp = Unit_Movesleft[unitnum] - 1;

                    Unit_Movesleft.RemoveAt(unitnum);
                    Unit_Movesleft.Insert(unitnum, temp);

                    movesleftplayer = movesleftplayer - 1;

                    Movesleft.Text = movesleftplayer + "/" + movesleftplayertotal;

                    SUnit_MovesLeft.Text = Convert.ToString(Unit_Movesleft[unitnum]);

                    movemode = false;
                }
                else
                {
                    applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] + 1);
                    applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] + 2);
                    applyimage(Unit_Row[unitnum] - 1, Unit_Cell[unitnum]);
                    applyimage(Unit_Row[unitnum] + 1, Unit_Cell[unitnum] + 1);
                    applyimage(Unit_Row[unitnum] - 1, Unit_Cell[unitnum] + 1);
                    applyimage(Unit_Row[unitnum] - 1, Unit_Cell[unitnum] - 1);
                    applyimage(Unit_Row[unitnum] + 1, Unit_Cell[unitnum]);
                    applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] - 1);
                    applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] - 2);
                    applyimage(Unit_Row[unitnum] + 1, Unit_Cell[unitnum] - 1);
                    applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] - 1);
                    applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] - 2);
                    applyimage(Unit_Row[unitnum] - 1, Unit_Cell[unitnum]);
                    applyimage(Unit_Row[unitnum] + 2, Unit_Cell[unitnum]);
                    applyimage(Unit_Row[unitnum] - 2, Unit_Cell[unitnum]);

                    movemode = false;
                }
            }
            else
            {
                applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] + 1);
                applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] + 2);
                applyimage(Unit_Row[unitnum] - 1, Unit_Cell[unitnum]);
                applyimage(Unit_Row[unitnum] + 1, Unit_Cell[unitnum] + 1);
                applyimage(Unit_Row[unitnum] - 1, Unit_Cell[unitnum] + 1);
                applyimage(Unit_Row[unitnum] - 1, Unit_Cell[unitnum] - 1);
                applyimage(Unit_Row[unitnum] + 1, Unit_Cell[unitnum]);
                applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] - 1);
                applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] - 2);
                applyimage(Unit_Row[unitnum] + 1, Unit_Cell[unitnum] - 1);
                applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] - 1);
                applyimage(Unit_Row[unitnum], Unit_Cell[unitnum] - 2);
                applyimage(Unit_Row[unitnum] - 1, Unit_Cell[unitnum]);
                applyimage(Unit_Row[unitnum] + 2, Unit_Cell[unitnum]);
                applyimage(Unit_Row[unitnum] - 2, Unit_Cell[unitnum]);

                movemode = false;
            }
        }
        else
        {

            for (int Unit = 0; Unit < Unit_Names.Count(); Unit++)
            {
                if (Unit_Row[Unit] == e.RowIndex)
                {
                    if (Unit_Cell[Unit] == e.ColumnIndex)
                    {
                        refreshlbl(Unit);
                    }
                }
            }
        }

    }

    public void refreshlbl(int Unit)
    {
        unitnum = Unit;
        SUnit_Name.Text = Unit_Names[Unit];
        SUnit_Level.Text = Convert.ToString(Unit_Lvl[Unit]);
        SUnit_Health.Maximum = Unit_MaxHealth[Unit];
        SUnit_Health.Value = Unit_Health[Unit];
        SUnit_Class.Text = Unit_Class[Unit];
        SUnit_AttackDmg.Text = Convert.ToString(Unit_Att[Unit]);
        SUnit_Def.Text = Convert.ToString(Unit_Def[Unit]);
        SUnit_Crit.Text = Convert.ToString(UNit_Crit[Unit]);
        SUnit_Dodge.Text = Convert.ToString(Unit_Dodge[Unit]);
        SUnit_aff.Text = Unit_aff[Unit];
        SUnit_Inf.Text = Convert.ToString(Unit_inf[Unit]);
        SUnit_MovesLeft.Text = Convert.ToString(Unit_Movesleft[Unit]);

        Gold_lbl.Text = Convert.ToString(gold);
        Movesleft.Text = movesleftplayer + "/" + movesleftplayertotal;
        production.Text = Convert.ToString(productionval);

        InUse.Visible = false;
        InUse.Text = "null";
        Shop_btn.Visible = false;
        Shop_btn.Enabled = false;
        Armory_Btn.Visible = false;
        Armory_Btn.Enabled = false;

    }

        public void Displaymove()
        {
            try
            {
                if (Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] + 1].Tag == "Unit" || Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] + 1].Style.BackColor == Color.Gray || Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] + 1].Style.BackColor == Color.Blue)
                {

                }
                else
                {
                    Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] + 1].Value = Properties.Resources.GoHere;
                    Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] + 1].Tag = "Gh";
                }
            }
            catch
            {
                goto cheatsy1;
            }

        cheatsy1:

            try
            {
                if (Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] + 2].Tag == "Unit" || Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] + 2].Style.BackColor == Color.Gray || Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] + 2].Style.BackColor == Color.Blue)
                {

                }
                else
                {
                    Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] + 2].Value = Properties.Resources.GoHere;
                    Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] + 2].Tag = "Gh";
                }
            }
            catch
            {
                goto cheatsy2;
            }

        cheatsy2:

            try
            {

                if (Map.Rows[Unit_Row[unitnum] - 1].Cells[Unit_Cell[unitnum]].Tag == "Unit" || Map.Rows[Unit_Row[unitnum] - 1].Cells[Unit_Cell[unitnum]].Style.BackColor == Color.Gray || Map.Rows[Unit_Row[unitnum] - 1].Cells[Unit_Cell[unitnum]].Style.BackColor == Color.Blue)
                {

                }
                else
                {
                    Map.Rows[Unit_Row[unitnum] - 1].Cells[Unit_Cell[unitnum]].Value = Properties.Resources.GoHere;
                    Map.Rows[Unit_Row[unitnum] - 1].Cells[Unit_Cell[unitnum]].Tag = "Gh";
                }
            }
            catch
            {
                goto cheatsy3;
            }

        cheatsy3:

            try
            {
                if (Map.Rows[Unit_Row[unitnum] + 1].Cells[Unit_Cell[unitnum] + 1].Tag == "Unit" || Map.Rows[Unit_Row[unitnum] + 1].Cells[Unit_Cell[unitnum] + 1].Style.BackColor == Color.Gray || Map.Rows[Unit_Row[unitnum] + 1].Cells[Unit_Cell[unitnum] + 1].Style.BackColor == Color.Blue)
                {

                }
                else
                {
                    Map.Rows[Unit_Row[unitnum] + 1].Cells[Unit_Cell[unitnum] + 1].Value = Properties.Resources.GoHere;
                    Map.Rows[Unit_Row[unitnum] + 1].Cells[Unit_Cell[unitnum] + 1].Tag = "Gh";
                }
            }
            catch
            {
                goto cheatsy4;
            }

        cheatsy4:

            try
            {

                if (Map.Rows[Unit_Row[unitnum] - 1].Cells[Unit_Cell[unitnum] + 1].Tag == "Unit" || Map.Rows[Unit_Row[unitnum] - 1].Cells[Unit_Cell[unitnum] + 1].Style.BackColor == Color.Gray || Map.Rows[Unit_Row[unitnum] - 1].Cells[Unit_Cell[unitnum] + 1].Style.BackColor == Color.Blue)
                {

                }
                else
                {
                    Map.Rows[Unit_Row[unitnum] - 1].Cells[Unit_Cell[unitnum] + 1].Value = Properties.Resources.GoHere;
                    Map.Rows[Unit_Row[unitnum] - 1].Cells[Unit_Cell[unitnum] + 1].Tag = "Gh";

                }
            }
            catch
            {
                goto cheatsy5;
            }

        cheatsy5:

            try
            {

                if (Map.Rows[Unit_Row[unitnum] + 1].Cells[Unit_Cell[unitnum]].Tag == "Unit" || Map.Rows[Unit_Row[unitnum] + 1].Cells[Unit_Cell[unitnum]].Style.BackColor == Color.Gray || Map.Rows[Unit_Row[unitnum] + 1].Cells[Unit_Cell[unitnum]].Style.BackColor == Color.Blue)
                {

                }
                else
                {
                    Map.Rows[Unit_Row[unitnum] + 1].Cells[Unit_Cell[unitnum]].Value = Properties.Resources.GoHere;
                    Map.Rows[Unit_Row[unitnum] + 1].Cells[Unit_Cell[unitnum]].Tag = "Gh";
                }
            }
            catch
            {
                goto cheatsy6;
            }

        cheatsy6:

            try
            {

                if (Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] - 1].Tag == "Unit" || Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] - 1].Style.BackColor == Color.Gray || Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] - 1].Style.BackColor == Color.Blue)
                {

                }
                else
                {
                    Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] - 1].Value = Properties.Resources.GoHere;
                    Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] - 1].Tag = "Gh";
                }
            }
            catch
            {
                goto cheatsy7;
            }

        cheatsy7:

            try
            {

                if (Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] - 2].Tag == "Unit" || Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] - 2].Style.BackColor == Color.Gray || Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] - 2].Style.BackColor == Color.Blue)
                {

                }
                else
                {
                    Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] - 2].Value = Properties.Resources.GoHere;
                    Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] - 2].Tag = "Gh";
                }
            }
            catch
            {
                goto cheatsy8;
            }

        cheatsy8:

            try
            {

                if (Map.Rows[Unit_Row[unitnum] + 1].Cells[Unit_Cell[unitnum] - 1].Tag == "Unit" || Map.Rows[Unit_Row[unitnum] + 1].Cells[Unit_Cell[unitnum] - 1].Style.BackColor == Color.Gray || Map.Rows[Unit_Row[unitnum] + 1].Cells[Unit_Cell[unitnum] - 1].Style.BackColor == Color.Blue)
                {

                }
                else
                {
                    Map.Rows[Unit_Row[unitnum] + 1].Cells[Unit_Cell[unitnum] - 1].Value = Properties.Resources.GoHere;
                    Map.Rows[Unit_Row[unitnum] + 1].Cells[Unit_Cell[unitnum] - 1].Tag = "Gh";
                }
            }
            catch
            {
                goto cheatsy9;
            }

        cheatsy9:

            try
            {
                if (Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] - 1].Tag == "Unit" || Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] - 1].Style.BackColor == Color.Gray || Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] - 1].Style.BackColor == Color.Blue)
                {

                }
                else
                {
                    Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] - 1].Value = Properties.Resources.GoHere;
                    Map.Rows[Unit_Row[unitnum]].Cells[Unit_Cell[unitnum] - 1].Tag = "Gh";
                }
            }
            catch
            {
                goto cheatsy10;
            }

        cheatsy10:

            try
            {

                if (Map.Rows[Unit_Row[unitnum] - 1].Cells[Unit_Cell[unitnum] - 1].Tag == "Unit" || Map.Rows[Unit_Row[unitnum] - 1].Cells[Unit_Cell[unitnum] - 1].Style.BackColor == Color.Gray || Map.Rows[Unit_Row[unitnum] - 1].Cells[Unit_Cell[unitnum] - 1].Style.BackColor == Color.Blue)
                {

                }
                else
                {
                    Map.Rows[Unit_Row[unitnum] - 1].Cells[Unit_Cell[unitnum] - 1].Value = Properties.Resources.GoHere;
                    Map.Rows[Unit_Row[unitnum] - 1].Cells[Unit_Cell[unitnum] - 1].Tag = "Gh";
                }
            }
            catch
            {
                goto cheatsy11;
            }

        cheatsy11:

            try
            {

                if (Map.Rows[Unit_Row[unitnum] + 2].Cells[Unit_Cell[unitnum]].Tag == "Unit" || Map.Rows[Unit_Row[unitnum] + 2].Cells[Unit_Cell[unitnum]].Style.BackColor == Color.Gray || Map.Rows[Unit_Row[unitnum] + 2].Cells[Unit_Cell[unitnum]].Style.BackColor == Color.Blue)
                {

                }
                else
                {
                    Map.Rows[Unit_Row[unitnum] + 2].Cells[Unit_Cell[unitnum]].Value = Properties.Resources.GoHere;
                    Map.Rows[Unit_Row[unitnum] + 2].Cells[Unit_Cell[unitnum]].Tag = "Gh";
                }
            }
            catch
            {
                goto cheatsy12;
            }

        cheatsy12:

            try
            {

                if (Map.Rows[Unit_Row[unitnum] - 2].Cells[Unit_Cell[unitnum]].Tag == "Unit" || Map.Rows[Unit_Row[unitnum] - 2].Cells[Unit_Cell[unitnum]].Style.BackColor == Color.Gray || Map.Rows[Unit_Row[unitnum] - 2].Cells[Unit_Cell[unitnum]].Style.BackColor == Color.Blue)
                {

                }
                else
                {
                    Map.Rows[Unit_Row[unitnum] - 2].Cells[Unit_Cell[unitnum]].Value = Properties.Resources.GoHere;
                    Map.Rows[Unit_Row[unitnum] - 2].Cells[Unit_Cell[unitnum]].Tag = "Gh";
                }
            }
            catch
            {
                goto cheatsy13;
            }

        cheatsy13:

            Console.WriteLine("cheatsy13 is reporting an error here because there isnt any code to goto, but im lazy and its late so im just doing this instead");
        }

        private void SUnit_Move_Click(object sender, EventArgs e)
    {
        Displaymove();

        movemode = true;
    }

    private void Map_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
    {
        Debug.Text = Convert.ToString(Map.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag);
    }

    private void NextTurn_Click(object sender, EventArgs e)
    {
        //would have AI code go here, but i havent coded it yet.

        for (int i = 0; i < Unit_Names.Count(); i++)
        {
            Unit_Movesleft[i] = 2;
        }

        productionval = productionval + 1;
        movesleftplayer = movesleftplayertotal;
        refreshlbl(unitnum);
    }

    private void Map_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void Armory_Btn_Click(object sender, EventArgs e)
    {
        NewUnit Armory = new NewUnit();
        Armory.Show();
    }
}


    }

