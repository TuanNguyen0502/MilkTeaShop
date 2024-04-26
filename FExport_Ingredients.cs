using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaShop
{
    public partial class FExport_Ingredients : Form
    {
        readonly string conStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True";
        private int currentOrderId;

        public FExport_Ingredients()
        {
            InitializeComponent();
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            DateTime ngayNhap = DateTime.Today;
            string maNCC = textBox_MaNhanVien.Text.Trim();

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("proc_CreateDonNhapNL", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                        cmd.Parameters.AddWithValue("@MaNCC", maNCC);

                        var result = cmd.ExecuteScalar();
                        if (int.TryParse(result.ToString(), out currentOrderId))
                        {
                            MessageBox.Show($"Order created successfully with ID: {currentOrderId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"An error occurred: {result}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_MaNguyenLieu.Text) ||
                string.IsNullOrWhiteSpace(textBox_SoLuong.Text) ||
                string.IsNullOrWhiteSpace(textBox_DonVi.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBox_SoLuong.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int rowIndex = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowIndex].Cells["maNLColumn"].Value = textBox_MaNguyenLieu.Text.Trim();
            dataGridView1.Rows[rowIndex].Cells["soLuongColumn"].Value = quantity;
            dataGridView1.Rows[rowIndex].Cells["donViColumn"].Value = textBox_DonVi.Text.Trim();

            textBox_MaNguyenLieu.Text = string.Empty;
            textBox_SoLuong.Text = string.Empty;
            textBox_DonVi.Text = string.Empty;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

