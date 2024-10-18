using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using NwindMVC.Models;
using static System.Net.Mime.MediaTypeNames;

namespace NwindMVC.Controllers
{
    public class OrderController : Controller
    {
        private RepositoryOrders _repositoryOrders;
        public OrderController(RepositoryOrders repository)
        {
            _repositoryOrders = repository;
        }
        // GET: OrderController
        public ActionResult Index()
        {
            List<int> orderIds = _repositoryOrders.GetAllOrderId();
            OrderIdsViewModel idsViewModel = new OrderIdsViewModel(orderIds);           
            return View(idsViewModel);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            Order order=_repositoryOrders.FindOrderById(id);
            List<OrderDetail> detail = _repositoryOrders.FindOrderDetailByOrderId(id);
            ViewData["OrderDetail"] = detail;
            return View(order);
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
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

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
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

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
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
