using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public static bool isO = false;
        public string[,] winArray = {{"0","1","2"}, { "3","4","5" },{ "6","7","8" }, { "0","3","6" },{ "2","5","8" },{ "1","4","7" }, { "0","4","8" },{ "2","4","6" } };
        public string[] playersWent = {"","","","","","","","","" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
             Button s = (sender as Button);
            if (s.Text == "")
            {
                if (isO)
                    s.Text = "O";
                else
                    s.Text = "X";


                int whereAt = Int32.Parse(s.Name.Replace("button", "").ToString());
                playersWent[whereAt - 1] = s.Text;


                for (int i = 0; i < 8; i++)
                {
                    // MessageBox.Show(Int32.Parse(winArray[i, 0]) + "");
                    bool won = false;
                    if (playersWent[Int32.Parse(winArray[i, 0])] == "" || playersWent[Int32.Parse(winArray[i, 1])] == "" || playersWent[Int32.Parse(winArray[i, 2])] == "")
                        continue;

                    if (playersWent[Int32.Parse(winArray[i, 0])] == s.Text && playersWent[Int32.Parse(winArray[i, 1])] == s.Text && playersWent[Int32.Parse(winArray[i, 2])] == s.Text)
                        won = true;
                    else
                        won = false;
               


                    if (won)
                    {
                        MessageBox.Show(s.Text + " is the Winner!");
                        reset();
                    }
                    else
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "")
                        {
                            MessageBox.Show("No One Won");
                            reset();
                        }

                    }
                }
                isO = !isO;

            }
            else
                MessageBox.Show("You can not click on a already filled box");
        }
        
private void reset()
        {
            for (int o = 0; o < playersWent.Length; o++)
                playersWent[o] = "";

            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
            this.button7.Text = "";
            this.button8.Text = "";
            this.button9.Text = "";
            isO = true;
        }
        
    }
}
