namespace PruebaTecnicaJJT.Business.DTOs
{
    public sealed class DTODivisionPoliticaColombia : DTOBase
    {
        public int DvsPltColCodigo { get; set; }
        public int DvsPltColCodigoDane { get; set; }
        public string DvsPltColNombreMunicipio { get; set; } = null!;
        public int DvsPltColDptColCodigoDane { get; set; }
    }
}
