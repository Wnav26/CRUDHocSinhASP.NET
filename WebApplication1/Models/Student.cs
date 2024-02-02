using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { get; set; } // Mã sinh viên

        [Required(ErrorMessage = "Họ tên là trường bắt buộc.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Họ tên phải từ 4 đến 100 ký tự.")]
        [Display(Name = "Họ và tên")]
        public string Name { get; set; } // Họ tên

        [Required(ErrorMessage = "Email là trường bắt buộc.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        [Display(Name = "Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email không hợp lệ.")]
        public string Email { get; set; } // Email

        [Required(ErrorMessage = "Mật khẩu là trường bắt buộc.")]
        [MinLength(8, ErrorMessage = "Mật khẩu phải từ 8 ký tự trở lên.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=]).*$",
            ErrorMessage = "Mật khẩu phải chứa ít nhất một ký tự viết hoa, một ký tự viết thường, một số và một ký tự đặc biệt.")]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; } // Mật khẩu

        [Required(ErrorMessage = "Ngành học là trường bắt buộc.")]
        [Display(Name = "Ngành học")]
        public Branch? Branch { get; set; } // Ngành học

        [Required(ErrorMessage = "Giới tính là trường bắt buộc.")]
        [Display(Name = "Giới tính")]
        public Gender? Gender { get; set; } // Giới tính

        [Display(Name = "Hệ")]
        public bool IsRegular { get; set; } // Hệ: true-chính qui, false-phi chính qui

        [Required(ErrorMessage = "Địa chỉ là trường bắt buộc.")]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; } // Địa chỉ

        [Required(ErrorMessage = "Ngày sinh là trường bắt buộc.")]
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005", ErrorMessage = "Ngày sinh phải nằm trong khoảng từ 1/1/1963 đến 12/31/2005.")]
        public DateTime DateOfBorth { get; set; } // Ngày sinh
    }
}
