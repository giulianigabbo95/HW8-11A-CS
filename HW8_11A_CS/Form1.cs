using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework
{
    public partial class Form1 : Form
    {
        private int m;          // n. of paths
        private int n;          // number of points for each path
        private double lamba;   // lamba factor
        private int t;          // point at time T
        private int c;          // nb of clusters for histograms

        private Distribution RN;

        private ggPictureBox ggPictureBox1;
        private ggPictureBox ggPictureBox2;
        private ggPictureBox ggPictureBox3;

        public Form1()
        {
            InitializeComponent();

            ggPictureBox2 = new ggPictureBox(MainPanel);
            ggPictureBox2.BackColor = Color.White;
            ggPictureBox2.Top = 0; 
            ggPictureBox2.Left = 0;
            ggPictureBox2.Height = MainPanel.Height / 2;
            ggPictureBox2.Width = MainPanel.Width / 3;
            ggPictureBox2.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.Controls.Add(ggPictureBox2);

            ggPictureBox3 = new ggPictureBox(MainPanel);
            ggPictureBox3.BackColor = Color.White;
            ggPictureBox3.Top = ggPictureBox2.Top + ggPictureBox2.Height;
            ggPictureBox3.Left = 0;
            ggPictureBox3.Height = MainPanel.Height / 2;
            ggPictureBox3.Width = MainPanel.Width / 3;
            ggPictureBox3.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.Controls.Add(ggPictureBox3);

            ggPictureBox1 = new ggPictureBox(MainPanel);
            ggPictureBox1.BackColor = Color.White;
            ggPictureBox1.Top = 0;      
            ggPictureBox1.Left = MainPanel.Left + ggPictureBox2.Width;  
            ggPictureBox1.Height = MainPanel.Height;
            ggPictureBox1.Width = MainPanel.Width - ggPictureBox2.Width; 
            ggPictureBox1.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.Controls.Add(ggPictureBox1);

            tbTPoint.Minimum = 1;
            tbTPoint.Maximum = (int)NbPoints.Value;
            tbTPoint.Value = (int)Math.Ceiling((double)NbPoints.Value / 2);

            NbPoints.Value = 10;
            NbClusters.Value = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetVariables();
        }

        // Events
        //--------------------------------------------------------

        private void btnRecalc_Click(object sender, EventArgs e)
        {
            SetVariables();

            tbTPoint.Minimum = 1;
            tbTPoint.Maximum = n;

            CreateStatEngineInstance();
            DrawChart();
        }

        private void NbPoints_ValueChanged(object sender, EventArgs e)
        {
            SetVariables();

            tbTPoint.Maximum = n;
            t = tbTPoint.Value = (int)Math.Ceiling((double)n / 2);

            CreateStatEngineInstance();
            DrawChart();
        }

        private void variance_ValueChanged(object sender, EventArgs e)
        {
            SetVariables();
            CreateStatEngineInstance();
            DrawChart();
        }

        private void NbPath_ValueChanged(object sender, EventArgs e)
        {
            SetVariables();
            CreateStatEngineInstance();
            DrawChart();
        }

        private void cmbDistribution_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetVariables();
            CreateStatEngineInstance();
            DrawChart();
        }

        private void tbTPoint_ValueChanged(object sender, EventArgs e)
        {
            t = tbTPoint.Value;
            DrawChart();
        }

        private void btnClusters_Click(object sender, EventArgs e)
        {
            SetVariables();
            DrawChart();

        }

        private void NbClusters_ValueChanged(object sender, EventArgs e)
        {
            SetVariables();
            DrawChart();
        }

        // Methods
        //--------------------------------------------------------

        private void SetVariables()
        {
            n = (int)NbPoints.Value;
            m = (int)NbPath.Value;
            lamba = (double)LambaVal.Value;
            t = tbTPoint.Value;
            c = (int)NbClusters.Value;
        }

        private void CreateStatEngineInstance()
        {
            RN = new Distribution(n, m, lamba);
            RN.Paths = RN.GenerateDistribution();
            RN.DistanceFromOrigin = RN.GenerateDistanceFromOriginSequence();
            RN.DistanceFromPrevious = RN.GenerateDistanceFromPreviousSequence();
        }

        private void DrawChart()
        {
            if (RN != null)
            {
                ChartManager CM = new ChartManager(RN, ggPictureBox1, t);
                CM.DrawChart(c);

                CM = new ChartManager(RN, ggPictureBox2, -1);
                CM.DrawDistancesFromOrigin(c);

                CM = new ChartManager(RN, ggPictureBox3, -2);
                CM.DrawDistancesFromPrevious(c);
            }
        }
    }
}
