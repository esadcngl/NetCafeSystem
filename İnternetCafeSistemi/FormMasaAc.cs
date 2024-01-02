using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnternetCafeSistemi
{
    public partial class FormMasaAc : Form
    {
        public FormMasaAc()
        {
            InitializeComponent();
           
        }
        RadioButton radio;
        private void radioSüresiz_CheckedChanged(object sender, EventArgs e)
        {
            radio = sender as RadioButton;
            if (radio == radioSüreli)
            {
                comboSüreli.Visible = true;
            }
            else
            {
                comboSüreli.Visible = false;
            }
        }

    }
}
