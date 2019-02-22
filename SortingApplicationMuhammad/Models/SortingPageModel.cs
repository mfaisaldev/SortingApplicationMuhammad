using GenericClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SortingApplicationMuhammad.Models
{
	public class SortingPageModel
	{
		[RegularExpression(@"[a-zA-Z0-9,\s]+", ErrorMessage = "Invalid character found. Only string, integer values with comma is allowed.")]
		[Required(ErrorMessage = "Please enter a correct range of string or integer values. For example, 1,2,3,2,1 OR a,f,sf,as,q")]
		public string InputArray { get; set; }
		public SortingTypes SortingType { get; set; }
		public string OutPutArray { get; set; }		
	}

	public enum SortingTypes
	{		
		Quick,
		Bubble
	}
}