using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module01Exercise01
{
    public class CurrenDateExtension : IMarkupExtension
    {
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return $"Welcome to my application the date today is {DateTime.Now.ToString("D")}";
        }
    }
}
