using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace WpfComboBoxErrorTemplate
{
    public static class RaisePropertyChangedExtensions
    {
        public static void SetValueIfChanged<T>(this IRaisePropertyChanged source,
                                                ref T field,
                                                T value,
                                                [CallerMemberName] string propertyName = null)
        {
            // ReSharper disable once ExplicitCallerInfoArgument
            SetValueIfChanged(source, ref field, value, EqualityComparer<T>.Default, propertyName);
        }

        public static void SetValueIfChanged<T>(this IRaisePropertyChanged source,
                                                ref T field,
                                                T value,
                                                IEqualityComparer<T> equalityComparer,
                                                [CallerMemberName] string propertyName = null)
        {
            if (equalityComparer.GetHashCode(field) == equalityComparer.GetHashCode(value) &&
                equalityComparer.Equals(field, value))
                return;

            field = value;
            source.RaisePropertyChanged(propertyName);
        }
    }
}