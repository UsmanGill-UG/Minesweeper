using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper
{
    public partial class MineSweeper : Form
    {
        int dim = 0, NOM =0;
        cell[,] cs;
        public MineSweeper()
        {
            InitializeComponent();
        }

        private void InitMines()
        {
            Random R = new Random();
            for (int mi = 1; mi <= NOM; mi++)
            {
                int ri = R.Next(dim);
                int ci = R.Next(dim);
                if (cs[ri, ci].getnum() == -1)
                {
                    mi--;
                    continue;
                }
                cs[ri, ci].setnum(-1);
     //           cs[ri, ci].Text = cs[ri, ci].getnum().ToString();
            }
            for(int ri =0; ri < dim;ri++ )
            {
                for (int ci = 0; ci < dim; ci++)
                {
                    if (cs[ri, ci].getnum() == -1)
                        continue;
                    int minecount = WindowCount(ri, ci);
                    cs[ri, ci].setnum(minecount);
        //            cs[ri, ci].Text = cs[ri, ci].getnum().ToString();
                }
            }
        }

        int WindowCount(int ri , int ci)
        {
            int count = 0;
            for(int r = ri -1; r<= ri+1; r++)
            {
                for (int c = ci - 1; c <= ci + 1; c++)
                {
                    if ((r == ri && c == ci)|| r < 0|| c< 0 || r >=dim ||c>=dim)
                        continue;
                    if (cs[r, c].getnum() == -1)
                        count++;
                }
            }
            return count;
        }
        private void LoadCells()
        {
            board.Controls.Clear();
            cs = new cell[dim , dim];
            int H = board.Height / dim - 6;
            int W = board.Width / dim - 6;
            for (int ri =0; ri < dim; ri++)
            {
                for (int ci = 0; ci < dim; ci++)
                {
                    cell c = new cell(ri, ci, H, W);
                    c.Click += new System.EventHandler(this.cell_Click);
                    board.Controls.Add(c);
                    cs[ri, ci] = c;
                }
            }
            InitMines();
        }

        void Explore(int ri, int ci)
        {
            if (cs[ri, ci].IsOpen == true)
                return;
            cs[ri, ci].IsOpen = true;
            if(cs[ri, ci].getnum() == 0)
            {
                cs[ri, ci].BackColor = Color.Gray;
            }
            for (int r = ri - 1; r <= ri + 1; r++)
                for (int c = ci - 1; c <= ci + 1; c++)
                {
                    if (r < 0 || c < 0 || r >= dim || c >= dim)
                        continue;
                    if (cs[r, c].IsOpen == false)
                    {

                        if (cs[r, c].num != 0)
                        {
                            if (cs[r, c].num == 1)
                            {
                                cs[r, c].ForeColor = Color.Blue;
                                cs[r, c].BackColor = Color.Black;
                            }
                            if (cs[r, c].num == 2)
                            {
                                cs[r, c].ForeColor = Color.Green;
                                cs[r, c].BackColor = Color.Black;
                            }
                            if (cs[r, c].num == 3)
                            {
                                cs[r, c].ForeColor = Color.Red;
                                cs[r, c].BackColor = Color.Black;
                            }
                            cs[r, c].Text = cs[r, c].num.ToString();
                            cs[r, c].IsOpen = true;
                        }
                        else if (cs[r, c].num == 0)
                        {
                            Explore(r, c);
                            cs[r, c].BackColor = Color.Gray;
                        }
                    }
                }
        }

        bool IsWin()
        {
            int count = 0;
            for(int r =0; r<dim;r++)
            {
                for (int c =0; c< dim; c++)
                {
                    if ((cs[r, c].getnum() != -1) && (cs[r, c].IsOpen == false))
                        count++;
                }
            }
            if (count ==0)
                return true;
            return false;
        }
        private void cell_Click(object sender, EventArgs e)
        {
            cell c = (cell)sender;
            if(IsWin() == true)
            {
                MessageBox.Show("YOU WON");
                return;
            }
          //  MouseEventArgs me = (MouseEventArgs)e;
            if (c.flag == true)
                return;
            if (c.IsOpen== true)
                return;
            if (c.getnum() == -1)
            {
                MessageBox.Show("GAME OVER");
                for (int ri = 0; ri < dim; ri++)
                {
                    for (int ci = 0; ci < dim; ci++)
                    {
                        if (cs[ri, ci].getnum() == -1)
                        {
                            cs[ri, ci].ForeColor = Color.Red;
                            cs[ri, ci].Text = "💣";
                        }
                    }
                }
                return;
            }
            else if (c.getnum() != 0)
            {
                c.IsOpen = true;
                // this.Start.ForeColor = System.Drawing.Color.CornflowerBlue;
                if (c.getnum() == 1)
                    c.ForeColor = Color.Blue;
                if (c.getnum() == 2)
                    c.ForeColor = Color.Green;
                if (c.getnum() == 3)
                    c.ForeColor = Color.Red;
                c.Text = c.getnum().ToString();
            }
            else
            {
                Explore(c.ri , c.ci);
            }
        }


        private void Start_Click(object sender,EventArgs e)
        {

            if (Beginner.Checked)
            {
                dim = 9;
                NOM = 10;
            }
            if (Intermediate.Checked)
            {
                dim = 15;
                NOM = 15;
            }
            if (Hard.Checked)
            {
                dim = 25;
                NOM = 30;

            }
            if (dim ==0 )
            {
                MessageBox.Show("Please Select Level!!!");
                return;
            }
            LoadCells();

        }
    }
}
