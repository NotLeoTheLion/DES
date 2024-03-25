using DES.Classes;
using DES.CLasses;
using System.Security.Cryptography;
using System.Text;

namespace DES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cipher cipher = new Cipher();
        Files file = new Files();

        private void Encryption()
        {
            string selectedMode = comboBoxMode.SelectedItem.ToString();
            switch (selectedMode)
            {
                case "ECB":
                    string ECB = cipher.Encrypt(txtBoxText.Text, txtBoxKey.Text, CipherMode.ECB);
                    txtBoxResult.Text = ECB;
                    break;
                case "CBC":
                    string CBC = cipher.Encrypt(txtBoxText.Text, txtBoxKey.Text, CipherMode.CBC);
                    txtBoxResult.Text = CBC;
                    break;
                case "CFB":
                    string CFB = cipher.Encrypt(txtBoxText.Text, txtBoxKey.Text, CipherMode.CFB);
                    txtBoxResult.Text = CFB;
                    break;
                default:
                    MessageBox.Show("Choose a mode");
                    break;

            }

        }
        private void Decryption(string encrypted)
        {
            string selectedMode = comboBoxMode.SelectedItem.ToString();
            switch (selectedMode)
            {
                case "ECB":
                    string ECB = cipher.Decrypt(encrypted, txtBoxKey.Text, CipherMode.ECB);
                    txtBoxResult.Text = ECB;
                    break;
                case "CBC":
                    string CBC = cipher.Decrypt(encrypted, txtBoxKey.Text, CipherMode.CBC);
                    txtBoxResult.Text = CBC;
                    break;
                case "CFB":
                    string CFB = cipher.Decrypt(encrypted, txtBoxKey.Text, CipherMode.CFB);
                    txtBoxResult.Text = CFB;
                    break;
                default:
                    MessageBox.Show("Choose a mode");
                    break;
            }
        }

        private bool chechTextBox()
        {
            if (txtBoxText.Text == "")
            {
                MessageBox.Show("Input text");
                return false;
            }
            if (txtBoxKey.Text.Length != 8)
            {
                MessageBox.Show("Input a key that is 8 symbols");
                return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = chechTextBox();
            if (check)
            {
                string value = comboBox.SelectedItem.ToString();
                switch (value)
                {
                    case "Cypher":
                        Encryption();
                        break;
                    case "Decypher":
                        Decryption(txtBoxResult.Text);
                        break;
                    default:
                        MessageBox.Show("Choose Cypher/Decypher");
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            file.saveTextFile(txtBoxResult.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBoxText.Text = file.openTextFile();
        }
    }
}
