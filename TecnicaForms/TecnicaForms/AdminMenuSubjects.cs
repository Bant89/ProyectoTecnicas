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
    public partial class AdminMenuSubjects : Form
    {
        public AdminMenuSubjects()
        {
            InitializeComponent();
        }

        //Agregar button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarAsignatura agregar = new AgregarAsignatura();
            agregar.Show();
            
        }
        //Editar button
        private void button2_Click(object sender, EventArgs e)
        {
            int indx = listBox1.SelectedIndex;
            //Put the code to edit it here
            if(listBox1.SelectedIndex >= 0)
            {
                //I will leave this little hint here
                //listBox1.Items.;
            }
        }
        //Salir button
        private void button3_Click(object sender, EventArgs e)
        {
            //Pops up a box that ask the user if he wants to exit the menu or no
            DialogResult dialog = MessageBox.Show("Estas seguro de que deseas salir?", "Salir", MessageBoxButtons.YesNo);

            if(dialog == DialogResult.Yes)
            {
                this.Close();
                AdminMenu AM = new AdminMenu();
                AM.Show();
            }
        }

        //Minimize button
        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Allow us to move the app while holding left mouse button
        Point lastPoint;
        private void AdminMenuSubjects_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AdminMenuSubjects_MouseDown(object sender, MouseEventArgs e)
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
