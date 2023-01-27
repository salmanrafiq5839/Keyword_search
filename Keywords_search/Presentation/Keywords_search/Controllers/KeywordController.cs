using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Keywords_search.Controllers
{
    public class KeywordController : Controller
    {
        // GET: KeywordController
        public ActionResult Index()
        {
            return View();
        }

        // GET: KeywordController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KeywordController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KeywordController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KeywordController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KeywordController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KeywordController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KeywordController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
