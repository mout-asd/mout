using System;
using System.Drawing;
using System.Windows.Forms;

namespace mout
{
    public partial class InfoForm : Form
    {
        private int _photoIndex = 1;
        private string _currentDirectory;
        private string _currentCity;

        public InfoForm(int i)
        {
            InitializeComponent();
            GetAllPaths(i);
        }

        private void GetAllPaths(int i)
        {
            switch (i)
            {
                case 1:
                    _currentDirectory = Environment.CurrentDirectory + @"\Rostov\";
                    _currentCity = "РостовВеликий";
                    break;
                case 2:
                    _currentDirectory = Environment.CurrentDirectory + @"\Vladimir\";
                    _currentCity = "Владимир";
                    break;
                case 3:
                    _currentDirectory = Environment.CurrentDirectory + @"\Ivanovo\";
                    _currentCity = "Иваново";
                    break;
                case 4:
                    _currentDirectory = Environment.CurrentDirectory + @"\Kostroma\";
                    _currentCity = "Кострома";
                    break;
                case 5:
                    _currentDirectory = Environment.CurrentDirectory + @"\Posad\";
                    _currentCity = "Сергиев Посад";
                    break;
                case 6:
                    _currentDirectory = Environment.CurrentDirectory + @"\Pereslavl\";
                    _currentCity = "Переславль-Залесский";
                    break;
                case 7:
                    _currentDirectory = Environment.CurrentDirectory + @"\Suzdal\";
                    _currentCity = "Сузаль";
                    break;
                case 8:
                    _currentDirectory = Environment.CurrentDirectory + @"\Yaroslavl\";
                    _currentCity = "Ярославль";
                    break;
            }
        }
        private void ShowText()
        {
            object readOnly = false;
            object visible = true;
            object save = false;
            object fileName = _currentDirectory + _currentCity + ".docx";
            object newTemplate = false;
            object missing = Type.Missing;

            Microsoft.Office.Interop.Word.Document document;
            Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
            document = application.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing
                , ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);
            document.ActiveWindow.Selection.WholeStory();
            document.ActiveWindow.Selection.Copy();
            IDataObject dataObject = Clipboard.GetDataObject();
            richTextBox1.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
            document.Close();
            application.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            photoPanel.Visible = true;
            richTextBox1.Visible = false;
            panel2.Visible = true;
            pictureBox1.Image = Image.FromFile(_currentDirectory + _photoIndex + ".jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            photoPanel.Visible = false;
            richTextBox1.Visible= true;
            ShowText();
        }

        private void button4_Click(object sender, EventArgs e) => Close();

        private void button1_Click(object sender, EventArgs e)
        {
            photoPanel.Visible = true;
            richTextBox1.Visible = false;
            panel2.Visible = false;
            pictureBox1.Image = Image.FromFile(_currentDirectory+"map.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _photoIndex--;
            if (_photoIndex < 1)
                _photoIndex = 6;
            pictureBox1.Image = Image.FromFile(_currentDirectory + _photoIndex + ".jpg");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            _photoIndex++;
            if (_photoIndex > 6)
                _photoIndex = 1;
            pictureBox1.Image = Image.FromFile(_currentDirectory + _photoIndex + ".jpg");
        }
    }
}
