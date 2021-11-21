using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDollibee
{
    public partial class Form2 : Form
    {
        Form1 form1;

        public Form2()
        {
        }

        public Form2(Form1 frm1)
        {
            InitializeComponent();
            this.form1 = frm1;
        }
    }
}
