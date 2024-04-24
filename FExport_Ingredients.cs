﻿using System;
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
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dgvMaterials.Columns.Add("maNLColumn", "Mã NL");
            dgvMaterials.Columns.Add("soLuongColumn", "Số Lượng");
            dgvMaterials.Columns.Add("donViColumn", "Đơn Vị");
            dgvMaterials.Columns.Add("donGiaColumn", "Đơn Giá");
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            DateTime ngayNhap = DateTime.Today;
            string maNCC = txtNCC.Text.Trim();

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
    }
}

