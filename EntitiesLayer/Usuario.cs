namespace EntitiesLayer
{
    using System.ComponentModel.DataAnnotations;

    public partial class Usuario
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MinLength(3, ErrorMessage = "Debe contener minimo 3 digitos.")]
        [StringLength(40, ErrorMessage = "Solo puede contener 40 digitos.")]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Debe ser un correo valido")]
        [StringLength(40, ErrorMessage = "Solo puede contener 40 digitos.")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public int Departamento { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MinLength(3, ErrorMessage = "Debe contener minimo 3 digitos.")]
        [StringLength(15, ErrorMessage = "Solo puede contener 15 digitos.")]
        public string Cargo { get; set; }
    
        public virtual Departamento Departamento1 { get; set; }
    }
}
