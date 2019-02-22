using GenericClass;
using SortingApplicationMuhammad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace SortingApplicationMuhammad.Controllers
{
    public class SortController : Controller
    {
        // GET: Sort
        public ActionResult Index()
        {
            return View();			
        }

        // GET: Sort/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sort/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sort/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
				// TODO: Add insert logic here
				string str = collection["InputArray"];
				string sorting = collection["SortingTypes"];
				if (ModelState.IsValid)
				{					
					if (!str.Contains(","))
					{
						ModelState.AddModelError(string.Empty, "Please enter a correct range of string or integer values. For example, 1,2,3,2,1 OR a,f,sf,as,q");

						return View();
					}
					else
					{
						List<string> mainArray = new List<string>();
						List<int> listofInts = new List<int>();
						mainArray = Regex.Split(str, ",").ToList();
						if (SortClass.CheckArray(mainArray))
						{
							listofInts = mainArray.Select(int.Parse).ToList();
							if (sorting == "Quick")
							{
								TempData["Success"] = string.Join("", QuickSort.QuickSortMethod(listofInts.ToArray(), 0, listofInts.Count - 1).Distinct());
							}
							else
							{
								TempData["Success"] = string.Join("", SortClass.BubbleSort(listofInts.ToArray()));
							}
						}
						else
						{
							if (sorting == "Quick")
							{
								TempData["Success"] = string.Join("", QuickSort.QuickSortMethod(mainArray.ToArray(), 0, mainArray.Count - 1).Distinct());
							}
							else
							{
								TempData["Success"] = string.Join("", SortClass.BubbleSort(mainArray.ToArray()));
							}
						}

						
					}
				}
				
				return View();				
            }
            catch
            {
                return View();
            }
        }

    }
}
