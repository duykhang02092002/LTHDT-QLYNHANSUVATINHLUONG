// GiaoVien.cs
using System;

public class GiaoVien : NhanSu
{
    public string HocHam { get; set; }
    public string HocVi { get; set; }
    public int SoTietGiang { get; set; }

    public GiaoVien(string maSo, string hoTen, int namSinh, string hocHam, string hocVi, int soTietGiang)
        : base(maSo, hoTen, namSinh)
    {
        HocHam = hocHam;
        HocVi = hocVi;
        SoTietGiang = soTietGiang;
    }

    public override void InHoSo()
    {
        base.InHoSo();
        Console.WriteLine($"Học hàm: {HocHam}");
        Console.WriteLine($"Học vị: {HocVi}");
        Console.WriteLine($"Số tiết giảng: {SoTietGiang}");
    }

    public override decimal TinhLuong()
    {
        decimal donGia;
        switch (HocVi.ToLower())
        {
            case "tiến sĩ":
                donGia = 65000;
                break;
            case "thạc sĩ":
                donGia = 55000;
                break;
            case "cử nhân":
                donGia = 50000;
                break;
            default:
                donGia = 0;
                break;
        }
        return SoTietGiang * donGia;
    }
}
