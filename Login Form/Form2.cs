using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlTypes;

namespace Login_Form
{
    public partial class Form2 : Form
    {
        public Form2(string Name)
        {
            InitializeComponent();

            // Set the label text to display the user's name and current date/time
            lbl_Name.Text = $"Welcome, {Name}";
            lbl_Time.Text = $"Current Date/Time: {DateTime.Now}";
        }
    }
}
