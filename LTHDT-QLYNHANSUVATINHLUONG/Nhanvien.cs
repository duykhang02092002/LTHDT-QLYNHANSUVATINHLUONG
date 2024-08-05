// NhanVien.cs
using System;

public class NhanVien : NhanSu
{
    public string ChucVu { get; set; }
    public decimal LuongCoBan { get; set; }
    public decimal HeSoLuong { get; set; }

    public NhanVien(string maSo, string hoTen, int namSinh, string chucVu, decimal luongCoBan, decimal heSoLuong)
        : base(maSo, hoTen, namSinh)
    {
        ChucVu = chucVu;
        LuongCoBan = luongCoBan;
        HeSoLuong = heSoLuong;
    }

    public override void InHoSo()
    {
        base.InHoSo();
        Console.WriteLine($"Chức vụ: {ChucVu}");
    }

    public override decimal TinhLuong()
    {
        return LuongCoBan * HeSoLuong;
    }
}
