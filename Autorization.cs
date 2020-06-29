using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KGEU.CourseWork
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "Supervisor" && textBox1.Text == "Supervisor")
            {
                // назначает новую главную форму
                Program.Context.MainForm = new Form1();

                this.Close();

                // покажет вторую форму и оставит приложение живым до ее закрытия
                Program.Context.MainForm.Show();
            }
        }
    }
}
