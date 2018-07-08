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
    public partial class AdminSubjectsList : Form
    {
        public AdminSubjectsList()
        {
            InitializeComponent();
        }

        //Informacion personal listbox
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Salir button
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Estas seguro de que deseas salir?", "Salir", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
                AdminStudentsMenu ASM = new AdminStudentsMenu();
                ASM.Show();
            }
            
        }

        //Calificar button
        private void button1_Click(object sender, EventArgs e)
        {
            //This will take the index of the element that the users clicks on
            //Use this to change the grade in the 6 or 7 listbox :D (I'm fucking tired of this shit tbh)
            int indx = listBox1.SelectedIndex;
        }

        //Minimize button
        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AdminSubjectsList_Load(object sender, EventArgs e)
        {

        }
    }
}
