using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            spinEdit1.KeyPress += new KeyPressEventHandler(spinEdit1_KeyPress);
            spinEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }
        void spinEdit1_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }
    }
}