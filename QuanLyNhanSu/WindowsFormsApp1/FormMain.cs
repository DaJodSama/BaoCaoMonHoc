using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        TaiKhoan taikhoan = new TaiKhoan();
        public bool PhanQuyen()
        {
            if(taikhoan.sTaiKhoan!="admin")
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            return true;
        }
        NhanVienBLL nvbll = new NhanVienBLL();
        PBBLL pb = new PBBLL();
        GTBLL gt = new GTBLL();
        TTBLL tt = new TTBLL();
        //string TaiKhoan = "", MatKhau = "", Quyen = "";
        public bool isExit = true;

        public event EventHandler LogOut;
        public FormMain()
        {
            InitializeComponent();
        }

        //public FormMain(string TaiKhoan, string MatKhau, string Quyen)
        //{
        //    InitializeComponent();
        //    this.TaiKhoan = TaiKhoan;
        //    this.MatKhau = MatKhau;
        //    this.Quyen = Quyen;
        //}
        private void FormMain_Load(object sender, EventArgs e)
        {
            
            List<NhanVien> lst = nvbll.ReadNV();
            foreach (NhanVien nv in lst)
            {
                dtgvEmployee.Rows.Add(nv.MaNV, nv.HoTen, nv.NgaySinh.ToShortDateString(), nv.DiaChi, nv.DiDong, nv.TenGT, nv.TenPB, nv.TenTT);

            }
            List<GioiTinhBEL> listGT = gt.ReadGTList();
            foreach (GioiTinhBEL g in listGT)
            {
                cbGender.Items.Add(g);
            }
            cbGender.DisplayMember = "GioiTinh";

            List<TrangThaiBEL> listTT = tt.ReadTTList();
            foreach (TrangThaiBEL t in listTT)
            {
                cbTT.Items.Add(t);
            }
            cbTT.DisplayMember = "TrangThai";

            List<PhongBanBEL> listPB = pb.ReadPBList();
            foreach (PhongBanBEL p in listPB)
            {
                cbPB.Items.Add(p);
            }
            cbPB.DisplayMember = "Name_PB";
            //btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
            
            
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
           
        }

        

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.Close();
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = int.Parse(txbId.Text);
                nv.HoTen = txbName.Text;
                nv.NgaySinh = DateTime.Parse(dtBirth.Value.ToString("yyyy/MM/dd"));
                nv.DiaChi = txbAddress.Text;
                nv.DiDong = txbDiDong.Text;
                nv.GT = (GioiTinhBEL)cbGender.SelectedItem;
                nv.PB = (PhongBanBEL)cbPB.SelectedItem;
                nv.TT = (TrangThaiBEL)cbTT.SelectedItem;

                nvbll.AddNV(nv);    

                dtgvEmployee.Rows.Add(nv.MaNV, nv.HoTen, nv.NgaySinh.ToShortDateString(),nv.DiaChi, nv.DiDong, nv.GT.GioiTinh, nv.PB.Name_PB, nv.TT.TrangThai);

                MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkData()) {
                
            DataGridViewRow row = dtgvEmployee.CurrentRow;

                if (row != null)
                {
                    NhanVien nv = new NhanVien();

                    nv.MaNV = int.Parse(txbId.Text);
                    nv.HoTen = txbName.Text;
                    nv.NgaySinh = DateTime.Parse(dtBirth.Value.ToString("yyyy/MM/dd"));
                    nv.DiaChi = txbAddress.Text;
                    nv.DiDong = txbDiDong.Text;
                    nv.GT = (GioiTinhBEL)cbGender.SelectedItem;
                    nv.PB = (PhongBanBEL)cbPB.SelectedItem;
                    nv.TT = (TrangThaiBEL)cbTT.SelectedItem;
                
                    nvbll.EditNV(nv);

                    row.Cells[0].Value = nv.MaNV;
                    row.Cells[1].Value = nv.HoTen;
                    row.Cells[2].Value = nv.NgaySinh;
                    row.Cells[3].Value = nv.DiaChi;
                    row.Cells[4].Value = nv.DiDong;
                    row.Cells[5].Value = nv.TenGT;
                    row.Cells[6].Value = nv.TenPB;
                    row.Cells[7].Value = nv.TenTT;
                }
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();

            nv.MaNV = int.Parse(txbId.Text);
            nv.HoTen = txbName.Text;
            nv.NgaySinh = DateTime.Parse(dtBirth.Text);
            nv.DiaChi = txbAddress.Text;
            nv.DiDong = txbDiDong.Text;
            nv.GT = (GioiTinhBEL)cbGender.SelectedItem;
            nv.PB = (PhongBanBEL)cbPB.SelectedItem;
            nv.TT = (TrangThaiBEL)cbTT.SelectedItem;

            if (dtgvEmployee.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int idx = dtgvEmployee.CurrentCell.RowIndex;
                    nvbll.DeleteNV(nv);
                    dtgvEmployee.Rows.RemoveAt(idx);
                }
            }
            else
            {
                MessageBox.Show("Không có hàng nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dtgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dtgvEmployee.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                txbId.Text = row.Cells[0].Value.ToString();
                txbName.Text = row.Cells[1].Value.ToString();
                dtBirth.Text = row.Cells[2].Value.ToString();
                txbAddress.Text = row.Cells[3].Value.ToString();
                txbDiDong.Text = row.Cells[4].Value.ToString();
                cbGender.Text = row.Cells[5].Value.ToString();
                cbPB.Text = row.Cells[6].Value.ToString();
                cbTT.Text = row.Cells[7].Value.ToString();
            }
        }
        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "H1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã Nhân Viên";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Họ và Tên";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Ngày Sinh";
            cl3.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Địa Chỉ";

            cl4.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Số Điện Thoại";

            cl5.ColumnWidth = 17.5;
            
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Giới Tính";

            cl6.ColumnWidth = 15.5;
            
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Phòng Ban";

            cl7.ColumnWidth = 20.5;
            
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Trạng Thái";

            cl8.ColumnWidth = 30.5;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "H3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 4;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            //Căn giữa cột mã nhân viên

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaNV");
            DataColumn col2 = new DataColumn("HoTen");
            DataColumn col3 = new DataColumn("NgaySinh");
            DataColumn col4 = new DataColumn("Diachi");
            DataColumn col5 = new DataColumn("DiDong");
            DataColumn col6 = new DataColumn("id_gioitinh");
            DataColumn col7 = new DataColumn("id_phongban");
            DataColumn col8 = new DataColumn("id_trangthai");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);

            foreach (DataGridViewRow dtgvRow in dtgvEmployee.Rows)
            {
                DataRow dtrow = dataTable.NewRow();

                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;
                dtrow[5] = dtgvRow.Cells[5].Value;
                dtrow[6] = dtgvRow.Cells[6].Value;
                dtrow[7] = dtgvRow.Cells[7].Value;

                dataTable.Rows.Add(dtrow);
            }
            ExportFile(dataTable, "Danh sach", "DANH SÁCH NHÂN VIÊN");
        }
        
        private void dtgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;
            //if (index > 0)
            //{
            //    txbId.Text = dtgvEmployee.Rows[index].Cells["MaSV"].Value.ToString();
            //    txbName.Text = dtgvEmployee.Rows[index].Cells["HoTen"].Value.ToString();
            //    dtBirth.Text = dtgvEmployee.Rows[index].Cells["NgaySinh"].Value.ToString();
            //    cbGender.Text = dtgvEmployee.Rows[index].Cells["id_gioitinh"].Value.ToString();
            //    txbAddress.Text = dtgvEmployee.Rows[index].Cells["DiaChi"].Value.ToString();
            //    txbDiDong.Text = dtgvEmployee.Rows[index].Cells["DiDong"].Value.ToString();
            //    cbPB.Text = dtgvEmployee.Rows[index].Cells["id_phongban"].Value.ToString();
            //    cbTT.Text = dtgvEmployee.Rows[index].Cells["id_trangthai"].Value.ToString();
            //}
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        //Check validate
        public bool checkData()
        {
            List<NhanVien> lst = nvbll.ReadNV();
            NhanVien nv = new NhanVien();

            string input1 = txbId.Text.Trim();
            string input2 = txbName.Text.Trim();
            string input3 = dtBirth.Text.Trim();
            string input4 = txbAddress.Text.Trim();
            string input5 = cbGender.Text.Trim();
            string input6 = txbDiDong.Text.Trim();
            string input7 = cbPB.Text.Trim();
            string input8 = cbTT.Text.Trim();

            if (string.IsNullOrWhiteSpace(input1))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbId.Focus();
                return false;
            }
            if (input1.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("Mã sinh viên chỉ được nhập số.");
                txbId.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(input2))
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbName.Focus();
                return false;
            }
            if (input2.Any(char.IsDigit))
            {
                MessageBox.Show("Tên nhân viên không được chứa số.");
                txbName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(input3))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtBirth.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(input4))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbAddress.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(input5))
            {
                
            }
            if (string.IsNullOrWhiteSpace(input6))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbDiDong.Focus();
                return false;
            }
            if (!string.IsNullOrEmpty(input6))
            {
                if (input6.Any(c => !char.IsDigit(c)))
                {
                    MessageBox.Show("Số điện thoại chỉ được nhập số.");
                    txbDiDong.Focus();
                    return false;
                }
            }
            if (string.IsNullOrWhiteSpace(input7))
            {
                MessageBox.Show("Bạn chưa chọn phòng ban nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbPB.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(input8))
            {
                MessageBox.Show("Bạn chưa tinh trạng nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTT.Focus();
                return false;
            }

            return true;
        }

        private void txbFind_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg;*.png)|*.jpg|*.jpeg|*.png", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TaiKhoan tk = new TaiKhoan();
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    txbFileName.Text = ofd.FileName;

                }
            }
        }
        //byte[] ConvertImageToBytes(Image image)
        //{
        //    using(MemoryStream ms = new MemoryStream())
        //    {
        //        image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        //        return ms.ToArray();
        //    }
        //}
        //public Image ConvertByteToImage(byte[] data)
        //{
        //    using(MemoryStream ms = new MemoryStream(data))
        //    {
        //        return Image.FromStream(ms);
        //    }
        //}


    }
}
