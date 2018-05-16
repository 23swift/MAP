using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MAS_WorkFlowService;
using DA;
using DA.Models;
namespace MerchantAquiringSystemWithWF.Controllers
{
    public class RequestsController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET: Requests
        public ActionResult Index()
        {
            List<Models.RequestViewModel> list = new List<Models.RequestViewModel>();
            unitOfWork.RequestRepository.GetAll().ToList().ForEach(x => list.Add(new Models.RequestViewModel {
                Id=x.Id,RequestDescription=x.RequestDescription,CreatedBy=x.CreatedBy,CreatedDate=x.CreatedDate,
                //Status = x.Status==1 || x.Status == 11 || x.Status == 12 || x.Status == 25 ?  RequestConfigHelper.GetStatusDisplayName(x.Status): "FOR " + RequestConfigHelper.GetStatusDisplayName(x.Status),
                Status = RequestConfigHelper.GetStatusDisplayName(x.Status),
                View = RequestConfigHelper.GetStatusConfig(x.Status).view,RequestType = RequestConfigHelper.GetRequestTypeDisplayName(x.RequestType)


            }));

           
            return View(list);
        }

        // GET: Requests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
               
            }
            DA.Models.Request request = unitOfWork.RequestRepository.Get((Int32)id);
            ViewBag.view = RequestConfigHelper.GetStatusConfig(request.Status).view;
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        // GET: Requests/Create
        public ActionResult Create()
        {
            var requestTypeList = new List<SelectListItem>();
            RequestConfigHelper.GetAllRequestType().ForEach(x =>
                requestTypeList.Add(new SelectListItem { Text = x.DisplayName, Value = x.Value.ToString() })

                );
            ViewBag.requestTypeList = requestTypeList;
            return View();
        }

        // POST: Requests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RequestType,RequestDescription,Status,WorkflowInstanceId,BookMark,CreatedDate,CreatedBy")] DA.Models.Request request)
        {
            if (ModelState.IsValid)
            {
                request.CreatedDate = DateTime.Now;

                
                request.Status = RequestState.DRAFT.Value;
                unitOfWork.RequestRepository.Add(request);
               
                unitOfWork.Complete();
                // return RedirectToAction("Index");
                return RedirectToAction("Draft","RequestUIFlow",new { Id= request.Id });
            }

            return View(request);
        }

        // GET: Requests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var urlRef = HttpContext.Request.UrlReferrer;
            if (urlRef.Segments.Count() > 3) {
                ViewBag.urlRef = urlRef.Segments[1] + urlRef.Segments[2].Replace("/", "");
            }

          
            Request request = unitOfWork.RequestRepository.Get((Int32)id);
            ViewBag.Title = RequestConfigHelper.GetRequestTypeDisplayName(request.RequestType);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }
        public ActionResult MAU_Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var urlRef = HttpContext.Request.UrlReferrer;
            ViewBag.urlRef = urlRef.Segments[1] + urlRef.Segments[2].Replace("/", "");

            Request request = unitOfWork.RequestRepository.Get((Int32)id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }
        // POST: Requests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MAU_Edit([Bind(Include = "Id,RequestDescription,Status,WorkflowInstanceId,BookMark,CreatedDate,CreatedBy,WithRequirements,WithException,RequestType")] Request request)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.RequestRepository.Update(request);
                unitOfWork.Complete();

                return RedirectToAction("MAUScreening","RequestUIFLow",new {Id= request.Id }  );
            }
            return View(request);
        }
        // POST: Requests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RequestDescription,Status,WorkflowInstanceId,BookMark,CreatedDate,CreatedBy,WithRequirements,WithException")] Request request)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.RequestRepository.Update(request);
                unitOfWork.Complete();
                
                return RedirectToAction("Index");
            }
            return View(request);
        }

        // GET: Requests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = unitOfWork.RequestRepository.Get((Int32)id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        // POST: Requests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Request request = unitOfWork.RequestRepository.Get((Int32)id);
            unitOfWork.RequestRepository.Remove(request);
            unitOfWork.Complete();
            return RedirectToAction("Index");
        }
        public ActionResult RequestWithTab()
        {

            return View();
        }
        public ActionResult RequestWithTabIndex()
        {

            return View();
        }
        public ActionResult RequestWithTabProfile()
        {

            return View();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
