using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class NhanVienAccess:DBConnection
    {
        
        public List<NhanVien> ReadNV()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_NhanVien", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<NhanVien> list = new List<NhanVien>();

            PBDAL pb = new PBDAL();
            GioiTinhDAL gt = new GioiTinhDAL();
            TrangThaiDAL tt = new TrangThaiDAL();

            while (reader.Read())
            {
                NhanVien nv = new NhanVien();
                
                nv.MaNV = int.Parse(reader["MaNV"].ToString());
                nv.HoTen = reader["HoTen"].ToString();
                nv.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                nv.DiaChi = reader["DiaChi"].ToString();
                nv.DiDong = reader["DiDong"].ToString();
                nv.GT = gt.ReadGT(int.Parse(reader["id_gioitinh"].ToString()));
                nv.PB = pb.ReadPB(int.Parse(reader["id_phongban"].ToString()));
                nv.TT = tt.ReadTT(int.Parse(reader["id_trangthai"].ToString()));
                //tk.filename = reader["FileName"].ToString();

                list.Add(nv);
            }
            conn.Close();
            return list;
        }
        public void AddNV(NhanVien nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_NhanVien values(@MaNV,@HoTen,@NgaySinh,@DiaChi,@DiDong,@id_gioitinh,@id_phongban,@id_trangthai)", conn);
            cmd.Parameters.Add(new SqlParameter("@MaNV", nv.MaNV));
            cmd.Parameters.Add(new SqlParameter("@HoTen", nv.HoTen));
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", nv.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", nv.DiaChi));
            cmd.Parameters.Add(new SqlParameter("@DiDong", nv.DiDong));
            cmd.Parameters.Add(new SqlParameter("@id_gioitinh", nv.GT.Id));
            cmd.Parameters.Add(new SqlParameter("@id_phongban", nv.PB.Id_PB));
            cmd.Parameters.Add(new SqlParameter("@id_trangthai", nv.TT.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void EditNV(NhanVien nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update tbl_NhanVien set HoTen=@HoTen, NgaySinh=@NgaySinh, DiaChi=@DiaChi, DiDong=@DiDong, id_gioitinh=@id_gioitinh, id_phongban=@id_phongban, id_trangthai=@id_trangthai where MaNV =@MaNV", conn);
           
            cmd.Parameters.Add(new SqlParameter("@MaNV", nv.MaNV));
            cmd.Parameters.Add(new SqlParameter("@HoTen", nv.HoTen));
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", nv.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", nv.DiaChi));
            cmd.Parameters.Add(new SqlParameter("@DiDong", nv.DiDong));
            cmd.Parameters.Add(new SqlParameter("@id_gioitinh", nv.GT.Id));
            cmd.Parameters.Add(new SqlParameter("@id_phongban", nv.PB.Id_PB));
            cmd.Parameters.Add(new SqlParameter("@id_trangthai", nv.TT.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteNV(NhanVien nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_NhanVien where MaNV=@MaNV", conn);
            cmd.Parameters.Add(new SqlParameter("@MaNV", nv.MaNV));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void SearchNV(NhanVien nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_NhanVien where HoTen like '%"+nv+"%'", conn);
            cmd.ExecuteNonQuery(); 
            conn.Close();
        }
    }
}
