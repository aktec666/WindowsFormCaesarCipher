using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormCaesarCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        string Encryption(string text, int key)
        {
            key %= 32;
            string result = ""; // тут будет ответ

            foreach (char x in text)
                if (alphabet.Contains((x + "").ToUpper()))
                {
                    string temp = alphabet[((x - 'А') + key) % 32] + "";
                    if (x >= 'а' && x <= 'я')
                        result += temp.ToLower();
                    else
                        result += temp;
                }
                else
                    result += x;

            return result;
        }

        string Code(string text, int key)
        {
            return Encryption(text, key);
        }

        string Decode(string text, int key)
        {
            return Encryption(text, -key);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCode_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = Code(textBoxInput.Text, (int)(numericUpDownKey.Value));
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = Decode(textBoxInput.Text, (int)(numericUpDownKey.Value));
        }
    }
}
