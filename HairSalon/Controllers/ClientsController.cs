using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Client.Include(client => client.Stylist).ToList();
      return View(model);
    }
    public ActionResult Delete(int id)
    {
      var thisClient = _db.Client.FirstOrDefault(clients => clients.ClientId == id);
      return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisClient = _db.Client.FirstOrDefault(clients => clients.ClientId == id);
      _db.Client.Remove(thisClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Restaurant thisClient = _db.Client.FirstOrDefault(clients => clients.ClientId == id);
      return View(thisClient);
    }
    public ActionResult Edit(int id)
    {
      var thisClient = _db.Client.FirstOrDefault(client => clients.ClientId == id);
      ViewBag.StylistId = new SelectList(_db.Stylist, "StylistId", "Name");
      return View(thisClient);
    }

    [HttpPost]
    public ActionResult Edit(Client Client)
    {
      _db.Entry(client).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Client.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylist, "StylisteId", "Name");
      return View();
    }
  }
}

