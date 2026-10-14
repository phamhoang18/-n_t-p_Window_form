    namespace Bai4_SlotBooking
    {
        public partial class Form1 
        {
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            private void InitializeComponent()
            {
                this.tlpSeats = new System.Windows.Forms.TableLayoutPanel();
                this.lblSlotCaption = new System.Windows.Forms.Label();
                this.cboSlot = new System.Windows.Forms.ComboBox();
                this.lblCountCaption = new System.Windows.Forms.Label();
                this.lblCount = new System.Windows.Forms.Label();
                this.lblTotalCaption = new System.Windows.Forms.Label();
                this.lblTotal = new System.Windows.Forms.Label();
                this.lblLegendEmpty = new System.Windows.Forms.Label();
                this.lblLegendSelected = new System.Windows.Forms.Label();
                this.lblLegendBooked = new System.Windows.Forms.Label();
                this.btnConfirm = new System.Windows.Forms.Button();
                this.btnCancelAll = new System.Windows.Forms.Button();
                this.SuspendLayout();

                this.tlpSeats.BackColor = System.Drawing.Color.WhiteSmoke;
                this.tlpSeats.ColumnCount = 5;
                this.tlpSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
                this.tlpSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
                this.tlpSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
                this.tlpSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
                this.tlpSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
                this.tlpSeats.Location = new System.Drawing.Point(20, 20);
                this.tlpSeats.Name = "tlpSeats";
                this.tlpSeats.RowCount = 4;
                this.tlpSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
                this.tlpSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
                this.tlpSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
                this.tlpSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
                this.tlpSeats.Size = new System.Drawing.Size(350, 300);
                this.tlpSeats.TabIndex = 0;

                this.lblSlotCaption.AutoSize = true;
                this.lblSlotCaption.Location = new System.Drawing.Point(395, 25);
                this.lblSlotCaption.Name = "lblSlotCaption";
                this.lblSlotCaption.Text = "Khung giờ:";

                this.cboSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.cboSlot.Items.AddRange(new object[] { "Sáng - 100.000đ", "Tối - 150.000đ" });
                this.cboSlot.Location = new System.Drawing.Point(395, 48);
                this.cboSlot.Name = "cboSlot";
                this.cboSlot.Size = new System.Drawing.Size(150, 23);
                this.cboSlot.TabIndex = 1;
                this.cboSlot.SelectedIndexChanged += new System.EventHandler(this.cboSlot_SelectedIndexChanged);

                this.lblCountCaption.AutoSize = true;
                this.lblCountCaption.Location = new System.Drawing.Point(395, 100);
                this.lblCountCaption.Name = "lblCountCaption";
                this.lblCountCaption.Text = "Số vị trí đang chọn:";

                this.lblCount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
                this.lblCount.Location = new System.Drawing.Point(395, 120);
                this.lblCount.Name = "lblCount";
                this.lblCount.Size = new System.Drawing.Size(150, 30);
                this.lblCount.Text = "0";

                this.lblTotalCaption.AutoSize = true;
                this.lblTotalCaption.Location = new System.Drawing.Point(395, 165);
                this.lblTotalCaption.Name = "lblTotalCaption";
                this.lblTotalCaption.Text = "Tạm tính tiền:";

                this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
                this.lblTotal.ForeColor = System.Drawing.Color.Red;
                this.lblTotal.Location = new System.Drawing.Point(395, 185);
                this.lblTotal.Name = "lblTotal";
                this.lblTotal.Size = new System.Drawing.Size(170, 30);
                this.lblTotal.Text = "0 đ";

                this.lblLegendEmpty.BackColor = System.Drawing.Color.White;
                this.lblLegendEmpty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.lblLegendEmpty.Location = new System.Drawing.Point(395, 245);
                this.lblLegendEmpty.Name = "lblLegendEmpty";
                this.lblLegendEmpty.Size = new System.Drawing.Size(100, 22);
                this.lblLegendEmpty.Text = "Trống";
                this.lblLegendEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                this.lblLegendSelected.BackColor = System.Drawing.Color.LimeGreen;
                this.lblLegendSelected.Location = new System.Drawing.Point(395, 272);
                this.lblLegendSelected.Name = "lblLegendSelected";
                this.lblLegendSelected.Size = new System.Drawing.Size(100, 22);
                this.lblLegendSelected.Text = "Đang chọn";
                this.lblLegendSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                this.lblLegendBooked.BackColor = System.Drawing.Color.Red;
                this.lblLegendBooked.ForeColor = System.Drawing.Color.White;
                this.lblLegendBooked.Location = new System.Drawing.Point(395, 299);
                this.lblLegendBooked.Name = "lblLegendBooked";
                this.lblLegendBooked.Size = new System.Drawing.Size(100, 22);
                this.lblLegendBooked.Text = "Đã đặt";
                this.lblLegendBooked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                this.btnConfirm.Location = new System.Drawing.Point(20, 345);
                this.btnConfirm.Name = "btnConfirm";
                this.btnConfirm.Size = new System.Drawing.Size(170, 38);
                this.btnConfirm.TabIndex = 2;
                this.btnConfirm.Text = "Xác nhận đặt";
                this.btnConfirm.UseVisualStyleBackColor = true;
                this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

                this.btnCancelAll.Location = new System.Drawing.Point(200, 345);
                this.btnCancelAll.Name = "btnCancelAll";
                this.btnCancelAll.Size = new System.Drawing.Size(170, 38);
                this.btnCancelAll.TabIndex = 3;
                this.btnCancelAll.Text = "Hủy chọn tất cả";
                this.btnCancelAll.UseVisualStyleBackColor = true;
                this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);

                this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(590, 405);
                this.Controls.Add(this.tlpSeats);
                this.Controls.Add(this.lblSlotCaption);
                this.Controls.Add(this.cboSlot);
                this.Controls.Add(this.lblCountCaption);
                this.Controls.Add(this.lblCount);
                this.Controls.Add(this.lblTotalCaption);
                this.Controls.Add(this.lblTotal);
                this.Controls.Add(this.lblLegendEmpty);
                this.Controls.Add(this.lblLegendSelected);
                this.Controls.Add(this.lblLegendBooked);
                this.Controls.Add(this.btnConfirm);
                this.Controls.Add(this.btnCancelAll);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.Name = "frmSlotBooking";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "Sơ đồ chọn vị trí / Đặt bàn hẹn giờ";
                this.Load += new System.EventHandler(this.Form1_Load);   // Sinh 20 nút ở đây
                this.ResumeLayout(false);
                this.PerformLayout();
            }

            #endregion

            private System.Windows.Forms.TableLayoutPanel tlpSeats;
            private System.Windows.Forms.Label lblSlotCaption;
            private System.Windows.Forms.ComboBox cboSlot;
            private System.Windows.Forms.Label lblCountCaption;
            private System.Windows.Forms.Label lblCount;
            private System.Windows.Forms.Label lblTotalCaption;
            private System.Windows.Forms.Label lblTotal;
            private System.Windows.Forms.Label lblLegendEmpty;
            private System.Windows.Forms.Label lblLegendSelected;
            private System.Windows.Forms.Label lblLegendBooked;
            private System.Windows.Forms.Button btnConfirm;
            private System.Windows.Forms.Button btnCancelAll;
        }
    }
