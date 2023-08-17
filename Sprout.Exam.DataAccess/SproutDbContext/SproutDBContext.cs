using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Sprout.Exam.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sprout.Exam.DataAccess.SproutDbContext
{
	public class SproutDBContext : ApiAuthorizationDbContext<ApplicationUser>
	{
		public SproutDBContext(
		 DbContextOptions options,
		 IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
		{
		}

		public DbSet<Employee> Employee { get; set; }
	}
}
