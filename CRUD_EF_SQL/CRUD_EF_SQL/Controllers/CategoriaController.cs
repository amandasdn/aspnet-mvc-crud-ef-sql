using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD_EF_SQL.Models;

namespace CRUD_EF_SQL.Controllers
{
    public class CategoriaController : Controller
    {
        DbProdutosEntities dbProdutos = new DbProdutosEntities();

        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<Categoria> categorias = dbProdutos.Categoria;

            return View(categorias);
        }

        [HttpGet]
        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(Categoria objCategoria)
        {
            if (ModelState.IsValid)
            {
                objCategoria.datacadastro = DateTime.Now;
                dbProdutos.Categoria.Add(objCategoria);
                dbProdutos.SaveChanges();

                return RedirectToAction("Index", new { status = "cadastrada" });
            }

            return View(objCategoria);
        }

        [HttpGet]
        public ActionResult Detalhes(int? id_categoria)
        {
            string teste = "";

            if (id_categoria == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            teste = teste;

            return View();
        }
    }
}