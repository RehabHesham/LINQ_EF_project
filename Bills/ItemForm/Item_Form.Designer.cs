﻿namespace Bills.ItemForm
{
    partial class Item_Form
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
            this.Spliter = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Spliter)).BeginInit();
            this.Spliter.Panel1.SuspendLayout();
            this.Spliter.Panel2.SuspendLayout();
            this.Spliter.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spliter
            // 
            this.Spliter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spliter.Location = new System.Drawing.Point(0, 0);
            this.Spliter.Name = "Spliter";
            // 
            // Spliter.Panel1
            // 
            this.Spliter.Panel1.Controls.Add(this.button1);
            // 
            // Spliter.Panel2
            // 
            this.Spliter.Panel2.Controls.Add(this.button2);
            this.Spliter.Size = new System.Drawing.Size(800, 450);
            this.Spliter.SplitterDistance = 356;
            this.Spliter.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Item_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Spliter);
            this.Name = "Item_Form";
            this.Text = "ItemForm";
            this.Spliter.Panel1.ResumeLayout(false);
            this.Spliter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Spliter)).EndInit();
            this.Spliter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Spliter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}