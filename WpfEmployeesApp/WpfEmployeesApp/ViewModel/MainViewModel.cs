using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using WpfEmployeesApp.Support;
using WpfEmployeesApp.ViewModel.RowVM;

namespace WpfEmployeesApp.ViewModel
{
	public class MainViewModel : VMBase
	{
		public ObservableCollection<EmployeeVM> Managers { get; set; }
		public MainViewModel()
			: base()
		{
		}

		protected override async void GetData()
		{
			ObservableCollection<EmployeeVM> _managers = new ObservableCollection<EmployeeVM>();
			var managers = await (from em in db.Employees
								  where em.ManagerId == null
								  select em).ToListAsync();
			//  await Task.Delay(9000);
			foreach (Employee emp in managers)
			{
				_managers.Add(new EmployeeVM { IsNew = false, EmployeesModelDbEmployee = emp });
			}
			Managers = _managers;
			RaisePropertyChanged("Managers");
		}
	}
}
