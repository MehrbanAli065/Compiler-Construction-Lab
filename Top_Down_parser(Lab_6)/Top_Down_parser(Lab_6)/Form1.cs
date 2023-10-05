using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Top_Down_parser_Lab_6_
{
    public partial class Form1 : Form
    {
        private Dictionary<char, HashSet<char>> firstSets = new Dictionary<char, HashSet<char>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Action_Click(object sender, EventArgs e)
        {
            firstSets.Clear();
            string[] productions = inpTB.Text.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            foreach (var production in productions)
            {
                string[] parts = production.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 2)
                {
                    MessageBox.Show($"Invalid production: {production}");
                    return;
                }

                char nonTerminal = parts[0][0];
                string[] symbols = parts[1].Split('|');

                if (!firstSets.ContainsKey(nonTerminal))
                {
                    firstSets[nonTerminal] = new HashSet<char>();
                }

                foreach (var symbol in symbols)
                {
                    CalculateFirstSet(nonTerminal, symbol.Trim());
                }
            }

            DisplayFirstSets();
        }

        private void CalculateFirstSet(char nonTerminal, string symbol)
        {
            if (char.IsUpper(symbol[0]))
            {
                // Non-terminal symbol
                char firstSymbol = symbol[0];
                if (!firstSets.ContainsKey(firstSymbol))
                {
                    MessageBox.Show($"Invalid non-terminal symbol: {firstSymbol}");
                    return;
                }

                foreach (var terminal in firstSets[firstSymbol])
                {
                    firstSets[nonTerminal].Add(terminal);
                }

                if (firstSets[firstSymbol].Contains('?'))
                {
                    CalculateFirstSet(nonTerminal, symbol.Substring(1));
                }
            }
            else
            {
                // Terminal symbol
                firstSets[nonTerminal].Add(symbol[0]);
            }
        }

        private void DisplayFirstSets()
        {
            outTB.Clear();
            foreach (var entry in firstSets)
            {
                outTB.AppendText($"First({entry.Key}) = {{ {string.Join(", ", entry.Value)} }}\n");
            }
        }
    }
}
