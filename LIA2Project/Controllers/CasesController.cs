using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LIA2Project.Models;
using LIA2Project.Models.DataAccess;
using LIA2Project.Models.ViewModels;

namespace LIA2Project.Controllers
{
    public class CasesController : Controller
    {
        CasesDataAccessLayer objCase = new CasesDataAccessLayer();
        UserDataAccessLayer objUser = new UserDataAccessLayer();

        [HttpGet]
        [Route("api/Cases/Index")]
        public IEnumerable<Cases> Index()
        {
            return objCase.GetAllCases();
        }

        [HttpPost]
        [Route("api/Cases/Create")]
        public int Create([Bind("CaseId")]CreateCaseViewModel cas)
        {
            return objCase.AddCase(cas.TheCases);
        }

        [HttpGet]
        [Route("api/Cases/Details/{id}")]
        public Cases Details(int id)
        {
            return objCase.GetCaseData(id);
        }

        [HttpPut]
        [Route("api/Cases/Edit")]
        public int Edit(Cases cas)
        {
            return objCase.UpdateCase(cas);
        }

        [HttpDelete]
        [Route("api/Cases/Delete/{id}")]
        public int Delete(int id)
        {
            return objCase.DeleteCase(id);
        }


        [HttpGet]
        [Route("api/Cases/GetCreateCaseViewModel")]
        public CreateCaseViewModel GetCreateCaseViewModel(int caseId, int userId)
        {
            Cases C = objCase.GetCaseData(caseId);
            Users U = objUser.GetUserData(userId);
            return new CreateCaseViewModel { TheCases = C, TheUsers = U };
        }
    }
}