namespace Bottom_Up_Parser_Lab_8_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool IsCVariable(string input)
        {
            int state = 0;
            foreach (char c in input)
            {
                switch (state)
                {
                    case 0:
                        if (char.IsLetter(c) || c == '_')
                            state = 1;
                        else
                            return false;
                        break;
                    case 1:
                        if (char.IsLetterOrDigit(c) || c == '_')
                            state = 1;
                        else
                            return false;
                        break;
                }
            }
            return state == 1;
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            string input = VariableTextBox.Text;
            bool isValid = IsCVariable(input);
            if (isValid)
            {
                MessageBox.Show("Valid C variable name.");
            }
            else
            {
                MessageBox.Show("Not a valid C variable name.");
            }
        }
    }

    }
