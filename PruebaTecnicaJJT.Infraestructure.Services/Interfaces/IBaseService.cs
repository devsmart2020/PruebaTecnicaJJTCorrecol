namespace PruebaTecnicaJJT.Infraestructure.Services.Interfaces
{
    public interface IBaseService
    {      
        Task<bool> Create<TDto>(TDto Dto);
        Task<bool> Delete(dynamic pk);
        Task<TDto> FindById<TDto, TEntity>(TDto entity, IDictionary<string, object> parameters);
        Task<IEnumerable<TEntity>> FindListById<TEntity>(dynamic valueParameter);
        Task<IEnumerable<TDto>> GetAll<TDto>();
    }
}
