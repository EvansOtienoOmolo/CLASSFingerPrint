namespace CLASSFingerPrint
{
    partial class Registration
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
            this.Rname = new System.Windows.Forms.Label();
            this.Rnumber = new System.Windows.Forms.Label();
            this.Register_bt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.R_number = new System.Windows.Forms.TextBox();
            this.R_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Rname
            // 
            this.Rname.AutoSize = true;
            this.Rname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rname.Location = new System.Drawing.Point(25, 41);
            this.Rname.Name = "Rname";
            this.Rname.Size = new System.Drawing.Size(42, 13);
            this.Rname.TabIndex = 0;
            this.Rname.Text = "NAME";
            // 
            // Rnumber
            // 
            this.Rnumber.AutoSize = true;
            this.Rnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rnumber.Location = new System.Drawing.Point(25, 116);
            this.Rnumber.Name = "Rnumber";
            this.Rnumber.Size = new System.Drawing.Size(59, 13);
            this.Rnumber.TabIndex = 1;
            this.Rnumber.Text = "REG NO.";
            // 
            // Register_bt
            // 
            this.Register_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_bt.Location = new System.Drawing.Point(378, 295);
            this.Register_bt.Name = "Register_bt";
            this.Register_bt.Size = new System.Drawing.Size(75, 23);
            this.Register_bt.TabIndex = 2;
            this.Register_bt.Text = "Register";
            this.Register_bt.UseVisualStyleBackColor = true;
            this.Register_bt.Click += new System.EventHandler(this.Register_bt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(187, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 126);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // R_number
            // 
            this.R_number.Location = new System.Drawing.Point(155, 113);
            this.R_number.Name = "R_number";
            this.R_number.Size = new System.Drawing.Size(155, 20);
            this.R_number.TabIndex = 4;
            // 
            // R_name
            // 
            this.R_name.Location = new System.Drawing.Point(147, 34);
            this.R_name.Name = "R_name";
            this.R_name.Size = new System.Drawing.Size(163, 20);
            this.R_name.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(204, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(201, 136);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "forgort reg no.";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(204, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "pic";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(482, 401);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.R_name);
            this.Controls.Add(this.R_number);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Register_bt);
            this.Controls.Add(this.Rnumber);
            this.Controls.Add(this.Rname);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rname;
        private System.Windows.Forms.Label Rnumber;
        private System.Windows.Forms.Button Register_bt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox R_number;
        private System.Windows.Forms.TextBox R_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
    }
}