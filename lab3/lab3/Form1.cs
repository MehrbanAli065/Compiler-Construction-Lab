using System.Text.RegularExpressions;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validate_Click(object sender, EventArgs e)
        {
            string input = tb.Text;
            string pattern = @"^[-+]?[0-9]*\.?[0-9]{1,6}$";

            if (Regex.IsMatch(input, pattern))
            {
                MessageBox.Show("Valid floating-point number.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid floating-point number.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  // Create an instance of Form2
            form2.Show();
        }
    }
}