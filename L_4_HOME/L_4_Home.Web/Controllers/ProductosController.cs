﻿using L_4_Home.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L_4_Home.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {


            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "La Casa de tus sueños";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "La Casa de tus sueños";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "La Casa de tus sueños";

            var listadeProductos = new List<ProductoModel>();

            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return View(listadeProductos);
        }
    }
}