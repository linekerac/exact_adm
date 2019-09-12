﻿using ExactAdm.Application.DTO;
using ExactAdm.Application.Interfaces;
using ExactAdm.Domain;
using ExactAdm.Domain.Entities;
using ExactAdm.Domain.Models;
using ExactAdm.Infra.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ExactAdm.WebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        readonly protected IAppBase<User, UserDTO> app;


        public HomeController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration,
            IAppBase<User, UserDTO> app)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            this.app = app;
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            var usuario = app.SelecionarPorId(id);

            return View(usuario);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(UserDTO pUserDTO)
        {
            if (ModelState.IsValid)
            {
                //app.Alterar(pUserDTO);
                return RedirectToAction("Index");
            }
            app.Alterar(pUserDTO);
            return View(pUserDTO);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var userDTO = app.SelecionarTodos(); 
            return View(userDTO);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        //[Authorize(Roles = Constantes.ROLEADMIN)]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //[Authorize(Roles = Constantes.ROLEADMIN)]
        [HttpPost]
        public async Task<IActionResult> Register(UserDTO model)
        {
            var user = new ApplicationUser { UserName = model.USERID, Email = model.USERID };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                app.Incluir(model);
                if (model.Admin)
                {
                    await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, Constantes.ROLEADMIN));
                }

                await _userManager.AddClaimAsync(user, new Claim("Setor", model.Setor));
                return Redirect("~/Home/Login");
            }
            else
            {
                ModelState.AddModelError("", "O e-mail ou a senha inseridos estão incorretos");
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> LoginUser(UserTemp user)
        {
            var userInfo = await _userManager.FindByNameAsync(user.USERID);
            if (user == null)
            {
                return BadRequest("Invalid credentials");
            }

             var result = await _signInManager.CheckPasswordSignInAsync(userInfo, user.PASSWORD, true);
            if (!result.Succeeded)
            {
                return BadRequest("Invalid credentials");
            }

            var userToken = await BuildToken(user);
            if (userToken.Token != null)
            {
                //Save token in session object
                HttpContext.Session.SetString("JWToken", userToken.Token);
            }
            return Redirect("~/Index");
        }

        private async Task<UserToken> BuildToken(UserTemp userInfo)
        {
            var user = await _userManager.FindByNameAsync(userInfo.USERID);
            var userClaims = await _userManager.GetClaimsAsync(user);
            userClaims.Add(new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.USERID));
            userClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            //userClaims.Add(new Claim(ClaimTypes.Role, "User"));
            //userClaims.Add(new Claim(ClaimTypes.Role, "Admin"));
            //userClaims.Add(new Claim(ClaimTypes.Role, "SuperAdmin"));

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.USERID),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            // tempo de expiração do token: 1 hora
            var expiration = DateTime.UtcNow.AddHours(1);
            JwtSecurityToken token = new JwtSecurityToken(
               issuer: "http://localhost:45092/",
               audience: "http://localhost:45092/",
               claims: userClaims,
               expires: expiration,
               signingCredentials: creds);
            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };
        }

        public IActionResult Logoff()
        {
            HttpContext.Session.Clear();
            return Redirect("~/Home/Login");

        }
    }
}