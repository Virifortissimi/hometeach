using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eagle_hometeach.src.Data;
using eagle_hometeach.src.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eagle_hometeach.src.Controllers
{
    public class TeacherController : Controller
    {
        private TeacherDbContext db = null;

        public TeacherController(TeacherDbContext db)
        {
            this.db = db;
        }

        [Authorize]
        public IActionResult List() 
        { 
            List<TeacherDetail> model = (from e in db.TeacherDetails
                                    orderby e.TeacherID 
                                    select e).ToList(); 
            return View(model); 
        }

        [Authorize]
        public IActionResult Insert()
        {
            return View();
        }

        [Authorize]
        [HttpPost] 
        public IActionResult Insert(TeacherDetail model) 
        {
            try
            {
                if (int.Parse(model.YearsOfExperience) < 0)
                {
                    ViewBag.Message = "You could not have had a negative years experience...";
                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        db.TeacherDetails.Add(model);
                        db.SaveChanges();
                        ViewBag.SuccessMessage = "Yay! You are now listed as a teacher on HomeTeach";
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                ViewBag.Message = "Oh No! Please input Values";
            }
            
            return View(model);
        }

        [Authorize]
        public IActionResult SeeProfile(int id) 
        { 
            TeacherDetail model = db.TeacherDetails.Find(id); 
            return View(model); 
        }


        [Authorize]
        public IActionResult FilterTeacherBySubject(string Subject)
        {
            TeacherDetail model = db.TeacherDetails.Find(Subject);
            return View(model);
        }

        //    public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
