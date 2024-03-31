using LibraryManagerApi.Communication.Request;
using LibraryManagerApi.Communication.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagerApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : LIbraryManagerApiBaseController
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var response = new ResponseRegisterBookJson
        {
            Id = request.Id,
            Title = request.Title,
        };

        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll() 
    {
        var response = new List<Book>()
        {
            new Book {
            Id = 1,
            Title = "Test",
            Author = "test",
            Price = 60,
            Quantity = 50
            },
            new Book {
            Id = 1,
            Title = "Test",
            Author = "test",
            Price = 60,
            Quantity = 50
            }
        };

        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateBookJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete() 
    {
        return NoContent();
    }
}
