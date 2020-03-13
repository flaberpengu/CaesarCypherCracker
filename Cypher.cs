using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCypherCracker
{
    class Cypher
    {
        private int shiftBy;
        List<string> myText;

        public Cypher(List<string> encryptedText)
        {
            myText = encryptedText;
        }

        //Checks if the character is a space; if so, returns true
        protected bool IsWhiteSpace(char ch)
        {
            bool isWhiteSpace = false;
            if ((ch.ToString()).Equals(" "))
            {
                isWhiteSpace = true;
            }
            return isWhiteSpace;
        }

        //Checks if character is punctuation; if so, returns true
        protected bool IsPunctuation(char ch)
        {
            bool isPunctuation = false;
            String[] punctuation = { ",", ".", "/", "?", ":", ";", "<", ">", "'", "@", "#", "~", "[", "]", "{", "}", "!", "\"", "£", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "\\", "|", "`", "¬" };
            foreach (string s in punctuation)
            {
                if ((ch.ToString()).Equals(s))
                {
                    isPunctuation = true;
                }
            }
            return isPunctuation;
        }

        //Checks if character is number; if so, returns true
        protected bool IsNumber(char ch)
        {
            bool isNumber = false;
            String[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            foreach (string number in numbers)
            {
                if ((ch.ToString()).Equals(number))
                {
                    isNumber = true;
                }
            }
            return isNumber;
        }

        //Decrypts a character by a given integer; returns decrypted character
        private char ShiftETP(char encChar)
        {
            int encVal = char.ToUpper(encChar) - 65;
            int plainVal = encVal - shiftBy;
            if (plainVal < 0)
            {
                plainVal += 26;
            }
            char plainChar = (char)(plainVal + 65);
            return plainChar;
        }

        //Decrypts text, returns List
        public List<String> Decrypt(int sb)
        {
            shiftBy = sb;
            List<String> decryptedList = new List<String>(); //New list
            string decryptedLine; //Temp new string
            for (int i = 0; i < myText.Count; i++) //For each line to decrypt
            {
                decryptedLine = "";
                for (int j = 0; j < myText[i].Length; j++) //For each character in line
                {
                    if (IsPunctuation(myText[i][j]) || IsNumber(myText[i][j]) || IsWhiteSpace(myText[i][j])) //Checks if character is letter
                    {
                        decryptedLine += myText[i][j]; //If not, then don't encrypt
                    }
                    else
                    {
                        decryptedLine += ShiftETP(myText[i][j]); //Otherwise, encrypt
                    }
                }
                decryptedList.Add(decryptedLine); //Add lines to list
            }
            return decryptedList;
        }
    }
}
