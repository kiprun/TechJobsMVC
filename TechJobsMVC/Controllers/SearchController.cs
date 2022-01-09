﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsMVC.Data;
using TechJobsMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsMVC.Controllers
{
    public class SearchController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.columns = ListController.ColumnChoices;
            return View();
        }

       
        // TODO #3: Create an action method to process a search request and render the updated search view. 
        public ActionResult Results(string searchType, string searchTerm)
        {
            List<Job> jobs; //Store results in job list

            if (string.IsNullOrEmpty(searchTerm))//if searchTerm is blank or empty
            {
                jobs = JobData.FindAll();//list all jobs
            }
            else
            {
                jobs = JobData.FindByColumnAndValue(searchType, searchTerm);//pass infomration from user serach
            }
           
            ViewBag.jobs = jobs;   
            ViewBag.title = "Search Results: " + searchTerm;
            ViewBag.columns = ListController.ColumnChoices;      
            return View("Index");//?
        }
    }
}
