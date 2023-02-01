using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckPhone_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;
            string phoneLast = CheckPhone(phoneNumber);
            if (phoneLast.Contains("Hata"))
            {
                MessageBox.Show(phoneLast);
            }
            else
            {
                MessageBox.Show($"{ phoneLast } telefona mesaj gonderilmistir.");
            }
        }
        public string CheckPhone(string phone)
        {
            try
            {
                if (phone == "")
                {
                    return "Hata mesaji => l]tfen telefon alanini doldurun";
                }
                phone = phone.Replace(" ", "");
                phone = phone.Replace("+", "");
                string firstCharacter = phone.Substring(0, 1);
                if (firstCharacter == "9")
                {
                    phone = phone.Substring(1, phone.Length - 1);
                }
                else if (firstCharacter != "0")
                {
                    phone = "0" + phone;
                }
                if (phone.Length == 11)
                {
                    Convert.ToDouble(phone);
                    return phone;
                }
                return "Hata mesaji. Lutfen telefon formatini kontrol ediniz. 11 hane olmalidir";
            }
            catch (FormatException)
            {

                return "Hata mesaji => L]tfen uygun format ile telefon giriniz";
            }
            catch(Exception)
            {
                return "Hata mesaji => Bilinmeyen hata lutfen telefon numarasini tekrar giriniz";
            }
        }
    }
}
