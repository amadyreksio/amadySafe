namespace amadySafe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.amadyButton2 = new amadyUI.amadyButton();
            this.amadyButton1 = new amadyUI.amadyButton();
            this.removeBtn = new amadyUI.amadyButton();
            this.addBtn = new amadyUI.amadyButton();
            this.roundifier1 = new amadyUI.Roundifier();
            this.label1 = new System.Windows.Forms.Label();
            this.roundifier2 = new amadyUI.Roundifier();
            this.fancyProgressBar1 = new amadyUI.FancyProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.statustext = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 41);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 399);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.amadyButton2);
            this.panel1.Controls.Add(this.amadyButton1);
            this.panel1.Controls.Add(this.removeBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(800, 37);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // amadyButton2
            // 
            this.amadyButton2.BackColor = System.Drawing.Color.Transparent;
            this.amadyButton2.BackgroundImageHeight = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.amadyButton2.BackgroundImageWidth = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.amadyButton2.BorderRadius = 8;
            this.amadyButton2.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.amadyButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.amadyButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.amadyButton2.Icon = global::amadySafe.Properties.Resources.settings;
            this.amadyButton2.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.amadyButton2.Location = new System.Drawing.Point(765, 0);
            this.amadyButton2.Name = "amadyButton2";
            this.amadyButton2.selected = false;
            this.amadyButton2.Size = new System.Drawing.Size(35, 37);
            this.amadyButton2.TabIndex = 3;
            this.amadyButton2.text = "-";
            this.amadyButton2.TextStroke = 1;
            this.amadyButton2.TextStrokeColor = System.Drawing.Color.Black;
            this.amadyButton2.Click += new System.EventHandler(this.amadyButton2_Click);
            // 
            // amadyButton1
            // 
            this.amadyButton1.BackColor = System.Drawing.Color.Transparent;
            this.amadyButton1.BackgroundImageHeight = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.amadyButton1.BackgroundImageWidth = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.amadyButton1.BorderRadius = 8;
            this.amadyButton1.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.amadyButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.amadyButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.amadyButton1.Icon = global::amadySafe.Properties.Resources.edit;
            this.amadyButton1.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.amadyButton1.Location = new System.Drawing.Point(80, 0);
            this.amadyButton1.Name = "amadyButton1";
            this.amadyButton1.selected = false;
            this.amadyButton1.Size = new System.Drawing.Size(35, 37);
            this.amadyButton1.TabIndex = 2;
            this.amadyButton1.text = "-";
            this.amadyButton1.TextStroke = 1;
            this.amadyButton1.TextStrokeColor = System.Drawing.Color.Black;
            this.amadyButton1.Click += new System.EventHandler(this.amadyButton1_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Transparent;
            this.removeBtn.BackgroundImageHeight = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.removeBtn.BackgroundImageWidth = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.removeBtn.BorderRadius = 8;
            this.removeBtn.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.removeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.removeBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.removeBtn.Icon = global::amadySafe.Properties.Resources.remove;
            this.removeBtn.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.removeBtn.Location = new System.Drawing.Point(45, 0);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.selected = false;
            this.removeBtn.Size = new System.Drawing.Size(35, 37);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.text = "-";
            this.removeBtn.TextStroke = 1;
            this.removeBtn.TextStrokeColor = System.Drawing.Color.Black;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BackgroundImageHeight = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.addBtn.BackgroundImageWidth = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.addBtn.BorderRadius = 8;
            this.addBtn.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.addBtn.Icon = global::amadySafe.Properties.Resources.upload;
            this.addBtn.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.addBtn.Location = new System.Drawing.Point(10, 0);
            this.addBtn.Name = "addBtn";
            this.addBtn.selected = false;
            this.addBtn.Size = new System.Drawing.Size(35, 37);
            this.addBtn.TabIndex = 0;
            this.addBtn.text = "+";
            this.addBtn.TextStroke = 1;
            this.addBtn.TextStrokeColor = System.Drawing.Color.Black;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // roundifier1
            // 
            this.roundifier1.borderRadius = 16;
            this.roundifier1.control = this.panel1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(0, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 4);
            this.label1.TabIndex = 2;
            this.label1.Text = "ReksioAmSmoosh";
            // 
            // roundifier2
            // 
            this.roundifier2.borderRadius = 16;
            this.roundifier2.control = this.listView1;
            // 
            // fancyProgressBar1
            // 
            this.fancyProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.fancyProgressBar1.backgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fancyProgressBar1.barColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.fancyProgressBar1.BorderRadius = 10;
            this.fancyProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fancyProgressBar1.Location = new System.Drawing.Point(0, 440);
            this.fancyProgressBar1.Max = 100;
            this.fancyProgressBar1.Min = 0;
            this.fancyProgressBar1.Name = "fancyProgressBar1";
            this.fancyProgressBar1.Size = new System.Drawing.Size(800, 10);
            this.fancyProgressBar1.TabIndex = 3;
            this.fancyProgressBar1.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.logo.Image = global::amadySafe.Properties.Resources.amadySafe;
            this.logo.Location = new System.Drawing.Point(359, 171);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(114, 99);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // statustext
            // 
            this.statustext.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statustext.ForeColor = System.Drawing.Color.White;
            this.statustext.Location = new System.Drawing.Point(0, 427);
            this.statustext.Name = "statustext";
            this.statustext.Size = new System.Drawing.Size(800, 13);
            this.statustext.TabIndex = 6;
            this.statustext.Text = "Status";
            this.statustext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statustext);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fancyProgressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Amady Safe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private amadyUI.Roundifier roundifier1;
        private System.Windows.Forms.Label label1;
        private amadyUI.Roundifier roundifier2;
        private amadyUI.amadyButton addBtn;
        private amadyUI.amadyButton removeBtn;
        private amadyUI.FancyProgressBar fancyProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox logo;
        private amadyUI.amadyButton amadyButton1;
        private amadyUI.amadyButton amadyButton2;
        private System.Windows.Forms.Label statustext;
    }
}

