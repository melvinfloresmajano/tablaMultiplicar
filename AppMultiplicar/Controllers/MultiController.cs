using AppMultiplicar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMultiplicar.Controllers
{
public class MultiController : Controller
{
calculos Modelo = new calculos();
public ActionResult Index(){
ViewBag.bandera = false;
if (Request.HttpMethod == "POST"){
ViewBag.x = true;int nuevo = Convert.ToInt32(Request["txtTabla"]);
ViewBag.ver = Modelo.Proceso(nuevo);}
return View();
}}}