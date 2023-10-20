﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before Staring Threading-");
            ThreadStart thread = new ThreadStart(MyThreadClass.Threads);
            Thread ThreadA = new Thread(thread);
            Thread ThreadB = new Thread(thread);
            ThreadA.Start();
            ThreadA.Name = "Thread A Process";
            ThreadB.Start();
            ThreadB.Name = "Thread B Process";
            ThreadA.Join();
            ThreadB.Join();
            Console.WriteLine("-End of Threading-");
            lblThread.Text = "-End of Threading-";
        }
    }
}
