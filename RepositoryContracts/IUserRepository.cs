using Entities;

namespace RepositoryContracts;

public interface IUserRepository
{
    Task AddAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(int id);
    Task GetSingleAsync(int id);
    IQueryable GetManyAsync();
}