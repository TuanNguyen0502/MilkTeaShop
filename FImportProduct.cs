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
        My_DBConnection db = new My_DBConnection();
        private int currentOrderId;
        string query;
        public FImportProduct()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadListDNSP();
        }
        private void LoadListDNSP()
        {
            try
            {
                flpDSDNSP.Controls.Clear();
                string sqlQuery = "SELECT * FROM V_DonNhapSanPham";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                db.OpenConn();
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        UC_DonNhap ucDNSP = new UC_DonNhap();
                        ucDNSP.OnDetailButtonClicked += UCDNSP_OnDetailButtonClicked;
                        ucDNSP.LblMaDN.Text = dataReader["MaDNSP"].ToString();
                        ucDNSP.LblImportDate.Text = ((DateTime)dataReader["NgayNhap"]).ToString("d/M/yyyy");
                        ucDNSP.LblTriGia.Text = dataReader["TriGiaDonNhap"].ToString();
                        ucDNSP.LblTenNCC.Text = dataReader["TenNCC"].ToString();
                        flpDSDNSP.Controls.Add(ucDNSP);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Bị hạn chế quyền\n" + ex.Message);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            finally
            {
                db.CloseConn();
            }
        }
        private void InitializeDataGridView()
        {
            dgvProducts.Columns.Add("maSPColumn", "Mã SP");
            dgvProducts.Columns.Add("soLuongColumn", "Số Lượng");
            dgvProducts.Columns.Add("donViColumn", "Đơn Vị");
            dgvProducts.Columns.Add("donGiaColumn", "Đơn Giá");
        }
        private void UCDNSP_OnDetailButtonClicked(string orderID)
        {
            LoadCTDNSP(orderID);
        }
        public void LoadCTDNSP(string MaDNSP)
        {
            try
            {
                flpCTDNSP.Controls.Clear();
                string sqlQuery = "SELECT * FROM func_DSCTDNSP(@MaDNSP)";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                cmd.Parameters.AddWithValue("@MaDNSP", MaDNSP);
                db.OpenConn();
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        UC_CTDN uCCTDNSP = new UC_CTDN();
                        uCCTDNSP.LblTen.Text = dataReader["TenSP"].ToString();
                        uCCTDNSP.LblDonVi.Text = dataReader["DonVi"].ToString();
                        uCCTDNSP.LblSoLuong.Text = dataReader["SoLuong"].ToString();
                        uCCTDNSP.LblDonGia.Text = dataReader["DonGia"].ToString();
                        flpCTDNSP.Controls.Add(uCCTDNSP);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Bị hạn chế quyền\n" + ex.Message);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            finally
            {
                db.CloseConn();
            }
        }
        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            DateTime ngayNhap = DateTime.Today;
            string maNCC = txtMaNCC.Text.Trim();

            if (string.IsNullOrWhiteSpace(maNCC))
            {
                MessageBox.Show("Please enter a valid supplier code (MaNCC).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                SqlCommand cmd = new SqlCommand("proc_CreateDonNhapSP", db.getConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                db.OpenConn();

                var result = cmd.ExecuteScalar();
                if (int.TryParse(result.ToString(), out currentOrderId) && currentOrderId > 0)
                {
                    MessageBox.Show($"Order created successfully with ID: {currentOrderId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnThemSP.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Order could not be created. Please check the supplier code and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Bị hạn chế quyền\n" + ex.Message);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            finally
            {
                db.CloseConn();
                LoadListDNSP();
            }
        }
        private void btnLuuDon_Click(object sender, EventArgs e)
        {
            if (dgvProducts.Rows.Count == 0 || (dgvProducts.Rows.Count == 1 && dgvProducts.Rows[0].IsNewRow))
            {
                MessageBox.Show("There are no items to save.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int savedItemsCount = 0;
            try
            {
                db.OpenConn();
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        using (SqlCommand cmd = new SqlCommand("InsertChiTietDNSP", db.getConn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaDNSP", currentOrderId);
                            cmd.Parameters.AddWithValue("@MaSP", row.Cells["maSPColumn"].Value);
                            cmd.Parameters.AddWithValue("@SoLuong", row.Cells["soLuongColumn"].Value);
                            cmd.Parameters.AddWithValue("@DonVi", row.Cells["donViColumn"].Value);
                            cmd.Parameters.AddWithValue("@DonGia", row.Cells["donGiaColumn"].Value);
                            cmd.ExecuteNonQuery();
                            savedItemsCount++;
                        }
                    }
                }
                if (savedItemsCount > 0)
                {
                    MessageBox.Show("All items have been saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No items were saved to the database.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Bị hạn chế quyền\n" + ex.Message);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            finally
            {
                db.CloseConn();
                LoadListDNSP();
            }
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
            if (currentOrderId <= 0)
            {
                MessageBox.Show("Please create an order before adding items.", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            dgvProducts.Rows[rowIndex].Cells["maSPColumn"].Value = txtMaSP.Text.Trim();
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
