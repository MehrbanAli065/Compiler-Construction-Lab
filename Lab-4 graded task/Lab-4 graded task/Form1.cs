namespace Lab_4_graded_task
{
    public partial class Form1 : Form
    {
        private string inputText;
        private List<Token> tokens;
        private bool usingBuffer1 = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void analyze_Click(object sender, EventArgs e)
        {
            // Get the input text from the textbox
            inputText = inpTB.Text;

            // Perform lexical analysis
            tokens = LexicalAnalysis(inputText);

            // Display the results in the RichTextBox
            DisplayTokens();
        }

        private List<Token> LexicalAnalysis(string input)
        {
            // Implement your lexical analysis logic here
            // For this example, we'll split by whitespace and classify tokens as 'Word' or 'Number'

            string[] inputTokens = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            List<Token> resultTokens = new List<Token>();

            foreach (string token in inputTokens)
            {
                string tokenType = GetTokenType(token);
                resultTokens.Add(new Token { Value = token, Type = tokenType });
            }

            return resultTokens;
        }

        private string GetTokenType(string token)
        {
            // Implement your logic to determine token types here
            // For this example, we'll classify tokens as 'Word' or 'Number' based on simple rules
            if (int.TryParse(token, out _))
                return "Number";
            else if (token.All(char.IsLetter))
                return "Word";
            else
                return "Unknown";
        }

        private void DisplayTokens()
        {
            // Clear the RichTextBox
            outputTB.Clear();

            // Display the tokens with formatting
            foreach (Token token in tokens)
            {
                outputTB.SelectionColor = (token.Type == "Number") ? System.Drawing.Color.Blue : System.Drawing.Color.Black;
                outputTB.AppendText($"{token.Value} ({token.Type}) ");
            }
        }
    }

    public class Token
    {
        public string Value { get; set; }
        public string Type { get; set; }
    }
}