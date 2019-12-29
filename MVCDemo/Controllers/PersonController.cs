using MVCDemo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Repository;

namespace MVCDemo.Controllers
{
    public class PersonController : Controller
    {

        PersonRepository person = new PersonRepository();

        // GET: Person
        public ActionResult Index()
        {
            IEnumerable<PersonModel> obj = person.SelectList();
            return View(obj);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PersonModel per)
        {
            try
            {
                person.InsertList(per);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            PersonModel per = person.SelectId(id);
            return View(per);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            PersonModel per = person.SelectId(id);
            return View(per);
        }

        [HttpPost]
        public ActionResult Edit(int id, PersonModel per)
        {
            try
            {
                person.UpdateList(per);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult Delete(int id)
        {
            PersonModel obj = person.SelectId(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                person.DeleteList(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}