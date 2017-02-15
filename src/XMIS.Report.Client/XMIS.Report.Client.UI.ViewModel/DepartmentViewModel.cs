// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DepartmentViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   The department view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Client.UI.ViewModel
{
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    ///     The department view model.
    /// </summary>
    public class DepartmentViewModel : ViewModelBase, INotifyPropertyChanged
    {
        #region Data

        /// <summary>
        ///     The _is checked.
        /// </summary>
        private bool? _isChecked = false;

        /// <summary>
        ///     The _parent.
        /// </summary>
        private DepartmentViewModel _parent;

        /// <summary>
        ///     The root.
        /// </summary>
        private static DepartmentViewModel root;

        #endregion Data

        #region CreateDepartments

        /// <summary>
        ///     The create departments.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        // http://www.codeproject.com/Articles/28306/Working-with-Checkboxes-in-the-WPF-TreeView
        public List<DepartmentViewModel> CreateDepartments()
        {
            // TODO GetDepartmentCollection();
            root = new DepartmentViewModel("Отделения", 17)
                       {
                           IsInitiallySelected = true, 
                           Children =
                               {
                                   new DepartmentViewModel("Хірургія", 1)
                                       {
                                           Children
                                               =
                                               {
                                                   new DepartmentViewModel
                                                       (
                                                       "1 хірургія", 
                                                       2), 
                                                   new DepartmentViewModel
                                                       (
                                                       "2 хірургія", 
                                                       3), 
                                                   new DepartmentViewModel
                                                       (
                                                       "3 хірургія", 
                                                       4)
                                               }
                                       }, 
                                   new DepartmentViewModel("Проктологія", 5)
                                       {
                                           Children
                                               =
                                               {
                                                   new DepartmentViewModel
                                                       (
                                                       "Онкопроктологія", 
                                                       22), 
                                                   new DepartmentViewModel
                                                       (
                                                       "Проктолог.загал.", 
                                                       23)
                                               }
                                       }, 
                                   new DepartmentViewModel("Вріт", 6), 
                                   new DepartmentViewModel("Урологія", 13), 
                                   new DepartmentViewModel("Терапія", 14)
                                       {
                                           Children
                                               =
                                               {
                                                   new DepartmentViewModel
                                                       (
                                                       "Пульмонологія", 
                                                       24), 
                                                   new DepartmentViewModel
                                                       (
                                                       "Терапія загальна", 
                                                       25)
                                               }
                                       }, 
                                   new DepartmentViewModel("Неврологія", 15), 
                                   new DepartmentViewModel(
                                       "Травматологія", 
                                       8), 
                                   new DepartmentViewModel("Ортопедія", 17), 
                                   new DepartmentViewModel(
                                       "Гастроентерол", 
                                       18), 
                                   new DepartmentViewModel("Фтизіатрія", 20)
                               }
                       };

            root.Initialize();
            return new List<DepartmentViewModel> { root };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentViewModel"/> class.
        /// </summary>
        /// <param name="departmentName">
        /// The department name.
        /// </param>
        /// <param name="departmentId">
        /// The department Id.
        /// </param>
        private DepartmentViewModel(string departmentName, int departmentId)
        {
            this.DepartmentName = departmentName;
            this.DepartmentId = departmentId;
            this.Children = new List<DepartmentViewModel>();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DepartmentViewModel" /> class.
        /// </summary>
        public DepartmentViewModel()
        {
            this.Departments = this.CreateDepartments();
        }

        /// <summary>
        ///     The initialize.
        /// </summary>
        private void Initialize()
        {
            foreach (var child in this.Children)
            {
                child._parent = this;
                child.Initialize();
            }
        }

        #endregion CreateDepartments

        #region Properties

        /// <summary>
        ///     Gets the children.
        /// </summary>
        public List<DepartmentViewModel> Children { get; }

        /// <summary>
        ///     Gets a value indicating whether is initially selected.
        /// </summary>
        public bool IsInitiallySelected { get; private set; }

        /// <summary>
        ///     Gets the department name.
        /// </summary>
        public string DepartmentName { get; private set; }

        /// <summary>
        ///     Gets the department id.
        /// </summary>
        public int DepartmentId { get; private set; }

        /// <summary>
        ///     Gets the departments.
        /// </summary>
        public List<DepartmentViewModel> Departments { get; private set; }

        #region IsChecked

        /// <summary>
        ///     Gets/sets the state of the associated UI toggle (ex. CheckBox).
        ///     The return value is calculated based on the check state of all
        ///     child DepartmentViewModels.  Setting this property to true or false
        ///     will set all children to the same check state, and setting it
        ///     to any value will cause the parent to verify its check state.
        /// </summary>
        public bool? IsChecked
        {
            get
            {
                return this._isChecked;
            }

            set
            {
                this.SetIsChecked(value, true, true);
            }
        }

        /// <summary>
        /// The set is checked.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="updateChildren">
        /// The update children.
        /// </param>
        /// <param name="updateParent">
        /// The update parent.
        /// </param>
        private void SetIsChecked(bool? value, bool updateChildren, bool updateParent)
        {
            if (value == this._isChecked)
            {
                return;
            }

            this._isChecked = value;
            if (updateChildren && this._isChecked.HasValue)
            {
                this.Children.ForEach(c => c.SetIsChecked(this._isChecked, true, false));
            }

            if (updateParent && this._parent != null)
            {
                this._parent.VerifyCheckState();
            }

            this.OnPropertyChanged("IsChecked");
        }

        /// <summary>
        ///     The verify check state.
        /// </summary>
        private void VerifyCheckState()
        {
            bool? state = null;
            for (var i = 0; i < this.Children.Count; ++i)
            {
                var current = this.Children[i].IsChecked;
                if (i == 0)
                {
                    state = current;
                }
                else if (state != current)
                {
                    state = null;
                    break;
                }
            }

            this.SetIsChecked(state, false, true);
        }

        #endregion IsChecked

        #endregion Properties

        #region INotifyPropertyChanged Members

        /// <summary>
        ///     The property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The on property changed.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        protected void OnPropertyChanged(string name)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        #endregion INotifyPropertyChanged Members

        #region Checked value

        /// <summary>
        ///     The get checked items.
        /// </summary>
        /// <param name="node">
        ///     The node.
        /// </param>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<DepartmentViewModel> GetCheckedItems()
        {
            var node = root;
            var checkedItems = new List<DepartmentViewModel>();
            this.ProcessNode(node, checkedItems);
            return checkedItems;
        }

        /// <summary>
        /// The process node.
        /// </summary>
        /// <param name="node">
        /// The node.
        /// </param>
        /// <param name="checkedItems">
        /// The checked items.
        /// </param>
        private void ProcessNode(DepartmentViewModel node, List<DepartmentViewModel> checkedItems)
        {
            foreach (var child in node.Children)
            {
                var state = child.IsChecked;
                if (state == true)
                {
                    checkedItems.Add(child);
                }

                this.ProcessNode(child, checkedItems);
            }
        }

        #endregion Checked value
    }
}