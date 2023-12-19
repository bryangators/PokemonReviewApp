using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;


        public CategoryRepository(DataContext context)
        {
            _context = context;
        }


        public bool CategoryNameExists(string name)
        {
            return _context.Categories.Where(c  => c.Name.Trim().ToUpper() == name.Trim().ToUpper()).Any();
        }


        public bool CategoryExists(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
        }


        public bool CreateCategory(Category category)
        {
            _context.Categories.Add(category);

            return Save();
        }


        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }


        public Category GetCategory(int id)
        {
            return _context.Categories.Where(c => c.Id == id).FirstOrDefault();
        }


        public ICollection<Pokemon> GetPokemomByCategory(int categoryId)
        {
            return _context.PokemonCategories.Where(c => c.CategoryId == categoryId).Select(c => c.Pokemon).ToList();
        }


        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }
    }
}
