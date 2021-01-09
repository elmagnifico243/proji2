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

namespace proji
{
    public partial class Form1 : Form
    {
        public delegate void UpdateControlsDelegate();
        public Form1()
        {
            InitializeComponent();
           /* vlcControl1.Play("file:///C:/Users/h0rk1p/Desktop/project/vids/7s.mp4");*/
            this.vlcControl1.PositionChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs>(this.bunifuProgressBar1_progressChanged);
           /* vlcControl1.Playing += new System.EventHandler<VlcMediaPlayerPlayingEventArgs>(SetProgresMax);*/
        }
        public int a = 0;
        public int c = 0;
        string[] files;
        bool psd;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                files = opf.SafeFileNames;

                 for (int x = 0; x < files.Length; x++)
                 {
                    /* comboBox1.Items.Add(files[x]);*/
                    comboBox1.Items.Insert(x, opf.FileName);
                    
                 }

            }
            if (comboBox1.SelectedItem == null)
            {
                int z = 0;
                comboBox1.SelectedIndex = z;
                comboBox1.SelectedItem = comboBox1.SelectedIndex;
            }
            else
            {
                /* int z = comboBox1.SelectedIndex;
                 z = z + 1;
                 comboBox1.SelectedItem = z;*/
                int z = 0;
                comboBox1.SelectedIndex = z;
                comboBox1.SelectedItem = comboBox1.SelectedIndex;
            }
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            /*if (psd)
            {
                vlcControl1.OnPaused();
                vlcControl1.SetPause(psd);
            }
            else
            {
                vlcControl1.Play();
            }
            vlcControl1.Play(new Uri(comboBox1.SelectedText));*/
            if (psd)
            {
                vlcControl1.Play();
            }
            else
            {
               string test = Convert.ToString(comboBox1.SelectedItem);
               vlcControl1.Play(new Uri(test));
            }
        }

        private void vlcControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Process.Start(System.IO.Directory.GetCurrentDirectory() + "  /../../../YoutubeDownloder/downloader/bin/Debug/downloader.exe");
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            psd = true;
            vlcControl1.SetPause(psd);

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
          /*  OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                files = opf.SafeFileNames;
                textBox1.Text = opf.FileName;
                for (int x = 0; x < files.Length; x++)
                {
                    listBox1.Items.Add(files[x]);
                }
            }
          */
        }


        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = listBox1.GetItemText(listBox1.SelectedItem);
            /*vlcControl1.Play(new Uri(item));*/
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void bunifuImageButton9_Click_1(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized
            ? FormWindowState.Normal
            : FormWindowState.Maximized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
             int z = comboBox1.SelectedIndex;
             int y = z + 1;
             
            if (y == y+1)
            {

            }
            else
            {
                comboBox1.SelectedIndex = y;
            }
            //the next comment is working
           /* comboBox1.SelectedIndex = comboBox1.SelectedIndex + 1;
            comboBox1.SelectedItem = comboBox1.SelectedIndex;*/
            
            /*int z = 0;
            comboBox1.SelectedIndex = z;
            comboBox1.SelectedItem = comboBox1.SelectedIndex;*/
        }

        private void panelLIST_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panelPLAYER_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void bunifuImageButton7_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        

        private void bunifuTrackbar1_ValueChanged(object sender, EventArgs e)
        {
            vlcControl1.Audio.Volume = bunifuTrackbar1.Value;
            label1.Text = bunifuTrackbar1.Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            bunifuTrackbar1.Value = int.Parse(bunifuTrackbar1.Text);

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {
           /* bunifuProgressBar1.Value = (int)vlcControl1.Time / 1000;
            vlcControl1.Time = bunifuProgressBar1.Value * 1000;*/
            int b = (int)vlcControl1.Time / 1000;
            int d = b / 60;
            b = b - d * 60;
          /*  label1.Text = d + ":" + b + "/" + c + ":" + a;*/
            // The Time value is milisecond, you have divide 1000 for be second.
        }

        private void bunifuTrackbar2_ValueChanged(object sender, EventArgs e)
        {
            vlcControl1.VlcMediaPlayer.Time = bunifuTrackbar2.Value * 1000;
            int b = (int)vlcControl1.VlcMediaPlayer.Time / 1000;
            int d = b / 60;
            b = b - d * 60;
            bunifuCustomLabel3.Text = d + ":" + b + "/" + c + ":" + a;
            bunifuTrackbar2.Value = b;
        }

        /*vlcControl1.GetCurrentMedia.duration.totalseconds
        if (vlcControl1.IsPlaying)
        {
            bunifuProgressBar1.MaximumValue = Convert.ToInt32(vlcControl1.Length);

            bunifuProgressBar1.Value = (int)vlcControl1.Position;
            vlcControl1.GetCurrentMedia
            bunifuProgressBar1.MaximumValue = vlcControl1.GetCurrentMedia(Duration.TotalSeconds);
            bunifuProgressBar1.Value = (int)vlcControl1.GetCurrentMedia(duration);*/



    }
}
