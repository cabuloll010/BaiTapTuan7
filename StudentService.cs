using QuanLySinhVien.DAL;
using QuanLySinhVien.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuanLySinhVien.BLL
{
    public class StudentService
    {
        private readonly StudentRepository _repository = new StudentRepository();

        public async Task<List<Student>> LayDanhSachAsync()
        {
            return await _repository.LayDanhSachAsync();
        }

        public async Task ThemSinhVienAsync(string hoTen, double diem)
        {
            if (string.IsNullOrWhiteSpace(hoTen))
                throw new ArgumentException("Vui lòng nhập họ tên!");

            if (diem < 0 || diem > 10)
                throw new ArgumentException("Điểm không hợp lệ! (Phải từ 0 đến 10)");

            var sv = new Student
            {
                FullName = hoTen.Trim(),
                Grade = diem
            };

            await _repository.ThemAsync(sv);
        }

        public async Task SuaSinhVienAsync(int id, string hoTen, double diem)
        {
            if (id <= 0)
                throw new ArgumentException("Vui lòng chọn một dòng để sửa!");

            if (string.IsNullOrWhiteSpace(hoTen))
                throw new ArgumentException("Vui lòng nhập họ tên!");

            if (diem < 0 || diem > 10)
                throw new ArgumentException("Điểm không hợp lệ! (Phải từ 0 đến 10)");

            var sv = new Student
            {
                Id = id,
                FullName = hoTen.Trim(),
                Grade = diem
            };

            await _repository.SuaAsync(sv);
        }

        public async Task XoaSinhVienAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Vui lòng chọn một dòng để xóa!");

            await _repository.XoaAsync(id);
        }

        public async Task<List<Student>> LocSinhVienDatAsync()
        {
            return await _repository.LocDatAsync();
        }
    }
}