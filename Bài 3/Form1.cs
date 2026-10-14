using System;
using System.Windows.Forms;

namespace Item_List_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ReadInput(out string code, out string name, out string unit, out decimal price))
                return;

            if (FindByCode(code, null) != null)
            {
                MessageBox.Show("Mã vật tư \"" + code + "\" đã tồn tại!", "Trùng mã",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                textBox1.SelectAll();
                return;
            }

            ListViewItem item = new ListViewItem(new string[] { code, name, unit, price.ToString("N0") });
            item.Tag = price;
            listView1.Items.Add(item);

            listView1.SelectedItems.Clear();
            ClearInput();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn một dòng trong danh sách để cập nhật!", "Chưa chọn dòng",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ReadInput(out string code, out string name, out string unit, out decimal price))
                return;

            ListViewItem selected = listView1.SelectedItems[0];

            if (FindByCode(code, selected) != null)
            {
                MessageBox.Show("Mã vật tư \"" + code + "\" đã tồn tại ở dòng khác!", "Trùng mã",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            selected.SubItems[0].Text = code;
            selected.SubItems[1].Text = name;
            selected.SubItems[2].Text = unit;
            selected.SubItems[3].Text = price.ToString("N0");
            selected.Tag = price;

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInput();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn một dòng cần xóa!", "Chưa chọn dòng",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListViewItem selected = listView1.SelectedItems[0];
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa vật tư \"" + selected.Text + "\" không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                listView1.Items.Remove(selected);
                ClearInput();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0) return;

            DialogResult result = MessageBox.Show("Xóa toàn bộ danh sách vật tư?", "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                listView1.Items.Clear();
                ClearInput();
            }
        }
        private void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            ListViewItem item = listView1.SelectedItems[0];
            textBox1.Text = item.SubItems[0].Text;
            textBox2.Text = item.SubItems[1].Text;
            comboBox1.SelectedItem = item.SubItems[2].Text;

            if (item.Tag != null)
            {
                textBox3.Text = item.Tag.ToString();
            }
            else
            {
                textBox3.Text = item.SubItems[3].Text.Replace(",", "");
            }
        }
        private bool ReadInput(out string code, out string name, out string unit, out decimal price)
        {
            code = textBox1.Text.Trim();
            name = textBox2.Text.Trim();
            unit = comboBox1.Text;
            price = 0;

            if (code == "")
            {
                MessageBox.Show("Vui lòng nhập mã vật tư!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return false;
            }
            if (name == "")
            {
                MessageBox.Show("Vui lòng nhập tên vật tư!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return false;
            }
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return false;
            }
            if (!decimal.TryParse(textBox3.Text.Trim(), out price) || price < 0)
            {
                MessageBox.Show("Đơn giá phải là số không âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                textBox3.SelectAll();
                return false;
            }
            return true;
        }

        private ListViewItem FindByCode(string code, ListViewItem exclude)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item == exclude) continue;
                if (string.Equals(item.SubItems[0].Text, code, StringComparison.OrdinalIgnoreCase))
                    return item;
            }
            return null;
        }

        private void ClearInput()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            textBox1.Focus();
        }
    }
}