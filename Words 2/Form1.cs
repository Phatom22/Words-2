using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Words_2
{
    public partial class Form1 : Form
    {
        private ArrayList wordList = new ArrayList();
        private ArrayList concatenatedWords = new ArrayList();


        public Form1()
        {
             
        InitializeComponent();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {

            string newWord1 = txtNewWord.Text.Trim();
            

            if (string.IsNullOrEmpty(newWord1))
            {
                MessageBox.Show("Please enter a word.");
                return;
            }

            if (comboBox1.Items.Contains(newWord1) ||comboBox2.Items.Contains(newWord1) )
            {
                MessageBox.Show("This word has already been entered.");
                return;
            }

            if (wordList.Contains(newWord1))
            {
                MessageBox.Show("This word has already been added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            comboBox1.Items.Add(newWord1);
            comboBox2.Items.Add(newWord1);
            wordList.Add(newWord1);
            concatenatedWords.Add(newWord1);

            MessageBox.Show("Word added successfully.");

           txtNewWord.Clear();
        
    }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedFirstWord = comboBox1.SelectedItem?.ToString();
            string selectedSecondWord = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedFirstWord) || string.IsNullOrEmpty(selectedSecondWord))
            {
                MessageBox.Show("Please select words from both ComboBoxes.");
                return;
            }
           
            
            if (selectedFirstWord == selectedSecondWord)
            {
                MessageBox.Show("Please select two different words to concatenate.");
                return;
            }
            else
            {

                string concatenatedWord = selectedFirstWord + selectedSecondWord;
                label6.Text = concatenatedWord;
            }
            


        }




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1) // Check if an item is selected
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex); // Remove the selected item
            }
            if (radioButton1.Checked)
            {
                button1.Text = " Remove item";
            }

            MessageBox.Show("word has been removed.");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1) // Check if an item is selected
            {
                comboBox2.Items.RemoveAt(comboBox2.SelectedIndex); // Remove the selected item
                
            }
            if (radioButton2.Checked)
            {
                button1.Text = " Remove item";
            }
            MessageBox.Show("word has been removed.");


        }
    }
}
