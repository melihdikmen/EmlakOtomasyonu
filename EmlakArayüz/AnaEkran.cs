﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmlakArayüz
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayıtEkranı form = new KayıtEkranı();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SorgulamaEkranı form = new SorgulamaEkranı();
            form.Show();
        }

        

     

       
    }
}
