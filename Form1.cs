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

namespace cryptography
{
    public partial class Form1 : Form
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;
        public Form1()
        {
            InitializeComponent();
        }
        // the caeser cipher encryption logic
        char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }
        string caeserEncipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }
        // the caeser cipher decryption logic
        string caeserdecipher(string input, int key)
        {
            return caeserEncipher(input, 26 - key);
        }
        // the des encryption logic
        public string desEncrypt(string source, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    byte[] data = Encoding.Unicode.GetBytes(source);
                    return Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }
        //the des decryption logic
        public static string desDecrypt(string encrypt, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    byte[] byteBuff = Convert.FromBase64String(encrypt);
                    return Encoding.Unicode.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
                }
            }
        }
        //the rsa encryption logic
        static public byte[] rsaEncryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        //the rsa decryption logic
        static public byte[] rsaDecryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        // the rail fence encryption logic
        public string rfenceEncrypt(string plaintext)
        {
            string ciphertext = null;
            int j = 0, k = 0;
            char[] ptca = plaintext.ToCharArray();
            char[,] railarray = new char[2, 100];
            for (int i = 0; i < ptca.Length; ++i)
            {
                if (i % 2 == 0)
                {
                    railarray[0, j] = ptca[i];
                    ++j;
                }
                else
                {
                    railarray[1, k] = ptca[i];
                    ++k;
                }
            }
            railarray[0, j] = '\0';
            railarray[1, k] = '\0';
            for (int x = 0; x < 2; ++x)
            {
                for (int y = 0; railarray[x, y] != '\0'; ++y) ciphertext += railarray[x, y];
            }
            return ciphertext;
        }
        // the rail fence decryption logic
        string rfenceDecrypt(string ciphertext)
        {
            string plaintext = null;
            int j = 0, k = 0, mid;
            char[] ctca = ciphertext.ToCharArray();
            char[,] railarray = new char[2, 100];
            if (ctca.Length % 2 == 0) mid = ((ctca.Length) / 2) - 1;
            else mid = (ctca.Length) / 2;
            for (int i = 0; i < ctca.Length; ++i)
            {
                if (i <= mid)
                {
                    railarray[0, j] = ctca[i];
                    ++j;
                }
                else
                {
                    railarray[1, k] = ctca[i];
                    ++k;
                }
            }
            railarray[0, j] = '\0';
            railarray[1, k] = '\0';
            for (int x = 0; x <= mid; ++x)
            {
                if (railarray[0, x] != '\0') plaintext += railarray[0, x];
                if (railarray[1, x] != '\0') plaintext += railarray[1, x];
            }
            return plaintext;
        }
        // the caeser cipher button
        private void btn_one_Click(object sender, EventArgs e)
        {
            string userString = txt_input.Text;
            int key = Convert.ToInt32(txt_key.Text);
            string cipherText = caeserEncipher(userString, key);
            txt_output.Text = cipherText;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        // the des button
        private void button1_Click(object sender, EventArgs e)
        {
            des_output.Text = desEncrypt(des_input.Text, des_key.Text);
        } 
        //the rsa button
        private void btn_three_Click(object sender, EventArgs e)
        {
            plaintext = ByteConverter.GetBytes(rsa_input.Text);
            encryptedtext = rsaEncryption(plaintext, RSA.ExportParameters(false), false);
            rsa_output.Text = ByteConverter.GetString(encryptedtext);
        }
        // the rail fence encryption button
        private void button1_Click_1(object sender, EventArgs e)
        {
            rfence_output.Text = rfenceEncrypt(rfence_input.Text);
        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {

        }
        //the caeser decryption button
        private void btn_caeser_decrypt_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(txt_key.Text);
            caeser_decrypted.Text = caeserdecipher(txt_output.Text, key);
        }
        //the des decryption button
        private void btn_des_decrypt_Click(object sender, EventArgs e)
        {
            des_decrypted.Text = desDecrypt(des_output.Text,des_key.Text) ;
        }
        //the rsa decryption button
        private void btn_rsa_decrypt_Click(object sender, EventArgs e)
        {
            byte[] decryptedtex = rsaDecryption(encryptedtext,RSA.ExportParameters(true), false);
            rsa_decrypted.Text = ByteConverter.GetString(decryptedtex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // the rail fence decryption button
        private void btn_rf_decrypt_Click(object sender, EventArgs e)
        {
            rf_decrypted.Text=  rfenceDecrypt(rfence_output.Text);
        }
    }
}
