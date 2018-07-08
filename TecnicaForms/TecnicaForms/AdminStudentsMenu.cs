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
    public partial class AdminStudentsMenu : Form
    {
        public AdminStudentsMenu()
        {
            InitializeComponent();
        }

        //Return the admin menu and exit the adminstudentsmenu
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMenu admin = new AdminMenu();
            admin.Show();        
        }

        //Ver estudiante button    
        private void button1_Click(object sender, EventArgs e)
        {
            //The button won't work unless the user has selected an item from the list
            if (listBox1.SelectedIndex >= 0)
            {
                this.Close();
                AdminSubjectsList ASL = new AdminSubjectsList();
                ASL.Show();
            }
           
        }

        //Borrar button
        private void button2_Click(object sender, EventArgs e)
        {
            //Here were are taking the index of the element the user clicks on
            int IndexofElement = listBox1.SelectedIndex;
            //You should take the index and delete the element if this button is clicked

            if (listBox1.Items.Count > 0 && IndexofElement >= 0)
            {
                DialogResult dialog = MessageBox.Show("Quiere eliminar este elemento?", "Delete", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    //You should implement the delete element here, I already did the If for you :)
                    //All you have to do is use the RemoveAt method the list has
                }

            }    

        }

        private void AdminStudentsMenu_Load(object sender, EventArgs e)
        {

        }

        //Minimize button
        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //This allow us to move the app while holding the left mouse button
        Point lastPoint;
        private void AdminStudentsMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AdminStudentsMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

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
    }
}
