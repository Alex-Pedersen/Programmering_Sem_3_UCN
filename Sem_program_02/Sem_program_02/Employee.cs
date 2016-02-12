namespace Sem_Program_02
{
	public class Employee
	{
		private string name;
		private string jobTitle;
		private double salery;

		public Employee(string name, string jobTitle, double salery)
		{
			this.name = name;
			this.jobTitle = jobTitle;
			this.salery = salery;
		}

		public string Name
		{
			get{return name;}
			set{name = value;}
		}

		public override string ToString()
		{
			return Name;
		}

	    public string JobTitle
	    {
	        get { return jobTitle; }
	        set { jobTitle = value; }
	    }

	    public string Name1
	    {
	        get { return name; }
	        set { name = value; }
	    }

	    public double Salery
	    {
	        get { return salery; }
	        set { salery = value; }
	    }
	}
}
