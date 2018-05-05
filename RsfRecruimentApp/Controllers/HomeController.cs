using RsfRecruimentApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace RsfRecruimentApp.Controllers
{
    public class HomeController : Controller
    {
        GateWay aGateway = new GateWay();
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.DivisionList = aGateway.CommonDivisionList().Where(r => r.Status == 0).ToList();
            ViewBag.DisTrictList = aGateway.CommonDistrictList().ToList();
            ViewBag.HighestEdu = aGateway.HighestEducation().ToList();
            ViewBag.MajorSub = aGateway.MajorSubject().ToList();
            ViewBag.MaritalStatus = aGateway.MaritalStatus().ToList();
            ViewBag.ReligionInfo = aGateway.ReligionInfo().ToList();
            ViewBag.BloodGroupList = aGateway.BloodGroup().ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Index(ApplicantDetailsInfo oneApplicantDetails, string Command)
        {
          

            var msg = aGateway.UpdateCandidateInformation(oneApplicantDetails);
            if (msg.Substring(0, 11) == "Update Fail")
            {
                ViewBag.DivisionList = aGateway.CommonDivisionList().Where(r => r.Status == 0).ToList();
                ViewBag.DisTrictList = aGateway.CommonDistrictList().ToList();
                ViewBag.HighestEdu = aGateway.HighestEducation().ToList();
                ViewBag.MajorSub = aGateway.MajorSubject().ToList();
                ViewBag.MaritalStatus = aGateway.MaritalStatus().ToList();
                ViewBag.ReligionInfo = aGateway.ReligionInfo().ToList();
                ViewBag.BloodGroupList = aGateway.BloodGroup().ToList();
                ViewBag.SuccessMsg = msg.ToString();
                return View();
            }
            ViewBag.SuccessMsg = msg.ToString();
            ModelState.Clear();
            ViewBag.DivisionList = aGateway.CommonDivisionList().Where(r => r.Status == 0).ToList();
            ViewBag.DisTrictList = aGateway.CommonDistrictList().ToList();
            ViewBag.HighestEdu = aGateway.HighestEducation().ToList();
            ViewBag.MajorSub = aGateway.MajorSubject().ToList();
            ViewBag.MaritalStatus = aGateway.MaritalStatus().ToList();
            ViewBag.ReligionInfo = aGateway.ReligionInfo().ToList();
            ViewBag.BloodGroupList = aGateway.BloodGroup().ToList();
            return View();


        }

        public JsonResult GetDistrictList(string Division)
        {
            var districtList = aGateway.CommonDistrictByDivisionID(Division).ToList();

            var arr = new ArrayList();

            foreach (var item in districtList)
            {
                arr.Add(new { DIST_NAME = item.DIST_NAME, DIST_CODE = item.DIST_CODE });

            }
            return Json(arr, JsonRequestBehavior.AllowGet);

        }
        public JsonResult GetUpozilaList(string District)
        {
            var upozilaList = aGateway.CommonUpozilaByDistrictID(District).ToList();

            var arrUpozila = new ArrayList();
            foreach (var item in upozilaList)
            {
                arrUpozila.Add(new { UPAZ_CODE = item.UPAZ_CODE, UPAZ_NAME = item.UPAZ_NAME, });

            }
            return Json(arrUpozila, JsonRequestBehavior.AllowGet);
        }
        public JsonResult CommonUnionInfoList(string Upozila)
        {
            var unionList = aGateway.CommonUnionInfo(Upozila).ToList();

            var arrunionList = new ArrayList();
            foreach (var item in unionList)
            {
                arrunionList.Add(new { UnionID = item.UnionID, UnionName = item.UnionName, });

            }
            return Json(arrunionList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SearchWithMoibleNoAndNID(string searchMobileNo, string searchNID)
        {
            ApplicantDetailsInfo listOfCandidateInfo = aGateway.SearchWithMoibleNoAndNID(searchMobileNo, searchNID);

            //if (listOfCandidateInfo.IsRecordsSubmitted)
            //{
            //    return Json("Already Submitted", JsonRequestBehavior.AllowGet);
            //}

            return Json(listOfCandidateInfo, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

    }
}