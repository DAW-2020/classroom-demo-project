﻿using DAW.Entities;
using DAW.Enums;
using DAW.IServices;
using Laborator4_453.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService _service;
        public ProfessorController(IProfessorService service)
        {
            this._service = service;
        }

        [HttpGet("all")]
        [Authorize]
        public IActionResult GetAll()
        {
            var response = _service.GetAll();
            return Ok(response);
        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult Get(int id)
        {
            var response = _service.GetById(id);
            return Ok(response);
        }

        [HttpPost("update")]
        [Authorize]
        public IActionResult Update(Professor payload)
        {
            if (!UserIsInRole(UserTypeEnum.Admin, UserTypeEnum.Professor))
                return Unauthorized("You are not in role to permit this action");

            _service.Update(payload);
            return Ok();
        }

        [HttpPost("create")]
        [Authorize]
        public IActionResult Create(Professor payload)
        {
            if (!UserIsInRole(UserTypeEnum.Admin))
                return Unauthorized("You are not in role to permit this action");

            _service.Insert(payload);
            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(int id)
        {
            if (!UserIsInRole(UserTypeEnum.Admin))
                return Unauthorized("You are not in role to permit this action");

            _service.Delete(id);
            return Ok();
        }

        private bool UserIsInRole(params UserTypeEnum[] roles)
        {
            var user = GetUserFromContext();
            return roles.Select(x => x.ToString()).Contains(user.Type);
        }

        private User GetUserFromContext() =>
            (User)HttpContext.Items["User"];
    }
}
