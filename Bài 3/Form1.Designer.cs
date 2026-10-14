namespace Item_List_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            folderBrowserDialog1 = new FolderBrowserDialog();
            this.colCode = new System.Windows.Forms.ColumnHeader();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colUnit = new System.Windows.Forms.ColumnHeader();
            this.colPrice = new System.Windows.Forms.ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 491);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin vật tư";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 27);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 147);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 6;
            label4.Text = "Đơn giá nhập";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            comboBox1.Location = new Point(120, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 28);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 107);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 3;
            label3.Text = "Đơn vị tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 68);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên vật tư";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 32);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã vật tư";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(324, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(497, 491);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách vật tư";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Location = new Point(6, 26);
            listView1.Name = "listView1";
            listView1.Size = new Size(485, 459);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colCode, this.colName, this.colUnit, this.colPrice });
            listView1.FullRowSelect = true;                           
            listView1.GridLines = true;
            listView1.HideSelection = false;                          
            listView1.Location = new System.Drawing.Point(10, 25);
            listView1.MultiSelect = false;                            
            listView1.Name = "lvItems";
            listView1.Size = new System.Drawing.Size(455, 345);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;       
            listView1.SelectedIndexChanged += new System.EventHandler(this.lvItems_SelectedIndexChanged);

            this.colCode.Text = "Mã VT";
            this.colCode.Width = 80;
            this.colName.Text = "Tên VT";
            this.colName.Width = 170;
            this.colUnit.Text = "Đơn vị tính";
            this.colUnit.Width = 90;
            this.colPrice.Text = "Đơn giá";
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPrice.Width = 100;

            // 
            // button1
            // 
            button1.Location = new Point(33, 188);
            button1.Name = "button1";
            button1.Size = new Size(101, 29);
            button1.TabIndex = 8;
            button1.Text = "Thêm mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            button2.Location = new Point(171, 188);
            button2.Name = "button2";
            button2.Size = new Size(101, 29);
            button2.TabIndex = 9;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new EventHandler(this.btnUpdate_Click);
            // 
            // button3
            // 
            button3.Location = new Point(33, 235);
            button3.Name = "button3";
            button3.Size = new Size(101, 29);
            button3.TabIndex = 10;
            button3.Text = "Xóa dòng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new EventHandler(this.btnDelete_Click);
            // 
            // button4
            // 
            button4.Location = new Point(171, 235);
            button4.Name = "button4";
            button4.Size = new Size(101, 29);
            button4.TabIndex = 11;
            button4.Text = "Xóa toàn bộ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 515);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private ListView listView1;
        private FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colUnit;
        private System.Windows.Forms.ColumnHeader colPrice;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}
