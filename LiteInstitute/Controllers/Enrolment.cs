using LiteInstitute.DTO;
using Microsoft.AspNetCore.Mvc;
using LiteInstitute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LiteInstitute.Controllers
{
    [Route("api/Enrolment")]
    [ApiController]
    public class Enrolment : ControllerBase
    {
        public InstuateDBContext ins;
        //
        private IMapper _mapper;
        public Enrolment(InstuateDBContext ff, IMapper maper)
        {
             ins = ff;
            _mapper = maper;
        }

        // GET: api/<Enrolment>
        [HttpGet]
        [Route("/GetStuentList")]
        public IActionResult GetStuentList()
        {
                 
            return Ok( ins.StudentTds.ToList());
        }

        // GET api/<Enrolment>/5
        [HttpGet]
        [Route("/GetStudnetById/{id}")]
        public IActionResult GetStudent(decimal id)
        {
            var record = ins.StudentTds.Where(x => x.Sid == id).FirstOrDefault();
            return Ok(record);
        }

        // POST api/<Enrolment>
        [HttpPost]
        [Route("/AddStudent")]
        public IActionResult AddStudent([FromBody] Student value)
        {
            StudentTd category = new StudentTd();
            StudentAddressTd addr = new StudentAddressTd();
           
          var c =  _mapper.Map<Student, StudentTd>(value, category);
           var address = value.Address.FirstOrDefault();
            c.StudentAddressTds.Add(new StudentAddressTd { City = address .City, Street = address.City, Sid = c.Sid} );
            var stdata =  new StudentTd {Name= value.name, Cource = value.Cource, Email = value.Email, Phone = value.Phone};
            ins.StudentTds.Add(c);
          
          ins.SaveChanges();
            return Ok(value);
        }

        // PUT api/<Enrolment>/5
        [HttpPut]
        [Route("/UpdateStudent/{id}")]
        public void UpdateStudent(int id, [FromBody] Student value)
        {

        }

        // DELETE api/<Enrolment>/5
        [HttpDelete()]
        [Route("/DeleteStudent/{id}")]
        public void DeleteStudent(int id)
        {

        }
    }
}
