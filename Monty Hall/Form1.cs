using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monty_Hall
{
    public partial class Form1 : Form
    {
        Random rnd;

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimulateSwitchers();
            SimulateStayers();
        }

        private void SimulateSwitchers()
        {
            textBox1.Text = "";
            textBox2.Text = "";

            int winCount = 0;
            int loseCount = 0;

            for (int i = 0; i < 100000; i++)
            {
                bool[] doorArr = new bool[3];

                int car = rnd.Next(0, 3);

                doorArr[car] = true;

                int choice = rnd.Next(0, 3);

                if (doorArr[choice])
                {
                    loseCount++;
                }
                else
                {
                    winCount++;
                }
            }

            textBox1.Text = winCount.ToString();
            textBox2.Text = loseCount.ToString();
        }

        private void SimulateStayers()
        {
            textBox3.Text = "";
            textBox4.Text = "";

            int winCount = 0;
            int loseCount = 0;

            for (int i = 0; i < 100000; i++)
            {
                bool[] doorArr = new bool[3];

                int car = rnd.Next(0, 3);

                doorArr[car] = true;

                int choice = rnd.Next(0, 3);

                if (doorArr[choice])
                {
                    winCount++;
                }
                else
                {
                    loseCount++;
                }
            }

            textBox4.Text = winCount.ToString();
            textBox3.Text = loseCount.ToString();
        }
    }
}
