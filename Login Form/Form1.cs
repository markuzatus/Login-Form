using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_Form
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=CHERNAYADIRA\SQLEXPRESS;Initial Catalog=""Time Register"";Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            //txt_box_PinCode.PasswordChar = '*';
            txt_box_PinCode.MaxLength = 4;

        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (txt_box_PinCode.Text == "0" || (isOperationPerformed))
                txt_box_PinCode.Clear();

            isOperationPerformed = false;

            Button button = (Button)sender;

            //validation on deciamls more than 1
            if (button.Text == ".")
            {
                if (!txt_box_PinCode.Text.Contains("."))
                    txt_box_PinCode.Text += button.Text;
            }
            else
            {
                txt_box_PinCode.Text += button.Text;
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            txt_box_PinCode.Text = "0";
            resultValue = 0;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txt_box_PinCode.Text.Length > 0)
                txt_box_PinCode.Text = txt_box_PinCode.Text.Remove(txt_box_PinCode.Text.Length - 1, 1);

            if (txt_box_PinCode.Text == "")
                txt_box_PinCode.Text = "0";
        }

        private void txt_box_PinCode_TextChanged(object sender, EventArgs e)
        {
            
            if (txt_box_PinCode.Text.Length>4)
            {
                MessageBox.Show("The maximum limit is 4");
            }
        }
    }
}
