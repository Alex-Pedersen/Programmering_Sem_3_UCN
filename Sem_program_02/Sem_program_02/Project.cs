using System;
using System.Collections.Generic;

namespace EmpProjectV1
{
	public class Project
	{
		private string name;
		private int depNo;
		private List<WorksOn> worksOnList;

		public Project(string name, int depNo)
		{
			this.name = name;
			this.depNo = depNo;
            this.worksOnList = new List<WorksOn>();
		}

		public string Name
		{
			get{return name;}
		}

		public void AddEmployee(Employee e, int hours)
		{
			WorksOn wOn = new WorksOn(hours, e, this);
			this.worksOnList.Add(wON);
		}

		//		public int GetTotalHours()
		//		{
		//			int sum = 0;
		//			for(int i=0; i<this.worksOnList.Count; i++)
		//			{
		//				sum = sum + this.worksOnList[i].Hours;
		//			}
		//			return sum;
		//		}

        public int GetTotalHours()
		{
			int sum = 0;
			foreach(WorksOn wOn in this.worksOnList)
			{
				sum = sum + wOn.Hours;
			}
			return sum;
		}

		public List<Employee> GetEmployees()
		{
			List<Employee> returnList = new List<Employee>();
			foreach(WorksOn wOn in this.worksOnList)
			{
				returnList.Add(wOn.Employee);
			}
			return returnList;
		}


	}
}

