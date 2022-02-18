using AutoMapper;
using PruebaTecnicaJJT.Infraestructure.Services.Interfaces;
using PruebaTecnicaJJT.Persistence.DALGeneric.Interfaces;

namespace PruebaTecnicaJJT.Infraestructure.Services.Implementation
{
    public sealed class DivisionPoliticaService : BaseService, IDivisionPoliticaService
    {
        #region Fields
        private readonly IDALGeneric _dALGeneric;
        private readonly IMapper _mapper;
        #endregion

        #region Ctor
        public DivisionPoliticaService(IDALGeneric dALGeneric, IMapper mapper)
            : base(dALGeneric, mapper)
        {
            _dALGeneric = dALGeneric;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public Task<bool> Create<TDto>(TDto Dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(dynamic pk)
        {
            throw new NotImplementedException();
        }

        public Task<TDto> FindById<TDto, TEntity>(TDto entity, IDictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> FindListById<TEntity>(dynamic valueParameter)
        {
            object entity = typeof(TEntity).Name;
            entity = "DivisionPoliticaColombia_ByState";
            string nameParameter = "DptColCodigoDane";
            int valueParam = valueParameter;
            return (IEnumerable<TEntity>)await _dALGeneric.FindListById(entity, nameParameter, valueParam);
        }

        public async Task<IEnumerable<TDto>> GetAll<TDto>()
        {
            object objName = typeof(TDto).Name;
            objName = "DivisionPoliticaColombia";
            return _mapper.Map<IEnumerable<TDto>>(await _dALGeneric.GetAll(objName));
        }
        #endregion
    }
}
