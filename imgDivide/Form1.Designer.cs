namespace imgDivide
{
    partial class frm_divide
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
            this.btnSource = new System.Windows.Forms.Button();
            this.txt_source = new System.Windows.Forms.TextBox();
            this.txt_destination = new System.Windows.Forms.TextBox();
            this.btnDestination = new System.Windows.Forms.Button();
            this.txt_interval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_doit = new System.Windows.Forms.Button();
            this.fBD = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(422, 12);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 23);
            this.btnSource.TabIndex = 0;
            this.btnSource.Text = "Source";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // txt_source
            // 
            this.txt_source.Location = new System.Drawing.Point(10, 12);
            this.txt_source.Name = "txt_source";
            this.txt_source.Size = new System.Drawing.Size(388, 20);
            this.txt_source.TabIndex = 1;
            // 
            // txt_destination
            // 
            this.txt_destination.Location = new System.Drawing.Point(10, 48);
            this.txt_destination.Name = "txt_destination";
            this.txt_destination.Size = new System.Drawing.Size(388, 20);
            this.txt_destination.TabIndex = 2;
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(422, 44);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(75, 23);
            this.btnDestination.TabIndex = 3;
            this.btnDestination.Text = "Destination";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // txt_interval
            // 
            this.txt_interval.Location = new System.Drawing.Point(298, 87);
            this.txt_interval.Name = "txt_interval";
            this.txt_interval.Size = new System.Drawing.Size(100, 20);
            this.txt_interval.TabIndex = 4;
            this.txt_interval.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Session interval";
            // 
            // btn_doit
            // 
            this.btn_doit.Location = new System.Drawing.Point(422, 171);
            this.btn_doit.Name = "btn_doit";
            this.btn_doit.Size = new System.Drawing.Size(75, 23);
            this.btn_doit.TabIndex = 6;
            this.btn_doit.Text = "Do it";
            this.btn_doit.UseVisualStyleBackColor = true;
            this.btn_doit.Click += new System.EventHandler(this.btn_doit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prefix";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "ROOM1_MMDD";
            // 
            // frm_divide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 206);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_doit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_interval);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.txt_destination);
            this.Controls.Add(this.txt_source);
            this.Controls.Add(this.btnSource);
            this.Name = "frm_divide";
            this.Text = "Divide images to folders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TextBox txt_source;
        private System.Windows.Forms.TextBox txt_destination;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.TextBox txt_interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_doit;
        private System.Windows.Forms.FolderBrowserDialog fBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

