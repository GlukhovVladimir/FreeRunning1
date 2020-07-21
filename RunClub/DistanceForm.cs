using RunClub.Helpers;
using System;
using System.Windows.Forms;

namespace RunClub
{
    public partial class DistanceForm : Form
    {
        public DateTime Date { set { date = value; } }
        private DateTime date;
        public double Distance => Convert.ToDouble(distanceTextBox.Text);
        public DistanceForm()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (!RegexService.CheckNum(distanceTextBox.Text))
            {
                MessageBox.Show(
                    "Введите дистанцию",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void DistanceForm_Load(object sender, EventArgs e)
        {
            titleLabel.Text = "Cколько километров вы пробежали " 
                + date.ToShortDateString() + "?";
        }
    }
}
