﻿using Classroom.Data;

namespace Classroom.Core.Repositories;

public interface IUserRepository
{
    ICollection<ApplicationUser> GetUsers(string? keyword);

    Task<ApplicationUser?> GetUser(string id);

    ApplicationUser UpdateUser(ApplicationUser user);
}
