namespace MyHomework
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTPoint = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NbClusters = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClusters = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LambaVal = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NbPath = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.NbPoints = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRecalc = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTPoint)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbClusters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LambaVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbTPoint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 617);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 46);
            this.panel1.TabIndex = 40;
            // 
            // tbTPoint
            // 
            this.tbTPoint.BackColor = System.Drawing.Color.Black;
            this.tbTPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTPoint.Location = new System.Drawing.Point(0, 0);
            this.tbTPoint.Maximum = 100000;
            this.tbTPoint.Minimum = 1;
            this.tbTPoint.Name = "tbTPoint";
            this.tbTPoint.Size = new System.Drawing.Size(1333, 44);
            this.tbTPoint.TabIndex = 8;
            this.tbTPoint.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbTPoint.Value = 1;
            this.tbTPoint.ValueChanged += new System.EventHandler(this.tbTPoint_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.NbClusters);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnClusters);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.LambaVal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.NbPath);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.NbPoints);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnRecalc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1335, 80);
            this.panel2.TabIndex = 41;
            // 
            // NbClusters
            // 
            this.NbClusters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbClusters.Location = new System.Drawing.Point(692, 33);
            this.NbClusters.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NbClusters.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NbClusters.Name = "NbClusters";
            this.NbClusters.Size = new System.Drawing.Size(77, 23);
            this.NbClusters.TabIndex = 53;
            this.NbClusters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NbClusters.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NbClusters.ValueChanged += new System.EventHandler(this.NbClusters_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(625, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "No Clusters";
            // 
            // btnClusters
            // 
            this.btnClusters.BackColor = System.Drawing.Color.Transparent;
            this.btnClusters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClusters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClusters.ForeColor = System.Drawing.Color.Black;
            this.btnClusters.Location = new System.Drawing.Point(775, 31);
            this.btnClusters.Name = "btnClusters";
            this.btnClusters.Size = new System.Drawing.Size(79, 24);
            this.btnClusters.TabIndex = 52;
            this.btnClusters.Text = "Redraw";
            this.btnClusters.UseVisualStyleBackColor = false;
            this.btnClusters.Click += new System.EventHandler(this.btnClusters_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(24, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Parameters";
            // 
            // LambaVal
            // 
            this.LambaVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LambaVal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LambaVal.Location = new System.Drawing.Point(394, 20);
            this.LambaVal.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.LambaVal.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.LambaVal.Name = "LambaVal";
            this.LambaVal.Size = new System.Drawing.Size(79, 23);
            this.LambaVal.TabIndex = 50;
            this.LambaVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LambaVal.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.LambaVal.ValueChanged += new System.EventHandler(this.variance_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(320, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "λ (Lamba):";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(941, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "You can move the chart inside the viewport or resize it using bottom-right corner" +
    "";
            // 
            // NbPath
            // 
            this.NbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbPath.Location = new System.Drawing.Point(225, 48);
            this.NbPath.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NbPath.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbPath.Name = "NbPath";
            this.NbPath.Size = new System.Drawing.Size(76, 23);
            this.NbPath.TabIndex = 44;
            this.NbPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NbPath.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbPath.ValueChanged += new System.EventHandler(this.NbPath_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(168, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "m (Paths)";
            // 
            // NbPoints
            // 
            this.NbPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbPoints.Location = new System.Drawing.Point(225, 19);
            this.NbPoints.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NbPoints.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NbPoints.Name = "NbPoints";
            this.NbPoints.Size = new System.Drawing.Size(76, 23);
            this.NbPoints.TabIndex = 42;
            this.NbPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NbPoints.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NbPoints.ValueChanged += new System.EventHandler(this.NbPoints_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(168, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "n (Points)";
            // 
            // btnRecalc
            // 
            this.btnRecalc.BackColor = System.Drawing.Color.Transparent;
            this.btnRecalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRecalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecalc.ForeColor = System.Drawing.Color.Black;
            this.btnRecalc.Location = new System.Drawing.Point(493, 20);
            this.btnRecalc.Name = "btnRecalc";
            this.btnRecalc.Size = new System.Drawing.Size(84, 46);
            this.btnRecalc.TabIndex = 40;
            this.btnRecalc.Text = "Recalc";
            this.btnRecalc.UseVisualStyleBackColor = false;
            this.btnRecalc.Click += new System.EventHandler(this.btnRecalc_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.Color.Teal;
            this.MainPanel.Location = new System.Drawing.Point(0, 80);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1335, 537);
            this.MainPanel.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(941, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "NAVY viewport = Distance from origin ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(941, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "GREEN viewport = Consecutive distance ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1335, 663);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Rademacher | Normal Distributions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTPoint)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbClusters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LambaVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tbTPoint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown LambaVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NbPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NbPoints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRecalc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NbClusters;
        private System.Windows.Forms.Button btnClusters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

