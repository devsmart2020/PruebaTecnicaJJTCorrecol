namespace PruebaTecnicaJJT.Business.Models
{
    public partial class Clientes
    {
        public int ClnId { get; set; }
        public int ClnTpoId { get; set; }
        public string ClnNumeroIdentificacion { get; set; } = null!;
        public string ClnNombres { get; set; } = null!;
        public string ClnApellidos { get; set; } = null!;
        public string? ClnEmail { get; set; }
        public string? ClnTelefono { get; set; }
        public string? ClnTelefonoAlterno { get; set; }
        public string ClnRazonSocial { get; set; } = null!;
        public int ClnPaisCodigo { get; set; }
        public int ClnDptColCodigoDane { get; set; }
        public int ClnDvsPltColCodigoDane { get; set; }

    }
}
