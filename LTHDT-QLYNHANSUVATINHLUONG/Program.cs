// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<NhanSu> danhSachNhanSu = new List<NhanSu>();

        // Nhập thông tin nhân sự
        Console.Write("Nhập số lượng nhân sự: ");
        if (int.TryParse(Console.ReadLine(), out int soNhanSu) && soNhanSu > 0)
        {
            for (int i = 0; i < soNhanSu; i++)
            {
                Console.WriteLine($"\nNhập thông tin cho nhân sự thứ {i + 1}:");

                Console.Write("Loại nhân sự (1- Nhân viên, 2- Giáo viên): ");
                int loaiNhanSu;
                if (!int.TryParse(Console.ReadLine(), out loaiNhanSu) || (loaiNhanSu != 1 && loaiNhanSu != 2))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại.");
                    i--;
                    continue;
                }

                Console.Write("Mã số: ");
                string maSo = Console.ReadLine();

                Console.Write("Họ tên: ");
                string hoTen = Console.ReadLine();

                Console.Write("Năm sinh: ");
                int namSinh;
                while (!int.TryParse(Console.ReadLine(), out namSinh) || namSinh < 1900 || namSinh > DateTime.Now.Year)
                {
                    Console.Write("Năm sinh không hợp lệ, vui lòng nhập lại: ");
                }

                if (loaiNhanSu == 1) // Nhân viên
                {
                    Console.Write("Chức vụ: ");
                    string chucVu = Console.ReadLine();

                    Console.Write("Lương cơ bản: ");
                    decimal luongCoBan;
                    while (!decimal.TryParse(Console.ReadLine(), out luongCoBan) || luongCoBan < 0)
                    {
                        Console.Write("Lương cơ bản không hợp lệ, vui lòng nhập lại: ");
                    }

                    Console.Write("Hệ số lương: ");
                    decimal heSoLuong;
                    while (!decimal.TryParse(Console.ReadLine(), out heSoLuong) || heSoLuong < 0)
                    {
                        Console.Write("Hệ số lương không hợp lệ, vui lòng nhập lại: ");
                    }

                    NhanVien nhanVien = new NhanVien(maSo, hoTen, namSinh, chucVu, luongCoBan, heSoLuong);
                    danhSachNhanSu.Add(nhanVien);
                }
                else if (loaiNhanSu == 2) // Giáo viên
                {
                    Console.Write("Học hàm: ");
                    string hocHam = Console.ReadLine();

                    Console.Write("Học vị: ");
                    string hocVi = Console.ReadLine();

                    Console.Write("Số tiết giảng: ");
                    int soTietGiang;
                    while (!int.TryParse(Console.ReadLine(), out soTietGiang) || soTietGiang < 0)
                    {
                        Console.Write("Số tiết giảng không hợp lệ, vui lòng nhập lại: ");
                    }

                    GiaoVien giaoVien = new GiaoVien(maSo, hoTen, namSinh, hocHam, hocVi, soTietGiang);
                    danhSachNhanSu.Add(giaoVien);
                }
            }
        }
        else
        {
            Console.WriteLine("Số lượng nhân sự không hợp lệ.");
            return;
        }

        // In thông tin và tính lương
        Console.WriteLine("\nDanh sách nhân sự:");
        foreach (var nhanSu in danhSachNhanSu)
        {
            nhanSu.InHoSo();
            Console.WriteLine($"Lương: {nhanSu.TinhLuong()}");
            Console.WriteLine();
        }
    }
}
