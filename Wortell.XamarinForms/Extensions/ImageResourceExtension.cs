using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wortell.XamarinForms.Extensions
{
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }
        public static Assembly Assembly { get; set; }

        public static string ResourcePrefix { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(Source) )
            {
                return null;
            }
            var resourceName = !string.IsNullOrWhiteSpace(ResourcePrefix)? $"{ResourcePrefix}.{Source}" : Source;
            var imageSource = ImageSource.FromResource(resourceName, Assembly);
            return imageSource;
        }
    }
}
