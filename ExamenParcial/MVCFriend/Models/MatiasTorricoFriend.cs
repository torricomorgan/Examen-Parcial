using System;
using System.ComponentModel.DataAnnotations;

namespace MVCFriend.Models
{
    public enum TypeFriend{
        Conocido,
        CompañeroEstudio,
        ColegaDeTrabajo,
        Amigo,
        AmigoDeInfancia,
        Pariente
    }
    public class MatiasTorricoFriend
    {
        [Key]
        public int FriendId { get; set; }
        [Required]
        [Display(Name="Nombre Completo")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Tipo Amigo")]
        public TypeFriend Type { get; set; }
        [Display(Name = "Apodo")]
        public string Nickname { get; set; }
        [Display(Name = "Cumpleaños")]
        public DateTime Birthdate { get; set; }
    }
}