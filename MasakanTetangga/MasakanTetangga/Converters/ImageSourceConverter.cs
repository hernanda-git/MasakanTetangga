using System;
using System.Globalization;
using System.Reflection;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace MasakanTetangga.Converters
{
    public class ImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            return ImageSource.FromResource((string)value, typeof(ImageResourceExtension).GetTypeInfo().Assembly);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
    