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
            LoadDataGirdViewDonXuatNguyenLieu();
            AddBinding();
        }

        private void AddBinding()
        {
            textBox_MaNhanVien.DataBindings.Add(new Binding("Text", dataGridView_DonXuatNguyenLieu.DataSource, "Mã nhân viên"));
            textBox_MaDonXuat.DataBindings.Add(new Binding("Text", dataGridView_DonXuatNguyenLieu.DataSource, "Mã đơn"));
        }

        private void LoadDataGirdViewChiTietDonXuatNguyenLieu()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    string sqlStr = string.Format($"SELECT * FROM func_ChiTietDonXuatNguyenLieu('{textBox_MaDonXuat.Text}')");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView_ChiTietDXNL.DataSource = dt;
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

        private void LoadDataGirdViewDonXuatNguyenLieu()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    string sqlStr = string.Format("SELECT * FROM v_DonXuatNguyenLieu");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView_DonXuatNguyenLieu.DataSource = dt;
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

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("proc_CreateDonXuatNguyenLieu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NgayXuat", DateTime.Now);
                        cmd.Parameters.AddWithValue("@MaNhanVien", textBox_MaNhanVien.Text);

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
            LoadDataGirdViewDonXuatNguyenLieu();
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

            this.dataGridView_ChiTietDXNL.Rows.Add(textBox_MaNguyenLieu.Text.Trim(), quantity, "NULL", textBox_DonVi.Text.Trim());

            //int rowIndex = dataGridView_ChiTietDXNL.Rows.Add();
            //dataGridView_ChiTietDXNL.Rows[rowIndex].Cells["Mã nguyên liệu"].Value = textBox_MaNguyenLieu.Text.Trim();
            //dataGridView_ChiTietDXNL.Rows[rowIndex].Cells["Số lượng"].Value = quantity;
            //dataGridView_ChiTietDXNL.Rows[rowIndex].Cells["Đơn vị"].Value = textBox_DonVi.Text.Trim();

            textBox_MaNguyenLieu.Text = string.Empty;
            textBox_SoLuong.Text = string.Empty;
            textBox_DonVi.Text = string.Empty;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_DonXuatNguyenLieu.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView_DonXuatNguyenLieu.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView_DonXuatNguyenLieu.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_DonXuatNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataGirdViewChiTietDonXuatNguyenLieu();
        }
    }
}

