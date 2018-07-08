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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //First picure
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //Name of the app
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //UserName textbox && we are saving the username entered by the user to confirm if the one making the log in
        //request is the administrator of the platform
        string UserName;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UserName = textBox1.Text;
        }

        //Password textbox && we are saving the password entered by the user to confirm if the one making the log in
        //request is the administrator of the platform
        string password;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            password = textBox2.Text;
        }

        //Sign Up button
        //If we click the register button, we will hide the login screen and open the register one
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register1 = new Register();
            register1.Show();

        }

        //Log In button
        //We are checking if the password and the username matches the admin account
        //If it does not match, it clear the textbox
        //If it does, we continue to the admin menu
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(UserName == "Admin" && password == "admin123")
            {
                this.Hide();
                AdminMenu admin = new AdminMenu();
                admin.Show();
                
            }
            //THIS WILL CLEAN THE PASSWORD AND USERNAME TEXTBOX IF IT IS INCORRECT
            //THIS SHOULD BE KEPT ON THE BOTTOM OF THE METHOD
            textBox1.ResetText();
            textBox2.ResetText();
        }

        //Exit button (closes the entire app)
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimize button
        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Allows the logIn design to be moved around
        private void LogIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        //Allows the logIn design to be moved around
        private void LogIn_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Black bar at the top
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //Allows the logIn design to be moved around from the top panel(purple one)
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        //Allows the logIn design to be moved around from the top panel(purple one)
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }
    }
}
