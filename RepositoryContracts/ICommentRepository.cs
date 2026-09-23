using Entities;

namespace RepositoryContracts;

public interface ICommentRepository
{
    Task AddAsync(Comment comment);
    Task UpdateAsync(Comment comment);
    Task DeleteAsync(int id);
    Task GetSingleAsync(int id);
    IQueryable GetManyAsync();
}