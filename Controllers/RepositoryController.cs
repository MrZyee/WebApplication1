using Microsoft.AspNetCore.Mvc;
using WebApplication1.Core;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class RepositoryController : Controller
    {
        [HttpDelete]
        public void Delete([FromQuery]int id)
        {
            DelRecord Delreco = new DelRecord();
            Delreco.Del(id);
            
        }
        [HttpPost]
        public void Add(string name,string surname, int age)
        {
            Class1 add = new Class1();
            add.button1_Click(name, surname, age);
        }
        [HttpPut]
        public void UpdateReco([FromBody] RepositoryViewModels model, [FromQuery] int id)
        {
            UpdateRecord update = new UpdateRecord();
            update.Update(model.name, model.surname, model.age, id);
        }

        //metoda dodania kolumny... do zrobienia
    }
}
