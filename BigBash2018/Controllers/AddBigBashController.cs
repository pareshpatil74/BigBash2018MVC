using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using System.Dynamic;

namespace BigBash2018.Controllers
{
    public class AddBigBashController : Controller
    {
        // GET: AddBigBash
        public ActionResult AddBigBash()
        {
            return View();
        }

        [HttpPost]
        [ActionName("AddBigBash")]
        public ActionResult PostAddBigBash()
        {

            AddBigBash lg = new AddBigBash();
            TryUpdateModel(lg);
            if (ModelState.IsValid)
            {

                BigBashBusinessLayer BBLayer = new BigBashBusinessLayer();
                BBLayer.AddBibBashInfo(lg);

                return RedirectToAction("Review");

            }

            return View("~/Views/AddBigBash/AddBigBash.cshtml");

        }



        public ActionResult AddBigBashNew()
        {
            return View();
        }

        [HttpPost]
        [ActionName("AddBigBashNew")]
        public ActionResult PostAddBigBashNew()
        {

            AddBigBashNew lg = new AddBigBashNew();
            TryUpdateModel(lg);
            if (ModelState.IsValid)
            {

                BigBashBusinessLayer BBLayer = new BigBashBusinessLayer();
                BBLayer.AddBibBashInfoNew(lg);

                return RedirectToAction("ReviewNew");

            }

            return View("~/Views/AddBigBash/AddBigBash.cshtml");

        }

        public ActionResult Review()
        {
            BigBashBusinessLayer BBLayer = new BigBashBusinessLayer();
            List<GetBigBashTable> GetBigBashTable = BBLayer.GetBigBashInfo.ToList();
            return View(GetBigBashTable);
        }

        public ActionResult ReviewNew()
        {
            BigBashBusinessLayer BBLayer = new BigBashBusinessLayer();
            List<GetBigBashTableNew> GetBigBashTableNew = BBLayer.GetBigBashInfoNew.ToList();
            return View(GetBigBashTableNew);
        }



        public ActionResult AhmerSubtotal()
        {
            BigBashBusinessLayer BBLayer = new BigBashBusinessLayer();
            int iSubtotal = BBLayer.GetSubTotal("Ahmer");
            ViewBag.Name = "Ahmer";
            ViewBag.iSubtotal = iSubtotal;
            return View("~/Views/AddBigBash/Subtotal.cshtml");
        }
        public ActionResult AltafSubtotal()
        {
            BigBashBusinessLayer BBLayer = new BigBashBusinessLayer();
            int iSubtotal = BBLayer.GetSubTotal("Altaf");
            ViewBag.Name = "Altaf";
            ViewBag.iSubtotal = iSubtotal;
            return View("~/Views/AddBigBash/Subtotal.cshtml");
        }

        public ActionResult AnilSubtotal()
        {
            BigBashBusinessLayer BBLayer = new BigBashBusinessLayer();
            int iSubtotal = BBLayer.GetSubTotal("Anil");
            ViewBag.Name = "Anil";
            ViewBag.iSubtotal = iSubtotal;
            return View("~/Views/AddBigBash/Subtotal.cshtml");
        }

        public ActionResult DeepuSubtotal()
        {
            BigBashBusinessLayer BBLayer = new BigBashBusinessLayer();
            int iSubtotal = BBLayer.GetSubTotal("Deepu");
            ViewBag.Name = "Deepu";
            ViewBag.iSubtotal = iSubtotal;
            return View("~/Views/AddBigBash/Subtotal.cshtml");
        }

        public ActionResult KalpeshSubtotal()
        {
            BigBashBusinessLayer BBLayer = new BigBashBusinessLayer();
            int iSubtotal = BBLayer.GetSubTotal("Kalpesh");
            ViewBag.Name = "Kalpesh";
            ViewBag.iSubtotal = iSubtotal;
            return View("~/Views/AddBigBash/Subtotal.cshtml");
        }

        public ActionResult KhursheedSubtotal()
        {
            BigBashBusinessLayer BBLayer = new BigBashBusinessLayer();
            int iSubtotal = BBLayer.GetSubTotal("Khursheed");
            ViewBag.Name = "Khursheed";
            ViewBag.iSubtotal = iSubtotal;
            return View("~/Views/AddBigBash/Subtotal.cshtml");
        }

        public ActionResult PareshSubtotal()
        {
            BigBashBusinessLayer BBLayer = new BigBashBusinessLayer();
            int iSubtotal = BBLayer.GetSubTotal("Paresh");
            ViewBag.Name = "Paresh";
            ViewBag.iSubtotal = iSubtotal;
            return View("~/Views/AddBigBash/Subtotal.cshtml");
        }

        public ActionResult SuroorSubtotal()
        {
            BigBashBusinessLayer BBLayer = new BigBashBusinessLayer();
            int iSubtotal = BBLayer.GetSubTotal("Suroor");
            ViewBag.Name = "Suroor";
            ViewBag.iSubtotal = iSubtotal;
            return View("~/Views/AddBigBash/Subtotal.cshtml");
        }

        public ActionResult VikasSubtotal()
        {
            BigBashBusinessLayer BBLayer = new BigBashBusinessLayer();
            int iSubtotal = BBLayer.GetSubTotal("Vikas");
            ViewBag.Name = "Vikas";
            ViewBag.iSubtotal = iSubtotal;
            return View("~/Views/AddBigBash/Subtotal.cshtml");
        }

    }
}