﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skork.frm {
    public partial class frmDebug : Form {
        public frmDebug() {
            InitializeComponent();
        }

        private void frmDebug_Load(object sender, EventArgs e) {
            this.Icon = Properties.Resources.skork_icon;

        }
    }
}