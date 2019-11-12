using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Productos.Models;

namespace Productos.Controllers
{
    public class ProductosController : Controller
    {
        public List<Producto> Productos { get; set; }
        public ProductosController()
        {
            Productos = new List<Producto>
            {
            new Producto { Id = 1, Nombre = "Manzana", Descripcion = "Fruta proveniente del manzano", Tipo = "Fruta", Precio = 0.65, FechaCaducidad = Convert.ToDateTime("16/11/2019"), Imagen = "http://www.redagricola.com/cl/assets/uploads/2017/08/manazana-792x591-c-default.jpg" },
            new Producto { Id = 2, Nombre = "Pera", Descripcion = "Fruta proveniente del peral", Tipo = "Fruta", Precio = 0.75, FechaCaducidad = Convert.ToDateTime("15/11/2019"), Imagen = "https://cde.peru.com//ima/0/1/2/0/6/1206557/611x458/frutas.jpg" },
            new Producto { Id = 3, Nombre = "Ciruela", Descripcion = "Fruta proveniente del ciruelo", Tipo = "Fruta", Precio = 0.55, FechaCaducidad = Convert.ToDateTime("14/11/2019"), Imagen = "https://www.sportlifeargentina.com/media/cache/big/upload/images/article/5c57b1450ee6942e4d34a2f8/5c57b3bb0de694906e3494db-fruta-de-verano-ciruela-para-deportistas.jpg" },
            new Producto { Id = 4, Nombre = "Naranja", Descripcion = "Fruta proveniente del naranjo", Tipo = "Fruta", Precio = 0.29, FechaCaducidad = Convert.ToDateTime("17/11/2019"), Imagen = "https://static.elcorreo.com/www/multimedia/201902/08/media/cortadas/GF0N1J31-U401131236871ktC-U70573831277euB-624x385@El%20Correo-ElCorreo.jpg" },
            new Producto { Id = 5, Nombre = "Melocoton", Descripcion = "Fruta proveniente del melocotonero", Tipo = "Fruta", Precio = 1.3, FechaCaducidad = Convert.ToDateTime("13/11/2019"), Imagen = "https://www.hogarmania.com/archivos/201305/melocotones-xl-668x400x80xX.jpg" }
           

            };
        }



        public IActionResult Index()
        {

            ViewData["productos"] = Productos.OrderBy(producto => producto.Nombre).ToList();
            ViewBag.Nombre = "Arrate";



                return View(Productos.OrderBy(producto => producto.Nombre).ToList());
            
        }

        
        public IActionResult ProductosPrecio()
          {
        
                return View(Productos.OrderBy(producto => producto.Precio).ToList());

            
           
        }

        public IActionResult ProductosTipo()
        {
           
            {

                return View(Productos.OrderBy(producto => producto.Tipo).ToList());

            }
        }
    }
}