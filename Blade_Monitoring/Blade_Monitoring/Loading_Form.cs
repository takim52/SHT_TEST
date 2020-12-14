using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blade_Monitoring
{
    public partial class Loading_Form : Form
    {
        string text = "조회 중...";
        public Loading_Form()
        {
            InitializeComponent();
        }

        public Loading_Form(string txt)
        {
            InitializeComponent();
            text = txt;
            label1.Font = new Font("Tahoma", 36, FontStyle.Bold);
        }

        private void Loading_Form_Load(object sender, EventArgs e)
        {
            label1.Text = text;
        }
    }
}
