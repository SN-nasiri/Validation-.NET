using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvc.Models.Entities
{
    public class Users
    {
        public long Id { get; set; }

        [DisplayName("ایمیل")]
        [Required(ErrorMessage ="لطفا ایمیل را وارد کنید")]
        [EmailAddress(ErrorMessage ="ایمیل را به درستی وارد کنید")]
        public string Email { get; set; }

        [DisplayName("نام")]
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Name { get; set; }

        [DisplayName("سن")]
        [Range(16,120)]
        public byte Age { get; set; }

        [DisplayName("شماره موبایل")]
        [Required]
        [RegularExpression(@"(\+98|0)?9\d{9}")]
        public string Mobile { get; set; }
    }
}
