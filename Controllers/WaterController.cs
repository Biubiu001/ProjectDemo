using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using IServer;
using Microsoft.AspNetCore.Mvc;
using S.Core.Model;
using S.Data;

namespace ProjectDemo.Controllers
{
    
    public class WaterController : BaseController
    {

        private  IUserSevice _userService { get; }
        private readonly MysqlContext context;

        public WaterController(IUserSevice userSevice, IMapper mapper,MysqlContext mysqlContext) : base(mapper)
        {
            _userService = userSevice;
            context = mysqlContext;
        
        
        }
    
        public  IActionResult AddUser()
        {         
          var result =  _userService.AddUser();
            return Ok(result);
        }
        public async Task<IActionResult> GetUSer() { 
           await _userService.
        
        
        }
    }
}