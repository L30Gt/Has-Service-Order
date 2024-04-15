using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OsDsII.api.Data;
using OsDsII.api.Models;

namespace OsDsII.api.Repository.Comments
{
    public sealed class CommentRepository : ICommentRepository
    {
        private readonly DataContext _dataContext;

        public CommentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task AddCommentAsync(Comment comment)
        {
            await _dataContext.Comments.AddAsync(comment); // This line adds the comment to the context
            await _dataContext.SaveChangesAsync();
        }

    }
}
