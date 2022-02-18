using AutoMapper;
using PruebaTecnicaJJT.Infraestructure.Services.Interfaces;
using PruebaTecnicaJJT.Persistence.DALGeneric.Interfaces;

namespace PruebaTecnicaJJT.Infraestructure.Services.Implementation
{
    public sealed class PaisService : BaseService, IPaisService
    {
        #region Fields
        private readonly IDALGeneric _dALGeneric;
        private readonly IMapper _mapper;
        #endregion

        #region Ctor
        public PaisService(IDALGeneric dALGeneric, IMapper mapper)
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

        public Task<IEnumerable<TEntity>> FindListById<TEntity>(dynamic valueParameter)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TDto>> GetAll<TDto>()
        {
            object objName = typeof(TDto).Name;
            objName = "Pais";
            return _mapper.Map<IEnumerable<TDto>>(await _dALGeneric.GetAll(objName));
        }
        #endregion
    }
}
