using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th1;
        Thread th2;
        Random random;
       
        public void DrawRactangle()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue ,4), new Rectangle( random.Next(0, this.Width),  random.Next(0, this.Height), 20, 20));
                Thread.Sleep(3000);
            }
            MessageBox.Show("Complated rectangle");
        }

        
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            th1 = new Thread(DrawRactangle);
            th1.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           random = new Random();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {

        }
    }
}
