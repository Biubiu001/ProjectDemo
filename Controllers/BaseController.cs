using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using IServer;
using Microsoft.AspNetCore.Mvc;

namespace ProjectDemo.Controllers
{

    [Consumes(MediaTypeNames.Application.Json,"multipart/form-data;")]
    [Produces(MediaTypeNames.Application.Json)]
    [Route("api/[controller]/[action]")]
    public class BaseController : ControllerBase
    {

      
        private readonly IMapper _mapper;

        public BaseController() { 
        
        }
        public BaseController(  IMapper mapper) {
            _mapper = mapper;
        
        }
    }
}