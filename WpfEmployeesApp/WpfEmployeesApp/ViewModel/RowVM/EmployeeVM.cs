using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using WpfEmployeesApp.Support;

namespace WpfEmployeesApp.ViewModel.RowVM
{
	public class EmployeeVM : VMBase
	{
		public Employee EmployeesModelDbEmployee { get; set; }
		public ObservableCollection<EmployeeVM> EmployeeTeamMembers { get; set; }

		public EmployeeVM()
		{
			EmployeesModelDbEmployee = new Employee();
		}

		protected override async void OnTreeViewExpanded()
		{
			if (EmployeeTeamMembers != null) return;
			ObservableCollection<EmployeeVM> _team = new ObservableCollection<EmployeeVM>();
			var team = await(from em in db.Employees
							 where em.ManagerId == EmployeesModelDbEmployee.Id
							 select em).ToListAsync();
			foreach (Employee emp in team)
			{
				_team.Add(new EmployeeVM { IsNew = false, EmployeesModelDbEmployee = emp });
			}
			EmployeeTeamMembers = _team;
			RaisePropertyChanged("EmployeeTeamMembers");
		}
	}
}
