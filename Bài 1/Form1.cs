namespace Service_Charge_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBox1.Text.Trim(), out decimal price) || price < 0)
            {
                ShowError("Đơn giá phải không hợp lệ!", textBox1);
                return;
            }

            if (!int.TryParse(textBox2.Text.Trim(), out int quantity) || quantity <= 0)
            {
                ShowError("Số lượng khách không hợp lệ!", textBox2);
                return;
            }

            if (!decimal.TryParse(textBox3.Text.Trim(), out decimal discount) || discount < 0 || discount > 100)
            {
                ShowError("% giảm giá phải không hợp lệ!", textBox3);
                return;
            }

            // Công thức: Tổng tiền = (Đơn giá x Số lượng) x (100 - % giảm) / 100
            decimal total = (price * quantity) * (100 - discount) / 100;

            textBox4.Text = total.ToString("N0") + " đ";
        }

        // Bấm "Làm mới": xóa dữ liệu, đưa con trỏ về ô đầu tiên
        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        // Hàm dùng chung: hiện cảnh báo rồi đưa con trỏ vào ô bị lỗi
        private void ShowError(string message, Control control)
        {
            MessageBox.Show(message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
            if (control is TextBox tb)
            {
                tb.SelectAll();
            }
        }
    }
}
