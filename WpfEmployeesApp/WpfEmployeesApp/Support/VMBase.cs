namespace WpfEmployeesApp.Support
{
	public class VMBase : NotifyUIBase
	{
		protected EmployeesContext db = new EmployeesContext();

		private bool isNew = true;
		public bool IsNew
		{
			get
			{
				return isNew;
			}
			set
			{
				isNew = value;
				RaisePropertyChanged();
			}
		}

		private bool isSelected;
		public bool IsSelected
		{
			get { return isSelected; }
			set
			{
				isSelected = value;
				RaisePropertyChanged("IsSelected");
				OnTreeViewExpanded();
			}
		}

		private bool isExpanded;
		public bool IsExpanded
		{
			get { return isExpanded; }
			set
			{
				isExpanded = value;
				RaisePropertyChanged("IsExpanded");
				OnTreeViewExpanded();
			}
		}

		protected virtual void OnTreeViewExpanded()
		{
		}

		protected virtual void GetData()
		{
		}

		protected VMBase()
		{
			GetData();
		}
	}
}
