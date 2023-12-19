using PokemonReviewApp.Models;
using System.Data;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfAPokemon(int pokeId);
        bool ReviewExists(int reviewId);
        bool ReviewTitleExists(string title);
        bool CreateReview(Review review);
        bool Save();
    }
}
