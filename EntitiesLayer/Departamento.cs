namespace EntitiesLayer
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Departamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Departamento()
        {
            this.Codigo_Documento = new HashSet<Codigo_Documento>();
            this.Codigo_Documento1 = new HashSet<Codigo_Documento>();
            this.Usuarios = new HashSet<Usuario>();
        }
    
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MinLength(3, ErrorMessage = "Debe contener minimo 3 digitos.")]
        [StringLength(30, ErrorMessage = "Solo puede contener 30 digitos.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MinLength(2, ErrorMessage = "Debe contener minimo 2 digitos.")]
        [StringLength(10, ErrorMessage = "Solo puede contener 10 digitos.")]
        public string Siglas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Codigo_Documento> Codigo_Documento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Codigo_Documento> Codigo_Documento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
