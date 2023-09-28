using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_5_SYMBOL_TABLE
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> symbolTable;
        public Form1()
        {
            InitializeComponent();
            // Initialize the symbol table as a dictionary
            symbolTable = new Dictionary<string, string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string variableName = tb1.Text;
            string variableValue = tb2.Text;

            if (!string.IsNullOrWhiteSpace(variableName) && !string.IsNullOrWhiteSpace(variableValue))
            {
                if (!symbolTable.ContainsKey(variableName))
                {
                    symbolTable.Add(variableName, variableValue);
                    UpdateSymbolTableListView();
                }
                else
                {
                    MessageBox.Show("Variable name already exists in the symbol table.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both variable name and value.");
            }
        }

        private void UpdateSymbolTableListView()
        {
            // Clear the ListView
            // SymbolTableListView.Items.Clear();

            // Add the symbol table entries to the ListView
            foreach (var entry in symbolTable)
            {
                ListViewItem item = new ListViewItem(entry.Key);
                item.SubItems.Add(entry.Value);
                //  SymbolTableListView.Items.Add(item);
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            string variableName = tb1.Text;
            string variableValue = tb2.Text;

            if (!string.IsNullOrWhiteSpace(variableName) && !string.IsNullOrWhiteSpace(variableValue))
            {
                if (!symbolTable.ContainsKey(variableName))
                {
                    symbolTable.Add(variableName, variableValue);
                    UpdateSymbolTableListView();
                }
                else
                {
                    MessageBox.Show("Variable name already exists in the symbol table.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both variable name and value.");
            }
        }

    }
}