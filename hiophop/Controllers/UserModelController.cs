using hiophop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hiophop.Controllers
{
    public class UserModelController : Controller
    {
        private ApplicationDbContext _context;
        public UserModelController()
        {
            _context = new ApplicationDbContext();
        }


        //public ActionResult Index()
        //{
        //    //var viewModels = new UserModel();
        //    //{

        //    //    //car insurances comes from view model
        //    //    var ppl = _context.ppl.ToList();

        //    //};

        //    return View();
        //}




        
        public ActionResult Index(RegisterViewModel viewmodel)
        {
            var peeps = _context.ppl.ToList();

            try
            {
                var app = new UserModel
                {

                    Name = viewmodel.Name,
                    email = viewmodel.Email,
                    FavGenre = viewmodel.FavGenre,
                    Proffession = viewmodel.Proffession,
                    FutureGenre = viewmodel.FutureGenre

                };
                _context.ppl.Add(app);
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                                validationError.PropertyName,
                                                validationError.ErrorMessage);
                    }
                }

            }
            var peed = from m in peeps select m;



            return View(peed.ToList());
        }
    }
}