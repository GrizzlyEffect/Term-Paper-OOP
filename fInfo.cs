using Term_Paper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Term_Paper
{
    public partial class fInfo : Form
    {
        public fInfo()
        {
            InitializeComponent();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close the app?", "Exit the program",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр Form2
            fMainPageApp fmainPage = new fMainPageApp();

            // Отображаем Form2
            fmainPage.Show();

            // Закрываем текущую форму (Form1), если необходимо
            this.Hide();
        }
    }
}
