using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCypherCracker
{
    public partial class Form1 : Form
    {
        private Cypher cypher;
        private readonly FileReader fr;
        private readonly FileWriter fw;
        private OpenFileDialog openFileDialog1;
        private string filepath;
        //private string outputFilepath;
        //private OpenFileDialog openOutputFileDialog;
        private List<string> encryptedText;
        private string wordsPath = "F:\\Non-School\\c# projects\\actual programs\\CaesarCypherCracker\\CaesarCypherCracker\\wordsv2.txt";
        private List<string> validWords;
        private WordCounter wc;
        public Form1()
        {
            InitializeComponent();
            fr = new FileReader();
            fw = new FileWriter();
            validWords = fr.ReadData(wordsPath);
            wc = new WordCounter(validWords);
        }

        //Opens input file dialog form
        private void OpenFileDialogForm()
        {
            openFileDialog1 = new OpenFileDialog();
            { openFileDialog1.Filter = "Text files (*.txt)|*.txt"; openFileDialog1.Title = "Open text file"; };
        }

        //Sets input file path in the input file textbox
        private void SetPathText()
        {
            tbEncryptedFilePath.Text = filepath;
        }

        //Allows the user to select a .txt file
        private void BtnChooseEncryptedFile_Click(object sender, EventArgs e)
        {
            OpenFileDialogForm();
            //If file is chosen and returned correctly, do actions
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                SetPathText();
            }
            //Clears dialog form
            openFileDialog1.Dispose();
        }

        private void BtnStartDecrypt_Click(object sender, EventArgs e)
        {
            encryptedText = fr.ReadData(filepath);
            cypher = new Cypher(encryptedText);
            List<string> newText;
            double numNeeded;
            numNeeded = wc.GetWordsInText(encryptedText);
            numNeeded /= 2;
            for (int i = 1; i < 26; i++)
            {
                newText = cypher.Decrypt(i);
                int numCorrect = 0;
                int temp;
                for (int j = 0; j < newText.Count; j++)
                {
                    temp = wc.GetWordsInLine(newText[j]);
                    numCorrect += temp;
                    if (j == 10)
                    {
                        if (numCorrect < 6)
                        {
                            j = newText.Count;
                        }
                    }
                }
                if (numCorrect >= numNeeded)
                {
                    rtbOutput.AppendText(String.Join(Environment.NewLine, newText));
                    rtbOutput.AppendText(Environment.NewLine);
                }
            }
        }
    }
}
//http://www.mieliestronk.com/wordlist.html
//GIT