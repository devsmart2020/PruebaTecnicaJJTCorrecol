using AutoMapper;
using PruebaTecnicaJJT.Infraestructure.Services.Util;
using PruebaTecnicaJJT.Persistence.DALGeneric.Interfaces;

namespace PruebaTecnicaJJT.Infraestructure.Services.Interfaces;

public class BaseService
{
    private readonly IMapper _mapper;
    public BaseService(IDALGeneric dALGeneric, IMapper mapper)
    {
        _mapper = mapper;
    }

    public IDictionary<string, object> ToMapperDictionary<TEntity>(TEntity entity)
    {
        TEntity tbEntity = _mapper.Map<TEntity>(entity);
        return EntitiesConvert.ToDictionary(tbEntity);
    }
}

