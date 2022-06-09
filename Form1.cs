using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace MMHLab31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string input = "";

        bool CheckHexFormat(string input)
        {
            bool flag = true;
            string source = "0123456789abcdefABCDEF";
            for (int i=0;i< input.Length;i++)
            {
                if (!source.Contains(input[i]))
                    flag = false;
            }
            return flag;
        }

        byte[] ConvertHextoBinary(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                     .ToArray();
        }

        string ConvertStringToHex(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char t in str)
            {
                sb.Append(Convert.ToString(t, 16));
            }
            return sb.ToString();
        }

        private void InputText_TextChanged(object sender, EventArgs e)
        {
            string ComboBoxType = InputTypeComboBox.Text;
            if (ComboBoxType == "Text string")
            { input = InputText.Text; }
            else if (ComboBoxType == "Hex string")
            {
                if (CheckHexFormat(InputText.Text) == false)
                    MessageBox.Show("Wrong, input is not hex format!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else input = InputText.Text;
            }
            else if (ComboBoxType == "File")
            {
                string filename = InputText.Text;
                byte[] filebytes = File.ReadAllBytes(filename);
                StringBuilder sb = new StringBuilder();

                foreach (byte b in filebytes)
                {
                    sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
                }
                input = sb.ToString();
                testTextBox.Text = input;
            }
        }

        private void MD5CalButton_Click(object sender, EventArgs e)
        {
            //string input = InputText.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            MD5TextBox.Text = sb.ToString();
        }

        private void Sha1CalButton_Click(object sender, EventArgs e)
        {
            //string input = InputText.Text;
            SHA1 sha1 = SHA1.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = sha1.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            Sha1TextBox.Text = sb.ToString();
        }

        private void Sha2CalButton_Click(object sender, EventArgs e)
        {
            //string input = InputText.Text;
            SHA256 sha256 = SHA256.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = sha256.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            Sha2TextBox.Text = sb.ToString();
            testTextBox.Text = input;
        }

        private void Sha384CalButton_Click(object sender, EventArgs e)
        {
            //string input = InputText.Text;
            SHA384 sha384 = SHA384.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = sha384.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            Sha384TextBox.Text = sb.ToString();
        }

        private void Sha512CalButton_Click(object sender, EventArgs e)
        {
            //string input = InputText.Text;
            var sha3512 = new Org.BouncyCastle.Crypto.Digests.Sha3Digest(512);
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);

            sha3512.BlockUpdate(inputBytes, 0, inputBytes.Length);
            byte[] result = new byte[64];
            sha3512.DoFinal(result, 0);

            Sha512TextBox.Text = BitConverter.ToString(result).Replace("-", "");
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            InputText.Text = "";
            MD5TextBox.Text = "";
            Sha1TextBox.Text = "";
            Sha2TextBox.Text = "";
            Sha384TextBox.Text = "";
            Sha512TextBox.Text = "";
        }

        private void InputTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void testTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
