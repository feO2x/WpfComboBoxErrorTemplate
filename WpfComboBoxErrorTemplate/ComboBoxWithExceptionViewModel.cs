using System;
using System.Collections.Generic;

namespace WpfComboBoxErrorTemplate
{
    public sealed class ComboBoxWithExceptionViewModel : NotifyingObject
    {
        private bool _isThrowingException;
        private string _selectedItem;

        public bool IsThrowingException
        {
            get { return _isThrowingException; }
            set { this.SetValueIfChanged(ref _isThrowingException, value); }
        }

        public IReadOnlyList<string> Items { get; } = Model.CreateItems();

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (_isThrowingException)
                    throw new Exception("There's something wrong");
                this.SetValueIfChanged(ref _selectedItem, value);
            }
        }
    }
}