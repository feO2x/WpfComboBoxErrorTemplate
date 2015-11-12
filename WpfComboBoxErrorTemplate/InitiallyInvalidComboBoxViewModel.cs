using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace WpfComboBoxErrorTemplate
{
    public sealed class InitiallyInvalidComboBoxViewModel : NotifyingObject, INotifyDataErrorInfo
    {
        private readonly Dictionary<string, string> _errors = new Dictionary<string, string>();
        private string _selectedItem;
        private readonly IReadOnlyList<string> _items = Model.CreateItems();

        public InitiallyInvalidComboBoxViewModel()
        {
            AddSelectedItemErrorMessage();
        }

        private void AddSelectedItemErrorMessage()
        {
            if (_errors.ContainsKey(nameof(SelectedItem)) == false)
                _errors.Add(nameof(SelectedItem), "You have to choose a value here");
        }

        public IReadOnlyList<string> Items => _items;

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                if (_items.Contains(value))
                    _errors.Clear();
                else
                    AddSelectedItemErrorMessage();
                ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(nameof(SelectedItem)));
                OnPropertyChanged();
            }
        }


        public IEnumerable GetErrors(string propertyName)
        {
            string errorEntry;
            return _errors.TryGetValue(propertyName, out errorEntry) ? new[] { errorEntry } : null;
        }

        public bool HasErrors => _errors.Count > 0;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
    }
}
