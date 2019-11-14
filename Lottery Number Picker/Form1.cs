using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            int amountOfNumber = Convert.ToInt32(numericUpDown1.Value);
            int minimumValue = Convert.ToInt32(numericUpDown2.Value);
            int highestValue = Convert.ToInt32(numericUpDown3.Value);

            int[] arrA = new int[(amountOfNumber)];
            Random random = new Random();

            for (int i = 0; i <= arrA.Length - 1; i++)
            {
                var number = random.Next((amountOfNumber), (highestValue));
                while (arrA.Any(n => n == number))
                {
                    number = random.Next((minimumValue), (highestValue));
                }
                arrA[i] = number;
            }
            arrA = arrA.OrderBy(i => i).ToArray();

            
            if (amountOfNumber > 0 && arrA.Length > 0)
            {
                resultNumbers.Visible = true;
                resultNumbers.Text = string.Join(", ", arrA);
            }
            else
            {
                resultNumbers.Visible = false;
            }
        }
    }
}
    

