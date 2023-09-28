using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Set up the DataGridView
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Numbers";

            // Sample data
            string[] numbers = { "8e4", "5e-2", "6e9", "abc", "1.23" };

            // Loop through the sample data and add matching numbers to the DataGridView
            foreach (string number in numbers)
            {
                if (IsScientificNotation(number))
                {
                    dataGridView1.Rows.Add(number);
                }
            }
        }

        // Regular expression to match scientific notation numbers
        private static readonly Regex ScientificNotationRegex = new Regex(@"^[+-]?(\d+(\.\d*)?|\.\d+)([eE][+-]?\d+)?$");

        // Function to check if a string is in scientific notation
        private bool IsScientificNotation(string input)
        {
            return ScientificNotationRegex.IsMatch(input);
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  // Create an instance of Form2
            form1.Show();
        }
    }
}
