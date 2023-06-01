using FromMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FromMVCProject.Controllers
{
    public class ConnectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult SendBook()
        //{
        //    HttpClient httpClient = new HttpClient(); 
        //    httpClient.BaseAddress = new Uri("https://localhost:7006/api/Students/"); // BaseAddress'i API'nin kök adresine ayarla
        //    var response = await httpClient.GetAsync("FakeDataAl"); // API yönlendirmesini doğru şekilde ayarla
        //    response.EnsureSuccessStatusCode();
        //    var content = await response.Content.ReadAsStringAsync();
        //    var students = JsonConvert.DeserializeObject<List<Students2>>(content);
        //    return View(students);
        //    return View();
        //}
        public async Task<IActionResult> GetBook()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7006/api/"); // BaseAddress'i API'nin kök adresine ayarla
            var response = await httpClient.GetAsync("Kitaps"); // API yönlendirmesini doğru şekilde ayarla
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var students = JsonConvert.DeserializeObject<List<Book>>(content);
            return View(students);
        }
    }
}
