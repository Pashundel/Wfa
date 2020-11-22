namespace Wfa
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.directory_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sourceDirectory = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.destinationDirectory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.directory_button);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 513);
            this.panel1.TabIndex = 0;
            // 
            // directory_button
            // 
            this.directory_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directory_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directory_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directory_button.ForeColor = System.Drawing.Color.Navy;
            this.directory_button.Location = new System.Drawing.Point(60, 288);
            this.directory_button.Name = "directory_button";
            this.directory_button.Size = new System.Drawing.Size(383, 122);
            this.directory_button.TabIndex = 1;
            this.directory_button.Text = "Конвертувати";
            this.directory_button.UseVisualStyleBackColor = false;
            this.directory_button.Click += new System.EventHandler(this.transform_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 513);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Location = new System.Drawing.Point(9, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 205);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.sourceDirectory);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.destinationDirectory);
            this.panel3.Location = new System.Drawing.Point(9, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 160);
            this.panel3.TabIndex = 6;
            // 
            // sourceDirectory
            // 
            this.sourceDirectory.BackColor = System.Drawing.Color.MintCream;
            this.sourceDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sourceDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sourceDirectory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sourceDirectory.Location = new System.Drawing.Point(38, 13);
            this.sourceDirectory.Name = "sourceDirectory";
            this.sourceDirectory.Size = new System.Drawing.Size(168, 44);
            this.sourceDirectory.TabIndex = 1;
            this.sourceDirectory.Text = "Обрати директорію звідки";
            this.sourceDirectory.UseVisualStyleBackColor = false;
            this.sourceDirectory.Click += new System.EventHandler(this.sourceDirectory_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(281, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // destinationDirectory
            // 
            this.destinationDirectory.BackColor = System.Drawing.Color.MintCream;
            this.destinationDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.destinationDirectory.FlatAppearance.BorderSize = 2;
            this.destinationDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.destinationDirectory.Location = new System.Drawing.Point(281, 13);
            this.destinationDirectory.Name = "destinationDirectory";
            this.destinationDirectory.Size = new System.Drawing.Size(168, 44);
            this.destinationDirectory.TabIndex = 2;
            this.destinationDirectory.Text = "Обрати директорію куди";
            this.destinationDirectory.UseVisualStyleBackColor = false;
            this.destinationDirectory.Click += new System.EventHandler(this.destinationDirectory_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 513);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button directory_button;
        private System.Windows.Forms.Button destinationDirectory;
        private System.Windows.Forms.Button sourceDirectory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}