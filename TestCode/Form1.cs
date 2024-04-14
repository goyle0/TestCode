using System;
using System.Windows.Forms;
using TestCode.Models;

namespace TestCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var readText = new ReadText();
                var dataList = readText.ReadTextFile();
                foreach (var entity in dataList)
                {
                    OutputText.Text += entity.ToString() + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            OutputText.Text = string.Empty;
        }
    }
}
