using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper
{
    class cell:Button
    {
        public int num =0;
        public bool IsOpen = false;
        public bool flag = false;
        public int ri, ci;

        public cell (int r , int c , int h , int w)
        {
            this.Height = h;
            this.Width = w;
            this.ri = r;
            this.ci = c;
        }

        public void setnum(int n)
        {
            num = n;
        }

        public int getnum()
        {
            return num;
        }
    }
}






