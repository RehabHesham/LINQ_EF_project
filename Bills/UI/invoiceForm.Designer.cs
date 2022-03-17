namespace Bills.UI
{
    partial class invoiceForm
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
            this.gb_bill = new System.Windows.Forms.GroupBox();
            this.txt_invoiceNumber = new System.Windows.Forms.TextBox();
            this.lbl_invoiceNumber = new System.Windows.Forms.Label();
            this.dtp_incoiceDate = new System.Windows.Forms.DateTimePicker();
            this.cb_invoiceClient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_invoiceDate = new System.Windows.Forms.Label();
            this.lbl_salesInvoice = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gb_items = new System.Windows.Forms.GroupBox();
            this.btn_invoiceAddItem = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sellPrice = new System.Windows.Forms.TextBox();
            this.lbl_sellPrice = new System.Windows.Forms.Label();
            this.cb_ivoiceItemName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_compCancle = new System.Windows.Forms.Button();
            this.btn_compSave = new System.Windows.Forms.Button();
            this.gb_invoiceOther = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_invoiceError = new System.Windows.Forms.Label();
            this.gb_bill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gb_items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_invoiceOther.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_bill
            // 
            this.gb_bill.Controls.Add(this.txt_invoiceNumber);
            this.gb_bill.Controls.Add(this.lbl_invoiceNumber);
            this.gb_bill.Controls.Add(this.dtp_incoiceDate);
            this.gb_bill.Controls.Add(this.cb_invoiceClient);
            this.gb_bill.Controls.Add(this.label3);
            this.gb_bill.Controls.Add(this.lbl_invoiceDate);
            this.gb_bill.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_bill.Location = new System.Drawing.Point(27, 119);
            this.gb_bill.Name = "gb_bill";
            this.gb_bill.Size = new System.Drawing.Size(528, 237);
            this.gb_bill.TabIndex = 48;
            this.gb_bill.TabStop = false;
            this.gb_bill.Text = "Bill Detail";
            // 
            // txt_invoiceNumber
            // 
            this.txt_invoiceNumber.Enabled = false;
            this.txt_invoiceNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceNumber.Location = new System.Drawing.Point(183, 119);
            this.txt_invoiceNumber.Name = "txt_invoiceNumber";
            this.txt_invoiceNumber.Size = new System.Drawing.Size(276, 27);
            this.txt_invoiceNumber.TabIndex = 43;
            // 
            // lbl_invoiceNumber
            // 
            this.lbl_invoiceNumber.AutoSize = true;
            this.lbl_invoiceNumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoiceNumber.Location = new System.Drawing.Point(46, 123);
            this.lbl_invoiceNumber.Name = "lbl_invoiceNumber";
            this.lbl_invoiceNumber.Size = new System.Drawing.Size(126, 23);
            this.lbl_invoiceNumber.TabIndex = 42;
            this.lbl_invoiceNumber.Text = "Bill Number  :";
            // 
            // dtp_incoiceDate
            // 
            this.dtp_incoiceDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_incoiceDate.Location = new System.Drawing.Point(183, 62);
            this.dtp_incoiceDate.Name = "dtp_incoiceDate";
            this.dtp_incoiceDate.Size = new System.Drawing.Size(276, 27);
            this.dtp_incoiceDate.TabIndex = 41;
            // 
            // cb_invoiceClient
            // 
            this.cb_invoiceClient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_invoiceClient.FormattingEnabled = true;
            this.cb_invoiceClient.Location = new System.Drawing.Point(183, 178);
            this.cb_invoiceClient.Name = "cb_invoiceClient";
            this.cb_invoiceClient.Size = new System.Drawing.Size(276, 27);
            this.cb_invoiceClient.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Client Name :";
            // 
            // lbl_invoiceDate
            // 
            this.lbl_invoiceDate.AutoSize = true;
            this.lbl_invoiceDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoiceDate.Location = new System.Drawing.Point(81, 59);
            this.lbl_invoiceDate.Name = "lbl_invoiceDate";
            this.lbl_invoiceDate.Size = new System.Drawing.Size(91, 23);
            this.lbl_invoiceDate.TabIndex = 38;
            this.lbl_invoiceDate.Text = "Bill Date :";
            // 
            // lbl_salesInvoice
            // 
            this.lbl_salesInvoice.AutoSize = true;
            this.lbl_salesInvoice.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salesInvoice.Location = new System.Drawing.Point(18, 51);
            this.lbl_salesInvoice.Name = "lbl_salesInvoice";
            this.lbl_salesInvoice.Size = new System.Drawing.Size(224, 38);
            this.lbl_salesInvoice.TabIndex = 47;
            this.lbl_salesInvoice.Text = "Sales Invoice";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(0, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 38);
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // gb_items
            // 
            this.gb_items.Controls.Add(this.btn_invoiceAddItem);
            this.gb_items.Controls.Add(this.textBox2);
            this.gb_items.Controls.Add(this.label4);
            this.gb_items.Controls.Add(this.textBox1);
            this.gb_items.Controls.Add(this.label2);
            this.gb_items.Controls.Add(this.txt_sellPrice);
            this.gb_items.Controls.Add(this.lbl_sellPrice);
            this.gb_items.Controls.Add(this.cb_ivoiceItemName);
            this.gb_items.Controls.Add(this.label5);
            this.gb_items.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_items.Location = new System.Drawing.Point(27, 389);
            this.gb_items.Name = "gb_items";
            this.gb_items.Size = new System.Drawing.Size(528, 328);
            this.gb_items.TabIndex = 49;
            this.gb_items.TabStop = false;
            this.gb_items.Text = "Items Details";
            // 
            // btn_invoiceAddItem
            // 
            this.btn_invoiceAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_invoiceAddItem.Image = global::Bills.Properties.Resources.add1;
            this.btn_invoiceAddItem.Location = new System.Drawing.Point(220, 283);
            this.btn_invoiceAddItem.Margin = new System.Windows.Forms.Padding(0);
            this.btn_invoiceAddItem.Name = "btn_invoiceAddItem";
            this.btn_invoiceAddItem.Size = new System.Drawing.Size(79, 30);
            this.btn_invoiceAddItem.TabIndex = 48;
            this.btn_invoiceAddItem.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(183, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 27);
            this.textBox2.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "Total :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(183, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 27);
            this.textBox1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Quantity :";
            // 
            // txt_sellPrice
            // 
            this.txt_sellPrice.Enabled = false;
            this.txt_sellPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sellPrice.Location = new System.Drawing.Point(183, 119);
            this.txt_sellPrice.Name = "txt_sellPrice";
            this.txt_sellPrice.Size = new System.Drawing.Size(276, 27);
            this.txt_sellPrice.TabIndex = 43;
            // 
            // lbl_sellPrice
            // 
            this.lbl_sellPrice.AutoSize = true;
            this.lbl_sellPrice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sellPrice.Location = new System.Drawing.Point(46, 123);
            this.lbl_sellPrice.Name = "lbl_sellPrice";
            this.lbl_sellPrice.Size = new System.Drawing.Size(124, 23);
            this.lbl_sellPrice.TabIndex = 42;
            this.lbl_sellPrice.Text = "Selling Price :";
            // 
            // cb_ivoiceItemName
            // 
            this.cb_ivoiceItemName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ivoiceItemName.FormattingEnabled = true;
            this.cb_ivoiceItemName.Location = new System.Drawing.Point(183, 65);
            this.cb_ivoiceItemName.Name = "cb_ivoiceItemName";
            this.cb_ivoiceItemName.Size = new System.Drawing.Size(276, 27);
            this.cb_ivoiceItemName.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Item Name :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 739);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 204);
            this.dataGridView1.TabIndex = 50;
            // 
            // btn_compCancle
            // 
            this.btn_compCancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_compCancle.Image = global::Bills.Properties.Resources.cancle;
            this.btn_compCancle.Location = new System.Drawing.Point(158, 1660);
            this.btn_compCancle.Name = "btn_compCancle";
            this.btn_compCancle.Size = new System.Drawing.Size(121, 39);
            this.btn_compCancle.TabIndex = 52;
            this.btn_compCancle.UseVisualStyleBackColor = true;
            // 
            // btn_compSave
            // 
            this.btn_compSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_compSave.Image = global::Bills.Properties.Resources.save;
            this.btn_compSave.Location = new System.Drawing.Point(323, 1660);
            this.btn_compSave.Name = "btn_compSave";
            this.btn_compSave.Size = new System.Drawing.Size(93, 39);
            this.btn_compSave.TabIndex = 51;
            this.btn_compSave.UseVisualStyleBackColor = true;
            // 
            // gb_invoiceOther
            // 
            this.gb_invoiceOther.Controls.Add(this.textBox7);
            this.gb_invoiceOther.Controls.Add(this.label9);
            this.gb_invoiceOther.Controls.Add(this.textBox8);
            this.gb_invoiceOther.Controls.Add(this.label10);
            this.gb_invoiceOther.Controls.Add(this.textBox6);
            this.gb_invoiceOther.Controls.Add(this.textBox3);
            this.gb_invoiceOther.Controls.Add(this.label1);
            this.gb_invoiceOther.Controls.Add(this.textBox4);
            this.gb_invoiceOther.Controls.Add(this.label6);
            this.gb_invoiceOther.Controls.Add(this.textBox5);
            this.gb_invoiceOther.Controls.Add(this.label7);
            this.gb_invoiceOther.Controls.Add(this.label8);
            this.gb_invoiceOther.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_invoiceOther.Location = new System.Drawing.Point(27, 983);
            this.gb_invoiceOther.Name = "gb_invoiceOther";
            this.gb_invoiceOther.Size = new System.Drawing.Size(528, 403);
            this.gb_invoiceOther.TabIndex = 53;
            this.gb_invoiceOther.TabStop = false;
            this.gb_invoiceOther.Text = "Other Details";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(207, 342);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(276, 27);
            this.textBox7.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(104, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 52;
            this.label9.Text = "The Rest :";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(207, 287);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(276, 27);
            this.textBox8.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(114, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 23);
            this.label10.TabIndex = 50;
            this.label10.Text = "Paid Up :";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(207, 69);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(276, 27);
            this.textBox6.TabIndex = 49;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(207, 231);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(276, 27);
            this.textBox3.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "The Net :";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(207, 176);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(276, 27);
            this.textBox4.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 23);
            this.label6.TabIndex = 44;
            this.label6.Text = "Value Discount :";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(207, 124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(276, 27);
            this.textBox5.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Percentage Discount :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(108, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "Bill Total :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 1422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 200);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request A Form";
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(207, 131);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(276, 27);
            this.textBox10.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(132, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 23);
            this.label12.TabIndex = 44;
            this.label12.Text = "Time :";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 27);
            this.comboBox1.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(37, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 23);
            this.label14.TabIndex = 39;
            this.label14.Text = "Employee Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(277, 1735);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 55;
            // 
            // lbl_invoiceError
            // 
            this.lbl_invoiceError.AutoSize = true;
            this.lbl_invoiceError.Location = new System.Drawing.Point(285, 71);
            this.lbl_invoiceError.Name = "lbl_invoiceError";
            this.lbl_invoiceError.Size = new System.Drawing.Size(0, 13);
            this.lbl_invoiceError.TabIndex = 56;
            // 
            // invoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(616, 421);
            this.Controls.Add(this.lbl_invoiceError);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_invoiceOther);
            this.Controls.Add(this.btn_compCancle);
            this.Controls.Add(this.btn_compSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_items);
            this.Controls.Add(this.gb_bill);
            this.Controls.Add(this.lbl_salesInvoice);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "invoiceForm";
            this.Text = "invoiceForm";
            this.gb_bill.ResumeLayout(false);
            this.gb_bill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gb_items.ResumeLayout(false);
            this.gb_items.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_invoiceOther.ResumeLayout(false);
            this.gb_invoiceOther.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_bill;
        private System.Windows.Forms.TextBox txt_invoiceNumber;
        private System.Windows.Forms.Label lbl_invoiceNumber;
        private System.Windows.Forms.DateTimePicker dtp_incoiceDate;
        private System.Windows.Forms.ComboBox cb_invoiceClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_invoiceDate;
        private System.Windows.Forms.Label lbl_salesInvoice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gb_items;
        private System.Windows.Forms.Button btn_invoiceAddItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sellPrice;
        private System.Windows.Forms.Label lbl_sellPrice;
        private System.Windows.Forms.ComboBox cb_ivoiceItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_compCancle;
        private System.Windows.Forms.Button btn_compSave;
        private System.Windows.Forms.GroupBox gb_invoiceOther;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_invoiceError;
    }
}