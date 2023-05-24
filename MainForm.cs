using System;
using System.Windows.Forms;

namespace mout
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            switch (pictureBox.Name)
            {
                case "pictureBox1":
                    new InfoForm(1).ShowDialog();
                    break;
                case "pictureBox2":
                    new InfoForm(2).ShowDialog();
                    break;
                case "pictureBox3":
                    new InfoForm(3).ShowDialog();
                    break;
                case "pictureBox4":
                    new InfoForm(4).ShowDialog();
                    break;
                case "pictureBox5":
                    new InfoForm(5).ShowDialog();
                    break;
                case "pictureBox6":
                    new InfoForm(6).ShowDialog();
                    break;
                case "pictureBox7":
                    new InfoForm(7).ShowDialog();
                    break;
                case "pictureBox8":
                    new InfoForm(8).ShowDialog();
                    break;
            }
        }
    }
}
