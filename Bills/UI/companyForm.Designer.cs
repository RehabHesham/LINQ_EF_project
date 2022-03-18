namespace Bills.UI
{
    partial class companyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_compName = new System.Windows.Forms.TextBox();
            this.txt_compNotes = new System.Windows.Forms.RichTextBox();
            this.btn_compCancle = new System.Windows.Forms.Button();
            this.btn_compSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Data Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Notes :";
            // 
            // txt_compName
            // 
            this.txt_compName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_compName.Location = new System.Drawing.Point(260, 148);
            this.txt_compName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_compName.Name = "txt_compName";
            this.txt_compName.Size = new System.Drawing.Size(344, 32);
            this.txt_compName.TabIndex = 4;
            // 
            // txt_compNotes
            // 
            this.txt_compNotes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_compNotes.Location = new System.Drawing.Point(260, 212);
            this.txt_compNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_compNotes.Name = "txt_compNotes";
            this.txt_compNotes.Size = new System.Drawing.Size(344, 119);
            this.txt_compNotes.TabIndex = 5;
            this.txt_compNotes.Text = "";
            // 
            // btn_compCancle
            // 
            this.btn_compCancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_compCancle.Image = global::Bills.Properties.Resources.cancle;
            this.btn_compCancle.Location = new System.Drawing.Point(206, 382);
            this.btn_compCancle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_compCancle.Name = "btn_compCancle";
            this.btn_compCancle.Size = new System.Drawing.Size(151, 49);
            this.btn_compCancle.TabIndex = 7;
            this.btn_compCancle.UseVisualStyleBackColor = true;
            this.btn_compCancle.Click += new System.EventHandler(this.btn_compCancle_Click);
            // 
            // btn_compSave
            // 
            this.btn_compSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_compSave.Image = global::Bills.Properties.Resources.save;
            this.btn_compSave.Location = new System.Drawing.Point(414, 382);
            this.btn_compSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_compSave.Name = "btn_compSave";
            this.btn_compSave.Size = new System.Drawing.Size(116, 49);
            this.btn_compSave.TabIndex = 6;
            this.btn_compSave.UseVisualStyleBackColor = true;
            this.btn_compSave.Click += new System.EventHandler(this.btn_compSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(470, 345);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 16);
            this.label_error.TabIndex = 8;
            // 
            // companyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(710, 468);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.btn_compCancle);
            this.Controls.Add(this.btn_compSave);
            this.Controls.Add(this.txt_compNotes);
            this.Controls.Add(this.txt_compName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "companyForm";
            this.Text = "companyForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_compName;
        private System.Windows.Forms.RichTextBox txt_compNotes;
        private System.Windows.Forms.Button btn_compSave;
        private System.Windows.Forms.Button btn_compCancle;
        private System.Windows.Forms.Label label_error;
    }
}