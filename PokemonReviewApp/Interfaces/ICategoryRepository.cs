using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemomByCategory(int categoryId);
        bool CategoryExists(int id);
        bool CategoryNameExists(string name);
        bool CreateCategory(Category category);
        bool Save();
    }
}
