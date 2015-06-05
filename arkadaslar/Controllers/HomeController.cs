﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using System.Data.Entity.Infrastructure;
using arkadaslar.Models;

namespace arkadaslar.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index(int page = 1)
        {
            return View(db.post.OrderByDescending(v => v.ID).ToPagedList(page, 3));
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.post.Include(s => s.Pictures).SingleOrDefault(s => s.ID == id);
            if (post == null)
            {
                return HttpNotFound();
            }

            return View(post);
        }


        public ActionResult About()
        {
    

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Thank you for your interest in Blog";

            return View();
        }
    }
}