using Library;
using Microsoft.AspNetCore.Mvc;
using RESTService.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTService.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {


        private readonly BooksManager _manager = new BooksManager();

        // GET: api/<BooksController>
        [HttpGet]
        public List<Book> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public Book Get(string id)
        {
            return _manager.GetBook(id);
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            _manager.Add(book);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Book book)
        {
            _manager.Update(id, book);
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _manager.Delete(id);
        }
    }
}
