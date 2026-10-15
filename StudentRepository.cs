using Microsoft.EntityFrameworkCore;
using QuanLySinhVien.DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL
{
    public class StudentRepository
    {
        public async Task<List<Student>> LayDanhSachAsync()
        {
            using (var context = new AppDbContext())
            {
                return await context.Students.ToListAsync();
            }
        }

        public async Task ThemAsync(Student sv)
        {
            using (var context = new AppDbContext())
            {
                context.Students.Add(sv);
                await context.SaveChangesAsync();
            }
        }

        public async Task SuaAsync(Student sv)
        {
            using (var context = new AppDbContext())
            {
                var item = await context.Students.FindAsync(sv.Id);
                if (item != null)
                {
                    item.FullName = sv.FullName;
                    item.Grade = sv.Grade;
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task XoaAsync(int id)
        {
            using (var context = new AppDbContext())
            {
                var item = await context.Students.FindAsync(id);
                if (item != null)
                {
                    context.Students.Remove(item);
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task<List<Student>> LocDatAsync()
        {
            using (var context = new AppDbContext())
            {
                return await context.Students
                    .Where(sv => sv.Grade >= 5)
                    .OrderByDescending(sv => sv.Grade)
                    .ToListAsync();
            }
        }
    }
}