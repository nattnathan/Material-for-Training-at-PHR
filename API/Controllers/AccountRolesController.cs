﻿using API.Models;
using API_CodeFirst.Base;
using API_CodeFirst.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API_CodeFirst.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AccountRolesController : BaseController<IAccountRoleRepository, AccountRole, int>
{
    public AccountRolesController(IAccountRoleRepository repository) : base(repository)
    {
    }
}
