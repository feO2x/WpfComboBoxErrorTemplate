using System.Collections.Generic;

namespace WpfComboBoxErrorTemplate
{
    public class Model
    {
        public static IReadOnlyList<string> CreateItems()
        {
            return new List<string>
                   {
                       "One",
                       "Two",
                       "Three"
                   };
        }
    }
}