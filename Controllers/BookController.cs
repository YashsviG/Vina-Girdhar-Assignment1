using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Assignment1.Controllers
{
    public class BookController : Controller
    {
        static readonly HttpClient client = new HttpClient();
        static string books = "";
        
        static JsonElement booksArray;
        static async Task getBooks()
        {
            try
            {
                string responseBody = await client.GetStringAsync("https://www.googleapis.com/books/v1/volumes?q=harry+potter");

                booksArray = JsonSerializer.Deserialize<JsonElement>(responseBody);
                
                books = responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
        [Authorize]
        public async Task<ActionResult> Index()
        {  
            await getBooks();
            ViewBag.books = books;
            return View();
        }
        [Authorize]
        public IActionResult bookInfo(int id)
        {
            
            var book = booksArray.GetProperty("items")[id].GetProperty("volumeInfo");
            
            Console.WriteLine(book);
            Console.WriteLine(book.GetProperty("title"));

            ViewBag.bookTitle = book.GetProperty("title");
            ViewBag.authers = book.GetProperty("authors");
            ViewBag.publisher = book.GetProperty("publisher");
            ViewBag.publishDate = book.GetProperty("publishedDate");
            ViewBag.description = book.GetProperty("description");
            ViewBag.thumbnail = book.GetProperty("imageLinks").GetProperty("smallThumbnail");
            return View();
        }
    }
}