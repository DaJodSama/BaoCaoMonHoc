using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DiDong { get; set; }
        public GioiTinhBEL GT { get; set; }
        public string TenGT
        {
            get { return GT.GioiTinh; }
        }
        public TrangThaiBEL TT { get; set; }
        public string TenTT
        {
            get { return TT.TrangThai; }
        }
        public PhongBanBEL PB { get; set; }
        public string TenPB
        {
            get { return PB.Name_PB; }
        }
    }
    public class GioiTinhBEL
    {
        public int Id { get; set; }
        public string GioiTinh { get; set; }
        public List<NhanVien> GTNhanVien { get; set; }
    }
    public class TrangThaiBEL
    {
        public int Id { get; set; }
        public string TrangThai { get; set; }
        public List<NhanVien> TTNhanVien { get; set; }
    }
    public class PhongBanBEL
    {
        public int Id_PB { get; set; }
        public string Name_PB { get; set; }
        public List<NhanVien> PBNhanVien { get; set; }
    }

}
