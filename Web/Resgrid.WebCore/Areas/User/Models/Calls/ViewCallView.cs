﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Resgrid.Model;
using Microsoft.AspNet.Identity.EntityFramework6;

namespace Resgrid.Web.Areas.User.Models.Calls
{
	public class ViewCallView: BaseUserModel
	{
		public Department Department { get; set; }
		public IdentityUser User { get; set; }
		public Call Call { get; set; }
		public string Message { get; set; }
		public List<DepartmentGroup> Groups { get; set; }
		public List<IdentityUser> UnGroupedUsers { get; set; }
		public CallPriority CallPriority { get; set; }
		public SelectList CallPriorities { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }
		public List<UnitState> UnitStates { get; set; }
		public List<ActionLog> ActionLogs { get; set; }
		public List<UserGroupRole> UserGroupRoles { get; set; }
	}
}