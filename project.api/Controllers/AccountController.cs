using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using project.api.Repository.UserR;
using project.api.ViewModels;

namespace project.api.Controllers
{
    [ApiController]
    [Route("api/account")]

    public class AccountController : ControllerBase
    {
        private readonly IUserRepository repo;
        private readonly IMapper mapp;

        public AccountController(IUserRepository repo , IMapper mapp)
        {
           
            this.repo = repo;
            this.mapp = mapp??
            throw new ArgumentNullException(nameof(mapp));
        }

        [HttpGet]
        public ActionResult<IEnumerable<register>> GetUsers()
        {

            var usersFromRepo = repo.GetUsers();


            return Ok(mapp.Map<IEnumerable<register>>(usersFromRepo));


        }


    }
}