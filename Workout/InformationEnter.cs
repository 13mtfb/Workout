﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workout
{
    public partial class InformationEnter : Form
    {
        public bool ok;
        public InformationEnter()
        {
            
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
            ok = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
            ok = false;
        }
    }
}