using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TesteCRUD.Data;
using TesteCRUD.Models;

namespace TesteCRUD.Controllers;

public class ReservasController : Controller
{
    readonly private ApplicationDBContext _db;

    public ReservasController(ApplicationDBContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        IEnumerable<ReservasModel> reservas = _db.Reservas;
        return View(reservas);
    }

    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(ReservasModel reservas)
    {
        if (ModelState.IsValid)
        {
            _db.Reservas.Add(reservas);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }

    public IActionResult Deletar(int id)
    {
        ReservasModel reserva = _db.Reservas.FirstOrDefault(x => x.Id == id)!;
        _db.Reservas.Remove(reserva);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Finalizar(int id)
    {
        ReservasModel reserva = _db.Reservas.FirstOrDefault(x => x.Id == id)!;
        reserva.DataSaida = DateTime.Now;
        _db.Reservas.Update(reserva);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
}
