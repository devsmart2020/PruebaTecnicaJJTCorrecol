namespace PruebaTecnicaJJT.Business.DTOs
{
    public sealed class DTOClientesGetAll
    {
        public int Id { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Telefono { get; set; }
        public string? TelAlterno { get; set; }
        public string? RazonSocial { get; set; }
        public string Departamento { get; set; } = null!;
        public string Municipio { get; set; }
    }
}
