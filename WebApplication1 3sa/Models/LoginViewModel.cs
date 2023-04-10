

using System.ComponentModel.DataAnnotations;
namespace WebApplication1_3sa_.Models


{
    public partial class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı yazmalısın")]
        [StringLength(30, ErrorMessage = "max 30 karakter olmalı")]
        public string UserName{ get; set; }

        //[DataType(DataType.Password)] 
        [Required(ErrorMessage = "şifre yazmalısın")]
        [MinLength(6, ErrorMessage = "min 6 karakter olmalı")]
        [MaxLength(15, ErrorMessage = "max 15 karakter olmalı")]

        public string Password { get; set; }
    }
}
