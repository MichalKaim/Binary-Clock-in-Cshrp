using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Clock
{
    public partial class Form1 : Form
    {
        public DateTime czas;

        public Form1()
        {
            InitializeComponent();

            //Tworze timer i usawiam interwał na 1s
            Timer t = new Timer();

            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);

            t.Start();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void t_Tick(object sender, EventArgs e)
        {
            czas = DateTime.Now;

            checkHour();
            checkMinutes();
            checkSeconds();

            



        }

        private void checkHour()
        {

            if (czas.Hour > 20)
            {
                h20.Visible = false;
                h20O.Visible = true;
            }
            else if (czas.Hour > 10)
            {
                h20O.Visible = false;
                h20.Visible = true;
                h10.Visible = false;
                h10O.Visible = true;
            }

            switch (czas.Hour % 10)
            {

                case 0:
                    h01O.Visible = false;
                    h02O.Visible = false;
                    h04O.Visible = false;
                    h08O.Visible = false;

                    h01.Visible = true;
                    h02.Visible = true;
                    h04.Visible = true;
                    h08.Visible = true;
                    break;

                case 1:
                    h02O.Visible = false;
                    h04O.Visible = false;
                    h08O.Visible = false;

                    h01O.Visible = true;

                    h01.Visible = false;
                    h02.Visible = true;
                    h04.Visible = true;
                    h08.Visible = true;
                    break;

                case 2:
                    h01O.Visible = false;
                    h04O.Visible = false;
                    h08O.Visible = false;

                    h02O.Visible = true;

                    h01.Visible = true;
                    h02.Visible = false;
                    h04.Visible = true;
                    h08.Visible = true;
                    break;

                case 3:
                    h01O.Visible = true;
                    h02O.Visible = true;
                    h04O.Visible = false;
                    h08O.Visible = false;

                    h01.Visible = false;
                    h02.Visible = false;
                    h04.Visible = true;
                    h08.Visible = true;
                    break;

                case 4:
                    h01O.Visible = false;
                    h02O.Visible = false;
                    h04O.Visible = true;
                    h08O.Visible = false;

                    h01.Visible = true;
                    h02.Visible = true;
                    h04.Visible = false;
                    h08.Visible = true;
                    break;

                case 5:
                    h01O.Visible = true;
                    h02O.Visible = false;
                    h04O.Visible = true;
                    h08O.Visible = false;

                    h01.Visible = false;
                    h02.Visible = true;
                    h04.Visible = false;
                    h08.Visible = true;
                    break;

                case 6:
                    h01O.Visible = false;
                    h02O.Visible = true;
                    h04O.Visible = true;
                    h08O.Visible = false;

                    h01.Visible = true;
                    h02.Visible = false;
                    h04.Visible = false;
                    h08.Visible = true;
                    break;

                case 7:
                    h01O.Visible = true;
                    h02O.Visible = true;
                    h04O.Visible = true;
                    h08O.Visible = false;

                    h01.Visible = false;
                    h02.Visible = false;
                    h04.Visible = false;
                    h08.Visible = true;
                    break;

                case 8:
                    h01O.Visible = false;
                    h02O.Visible = false;
                    h04O.Visible = false;
                    h08O.Visible = true;

                    h01.Visible = true;
                    h02.Visible = true;
                    h04.Visible = true;
                    h08.Visible = false;
                    break;

                case 9:
                    h01O.Visible = true;
                    h02O.Visible = false;
                    h04O.Visible = false;
                    h08O.Visible = true;

                    h01.Visible = false;
                    h02.Visible = true;
                    h04.Visible = true;
                    h08.Visible = false;
                    break;
            }
        }

        private void checkMinutes()
        {
            switch (czas.Minute / 10)
            {
                case 0:
                    m10O.Visible = false;
                    m20O.Visible = false;
                    m40O.Visible = false;

                    m10.Visible = true;
                    m20.Visible = true;
                    m40.Visible = true;
                    break;

                case 1:
                    m10O.Visible = true;
                    m20O.Visible = false;
                    m40O.Visible = false;

                    m10.Visible = false;
                    m20.Visible = true;
                    m40.Visible = true;
                    break;

                case 2:
                    m10O.Visible = false;
                    m20O.Visible = true;
                    m40O.Visible = false;

                    m10.Visible = true;
                    m20.Visible = false;
                    m40.Visible = true;
                    break;

                case 3:
                    m10O.Visible = true;
                    m20O.Visible = true;
                    m40O.Visible = false;

                    m10.Visible = false;
                    m20.Visible = false;
                    m40.Visible = true;
                    break;

                case 4:
                    m10O.Visible = false;
                    m20O.Visible = false;
                    m40O.Visible = true;

                    m10.Visible = true;
                    m20.Visible = true;
                    m40.Visible = false;
                    break;

                case 5:
                    m10O.Visible = true;
                    m20O.Visible = false;
                    m40O.Visible = true;

                    m10.Visible = false;
                    m20.Visible = true;
                    m40.Visible = false;
                    break;

                case 6:
                    m10O.Visible = false;
                    m20O.Visible = true;
                    m40O.Visible = true;

                    m10.Visible = true;
                    m20.Visible = false;
                    m40.Visible = false;
                    break;
            }


            switch (czas.Minute % 10)
            {
                case 0:
                    m01O.Visible = false;
                    m02O.Visible = false;
                    m04O.Visible = false;
                    m08O.Visible = false;

                    m01.Visible = true;
                    m02.Visible = true;
                    m04.Visible = true;
                    m08.Visible = true;
                    break;

                case 1:
                    m02O.Visible = false;
                    m04O.Visible = false;
                    m08O.Visible = false;

                    m01O.Visible = true;

                    m01.Visible = false;
                    m02.Visible = true;
                    m04.Visible = true;
                    m08.Visible = true;
                    break;

                case 2:
                    m01O.Visible = false;
                    m04O.Visible = false;
                    m08O.Visible = false;

                    m02O.Visible = true;

                    m01.Visible = true;
                    m02.Visible = false;
                    m04.Visible = true;
                    m08.Visible = true;
                    break;

                case 3:
                    m01O.Visible = true;
                    m02O.Visible = true;
                    m04O.Visible = false;
                    m08O.Visible = false;

                    m01.Visible = false;
                    m02.Visible = false;
                    m04.Visible = true;
                    m08.Visible = true;
                    break;

                case 4:
                    m01O.Visible = false;
                    m02O.Visible = false;
                    m04O.Visible = true;
                    m08O.Visible = false;

                    m01.Visible = true;
                    m02.Visible = true;
                    m04.Visible = false;
                    m08.Visible = true;
                    break;

                case 5:
                    m01O.Visible = true;
                    m02O.Visible = false;
                    m04O.Visible = true;
                    m08O.Visible = false;

                    m01.Visible = false;
                    m02.Visible = true;
                    m04.Visible = false;
                    m08.Visible = true;
                    break;

                case 6:
                    m01O.Visible = false;
                    m02O.Visible = true;
                    m04O.Visible = true;
                    m08O.Visible = false;

                    m01.Visible = true;
                    m02.Visible = false;
                    m04.Visible = false;
                    m08.Visible = true;
                    break;

                case 7:
                    m01O.Visible = true;
                    m02O.Visible = true;
                    m04O.Visible = true;
                    m08O.Visible = false;

                    m01.Visible = false;
                    m02.Visible = false;
                    m04.Visible = false;
                    m08.Visible = true;
                    break;

                case 8:
                    m01O.Visible = false;
                    m02O.Visible = false;
                    m04O.Visible = false;
                    m08O.Visible = true;

                    m01.Visible = true;
                    m02.Visible = true;
                    m04.Visible = true;
                    m08.Visible = false;
                    break;

                case 9:
                    m01O.Visible = true;
                    m02O.Visible = false;
                    m04O.Visible = false;
                    m08O.Visible = true;

                    m01.Visible = false;
                    m02.Visible = true;
                    m04.Visible = true;
                    m08.Visible = false;
                    break;
            }
        }

        private void checkSeconds()
        {
            switch (czas.Second / 10)
            {
                case 0:
                    s10O.Visible = false;
                    s20O.Visible = false;
                    s40O.Visible = false;

                    s10.Visible = true;
                    s20.Visible = true;
                    s40.Visible = true;
                    break;

                case 1:
                    s10O.Visible = true;
                    s20O.Visible = false;
                    s40O.Visible = false;

                    s10.Visible = false;
                    s20.Visible = true;
                    s40.Visible = true;
                    break;

                case 2:
                    s10O.Visible = false;
                    s20O.Visible = true;
                    s40O.Visible = false;

                    s10.Visible = true;
                    s20.Visible = false;
                    s40.Visible = true;
                    break;

                case 3:
                    s10O.Visible = true;
                    s20O.Visible = true;
                    s40O.Visible = false;

                    s10.Visible = false;
                    s20.Visible = false;
                    s40.Visible = true;
                    break;

                case 4:
                    s10O.Visible = false;
                    s20O.Visible = false;
                    s40O.Visible = true;

                    s10.Visible = true;
                    s20.Visible = true;
                    s40.Visible = false;
                    break;

                case 5:
                    s10O.Visible = true;
                    s20O.Visible = false;
                    s40O.Visible = true;

                    s10.Visible = false;
                    s20.Visible = true;
                    s40.Visible = false;
                    break;

                case 6:
                    s10O.Visible = false;
                    s20O.Visible = true;
                    s40O.Visible = true;

                    s10.Visible = true;
                    s20.Visible = false;
                    s40.Visible = false;
                    break;
            }


            switch (czas.Second % 10)
            {
                case 0:
                    s01O.Visible = false;
                    s02O.Visible = false;
                    s04O.Visible = false;
                    s08O.Visible = false;

                    s01.Visible = true;
                    s02.Visible = true;
                    s04.Visible = true;
                    s08.Visible = true;
                    break;

                case 1:
                    s02O.Visible = false;
                    s04O.Visible = false;
                    s08O.Visible = false;

                    s01O.Visible = true;

                    s01.Visible = false;
                    s02.Visible = true;
                    s04.Visible = true;
                    s08.Visible = true;
                    break;

                case 2:
                    s01O.Visible = false;
                    s04O.Visible = false;
                    s08O.Visible = false;

                    s02O.Visible = true;

                    s01.Visible = true;
                    s02.Visible = false;
                    s04.Visible = true;
                    s08.Visible = true;
                    break;

                case 3:
                    s01O.Visible = true;
                    s02O.Visible = true;
                    s04O.Visible = false;
                    s08O.Visible = false;

                    s01.Visible = false;
                    s02.Visible = false;
                    s04.Visible = true;
                    s08.Visible = true;
                    break;

                case 4:
                    s01O.Visible = false;
                    s02O.Visible = false;
                    s04O.Visible = true;
                    s08O.Visible = false;

                    s01.Visible = true;
                    s02.Visible = true;
                    s04.Visible = false;
                    s08.Visible = true;
                    break;

                case 5:
                    s01O.Visible = true;
                    s02O.Visible = false;
                    s04O.Visible = true;
                    s08O.Visible = false;

                    s01.Visible = false;
                    s02.Visible = true;
                    s04.Visible = false;
                    s08.Visible = true;
                    break;

                case 6:
                    s01O.Visible = false;
                    s02O.Visible = true;
                    s04O.Visible = true;
                    s08O.Visible = false;

                    s01.Visible = true;
                    s02.Visible = false;
                    s04.Visible = false;
                    s08.Visible = true;
                    break;

                case 7:
                    s01O.Visible = true;
                    s02O.Visible = true;
                    s04O.Visible = true;
                    s08O.Visible = false;

                    s01.Visible = false;
                    s02.Visible = false;
                    s04.Visible = false;
                    s08.Visible = true;
                    break;

                case 8:
                    s01O.Visible = false;
                    s02O.Visible = false;
                    s04O.Visible = false;
                    s08O.Visible = true;

                    s01.Visible = true;
                    s02.Visible = true;
                    s04.Visible = true;
                    s08.Visible = false;
                    break;

                case 9:
                    s01O.Visible = true;
                    s02O.Visible = false;
                    s04O.Visible = false;
                    s08O.Visible = true;

                    s01.Visible = false;
                    s02.Visible = true;
                    s04.Visible = true;
                    s08.Visible = false;
                    break;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
