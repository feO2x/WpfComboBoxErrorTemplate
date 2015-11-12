# WpfComboBoxErrorTemplate

This repo demonstrates how Error Templates can be used with WPF Combo Boxes. There is one special case here: if a source (e.g. a view model implementing INotifyDataErrorInfo) reports errors when it is attached to the ComboBox, then the Validation.ErrorTemplate is not shown until the user selects an item.

This behavior can be circumvented by customizing the ControlTemplate of the ComboBox. You can see this template in the Resources.xaml file (or in Tab #3 when you run the program). Essentially, I added another Grid, Border and TextBlock whose values are changed by a Control Template Trigger that reacts when the Validation.HasError dependency property changes on the ComboBox control.
