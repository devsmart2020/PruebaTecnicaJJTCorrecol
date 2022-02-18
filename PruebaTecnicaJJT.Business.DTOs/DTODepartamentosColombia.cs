namespace PruebaTecnicaJJT.Business.DTOs
{
    public sealed class DTODepartamentosColombia : DTOBase
    {

        public int DptColCodigo { get; set; }
        public int DptColCodigoDane { get; set; }
        public string DptColNombredelDepartamento { get; set; } = null!;
        public short DptColPaisCodigo { get; set; }
    }
}
