namespace amadySafe
{
    partial class SafeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafeEditor));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundifier1 = new amadyUI.Roundifier();
            this.label1 = new System.Windows.Forms.Label();
            this.amadyButton1 = new amadyUI.amadyButton();
            this.amadyButton2 = new amadyUI.amadyButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(17, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '•';
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(114, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 52);
            this.panel1.TabIndex = 1;
            // 
            // roundifier1
            // 
            this.roundifier1.borderRadius = 16;
            this.roundifier1.control = this.panel1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Safe password:";
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
            this.amadyButton1.BorderRadius = 16;
            this.amadyButton1.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.amadyButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.amadyButton1.Icon = null;
            this.amadyButton1.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.amadyButton1.Location = new System.Drawing.Point(75, 317);
            this.amadyButton1.Name = "amadyButton1";
            this.amadyButton1.selected = false;
            this.amadyButton1.Size = new System.Drawing.Size(248, 61);
            this.amadyButton1.TabIndex = 3;
            this.amadyButton1.text = "OK";
            this.amadyButton1.TextStroke = 1;
            this.amadyButton1.TextStrokeColor = System.Drawing.Color.Black;
            this.amadyButton1.Click += new System.EventHandler(this.amadyButton1_Click);
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
            this.amadyButton2.BorderRadius = 16;
            this.amadyButton2.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.amadyButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.amadyButton2.Icon = global::amadySafe.Properties.Resources.show;
            this.amadyButton2.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.amadyButton2.Location = new System.Drawing.Point(311, 114);
            this.amadyButton2.Name = "amadyButton2";
            this.amadyButton2.selected = false;
            this.amadyButton2.Size = new System.Drawing.Size(52, 52);
            this.amadyButton2.TabIndex = 4;
            this.amadyButton2.text = "";
            this.amadyButton2.TextStroke = 1;
            this.amadyButton2.TextStrokeColor = System.Drawing.Color.Black;
            this.amadyButton2.Click += new System.EventHandler(this.amadyButton2_Click);
            // 
            // SafeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(381, 390);
            this.Controls.Add(this.amadyButton2);
            this.Controls.Add(this.amadyButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SafeEditor";
            this.Text = "SafeEditor";
            this.Load += new System.EventHandler(this.SafeEditor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private amadyUI.Roundifier roundifier1;
        private System.Windows.Forms.Label label1;
        private amadyUI.amadyButton amadyButton1;
        private amadyUI.amadyButton amadyButton2;
    }
}