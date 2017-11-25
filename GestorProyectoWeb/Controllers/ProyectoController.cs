﻿using GestorProyectoWeb.Models;
using GestorProyectoWeb.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestorProyectoWeb.Controllers
{
    public class ProyectoController : Controller
    {
        private Repositorio _repositorio;
        
        
        public ProyectoController()
        {
            ViewBag.showSuccessAlert = 0;
            _repositorio = new Repositorio();
            
        }

        // GET: Proyecto
        public ActionResult Index()
        {
            var proyectos = _repositorio.ObtenerProyectos();
            return View(proyectos);
        }

        // GET: Proyecto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Proyecto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proyecto/Create
        [HttpPost]
        public ActionResult Create(Proyecto proyecto)
        {
            try
            {
                   _repositorio.GuardarProyecto(proyecto);
            }
            catch (Exception ex)
            {

                return View();
            }

            return RedirectToAction("Index");
        }

        // GET: Proyecto/Edit/5
        public ActionResult Edit(int id)
        {
            Proyecto p = _repositorio.BuscarProyecto(id);
                return View(p);
        }

        // POST: Proyecto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Proyecto/Delete/5
        public ActionResult Delete(int id)
        {
            _repositorio.EliminarProyecto(id);
            ViewBag.showSuccessAlert = 1;
            return RedirectToAction("Index");
           
        }

        // POST: Proyecto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
