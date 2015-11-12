using System.Windows.Controls;

namespace WpfComboBoxErrorTemplate
{
    public partial class ComboBoxWithException : UserControl
    {
        public ComboBoxWithException()
        {
            InitializeComponent();
            DataContext = new ComboBoxWithExceptionViewModel();
        }
    }
}
