using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai4_SlotBooking
{
    public enum SeatState
    {
        Empty,     
        Selected,
        Booked  
    }

    public partial class Form1 : Form
    {
        private const int Cols = 5;                                
        private const int SeatCount = 20;
        private readonly int[] slotPrices = { 100000, 150000 };     

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSlot.SelectedIndex = 0;                              
            CreateSeats();                                         
            UpdateSummary();
        }

        private void CreateSeats()
        {
            for (int i = 0; i < SeatCount; i++)
            {
                int row = i / Cols;                                 
                int col = i % Cols;                              

                Button btn = new Button();
                btn.Name = "btnSeat" + (i + 1);
                btn.Text = ((char)('A' + row)).ToString() + (col + 1);   
                btn.Dock = DockStyle.Fill;                          
                btn.Margin = new Padding(4);
                btn.FlatStyle = FlatStyle.Flat;                    
                btn.FlatAppearance.BorderColor = Color.Gray;
                btn.Click += Seat_Click;                            

                if (i == 2 || i == 7 || i == 13)
                    SetSeatState(btn, SeatState.Booked);
                else
                    SetSeatState(btn, SeatState.Empty);

                tlpSeats.Controls.Add(btn, col, row);               
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SeatState state = (SeatState)btn.Tag;

            if (state == SeatState.Booked)
            {
                MessageBox.Show("Vị trí " + btn.Text + " đã có người đặt!", "Không thể chọn",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetSeatState(btn, state == SeatState.Empty ? SeatState.Selected : SeatState.Empty);
            UpdateSummary();                                       
        }

        private void SetSeatState(Button btn, SeatState state)
        {
            btn.Tag = state;                                        
            switch (state)
            {
                case SeatState.Empty:
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                    break;
                case SeatState.Selected:
                    btn.BackColor = Color.LimeGreen;
                    btn.ForeColor = Color.Black;
                    break;
                case SeatState.Booked:
                    btn.BackColor = Color.Red;
                    btn.ForeColor = Color.White;
                    break;
            }
        }

        private List<Button> GetSelectedSeats()
        {
            List<Button> list = new List<Button>();
            foreach (Control c in tlpSeats.Controls)
            {
                Button btn = c as Button;
                if (btn != null && (SeatState)btn.Tag == SeatState.Selected)
                    list.Add(btn);
            }
            return list;
        }

        private void UpdateSummary()
        {
            int count = GetSelectedSeats().Count;
            int price = cboSlot.SelectedIndex >= 0 ? slotPrices[cboSlot.SelectedIndex] : 0;

            lblCount.Text = count.ToString();
            lblTotal.Text = (count * price).ToString("N0") + " đ";
        }

        private void cboSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<Button> selected = GetSelectedSeats();
            if (selected.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn vị trí nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> names = new List<string>();
            foreach (Button btn in selected)
                names.Add(btn.Text);

            string message = "Khung giờ: " + cboSlot.Text + Environment.NewLine +
                             "Vị trí: " + string.Join(", ", names) + Environment.NewLine +
                             "Số lượng: " + selected.Count + Environment.NewLine +
                             "Tổng tiền: " + lblTotal.Text;

            MessageBox.Show(message, "Đặt chỗ thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (Button btn in selected)
                SetSeatState(btn, SeatState.Booked);               

            UpdateSummary();
        }

        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            foreach (Button btn in GetSelectedSeats())
                SetSeatState(btn, SeatState.Empty);

            UpdateSummary();
        }
    }
}