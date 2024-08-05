// NhanSu.cs
using System;

public abstract class NhanSu
{
    public string MaSo { get; set; }
    public string HoTen { get; set; }
    public int NamSinh { get; set; }

    protected NhanSu(string maSo, string hoTen, int namSinh)
    {
        MaSo = maSo;
        HoTen = hoTen;
        NamSinh = namSinh;
    }

    public virtual void InHoSo()
    {
        Console.WriteLine($"Mã số: {MaSo}");
        Console.WriteLine($"Họ tên: {HoTen}");
        Console.WriteLine($"Năm sinh: {NamSinh}");
    }

    public abstract decimal TinhLuong();
}
