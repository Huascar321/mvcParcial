namespace Huascar.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Fairy
    {
        [Key]
        public int FairyID { get; set; }

        
        [Display(Name = "Nombre Completo")]
        [StringLength(24, MinimumLength = 2)]
        [Required]
        public string NickName { get; set; }
        public List Wishes { get; set; }
        public enum List
        {
            Hamburguesa,

            Harmonica,

            Hielo,
        }
        [DataType(DataType.EmailAddress, ErrorMessage = "Este correo no es correcto")]
        public string Email { get; set; }

        //[Display(Name = "Nombre completo")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "Cumpleaños")]
        public DateTime Bithdate { get; set; }

    }
}