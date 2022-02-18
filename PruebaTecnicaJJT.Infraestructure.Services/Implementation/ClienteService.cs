using AutoMapper;
using PruebaTecnicaJJT.Business.Models;
using PruebaTecnicaJJT.Infraestructure.Services.Interfaces;
using PruebaTecnicaJJT.Persistence.DALGeneric.Interfaces;

namespace PruebaTecnicaJJT.Infraestructure.Services.Implementation
{
    public sealed class ClienteService : BaseService, IClienteService
    {
        #region Fields
        private readonly IDALGeneric _dALGeneric;
        private readonly IMapper _mapper;
        #endregion

        #region Ctor
        public ClienteService(IDALGeneric dALGeneric, IMapper mapper)
            : base(dALGeneric, mapper)
        {
            _dALGeneric = dALGeneric;
            _mapper = mapper;
        }
        #endregion

        #region Methods    

        public async Task<bool> Create<TDto>(TDto Dto)
        {
            Clientes tbCliente = _mapper.Map<Clientes>(Dto);
            return await _dALGeneric.CreateOrUpdate(tbCliente, ToMapperDictionary(Dto)) != null;
        }

        public async Task<bool> Delete(dynamic pk)
        {
            Clientes cliente = new();
            return await _dALGeneric.Delete(pk, "ClnId", cliente);
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
            objName = "Clientes";
            return _mapper.Map<IEnumerable<TDto>>(await _dALGeneric.GetAll(objName));
        }
        #endregion
    }
}
