using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using VxFormGenerator.Core;
using VxFormGenerator.Core.Repository;
using VxFormGenerator.Form.Components.Bootstrap;
using VxFormGenerator.Form.Components.Plain;
using VxFormGenerator.Models;

namespace VxFormGenerator.Repository.Bootstrap
{
    public class VxBootstrapRepository : FormGeneratorComponentModelBasedRepository
    {
        public VxBootstrapRepository()
        {
            _ComponentDict = new Dictionary<Type, Type>()
                  {
                    { typeof(string),          typeof(InputText) },
                    { typeof(DateTime),        typeof(InputDate<>) },
                    { typeof(bool),            typeof(BootstrapInputCheckbox) },
                    { typeof(Enum),            typeof(BootstrapInputSelectWithOptions<>) },
                    { typeof(ValueReferences), typeof(BootstrapInputCheckboxMultiple<>) },
                    { typeof(decimal),         typeof(InputNumber<>) },
                    { typeof(double),          typeof(InputNumber<>) },
                    { typeof(float),           typeof(InputNumber<>) },
                    { typeof(int),             typeof(InputNumber<>) },
                    { typeof(VxColor),         typeof(InputColor) }
                  };

            _DefaultComponent = null;
        }
    }
}
