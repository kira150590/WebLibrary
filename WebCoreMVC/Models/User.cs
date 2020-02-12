using System;
using System.ComponentModel.DataAnnotations;

namespace WebCoreMVC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Không được để trống")]
        [StringLength(maximumLength: 20, MinimumLength = 8, ErrorMessage = "{0} Không được nhỏ hơn {2} và vượt quá {1}")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} Không được để trống")]
        [StringLength(maximumLength: 20, MinimumLength = 8, ErrorMessage = "{0} Không được nhỏ hơn {2} và vượt quá {1}")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }

        [Required(ErrorMessage = "{0} Không được để trống")]
        [StringLength(maximumLength: 100, MinimumLength = 1, ErrorMessage = "{0} Không được nhỏ hơn {2} và vượt quá {1}")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} Không được để trống")]
        [StringLength(maximumLength: 100, MinimumLength = 1, ErrorMessage = "{0} Không được nhỏ hơn {2} và vượt quá {1}")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "{0} Không được để trống")]
        [StringLength(maximumLength: 11, MinimumLength = 10, ErrorMessage = "{0} Không được nhỏ hơn {2} và vượt quá {1}")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "{0} Không được để trống")]
        [StringLength(maximumLength: 50, MinimumLength = 10, ErrorMessage = "{0} Không được nhỏ hơn {2} và vượt quá {1}")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(maximumLength: 200, MinimumLength = 8, ErrorMessage = "{0} Không được nhỏ hơn {2} và vượt quá {1}")]
        public string Address { get; set; }

        [StringLength(maximumLength: 200, MinimumLength = 8, ErrorMessage = "{0} Không được nhỏ hơn {2} và vượt quá {1}")]
        public string Province { get; set; }

        [StringLength(maximumLength: 200, MinimumLength = 8, ErrorMessage = "{0} Không được nhỏ hơn {2} và vượt quá {1}")]
        public string District { get; set; }

        public string ImageName { get; set; }
    }
}
