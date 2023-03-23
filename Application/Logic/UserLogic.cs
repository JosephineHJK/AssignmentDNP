using Domain.DAOInterfaces;
using Domain.LogicInterfaces;
using Domain.Models;
using Entities.DTO;

namespace Domain.Logic;

public class UserLogic : IUserLogic
{
    private readonly IUserDao userDao;

    public UserLogic(IUserDao userDao)
    {
        this.userDao = userDao;
    }
    
    public async Task<User> CreateAsync(UserCreationDto dto)
    {
        User? existing = await userDao.GetByUsernameAsync(dto.UserName);
        if (existing != null)
            throw new Exception("Username already taken!");

        ValidateData(dto);
        User toCreate = new User
        {
            UserName = dto.UserName, Email = dto.Email, Password = dto.Password
        };
    
        User created = await userDao.CreateAsync(toCreate);
    
        return created;
    }

    public Task<User> Create(UserCreationDto dto)
    {
        throw new NotImplementedException();
    }

    private static void ValidateData(UserCreationDto userToCreate)
    {
        string userName = userToCreate.UserName;
        string passWord = userToCreate.Password;
        string email = userToCreate.Email;

        if (userName.Length < 3)
            throw new Exception("Username must be at least 3 characters!");

        if (userName.Length > 15)
            throw new Exception("Username must be less than 16 characters!");
        if (passWord.Length < 1)
            throw new Exception("You must write something!!");
        if (email.Length < 1)
            throw new Exception("Write your email here");
    }
    public Task<IEnumerable<User>> GetAsync(SearchUserParametersDto searchParameters)
    {
        return userDao.GetAsync(searchParameters);
    }
}