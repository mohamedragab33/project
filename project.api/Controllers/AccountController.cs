﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using project.api.EntityModels;
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

        public AccountController(IUserRepository repo, IMapper mapp)
        {

            this.repo = repo;
            this.mapp = mapp ??
            throw new ArgumentNullException(nameof(mapp));
        }

        [HttpGet(Name = "GetAuthors")]
        public ActionResult<IEnumerable<register>> GetUsers()
        {

            var usersFromRepo = repo.GetUsers();


            return Ok(mapp.Map<IEnumerable<register>>(usersFromRepo));


        }
        
        [HttpGet("{UserId:Guid}")]
        [Authorize]
        public IActionResult GetUser(Guid UserId)
        {


            var userFromDto = repo.GetUser(UserId);
            if (userFromDto == null)
            {


                return NotFound();

            }



            return Ok(mapp.Map<register>(userFromDto));


        }

        [HttpPost] 

        public ActionResult<register> Create(UserForCreation userForCreation)
        {


            if (userForCreation==null)
            {


                return NotFound();
            }


            var userFordataBase = mapp.Map<User>(userForCreation);
            repo.AddUser(userFordataBase);
             repo.Save();



            var userForReturn = mapp.Map<register>(userFordataBase);
            return CreatedAtRoute("GetAuthors",userForReturn);

           
        }

      


    }
}