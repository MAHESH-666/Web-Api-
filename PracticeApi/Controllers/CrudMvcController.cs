using PracticeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace PracticeApi.Controllers
{
    public class CrudMvcController : Controller
    {
        // GET: CrudMvc
        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            List<employee> emplist = new List<employee>();
            client.BaseAddress = new Uri("https://localhost:44307/api/newapi");

            var response = client.GetAsync("NewApi");
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<employee>>();
                display.Wait();
                emplist = display.Result;
            }
            return View(emplist);
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(employee emp)
        {
            client.BaseAddress = new Uri("https://localhost:44307/api/newapi");

            var response = client.PostAsJsonAsync<employee>("NewApi", emp);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Create");


        }


        public ActionResult Details(int id)
        {
            employee e = null;
            client.BaseAddress = new Uri("https://localhost:44307/api/newapi");
            var response = client.GetAsync("NewApi?id=" + id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<employee>();
                display.Wait();
                e = display.Result;
            }
            return View(e);
        }


        public ActionResult Edit(int id)
        {
            employee e = null;
            client.BaseAddress = new Uri("https://localhost:44307/api/newapi");
            var response = client.GetAsync("NewApi?id=" + id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<employee>();
                display.Wait();
                e = display.Result;
            }
            return View(e);

        }

        [HttpPost]
        public ActionResult Edit(employee e)
        {

            client.BaseAddress = new Uri("https://localhost:44307/api/newapi");

            var response = client.PutAsJsonAsync<employee>("NewApi", e);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Edit");

        }

        public ActionResult Delete(int id)
        {
            employee e = null;
            client.BaseAddress = new Uri("https://localhost:44307/api/newapi");
            var response = client.GetAsync("NewApi?id=" + id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<employee>();
                display.Wait();
                e = display.Result;
            }
            return View(e);

        }

        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {

            client.BaseAddress = new Uri("https://localhost:44307/api/newapi");

            var response = client.DeleteAsync("NewApi/"+id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Delete");
        }
    }
}