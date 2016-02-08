using System;

namespace EmpProjectV1
{
	public class WorksOn
	{
		private int hours;
		private Project p;
		private Employee e;

		public WorksOn(int hours, Employee e, Project p)
		{
			this.hours = hours;
			this.e = e;
			this.p = p;
		}

		public Employee Employee
		{
			get{return e;}
		}

		public Project Project
		{
			get{return p;}
		}

		public int Hours
		{
			get{ return hours;}
			set{hours = value;}
		}
	}
}
