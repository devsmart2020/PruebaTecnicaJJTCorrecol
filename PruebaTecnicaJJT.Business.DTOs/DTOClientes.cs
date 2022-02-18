using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaJJT.Business.DTOs
{
    public sealed class DTOClientes : DTOBase
    {
        [Key]
        public int ClnId { get; set; }
        [Required(ErrorMessage = "El Tipo de Identifiación requerido")]
        public int ClnTpoId { get; set; }
        [Required(ErrorMessage = "El Documento es requerido")]
        public string ClnNumeroIdentificacion { get; set; } = null!;
        [Required(ErrorMessage = "El Nombre es requerido")]
        public string ClnNombres { get; set; } = null!;
        [Required(ErrorMessage = "Los Apellidos son requeridos")]
        public string ClnApellidos { get; set; } = null!;
        public string? ClnEmail { get; set; }
        public string? ClnTelefono { get; set; }
        public string? ClnTelefonoAlterno { get; set; }
        [Required(ErrorMessage = "La Razón Social es requerida")]
        public string ClnRazonSocial { get; set; } = null!;
        [Required(ErrorMessage = "El País requerido")]
        public int ClnPaisCodigo { get; set; }
        [Required(ErrorMessage = "El Departamento requerido")]
        public int ClnDptColCodigoDane { get; set; }
        [Required(ErrorMessage = "El Municipio requerido")]
        public int ClnDvsPltColCodigoDane { get; set; }

    }
}
