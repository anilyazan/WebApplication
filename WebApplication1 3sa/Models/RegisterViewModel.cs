

using System.ComponentModel.DataAnnotations;
namespace WebApplication1_3sa_.Models


{
  
    
        public class RegisterViewModel
        {
            [Required(ErrorMessage = "Kullanıcı adı yazmalısın")]
            [StringLength(30, ErrorMessage = "max 30 karakter olmalı")]
            public string UserName { get; set; }

            //[DataType(DataType.Password)] 
            [Required(ErrorMessage = "şifre yazmalısın")]
            [MinLength(6, ErrorMessage = "min 6 karakter olmalı")]
            [MaxLength(15, ErrorMessage = "max 15 karakter olmalı")]

            public string Password { get; set; }

            [Required(ErrorMessage = " re-şifre yazmalısın")]
            [MinLength(6, ErrorMessage = "re-min 6 karakter olmalı")]
            [MaxLength(15, ErrorMessage = "re-max 15 karakter olmalı")]
            [Compare(nameof(Password))]
            public string RePassword { get; set; }

        }
}
