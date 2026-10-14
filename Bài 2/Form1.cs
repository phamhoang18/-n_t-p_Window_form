using Microsoft.VisualBasic;
using System.Data;
using System.Net.Quic;
using System.Text;

namespace IT_Support_Ticket
{
    public partial class Form1 : Form
    {
        private string imagePath = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh chụp lỗi";
                ofd.Filter = "Tệp hình ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (Image temp = Image.FromFile(ofd.FileName))
                    {
                        pictureBox1.Image?.Dispose();
                        pictureBox1.Image = new Bitmap(temp);
                    }
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    imagePath = ofd.FileName;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người yêu cầu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }


            string priority = radioButton1.Checked ? "Thấp" : radioButton2.Checked ? "Trung bình" : "Khẩn cấp";

            // CheckBox: gom các ô được tick vào danh sách
            List<string> devices = new List<string>();
            if (checkBox1.Checked) devices.Add("Máy tính bàn");
            if (checkBox2.Checked) devices.Add("Laptop");
            if (checkBox3.Checked) devices.Add("Máy in");
            if (checkBox4.Checked) devices.Add("Điện thoại");
            string deviceText = devices.Count > 0 ? string.Join(", ", devices) : "(không chọn)";

            string imageText = pictureBox1.Image != null ? System.IO.Path.GetFileName(imagePath) : "(không có ảnh)";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Mã phiếu: " + textBox1.Text.Trim());
            sb.AppendLine("Người yêu cầu: " + textBox2.Text.Trim());
            sb.AppendLine("Ngày ghi nhận: " + dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            sb.AppendLine("Mức độ ưu tiên: " + priority);
            sb.AppendLine("Loại sự cố: " + comboBox1.Text);
            sb.AppendLine("Thiết bị ảnh hưởng: " + deviceText);
            sb.AppendLine("Ảnh chụp lỗi: " + imageText);

            MessageBox.Show(sb.ToString(), "Tóm tắt phiếu sự cố", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Bấm "Nhập lại": đưa mọi control về trạng thái ban đầu
        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Value = DateTime.Today;
            radioButton2.Checked = true;
            comboBox1.SelectedIndex = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = null;
            imagePath = "";
            textBox1.Focus();
        }
    }
}
