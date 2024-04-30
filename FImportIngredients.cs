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
    public partial class FImportIngredients : Form
    {
        My_DBConnection db = new My_DBConnection();
        private int currentOrderId;
        string query;
        public FImportIngredients()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadListDNNL();
        }
        private void LoadListDNNL()
        {
            try
            {
                flpDSDNNL.Controls.Clear();
                string sqlQuery = "SELECT * FROM V_DonNhapNguyenLieu";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                db.OpenConn();
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        UC_DonNhap uCDNNL = new UC_DonNhap();
                        uCDNNL.OnDetailButtonClicked += UCDNNL_OnDetailButtonClicked;
                        uCDNNL.LblMaDN.Text = dataReader["MaDNNL"].ToString();
                        uCDNNL.LblImportDate.Text = ((DateTime)dataReader["NgayNhap"]).ToString("d/M/yyyy");
                        uCDNNL.LblTriGia.Text = dataReader["TriGiaDonNhap"].ToString();
                        uCDNNL.LblTenNCC.Text = dataReader["TenNCC"].ToString();
                        flpDSDNNL.Controls.Add(uCDNNL);
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
            dgvMaterials.Columns.Add("maNLColumn", "Mã NL");
            dgvMaterials.Columns.Add("soLuongColumn", "Số Lượng");
            dgvMaterials.Columns.Add("donViColumn", "Đơn Vị");
            dgvMaterials.Columns.Add("donGiaColumn", "Đơn Giá");
        }
        private void UCDNNL_OnDetailButtonClicked(string orderID)
        {
            LoadCTDNNL(orderID);
        }
        public void LoadCTDNNL(string MaDNNL)
        {
            try
            {
                flpCTDNNL.Controls.Clear();
                string sqlQuery = "SELECT * FROM func_DSCTDNNL(@MaDNNL)";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                cmd.Parameters.AddWithValue("@MaDNNL", MaDNNL);
                db.OpenConn();
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        UC_CTDN uCCTDNNL = new UC_CTDN();
                        uCCTDNNL.LblTen.Text = dataReader["TenNL"].ToString();
                        uCCTDNNL.LblDonVi.Text = dataReader["DonVi"].ToString();
                        uCCTDNNL.LblSoLuong.Text = dataReader["SoLuong"].ToString();
                        uCCTDNNL.LblDonGia.Text = dataReader["DonGia"].ToString();
                        flpCTDNNL.Controls.Add(uCCTDNNL);
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
                SqlCommand cmd = new SqlCommand("proc_CreateDonNhapNL", db.getConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                db.OpenConn();

                var result = cmd.ExecuteScalar();
                if (int.TryParse(result.ToString(), out currentOrderId) && currentOrderId > 0)
                {
                    MessageBox.Show($"Order created successfully with ID: {currentOrderId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnThemNL.Enabled = true;
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
                LoadListDNNL();
            }
        }
        private void btnLuuDon_Click(object sender, EventArgs e)
        {
            if (dgvMaterials.Rows.Count == 0 || (dgvMaterials.Rows.Count == 1 && dgvMaterials.Rows[0].IsNewRow))
            {
                MessageBox.Show("There are no items to save.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int savedItemsCount = 0;
            try
            {
                db.OpenConn();
                foreach (DataGridViewRow row in dgvMaterials.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        using (SqlCommand cmd = new SqlCommand("InsertChiTietDNNL", db.getConn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaDNNL", currentOrderId);
                            cmd.Parameters.AddWithValue("@MaNL", row.Cells["maNLColumn"].Value);
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
                LoadListDNNL();
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMaterials.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvMaterials.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvMaterials.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnThemNL_Click(object sender, EventArgs e)
        {
            if (currentOrderId <= 0)
            {
                MessageBox.Show("Please create an order before adding items.", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaNL.Text) ||
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

            int rowIndex = dgvMaterials.Rows.Add();
            dgvMaterials.Rows[rowIndex].Cells["maNLColumn"].Value = txtMaNL.Text.Trim();
            dgvMaterials.Rows[rowIndex].Cells["soLuongColumn"].Value = quantity;
            dgvMaterials.Rows[rowIndex].Cells["donViColumn"].Value = txtDonVi.Text.Trim();
            dgvMaterials.Rows[rowIndex].Cells["donGiaColumn"].Value = price;

            txtMaNL.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtDonVi.Text = string.Empty;
            txtDonGia.Text = string.Empty;
        }
    }
}
