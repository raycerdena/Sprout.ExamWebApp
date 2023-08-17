using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.Exam.DataAccess.Entities
{
	public class Employee
	{
		public int Id { get; set; }
		public string FullName { get; set; }
		public DateTime Birthdate { get; set; }
		public string Tin { get; set; }
		//db collumn not same
		public int EmployeeTypeId { get; set; }
		public bool IsDeleted { get; set; }
	}
}
