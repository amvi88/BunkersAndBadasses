using Models.Builder;

namespace Business.Factories
{
    public interface IItemFactory<I, P> 
        where I: Item 
        where P: BaseFactoryParameters
    {
        public ItemWrapper<I> Manufacture(P factoryParameters);
    }

}