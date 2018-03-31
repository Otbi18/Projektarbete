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

namespace projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string conString = "Data Source=TAN;Initial Catalog=projektarbete;User ID=SA;Password=***********";

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
