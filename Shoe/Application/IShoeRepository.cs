namespace Shoe.Application
{
    public interface IShoeRepository
    {
        List<Model.Shoe> GetShoes();
        bool DeleteShoe(int id);
    }
}
