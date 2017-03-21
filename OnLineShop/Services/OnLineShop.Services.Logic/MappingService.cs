using AutoMapper;
using OnLineShop.Services.Logic.Contracts;

namespace OnLineShop.Services.Logic
{
    public class MappingService: IMappingService
    {
        public T Map<T>(object source)
        {
            return Mapper.Map<T>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return Mapper.Map<TSource, TDestination>(source, destination);
        }
    }
}
