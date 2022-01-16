namespace EntitiesLayer
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Rep_Doc_DateRange_Result
    {
        public int ID { get; set; }

        [Display(Name = "Fecha")]
        public Nullable<System.DateTime> FechaDoc { get; set; }

        [Display(Name = "Usuario")]
        public string UserCorreo { get; set; }

        [Display(Name = "Departamento Origen")]
        public string Departamento_Origen { get; set; }

        [Display(Name = "Departamento Destino")]
        public string Departamento_Destino { get; set; }
        public string Secuencia { get; set; }
    }
}
