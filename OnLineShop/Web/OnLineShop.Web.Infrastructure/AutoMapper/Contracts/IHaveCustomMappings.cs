using AutoMapper;

namespace OnLineShop.Web.Infrastructure.AutoMapper.Contracts
{
    public  interface IHaveCustomMappings
    {
        void CreateMappings(IMapperConfigurationExpression configuration);
    }
}
