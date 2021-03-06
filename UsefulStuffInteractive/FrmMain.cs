﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsefulStuffPortable.Utilities;
using UsefulStuffPortable.Extensions;

namespace UsefulStuffInteractive
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnReplaceAtTest_Click(object sender, EventArgs e)
        {
            ReplaceString();
        }

        private void ReplaceString()
        {
            List<string> list = new List<string>
            {
                "Apple",
                "Orange",
                "Lemon"
            };

            Console.WriteLine("Old list: ");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            list.ReplaceAt("Apple", "Pear");

            Console.WriteLine("New list: ");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
