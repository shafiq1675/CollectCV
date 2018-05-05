using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RsfRecruimentApp.Models
{
    public class ApplicantDetailsInfo
    {
        public string ApplicantName { set; get; }
        public string ApplicantFatherName { set; get; }
        public string ApplicantMotherName { set; get; }
        public Nullable<System.DateTime> DateOfBirth { set; get; }
        public string Gender { set; get; }
        public string MaritalStatus { set; get; }
        public string Nationality { set; get; }
        public string Religion { set; get; }

        public string PlaceOfBirth { set; get; }

        public string NationalID { set; get; }


        public string PreHouseNo { set; get; }
        public string PreVillageOrStreet { set; get; }
        public string PrePostOffice { set; get; }
        public string PrePoliceStation { set; get; }
        public string PreUpozila { set; get; }
        public string PreDistrict { set; get; }
        public string PreDivision { set; get; }
        public string PresentUnionID { set; get; }
        public string PreMobileNo { set; get; }
        public string PreHomePhoneNo { set; get; }



        public string PerHouseNo { set; get; }
        public string PerVillageOrStreet { set; get; }
        public string PerPostOffice { set; get; }
        public string PerPoliceStation { set; get; }
        public string PerUpozila { set; get; }
        public string PerDistrict { set; get; }
        public string PerDivision { set; get; }
        public string PermanentUnionID { get; set; }
        public string PerMobileNo { set; get; }
        public string PerHomePhoneNo { set; get; }


        public string PreferenceNumber1 { set; get; }
        public string PreferenceNumber2 { set; get; }
        public string PreferenceNumber3 { set; get; }
        public bool PreferenceAnyWhere { set; get; }



        public string EmailAddress { set; get; }

        public HttpPostedFileBase ImageFile { set; get; }

        public string CareerObjective { set; get; }


        public string ReferenceName1 { get; set; }
        public string ReferenceOrgNAddress1 { get; set; }
        public string ReferenceDesignation1 { get; set; }
        public string ReferenceContactNo1 { get; set; }
        public string ReferenceEmail1 { get; set; }
        public string ReferenceRelation1 { get; set; }
        public string ReferenceName2 { get; set; }
        public string ReferenceOrgNAddress2 { get; set; }
        public string ReferenceDesignation2 { get; set; }
        public string ReferenceContactNo2 { get; set; }
        public string ReferenceEmail2 { get; set; }
        public string ReferenceRelation2 { get; set; }

        public bool ComputerSkill_MSWord { get; set; }
        public bool ComputerSkill_MSExcel { get; set; }
        public bool ComputerSkill_MSPPoint { get; set; }
        public bool ComputerSkill_MobileApp { get; set; }
        public bool ComputerSkill_ERP { get; set; }


        public string LanguageAbility { set; get; }


        public string ExtracurricularActivities { set; get; }
        public string Interest_Hobby { set; get; }

        public string AppliedBefore { set; get; }
        public string AttendVIVA { set; get; }

        //edu
        public string DegreeName { get; set; }
        public string MajorSubject { set; get; }
        public string Board_University { get; set; }
        public string InstituteName { get; set; }
        public string PassingYear { get; set; }
        public string Grade { get; set; }
        public string ExamGrade { get; set; }
        public string Result { get; set; }
        public string Achievement { get; set; }

        public string DegreeName1 { get; set; }
        public string Board_University1 { get; set; }
        public string InstituteName1 { get; set; }
        public string PassingYear1 { get; set; }
        public string Grade1 { get; set; }
        public string ExamGrade1 { get; set; }
        public string Result1 { get; set; }
        public string MajorSubject1 { get; set; }
        public string Achievement1 { get; set; }

        public string DegreeName2 { get; set; }
        public string Board_University2 { get; set; }
        public string InstituteName2 { get; set; }
        public string PassingYear2 { get; set; }
        public string Grade2 { get; set; }
        public string ExamGrade2 { get; set; }
        public string Result2 { get; set; }
        public string MajorSubject2 { get; set; }
        public string Achievement2 { get; set; }

        public string DegreeName3 { get; set; }
        public string Board_University3 { get; set; }
        public string InstituteName3 { get; set; }
        public string PassingYear3 { get; set; }
        public string Grade3 { get; set; }
        public string ExamGrade3 { get; set; }
        public string Result3 { get; set; }
        public string MajorSubject3 { get; set; }
        public string Achievement3 { get; set; }

        public string DegreeName4 { get; set; }
        public string Board_University4 { get; set; }
        public string InstituteName4 { get; set; }
        public string PassingYear4 { get; set; }
        public string Grade4 { get; set; }
        public string ExamGrade4 { get; set; }
        public string Result4 { get; set; }
        public string MajorSubject4 { get; set; }
        public string Achievement4 { get; set; }

        //traning

        public string TrainingName { get; set; }
        public string TrainingInstituteName { get; set; }
        public string TrainingInstituteAddress { get; set; }
        public string TrainingDuration { get; set; }
        public string TrainingYear { get; set; }
        public string TrainingAchievement { get; set; }

        public string TrainingName1 { get; set; }
        public string TrainingInstituteName1 { get; set; }
        public string TrainingInstituteAddress1 { get; set; }
        public string TrainingDuration1 { get; set; }
        public string TrainingYear1 { get; set; }
        public string TrainingAchievement1 { get; set; }

        public string TrainingName2 { get; set; }
        public string TrainingInstituteName2 { get; set; }
        public string TrainingInstituteAddress2 { get; set; }
        public string TrainingDuration2 { get; set; }
        public string TrainingYear2 { get; set; }
        public string TrainingAchievement2 { get; set; }

        public string TrainingName3 { set; get; }
        public string TrainingInstituteName3 { set; get; }
        public string TrainingInstituteAddress3 { set; get; }
        public string TrainingDuration3 { get; set; }
        public string TrainingYear3 { get; set; }
        public string TrainingAchievement3 { set; get; }
        public string TrainingName4 { set; get; }
        public string TrainingInstituteName4 { set; get; }
        public string TrainingInstituteAddress4 { set; get; }
        public string TrainingDuration4 { get; set; }
        public string TrainingYear4 { get; set; }
        public string TrainingAchievement4 { set; get; }

        //exprience

        public string ExperienceOrganization { get; set; }
        public string ExperienceOrganizationAddress { set; get; }
        public string ExperienceDesignation { get; set; }
        public string ExperienceDepartment { set; get; }
        public Nullable<DateTime> ExperienceFromDate { get; set; }
        public Nullable<DateTime> ExperienceToDate { get; set; }
        public string ExperienceAchievement { get; set; }

        public string ExperienceOrganization1 { get; set; }
        public string ExperienceOrganizationAddress1 { get; set; }
        public string ExperienceDesignation1 { get; set; }
        public string ExperienceDepartment1 { set; get; }
        public Nullable<DateTime> ExperienceFromDate1 { get; set; }
        public Nullable<DateTime> ExperienceToDate1 { get; set; }
        public string ExperienceAchievement1 { get; set; }

        public string ExperienceOrganization2 { get; set; }
        public string ExperienceOrganizationAddress2 { get; set; }
        public string ExperienceDesignation2 { get; set; }
        public string ExperienceDepartment2 { get; set; }
        public Nullable<DateTime> ExperienceFromDate2 { get; set; }
        public Nullable<DateTime> ExperienceToDate2 { get; set; }
        public string ExperienceAchievement2 { get; set; }
        public string ExperienceOrganization3 { get; set; }
        public string ExperienceOrganizationAddress3 { get; set; }
        public string ExperienceDesignation3 { get; set; }
        public string ExperienceDepartment3 { get; set; }
        public Nullable<DateTime> ExperienceFromDate3 { get; set; }
        public Nullable<DateTime> ExperienceToDate3 { get; set; }
        public string ExperienceAchievement3 { get; set; }
        public string ExperienceOrganization4 { get; set; }
        public string ExperienceOrganizationAddress4 { get; set; }
        public string ExperienceDesignation4 { get; set; }
        public string ExperienceDepartment4 { get; set; }
        public Nullable<DateTime> ExperienceFromDate4 { get; set; }
        public Nullable<DateTime> ExperienceToDate4 { get; set; }
        public string ExperienceAchievement4 { get; set; }


        public string AppliedPosition { get; set; }
        public string SearchMobileNo { set; get; }
        public string SearchNID { set; get; }

        public String ShowImage { set; get; }

        public bool IsRecordsSubmitted { get; set; }

        public string SourceOfJobInfo { set; get; }

        public string TrackingDistrictName { set; get; }



    }
}