using Entities;
using RepositoryContracts;
namespace InMemoryRepositories;

public class UserInMemoryRepository : IUserRepository
{
    private readonly List <User> _users = new();

    public Task AddAsync(User user)
    {
        user.Id = _users.Any() ? _users.Max(u => u.Id) + 1 : 1;
        _users.Add(user);
        return Task.FromResult(user);
    }

    public Task UpdateAsync(User user)
    {
        User? existingUser = _users.SingleOrDefault(u => u.Id == user.Id);
        if (existingUser is null)
        {
            throw new InvalidOperationException($"User with ID '{user.Id}' not found");
        }
        _users.Remove(existingUser);
        _users.Add(user);
        return Task.CompletedTask;
    }

    public Task DeleteAsync(int id)
    {
        User? userToRemove = _users.SingleOrDefault(u => u.Id == id);
        if (userToRemove is null)
        {
            throw new InvalidOperationException($"User with ID '{id}' not found");
        }
        _users.Remove(userToRemove);
        return Task.CompletedTask;
    }

    public Task GetSingleAsync(int id)
    {
        User? user = _users.SingleOrDefault(u => u.Id == id);
        if (user is null)
        {
            throw new InvalidOperationException($"User with ID '{id}' not found");
        }
        return Task.FromResult(user);
    }

    public IQueryable GetManyAsync()
    {
        return _users.AsQueryable();
    }
}