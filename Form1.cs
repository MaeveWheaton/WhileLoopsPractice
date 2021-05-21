using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileLoopsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                valuesOutput.Text = "";

                //collect values
                int start = Convert.ToInt32(startValueInput.Text);
                int end = Convert.ToInt32(endValueInput.Text);

                //display one at a time from start to end
                while (start <= end)
                {
                    valuesOutput.Text += $"{start} ";
                    start++;
                }
            }
            catch
            {
                valuesOutput.Text = "Please enter integer values";
            }            
        }
    }
}
