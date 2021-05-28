using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace baitaplonhedieuhanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Loadstatusbar();
        }
        
       // khai bao bien dem nguoc thoi gian
        decimal downTime;
        StatusBarPanel downTimePanel = new StatusBarPanel();
        StatusBarPanel barPanel = new StatusBarPanel();
             // khoi tao statusbar
        void Loadstatusbar()
        {
            StatusBar bar = new StatusBar();
            bar.ShowPanels = true;
            bar.Panels.Add(barPanel);
            bar.Panels.Add(downTimePanel);
            downTimePanel.Text = "";
            barPanel.Text = "đang đợi...";// khi chua thuc hien len se xuat hien dang doi

            this.Controls.Add(bar);
        }
        // gan su kien cho nut restart
        private void btrestart_Click(object sender, EventArgs e)
        {
            calculateDownTime();
            shutdown("-r -t "+ downTime.ToString());
            barPanel.Text = "đang khởi động lại...";// 
            timer1.Start();
        }
        // tao gia tri cho dong ho dem gio
        void calculateDownTime()
        {
            downTime = nudgiay.Value + nudphut.Value * 60 + nudgio.Value * 60 * 60;
        }
        private void nudgiay_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;
            if (box.Value>=60)
            {
                nudphut.Value++;
                box.Value = 0;
            }    
        }

        private void nudphut_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown box = sender as NumericUpDown;
            if (box.Value >= 60)
            {
                nudgio.Value++;
                box.Value = 0;
            }
        }
        // goi  ham tren command
        void shutdown( string command)
        {   
            System.Diagnostics.Process.Start("shutdown", command);
        }

        private void bthuylenh_Click(object sender, EventArgs e)
        {
            shutdown("-a");
            barPanel.Text = " đang đợi...";
            downTimePanel.Text = "";
            timer1.Stop();
        }

        private void btshutdown_Click(object sender, EventArgs e)
        {
            calculateDownTime();
            shutdown("-s -t "+downTime.ToString());
            barPanel.Text = "Shutting down";
            timer1.Start();
        }
        // dong ho dem nguoc
        private void timer1_Tick(object sender, EventArgs e)
        {
           
                downTime--;
                downTimePanel.Text = downTime.ToString();
            
        }
        // mo word
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("winword");
        }
        // mo excel
        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("excel");
        }
        // mo notepad
        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }
        // mo paint
        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");
        }
        //  mo may tinh
        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }
        // tat app khi an not dong tat ca cac app
        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName(comboBox1.Text))
                process.Kill();
        }
    }
}
