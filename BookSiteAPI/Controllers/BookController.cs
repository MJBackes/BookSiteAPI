using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookSiteAPI.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IRepositoryManager repository;
        private readonly ILoggerManager logger;
        public BookController(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            repository = repositoryManager;
            logger = loggerManager;
        }
        [HttpGet]
        public IActionResult GetBooks()
        {
            try
            {
                var books = repository.Book.GetAllBooks(trackChanges: false);
                return Ok(books);
            }
            catch(Exception e)
            {
                logger.LogError($"Something went wrong in the {nameof(GetBooks)} action {e}.");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}