using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfComboBoxErrorTemplate
{
    public partial class ComboBoxWithCustomValidationRule : UserControl
    {
        public IReadOnlyList<string> Items { get; private set; }
        public string SelectedItem { get; set; }

        public ComboBoxWithCustomValidationRule()
        {
            Items = Model.CreateItems();
            InitializeComponent();
            CustomValidationRule.IsValid = true;
        }

        private void ToggleButton_OnChecked(object sender, RoutedEventArgs e)
        {
            if (CustomValidationRule == null) return;
            CustomValidationRule.IsValid = true;
        }

        private void ToggleButton_OnUnchecked(object sender, RoutedEventArgs e)
        {
            if (CustomValidationRule == null) return;
            CustomValidationRule.IsValid = false;
        }
    }
}
