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
    public partial class FImportProduct : Form
    {
        readonly string conStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True";
        private int currentOrderId;
        string query;
        public FImportProduct()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadListDNSP();
        }

        private void InitializeDataGridView()
        {
            dgvProducts.Columns.Add("maNLColumn", "Mã NL");
            dgvProducts.Columns.Add("soLuongColumn", "Số Lượng");
            dgvProducts.Columns.Add("donViColumn", "Đơn Vị");
            dgvProducts.Columns.Add("donGiaColumn", "Đơn Giá");
        }

        private void LoadListDNSP()
        {

            query = "SELECT * FROM V_DonNhapSanPham";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                UCDNSP uCDNSP = new UCDNSP();
                                uCDNSP.LblMaDNSP.Text = dataReader["MaDNSP"].ToString();
                                uCDNSP.LblImportDate.Text = ((DateTime)dataReader["NgayNhap"]).ToString("d/M/yyyy");
                                uCDNSP.LblTriGia.Text = dataReader["TriGiaDonNhap"].ToString();
                                uCDNSP.LblTenNCC.Text = dataReader["TenNCC"].ToString();
                                flpDSDNSP.Controls.Add(uCDNSP);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {

                }
            }
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            DateTime ngayNhap = DateTime.Today;
            string maNCC = txtMaNCC.Text.Trim();

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("proc_CreateDonNhapSP", conn))
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
                    //LoadListDNSP();
                }
            }

        }

        private void btnLuuDon_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProducts.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvProducts.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                string.IsNullOrWhiteSpace(txtDonVi.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int rowIndex = dgvProducts.Rows.Add();
            dgvProducts.Rows[rowIndex].Cells["maNLColumn"].Value = txtMaSP.Text.Trim();
            dgvProducts.Rows[rowIndex].Cells["soLuongColumn"].Value = quantity;
            dgvProducts.Rows[rowIndex].Cells["donViColumn"].Value = txtDonVi.Text.Trim();
            dgvProducts.Rows[rowIndex].Cells["donGiaColumn"].Value = price;

            txtMaSP.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtDonVi.Text = string.Empty;
            txtDonGia.Text = string.Empty;
        }
    }
}
