﻿using System;
using System.Collections.Generic;
using System.Linq;
using API_CoreProject.Models;
using API_CoreProject.Models.CRUD_Angular;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_CoreProject.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Company> GetCompanies()
        {
            Mcontext mcontext = new Mcontext();
            //var a = mcontext.Companies.ToList();
            return mcontext.Companies;
        }

        // GET api/values/5 
        [HttpGet("{id}")]
        public List<Company> Get(int id)
        {
            return new List<Company>();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Company Company)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Company Company)
        {
        }

        // PUT api/values/5
        [HttpPatch("{id}")]
        public void Patch(int id, [FromBody]Company Company)
        {

        }
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}

/*
try
            {
                Mcontext mcontext = new Mcontext();
                List<Company> Companies = new List<Company>()
                {
                   new Company
                   {
                       Name = "microsoft",
                       Description = "microsoft company is a american's software company ",
                       Technologies = new List<Technology>()
                       {
                           new Technology
                           {
                               Name = "C#",
                               Description = "a multi programming language that use in windows",
                           },
                           new Technology
                           {
                               Name = "typeScript",
                               Description = "a language programming that use in angular"

                           }
                       }
                   },
                   new Company
                   {
                       Name = "google",
                       Description = "google company is a american search company",
                       Technologies = new List<Technology>()
                       {
                           new Technology
                           {
                               Name = "angular",
                               Description = "a language that use in web"
                           },
                           new Technology
                           {
                               Name = "google search",
                               Description = "a engine that search item free"
                           }
                       }
                   }
                };
                mcontext.Companies.AddRange(Companies);
                mcontext.SaveChanges();
            }
            catch (Exception)
            {
            } 
*/
