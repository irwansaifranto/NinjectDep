﻿using Business.Abstract;
using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class GreetingController : Controller
    {
        private readonly IGreetingRepository _greetingRepo;

        public GreetingController(IGreetingRepository greetingRepo)
        {
            _greetingRepo = greetingRepo;
        }
        // GET: Greeting
        public async Task<ActionResult> Index()
        {
            ViewBag.GreetingText = _greetingRepo.GetGreeting();

            return View();
        }

        // GET: Greeting/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Greeting/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Greeting/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Greeting/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Greeting/Edit/5
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

        // GET: Greeting/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Greeting/Delete/5
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
