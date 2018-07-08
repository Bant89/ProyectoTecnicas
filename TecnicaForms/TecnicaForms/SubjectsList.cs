using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class SubjectsList : Form
    {
        public SubjectsList()
        {
            InitializeComponent();
        }

        private void SubjectsList_Load(object sender, EventArgs e)
        {

        }     

        //Save button
        private void button1_Click(object sender, EventArgs e)
        {
            //Same shit
            //Use the index to save the elements to the list you are supossed to create
            //HINT: checkedListBox1.CheckedItems;
        }

        //Exit button
        private void button2_Click(object sender, EventArgs e)
        {
            //Displays a textbox to confirm that the user indeed wants to close the app
            DialogResult dialog = MessageBox.Show("Estas seguro de que deseas salir?", "Salir", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Allows to move the subjects list when clicking on it
        Point lastPoint;
        private void SubjectsList_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void SubjectsList_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Allows to move the subjects list when clicking on it
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Minimize button
        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
