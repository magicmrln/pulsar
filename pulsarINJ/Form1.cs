using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzWareINJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point lastPoint;
        public Mem m = new Mem();
        private int ProcessID;
        private bool IsProcOpen;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m.InjectDll(Directory.GetCurrentDirectory() + "/main.dll");
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessID = m.GetProcIdFromName("CombatMaster");
            if (ProcessID != 0)
            {
                IsProcOpen = m.OpenProcess(ProcessID);
                MessageBox.Show("combat master found! press ok to launch the injector");
            } else
            {
                MessageBox.Show("combat master not found");
                Application.Exit();
            }
        }
    }
}
