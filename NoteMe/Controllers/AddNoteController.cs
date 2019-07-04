using Microsoft.AspNet.Identity;
using NoteMe.DAL;
using NoteMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NoteMe.Controllers
{
    public class AddNoteController : Controller
    {
        public List<Notes> NoteList { get; set; }

        [Authorize]
        public ActionResult Index(Notes model)
        {
            return View();
        }

        [Authorize]
        public ActionResult Save(Notes model)
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.Message = "Add Note.";
                try
                {
                    string user = User.Identity.GetUserName();
                    NoteContext db = new NoteContext();
                    Notes nt = new Notes();
                    nt.Name = user;
                    nt.Date = DateTime.Now;
                    nt.Note = model.Note;
                    db.Note.Add(nt);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "You must login to add a note.";
                return View();
            }
        }
    }
}