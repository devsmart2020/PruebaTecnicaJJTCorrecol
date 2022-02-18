namespace PruebaTecnicaJJT.Business.Models
{
    public partial class TipoIdentificacion
    {

        public short TpoIdnId { get; set; }
        public string TpoIdnNombre { get; set; } = null!;
        public string TpoIdnDescripcion { get; set; } = null!;
        public string TpoIdnCodigo { get; set; } = null!;
        public short TpoIdnPaisCodigo { get; set; }
    }
}
