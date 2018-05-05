using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RsfRecruimentApp.Models
{
    public class GateWay
    {
        RASolarERPEntities dataConnection = new RASolarERPEntities();
        //protected RASolarERPEntities dataConnection { set; get; }

        //public GateWay()
        //{

        //}
        //public GateWay(RASolarERPEntities _dataConnection)
        //    :this()
        //{
        //    dataConnection = _dataConnection;
        //}

        public List<Common_DivisionInfo> CommonDivisionList()
        {
            var aDivisionList = dataConnection.Common_DivisionInfo.ToList();
            return aDivisionList;
        }
        public List<Common_DistrictInfo> CommonDistrictList()
        {
            var DistrictList = dataConnection.Common_DistrictInfo.ToList();
            return DistrictList;
        }
        public List<Common_UpazillaInfo> CommonUpazilaList()
        {
            var UpazilaList = dataConnection.Common_UpazillaInfo.ToList();
            return UpazilaList;
        }
        public List<Common_DistrictInfo> CommonDistrictByDivisionID(string divisionCode)
        {
            var aList = dataConnection.Common_DistrictInfo.Where(x => x.DIVI_CODE == divisionCode).ToList();
            return aList;

        }

        public List<Common_UpazillaInfo> CommonUpozilaByDistrictID(string districtCode)
        {
            var aList = dataConnection.Common_UpazillaInfo.Where(x => x.DIST_CODE == districtCode).ToList();
            return aList;

        }

        public List<Hrm_EducationInfo> HighestEducation()
        {
            var aList = dataConnection.Hrm_EducationInfo.ToList();
            return aList;
        }

        public List<Hrm_MajorSubject> MajorSubject()
        {
            var aList = dataConnection.Hrm_MajorSubject.ToList();
            return aList;
        }
        public List<Hrm_ReligionInfo> ReligionInfo()
        {
            var aList = dataConnection.Hrm_ReligionInfo.ToList();
            return aList;
        }

        public List<Hrm_MaritalStatusInfo> MaritalStatus()
        {
            var aList = dataConnection.Hrm_MaritalStatusInfo.ToList();
            return aList;
        }
        public List<Hrm_BloodGroupInfo> BloodGroup()
        {
            return dataConnection.Hrm_BloodGroupInfo.ToList();
        }
        public List<Common_UnionInfo> GetAllUnionInfo()
        {
            return dataConnection.Common_UnionInfo.ToList();
        }
        public List<Common_UnionInfo> CommonUnionInfo(string upazilaCode)
        {
            return dataConnection.Common_UnionInfo.Where(x => x.UpazilaCode == upazilaCode).ToList();
        }

        public ApplicantDetailsInfo SearchWithMoibleNoAndNID(string searchMobileNo, string searchNID)
        {
            Hrm_CandidatesCVBank listOfCandidateInfo = dataConnection.Hrm_CandidatesCVBank.Where(x => x.NationalIDCard.Equals(searchNID) && x.PresentMobileNo.Equals(searchMobileNo)).FirstOrDefault();

            if (listOfCandidateInfo == null)
            {
                return null;
            }
            else
            {
                ApplicantDetailsInfo aApplicantInfo = new ApplicantDetailsInfo()
                {
                    ApplicantName = listOfCandidateInfo.CandidateName,
                    ApplicantFatherName = listOfCandidateInfo.CandidateFathersName,
                    ApplicantMotherName = listOfCandidateInfo.CandidateMothersName,
                    DateOfBirth = listOfCandidateInfo.DateOfBirth,
                    Gender = listOfCandidateInfo.Gender == null ? null : listOfCandidateInfo.Gender.Trim(),
                    MaritalStatus = listOfCandidateInfo.MaritalStatus == null ? null : listOfCandidateInfo.MaritalStatus.Trim(),
                    Religion = listOfCandidateInfo.Religion == null ? null : listOfCandidateInfo.Religion.Trim(),
                    Nationality = listOfCandidateInfo.Nationality == null ? null : listOfCandidateInfo.Nationality.Trim(),
                    EmailAddress = listOfCandidateInfo.EmailID,
                    NationalID = listOfCandidateInfo.NationalIDCard,
                    PreferenceNumber1 = listOfCandidateInfo.PreferredDistrictCode == null ? null : listOfCandidateInfo.PreferredDistrictCode.Trim(),
                    PreferenceNumber2 = listOfCandidateInfo.PreferredDistrictCode1 == null ? null : listOfCandidateInfo.PreferredDistrictCode1.Trim(),
                    PreferenceNumber3 = listOfCandidateInfo.PreferredDistrictCode2 == null ? null : listOfCandidateInfo.PreferredDistrictCode2.Trim(),
                    PreferenceAnyWhere = listOfCandidateInfo.IsAnywhereInBd == null ? false : (bool)listOfCandidateInfo.IsAnywhereInBd,
                    SourceOfJobInfo = listOfCandidateInfo.SourcesOfJobInfo == null ? null : listOfCandidateInfo.SourcesOfJobInfo.Trim(),
                    AppliedPosition = listOfCandidateInfo.AppliedPosition,
                    CareerObjective = listOfCandidateInfo.CareerObjective,

                    PreHouseNo = listOfCandidateInfo.PresentHouseNo,
                    PreVillageOrStreet = listOfCandidateInfo.PresentStreetOrVillage,
                    PrePostOffice = listOfCandidateInfo.PresentPostOffice,
                    PrePoliceStation = listOfCandidateInfo.PresentPoliceStation,
                    PreDivision = listOfCandidateInfo.PresentDivisionCode == null ? null : listOfCandidateInfo.PresentDivisionCode.Trim(),
                    PreDistrict = listOfCandidateInfo.PresentDistrictCode == null ? null : listOfCandidateInfo.PresentDistrictCode.Trim(),
                    PreUpozila = listOfCandidateInfo.PresentUpazillaCode == null ? null : listOfCandidateInfo.PresentUpazillaCode.Trim(),
                    PresentUnionID = listOfCandidateInfo.PresentUnionID == null ? null : listOfCandidateInfo.PresentUnionID.Trim(),
                    PreMobileNo = listOfCandidateInfo.PresentMobileNo,
                    PreHomePhoneNo = listOfCandidateInfo.PresentPhone,
                    
                    PerHouseNo = listOfCandidateInfo.PermanentHouseNo,
                    PerVillageOrStreet = listOfCandidateInfo.PermanentStreetVillage,
                    PerPostOffice = listOfCandidateInfo.PermanentPostOffice,
                    PerPoliceStation = listOfCandidateInfo.PermanentPoliceStation,
                    PerDivision = listOfCandidateInfo.PermanentDivisionCode == null ? null : listOfCandidateInfo.PermanentDivisionCode.Trim(),
                    PerDistrict = listOfCandidateInfo.PermanentDistrictCode == null ? null : listOfCandidateInfo.PermanentDistrictCode.Trim(),
                    PerUpozila = listOfCandidateInfo.PermanentUpazillaCode == null ? null : listOfCandidateInfo.PermanentUpazillaCode.Trim(),
                    PermanentUnionID = listOfCandidateInfo.PermanentUnionID == null ? null : listOfCandidateInfo.PermanentUnionID.Trim(),
                    PerMobileNo = listOfCandidateInfo.PermanentMobileNo,
                    //PerHomePhoneNo = (listOfCandidateInfo.PresentPhone).Trim(),



                    ShowImage = listOfCandidateInfo.Photo == null ? null : Convert.ToBase64String(listOfCandidateInfo.Photo),


                    DegreeName = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.DegreeName == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.DegreeName.Trim(),
                    MajorSubject = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.MajorSubject == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.MajorSubject.Trim(),
                    Board_University = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Board_University == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Board_University.Trim(),
                    InstituteName = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.InstituteName == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.InstituteName.Trim(),
                    PassingYear = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.PassingYear == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.PassingYear.Trim(),
                    Result = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Result,
                    Grade = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Grade,
                    ExamGrade = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExamGrade == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExamGrade.Trim(),
                    Achievement = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Achievement,

                    DegreeName1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.DegreeName1 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.DegreeName1.Trim(),
                    MajorSubject1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.MajorSubject1 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.MajorSubject1.Trim(),
                    Board_University1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Board_University1 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Board_University1.Trim(),
                    InstituteName1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.InstituteName1,
                    PassingYear1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.PassingYear1,
                    Result1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Result1,
                    Grade1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Grade1,
                    ExamGrade1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExamGrade1 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExamGrade1.Trim(),
                    Achievement1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Achievement1,

                    DegreeName2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.DegreeName2 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.DegreeName2.Trim(),
                    MajorSubject2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.MajorSubject2 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.MajorSubject2.Trim(),
                    Board_University2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Board_University2 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Board_University2.Trim(),
                    InstituteName2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.InstituteName2,
                    PassingYear2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.PassingYear2,
                    Result2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Result2,
                    Grade2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Grade2,
                    ExamGrade2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExamGrade2 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExamGrade2.Trim(),
                    Achievement2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Achievement2,

                    DegreeName3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.DegreeName3 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.DegreeName3.Trim(),
                    MajorSubject3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.MajorSubject3 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.MajorSubject3.Trim(),
                    Board_University3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Board_University3 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Board_University3.Trim(),
                    InstituteName3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.InstituteName3,
                    PassingYear3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.PassingYear3,
                    Result3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Result3,
                    Grade3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Grade3,
                    ExamGrade3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExamGrade3 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExamGrade3.Trim(),
                    Achievement3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Achievement3,

                    DegreeName4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.DegreeName4 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.DegreeName4.Trim(),
                    MajorSubject4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.MajorSubject4 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.MajorSubject4.Trim(),
                    Board_University4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Board_University4 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Board_University4.Trim(),
                    InstituteName4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.InstituteName4,
                    PassingYear4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.PassingYear4,
                    Result4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Result4,
                    Grade4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Grade4,
                    ExamGrade4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExamGrade4 == null ? null : listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExamGrade4.Trim(),
                    Achievement4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.Achievement4,

                    TrainingName = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingName,
                    TrainingInstituteName = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingInstituteName,
                    TrainingInstituteAddress = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingInstituteAddress,
                    TrainingDuration = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingDuration,
                    TrainingYear = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingYear,
                    TrainingAchievement = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingAchievement,

                    TrainingName1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingName1,
                    TrainingInstituteName1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingInstituteName1,
                    TrainingInstituteAddress1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingInstituteAddress1,
                    TrainingDuration1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingDuration1,
                    TrainingYear1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingYear1,
                    TrainingAchievement1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingAchievement1,

                    TrainingName2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingName2,
                    TrainingInstituteName2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingInstituteName2,
                    TrainingInstituteAddress2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingInstituteAddress2,
                    TrainingDuration2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingDuration2,
                    TrainingYear2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingYear2,
                    TrainingAchievement2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingAchievement2,

                    TrainingName3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingName3,
                    TrainingInstituteName3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingInstituteName3,
                    TrainingInstituteAddress3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingInstituteAddress3,
                    TrainingDuration3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingDuration3,
                    TrainingYear3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingYear3,
                    TrainingAchievement3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingAchievement3,

                    TrainingName4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingName4,
                    TrainingInstituteName4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingInstituteName4,
                    TrainingInstituteAddress4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingInstituteAddress4,
                    TrainingDuration4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingDuration4,
                    TrainingYear4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingYear4,
                    TrainingAchievement4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.TrainingAchievement4,


                    ExperienceOrganization = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceOrganization,
                    ExperienceOrganizationAddress = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceOrganizationAddress,
                    ExperienceDesignation = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceDesignation,
                    ExperienceDepartment = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceDepartment,
                    ExperienceFromDate = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceFromDate,
                    ExperienceToDate = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceToDate,
                    ExperienceAchievement = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceAchievement,


                    ExperienceOrganization1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceOrganization1,
                    ExperienceOrganizationAddress1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceOrganizationAddress1,
                    ExperienceDesignation1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceDesignation1,
                    ExperienceDepartment1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceDepartment1,
                    ExperienceFromDate1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceFromDate1,
                    ExperienceToDate1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceToDate1,
                    ExperienceAchievement1 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceAchievement1,


                    ExperienceOrganization2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceOrganization2,
                    ExperienceOrganizationAddress2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceOrganizationAddress2,
                    ExperienceDesignation2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceDesignation2,
                    ExperienceDepartment2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceDepartment2,
                    ExperienceFromDate2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceFromDate2,
                    ExperienceToDate2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceToDate2,
                    ExperienceAchievement2 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceAchievement2,


                    ExperienceOrganization3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceOrganization3,
                    ExperienceOrganizationAddress3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceOrganizationAddress3,
                    ExperienceDesignation3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceDesignation3,
                    ExperienceDepartment3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceDepartment3,
                    ExperienceFromDate3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceFromDate3,
                    ExperienceToDate3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceToDate3,
                    ExperienceAchievement3 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceAchievement3,


                    ExperienceOrganization4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceOrganization4,
                    ExperienceOrganizationAddress4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceOrganizationAddress4,
                    ExperienceDesignation4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceDesignation4,
                    ExperienceDepartment4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceDepartment4,
                    ExperienceFromDate4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceFromDate4,
                    ExperienceToDate4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceToDate4,
                    ExperienceAchievement4 = listOfCandidateInfo.Hrm_CandidatesCVBankExtension.ExperienceAchievement4,


                    ComputerSkill_MSWord = listOfCandidateInfo.ComputerSkill_MSWord == null ? false : (bool)listOfCandidateInfo.ComputerSkill_MSWord,
                    ComputerSkill_MSPPoint = listOfCandidateInfo.ComputerSkill_MSPPoint == null ? false : (bool)listOfCandidateInfo.ComputerSkill_MSPPoint,
                    ComputerSkill_MSExcel = listOfCandidateInfo.ComputerSkill_MSExcel == null ? false : (bool)listOfCandidateInfo.ComputerSkill_MSExcel,
                    ComputerSkill_MobileApp = listOfCandidateInfo.ComputerSkill_MobileApp == null ? false : (bool)listOfCandidateInfo.ComputerSkill_MobileApp,
                    ComputerSkill_ERP = listOfCandidateInfo.ComputerSkill_ERP == null ? false : (bool)listOfCandidateInfo.ComputerSkill_ERP,

                    ExtracurricularActivities = listOfCandidateInfo.ExtracurricularActivities,

                    ReferenceName1 = listOfCandidateInfo.ReferenceName1,
                    ReferenceOrgNAddress1 = listOfCandidateInfo.ReferenceOrgNAddress1,
                    ReferenceDesignation1 = listOfCandidateInfo.ReferenceDesignation1,
                    ReferenceContactNo1 = listOfCandidateInfo.ReferenceContactNo1,
                    ReferenceEmail1 = listOfCandidateInfo.ReferenceEmail1,
                    ReferenceRelation1 = listOfCandidateInfo.ReferenceRelation1,

                    ReferenceName2 = listOfCandidateInfo.ReferenceName2,
                    ReferenceOrgNAddress2 = listOfCandidateInfo.ReferenceOrgNAddress2,
                    ReferenceDesignation2 = listOfCandidateInfo.ReferenceDesignation2,
                    ReferenceContactNo2 = listOfCandidateInfo.ReferenceContactNo2,
                    ReferenceEmail2 = listOfCandidateInfo.ReferenceEmail2,
                    ReferenceRelation2 = listOfCandidateInfo.ReferenceRelation2,

                    IsRecordsSubmitted = listOfCandidateInfo.IsRecordsSubmitted == null ? false : (bool)listOfCandidateInfo.IsRecordsSubmitted,


                };
                return aApplicantInfo;
            }


        }
        public string UpdateCandidateInformation(ApplicantDetailsInfo aApplicationDetailsInfo)
        {
            try
            {


                byte[] uploadFile = null;

                if (aApplicationDetailsInfo.ImageFile != null)
                {
                    uploadFile = new byte[aApplicationDetailsInfo.ImageFile.InputStream.Length];
                    aApplicationDetailsInfo.ImageFile.InputStream.Read(uploadFile, 0, uploadFile.Length);
                }

                Hrm_CandidatesCVBank aCVbank = dataConnection.Hrm_CandidatesCVBank.Where(x => x.NationalIDCard.Equals(aApplicationDetailsInfo.SearchNID) && x.PresentMobileNo.Equals(aApplicationDetailsInfo.SearchMobileNo)).FirstOrDefault();

                if (aCVbank != null)
                {
                    if (aCVbank.IsRecordsSubmitted == true)
                    {
                        return "Your CV is submited, not able to edit";
                    }
                }

                if (aCVbank == null)
                {
                    string firstPart = null;
                    decimal secondPart;
                    string finalPartForCandidateID = null;
                    string query = "SELECT MAX ([CandidateID]) FROM [RASolarERP].[dbo].[Hrm_CandidatesCVBank]";
                    string maxCandidateId = dataConnection.Database.SqlQuery<string>(query).FirstOrDefault();
                    if (maxCandidateId != null)
                    {
                        firstPart = maxCandidateId.Substring(0, 1).ToUpper();
                        secondPart = Convert.ToDecimal(maxCandidateId.Substring(1, 7));
                        secondPart++;
                        string secondPartToString = secondPart.ToString("0000000");
                        finalPartForCandidateID = string.Concat(firstPart, secondPartToString);
                    }
                    else
                    {
                        finalPartForCandidateID = "C0000001";
                    }
                    var aCVbankCreate = new Hrm_CandidatesCVBank()
                    {
                        CandidateID = finalPartForCandidateID,
                        SourcesOfJobInfo=aApplicationDetailsInfo.SourceOfJobInfo,
                        AppliedPosition = aApplicationDetailsInfo.AppliedPosition,
                        CandidateName = aApplicationDetailsInfo.ApplicantName,
                        //PresentMobileNo = aApplicationDetailsInfo.SearchMobileNo.Trim(),
                        //NationalIDCard = aApplicationDetailsInfo.SearchNID.Trim(),
                        CandidateFathersName = aApplicationDetailsInfo.ApplicantFatherName,
                        CandidateMothersName = aApplicationDetailsInfo.ApplicantMotherName,
                        DateOfBirth = aApplicationDetailsInfo.DateOfBirth,
                        Gender = aApplicationDetailsInfo.Gender,
                        MaritalStatus = aApplicationDetailsInfo.MaritalStatus,
                        Nationality = aApplicationDetailsInfo.Nationality,
                        Religion = aApplicationDetailsInfo.Religion,
                        NationalIDCard = aApplicationDetailsInfo.SearchNID,
                        EmailID = aApplicationDetailsInfo.EmailAddress,
                        ApplicationDate = DateTime.Now,
                        PreferredDistrictCode = aApplicationDetailsInfo.PreferenceNumber1,
                        PreferredDistrictCode1 = aApplicationDetailsInfo.PreferenceNumber2,
                        PreferredDistrictCode2 = aApplicationDetailsInfo.PreferenceNumber3,
                        IsAnywhereInBd = aApplicationDetailsInfo.PreferenceAnyWhere,
                        PresentDivisionCode = aApplicationDetailsInfo.PreDivision,
                        PresentDistrictCode = aApplicationDetailsInfo.PreDistrict,
                        PresentUpazillaCode = aApplicationDetailsInfo.PreUpozila,
                        PresentPoliceStation = aApplicationDetailsInfo.PrePoliceStation,
                        PresentUnionID = aApplicationDetailsInfo.PresentUnionID,
                        PresentPostOffice = aApplicationDetailsInfo.PrePostOffice,
                        PresentStreetOrVillage = aApplicationDetailsInfo.PreVillageOrStreet,
                        PresentHouseNo = aApplicationDetailsInfo.PreHouseNo,
                        PresentMobileNo = aApplicationDetailsInfo.SearchMobileNo,
                        PresentPhone = aApplicationDetailsInfo.PreHomePhoneNo,
                        PermanentDivisionCode = aApplicationDetailsInfo.PerDivision,
                        PermanentDistrictCode = aApplicationDetailsInfo.PerDistrict,
                        PermanentUpazillaCode = aApplicationDetailsInfo.PerUpozila,
                        PermanentUnionID = aApplicationDetailsInfo.PermanentUnionID,
                        PermanentPoliceStation = aApplicationDetailsInfo.PerPoliceStation,
                        PermanentPostOffice = aApplicationDetailsInfo.PerPostOffice,
                        PermanentStreetVillage = aApplicationDetailsInfo.PerVillageOrStreet,
                        PermanentHouseNo = aApplicationDetailsInfo.PerHouseNo,
                        PermanentMobileNo = aApplicationDetailsInfo.PerMobileNo,
                        ComputerSkill_MSWord = aApplicationDetailsInfo.ComputerSkill_MSWord,
                        ComputerSkill_MSExcel = aApplicationDetailsInfo.ComputerSkill_MSExcel,
                        ComputerSkill_MSPPoint = aApplicationDetailsInfo.ComputerSkill_MSPPoint,
                        ComputerSkill_MobileApp = aApplicationDetailsInfo.ComputerSkill_MobileApp,
                        ComputerSkill_ERP = aApplicationDetailsInfo.ComputerSkill_ERP,
                        ExtracurricularActivities = aApplicationDetailsInfo.ExtracurricularActivities,
                        CareerObjective = aApplicationDetailsInfo.CareerObjective,
                        ReferenceName1 = aApplicationDetailsInfo.ReferenceName1,
                        ReferenceOrgNAddress1 = aApplicationDetailsInfo.ReferenceOrgNAddress1,
                        ReferenceDesignation1 = aApplicationDetailsInfo.ReferenceDesignation1,
                        ReferenceContactNo1 = aApplicationDetailsInfo.ReferenceContactNo1,
                        ReferenceEmail1 = aApplicationDetailsInfo.ReferenceEmail1,
                        ReferenceRelation1 = aApplicationDetailsInfo.ReferenceRelation1,
                        ReferenceName2 = aApplicationDetailsInfo.ReferenceName2,
                        ReferenceOrgNAddress2 = aApplicationDetailsInfo.ReferenceOrgNAddress2,
                        ReferenceDesignation2 = aApplicationDetailsInfo.ReferenceDesignation2,
                        ReferenceContactNo2 = aApplicationDetailsInfo.ReferenceContactNo2,
                        ReferenceEmail2 = aApplicationDetailsInfo.ReferenceEmail2,
                        ReferenceRelation2 = aApplicationDetailsInfo.ReferenceRelation2,
                        Photo = uploadFile,
                        TrackingDistrictName=aApplicationDetailsInfo.TrackingDistrictName,
                        IsRecordsSubmitted = aApplicationDetailsInfo.IsRecordsSubmitted,
                        CreatedBy = "Admin",
                        CreatedOn = DateTime.Now,
                        ModifiedBy = null,
                        ModifiedOn = null,
                        Status = 0,
                        StatusChangedDate = null,
                    };

                    var aCVbankExtension = new Hrm_CandidatesCVBankExtension()
                    {
                        CandidateID = finalPartForCandidateID,
                        DegreeName = aApplicationDetailsInfo.DegreeName,
                        MajorSubject = aApplicationDetailsInfo.MajorSubject,
                        Board_University = aApplicationDetailsInfo.Board_University,
                        InstituteName = aApplicationDetailsInfo.InstituteName,
                        PassingYear = aApplicationDetailsInfo.PassingYear,
                        Grade = aApplicationDetailsInfo.Grade,
                        ExamGrade = aApplicationDetailsInfo.ExamGrade,
                        Result = aApplicationDetailsInfo.Result,
                        Achievement = aApplicationDetailsInfo.Achievement,
                        DegreeName1 = aApplicationDetailsInfo.DegreeName1,
                        MajorSubject1 = aApplicationDetailsInfo.MajorSubject1,
                        Board_University1 = aApplicationDetailsInfo.Board_University1,
                        InstituteName1 = aApplicationDetailsInfo.InstituteName1,
                        PassingYear1 = aApplicationDetailsInfo.PassingYear1,
                        Grade1 = aApplicationDetailsInfo.Grade1,
                        ExamGrade1 = aApplicationDetailsInfo.ExamGrade1,
                        Result1 = aApplicationDetailsInfo.Result1,
                        Achievement1 = aApplicationDetailsInfo.Achievement1,
                        DegreeName2 = aApplicationDetailsInfo.DegreeName2,
                        MajorSubject2 = aApplicationDetailsInfo.MajorSubject2,
                        Board_University2 = aApplicationDetailsInfo.Board_University2,
                        InstituteName2 = aApplicationDetailsInfo.InstituteName2,
                        PassingYear2 = aApplicationDetailsInfo.PassingYear2,
                        Grade2 = aApplicationDetailsInfo.Grade2,
                        ExamGrade2 = aApplicationDetailsInfo.ExamGrade2,
                        Result2 = aApplicationDetailsInfo.Result2,
                        Achievement2 = aApplicationDetailsInfo.Achievement2,
                        DegreeName3 = aApplicationDetailsInfo.DegreeName3,
                        MajorSubject3 = aApplicationDetailsInfo.MajorSubject3,
                        Board_University3 = aApplicationDetailsInfo.Board_University3,
                        InstituteName3 = aApplicationDetailsInfo.InstituteName3,
                        PassingYear3 = aApplicationDetailsInfo.PassingYear3,
                        Grade3 = aApplicationDetailsInfo.Grade3,
                        ExamGrade3 = aApplicationDetailsInfo.ExamGrade3,
                        Result3 = aApplicationDetailsInfo.Result3,
                        Achievement3 = aApplicationDetailsInfo.Achievement3,
                        DegreeName4 = aApplicationDetailsInfo.DegreeName4,
                        MajorSubject4 = aApplicationDetailsInfo.MajorSubject4,
                        Board_University4 = aApplicationDetailsInfo.Board_University4,
                        InstituteName4 = aApplicationDetailsInfo.InstituteName4,
                        PassingYear4 = aApplicationDetailsInfo.PassingYear4,
                        Grade4 = aApplicationDetailsInfo.Grade4,
                        ExamGrade4 = aApplicationDetailsInfo.ExamGrade4,
                        Result4 = aApplicationDetailsInfo.Result4,
                        Achievement4 = aApplicationDetailsInfo.Achievement4,
                        TrainingName = aApplicationDetailsInfo.TrainingName,
                        TrainingInstituteName = aApplicationDetailsInfo.TrainingInstituteName,
                        TrainingInstituteAddress = aApplicationDetailsInfo.TrainingInstituteAddress,
                        TrainingDuration = aApplicationDetailsInfo.TrainingDuration,
                        TrainingYear = aApplicationDetailsInfo.TrainingYear,
                        TrainingAchievement = aApplicationDetailsInfo.TrainingAchievement,
                        TrainingName1 = aApplicationDetailsInfo.TrainingName1,
                        TrainingInstituteName1 = aApplicationDetailsInfo.TrainingInstituteName1,
                        TrainingInstituteAddress1 = aApplicationDetailsInfo.TrainingInstituteAddress1,
                        TrainingDuration1 = aApplicationDetailsInfo.TrainingDuration1,
                        TrainingYear1 = aApplicationDetailsInfo.TrainingYear1,
                        TrainingAchievement1 = aApplicationDetailsInfo.TrainingAchievement1,
                        TrainingName2 = aApplicationDetailsInfo.TrainingName2,
                        TrainingInstituteName2 = aApplicationDetailsInfo.TrainingInstituteName2,
                        TrainingInstituteAddress2 = aApplicationDetailsInfo.TrainingInstituteAddress2,
                        TrainingDuration2 = aApplicationDetailsInfo.TrainingDuration2,
                        TrainingYear2 = aApplicationDetailsInfo.TrainingYear2,
                        TrainingAchievement2 = aApplicationDetailsInfo.TrainingAchievement2,
                        TrainingName3 = aApplicationDetailsInfo.TrainingName3,
                        TrainingInstituteName3 = aApplicationDetailsInfo.TrainingInstituteName3,
                        TrainingInstituteAddress3 = aApplicationDetailsInfo.TrainingInstituteAddress3,
                        TrainingDuration3 = aApplicationDetailsInfo.TrainingDuration3,
                        TrainingYear3 = aApplicationDetailsInfo.TrainingYear3,
                        TrainingAchievement3 = aApplicationDetailsInfo.TrainingAchievement3,
                        TrainingName4 = aApplicationDetailsInfo.TrainingName4,
                        TrainingInstituteName4 = aApplicationDetailsInfo.TrainingInstituteName4,
                        TrainingInstituteAddress4 = aApplicationDetailsInfo.TrainingInstituteAddress4,
                        TrainingDuration4 = aApplicationDetailsInfo.TrainingDuration4,
                        TrainingYear4 = aApplicationDetailsInfo.TrainingYear4,
                        TrainingAchievement4 = aApplicationDetailsInfo.TrainingAchievement4,
                        ExperienceOrganization = aApplicationDetailsInfo.ExperienceOrganization,
                        ExperienceOrganizationAddress = aApplicationDetailsInfo.ExperienceOrganizationAddress,
                        ExperienceDesignation = aApplicationDetailsInfo.ExperienceDesignation,
                        ExperienceDepartment = aApplicationDetailsInfo.ExperienceDepartment,
                        ExperienceFromDate = aApplicationDetailsInfo.ExperienceFromDate,
                        ExperienceToDate = aApplicationDetailsInfo.ExperienceToDate,
                        ExperienceAchievement = aApplicationDetailsInfo.ExperienceAchievement,
                        ExperienceOrganization1 = aApplicationDetailsInfo.ExperienceOrganization1,
                        ExperienceOrganizationAddress1 = aApplicationDetailsInfo.ExperienceOrganizationAddress1,
                        ExperienceDesignation1 = aApplicationDetailsInfo.ExperienceDesignation1,
                        ExperienceDepartment1 = aApplicationDetailsInfo.ExperienceDepartment1,
                        ExperienceFromDate1 = aApplicationDetailsInfo.ExperienceFromDate1,
                        ExperienceToDate1 = aApplicationDetailsInfo.ExperienceToDate1,
                        ExperienceAchievement1 = aApplicationDetailsInfo.ExperienceAchievement1,
                        ExperienceOrganization2 = aApplicationDetailsInfo.ExperienceOrganization2,
                        ExperienceOrganizationAddress2 = aApplicationDetailsInfo.ExperienceOrganizationAddress2,
                        ExperienceDesignation2 = aApplicationDetailsInfo.ExperienceDesignation2,
                        ExperienceDepartment2 = aApplicationDetailsInfo.ExperienceDepartment2,
                        ExperienceFromDate2 = aApplicationDetailsInfo.ExperienceFromDate2,
                        ExperienceToDate2 = aApplicationDetailsInfo.ExperienceToDate2,
                        ExperienceAchievement2 = aApplicationDetailsInfo.ExperienceAchievement2,
                        ExperienceOrganization3 = aApplicationDetailsInfo.ExperienceOrganization3,
                        ExperienceOrganizationAddress3 = aApplicationDetailsInfo.ExperienceOrganizationAddress3,
                        ExperienceDesignation3 = aApplicationDetailsInfo.ExperienceDesignation3,
                        ExperienceDepartment3 = aApplicationDetailsInfo.ExperienceDepartment3,
                        ExperienceFromDate3 = aApplicationDetailsInfo.ExperienceFromDate3,
                        ExperienceToDate3 = aApplicationDetailsInfo.ExperienceToDate3,
                        ExperienceAchievement3 = aApplicationDetailsInfo.ExperienceAchievement3,
                        ExperienceOrganization4 = aApplicationDetailsInfo.ExperienceOrganization4,
                        ExperienceOrganizationAddress4 = aApplicationDetailsInfo.ExperienceOrganizationAddress4,
                        ExperienceDesignation4 = aApplicationDetailsInfo.ExperienceDesignation4,
                        ExperienceDepartment4 = aApplicationDetailsInfo.ExperienceDepartment4,
                        ExperienceFromDate4 = aApplicationDetailsInfo.ExperienceFromDate4,
                        ExperienceToDate4 = aApplicationDetailsInfo.ExperienceToDate4,
                        ExperienceAchievement4 = aApplicationDetailsInfo.ExperienceAchievement4,


                    };

                    dataConnection.Hrm_CandidatesCVBank.Add(aCVbankCreate);
                    dataConnection.SaveChanges();
                    dataConnection.Hrm_CandidatesCVBankExtension.Add(aCVbankExtension);
                    dataConnection.SaveChanges();
                    return "Save Success";
                }
                else
                {
                    return "You are using duplicate mobile or national id no";
                }
            }
            catch (Exception ex)
            {
                return "Save failed, " + ex.Message + " Please try again.";
            }


        }

    }
}