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
        private readonly string conStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True";
        private int currentOrderId;
        private My_DBConnection db = new My_DBConnection();

        public FExport_Ingredients()
        {
            InitializeComponent();
            LoadDataGirdViewDonXuatNguyenLieu();
            LoadDataGirdViewChiTietDonXuatNguyenLieu();
            AddBinding();
        }

        private void AddBinding()
        {
            textBox_MaNhanVien.DataBindings.Add(new Binding("Text", dataGridView_DonXuatNguyenLieu.DataSource, "Mã nhân viên"));
            textBox_MaDonXuat.DataBindings.Add(new Binding("Text", dataGridView_DonXuatNguyenLieu.DataSource, "Mã đơn"));
            dateTimePicker_NgayXuat.DataBindings.Add(new Binding("Value", dataGridView_DonXuatNguyenLieu.DataSource, "Ngày xuất"));
        }

        private void LoadDataGirdViewChiTietDonXuatNguyenLieu()
        {
            try
            {
                db.OpenConn();
                string sqlStr = string.Format($"SELECT * FROM func_ChiTietDonXuatNguyenLieu('{textBox_MaDonXuat.Text}')");
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, db.getConn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_ChiTietDXNL.DataSource = dt;
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

        private void LoadDataGirdViewDonXuatNguyenLieu()
        {
            try
            {
                db.OpenConn();
                string sqlStr = string.Format("SELECT * FROM v_DonXuatNguyenLieu");
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, db.getConn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_DonXuatNguyenLieu.DataSource = dt;
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
            try
            {
                db.OpenConn();
                using (SqlCommand cmd = new SqlCommand("proc_CreateDonXuatNguyenLieu", db.getConn))
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

            try
            {
                db.OpenConn();
                using (SqlCommand cmd = new SqlCommand("proc_CreateChiTietDonXuatNguyenLieu", db.getConn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDonXuatNguyenLieu", textBox_MaDonXuat.Text);
                    cmd.Parameters.AddWithValue("@MaNguyenLieu", textBox_MaNguyenLieu.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", textBox_SoLuong.Text);
                    cmd.Parameters.AddWithValue("@DonVi", textBox_DonVi.Text);

                    cmd.ExecuteScalar();
                    MessageBox.Show("Succeed.");
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
            LoadDataGirdViewChiTietDonXuatNguyenLieu();
        }

        private void dataGridView_DonXuatNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataGirdViewChiTietDonXuatNguyenLieu();
        }

        private void dataGridView_ChiTietDXNL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaNguyenLieu.Text = dataGridView_ChiTietDXNL.SelectedCells[0].OwningRow.Cells["Mã nguyên liệu"].Value.ToString();
            textBox_SoLuong.Text = dataGridView_ChiTietDXNL.SelectedCells[0].OwningRow.Cells["Số lượng"].Value.ToString();
            textBox_DonVi.Text = dataGridView_ChiTietDXNL.SelectedCells[0].OwningRow.Cells["Đơn vị"].Value.ToString();
        }

        private void button_SuaDon_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConn();
                using (SqlCommand cmd = new SqlCommand("proc_UpdateDonXuatNguyenLieu", db.getConn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDXNL", textBox_MaDonXuat.Text);
                    cmd.Parameters.AddWithValue("@NgayXuat", dateTimePicker_NgayXuat.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@MaNhanVien", textBox_MaNhanVien.Text);

                    cmd.ExecuteScalar();
                    MessageBox.Show("Succeed.");
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
            LoadDataGirdViewDonXuatNguyenLieu();
        }

        private void button_SuaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConn();
                using (SqlCommand cmd = new SqlCommand("proc_UpdateChiTietDonXuatNguyenLieu", db.getConn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDonXuatNguyenLieu", textBox_MaDonXuat.Text);
                    cmd.Parameters.AddWithValue("@MaNguyenLieu", textBox_MaNguyenLieu.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", textBox_SoLuong.Text);
                    cmd.Parameters.AddWithValue("@DonVi", textBox_DonVi.Text);

                    cmd.ExecuteScalar();
                    MessageBox.Show("Succeed.");
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
            LoadDataGirdViewChiTietDonXuatNguyenLieu();
        }
    }
}

