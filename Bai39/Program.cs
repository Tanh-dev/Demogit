using System;

namespace Bai39
{
    class Sinhvien
    {
        public string ten { get; set; }
        public int tuoi { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Tạo đối tượng Person
            Sinhvien person = new Sinhvien { ten = "Đum", tuoi = 25 };

            // Lấy thông tin kiểu của đối tượng
            Type type = person.GetType();

            // In tên lớp
            Console.WriteLine("ten lop: " + type.Name);

            // Lấy thuộc tính Name và Age, sau đó in giá trị của chúng
            Console.WriteLine("ten: " + type.GetProperty("ten").GetValue(person));
            Console.WriteLine("tuoi: " + type.GetProperty("tuoi").GetValue(person));
        }
    }
}

