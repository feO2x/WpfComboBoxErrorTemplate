using System.Windows;
using System.Windows.Controls;

namespace WpfComboBoxErrorTemplate
{
    public partial class InitiallyInvalidComboBoxView : UserControl
    {
        public InitiallyInvalidComboBoxView()
        {
            InitializeComponent();
            DataContext = new InitiallyInvalidComboBoxViewModel();
        }
    }
}
