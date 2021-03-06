using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CommonSuite
{
    public partial class frmSearchMaps : DevExpress.XtraEditors.XtraForm
    {
        public frmSearchMaps()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public bool SearchForNumericValues
        {
            get
            {
                return checkEdit3.Checked;
            }
        }
        public bool SearchForStringValues
        {
            get
            {
                return checkEdit4.Checked;
            }
        }

        public bool IncludeSymbolNames
        {
            get
            {
                return checkEdit1.Checked;
            }
        }

        public bool IncludeSymbolDescription
        {
            get
            {
                return checkEdit2.Checked;
            }
        }

        public bool UseSpecificMapLength
        {
            get
            {
                return checkEdit5.Checked;
            }
        }

        public decimal MapLength
        {
            get
            {
                return spinEdit2.Value;
            }
        }


        public decimal NumericValueToSearchFor
        {
            get
            {
                return spinEdit1.Value;
            }
        }

        public string StringValueToSearchFor
        {
            get
            {
                return textEdit1.Text;
            }
        }

        private void checkEdit5_CheckedChanged(object sender, EventArgs e)
        {
            spinEdit2.Enabled = checkEdit5.Checked;
        }

    }
}