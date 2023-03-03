using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Application.Infrastructure.Binder
{
    public class GeometryModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {

            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var modelState = bindingContext.ModelState;
            var modelType = bindingContext.ModelType;
            var modelName = bindingContext.ModelName;
            var valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);

            if (valueProviderResult == ValueProviderResult.None)
            {
                return Task.CompletedTask;
            }


            try
            {
                var reader = new NetTopologySuite.IO.WKTReader();
                var result = (Geometry)reader.Read(valueProviderResult.FirstOrDefault());
                bindingContext.Result = ModelBindingResult.Success(result);
            }
            catch
            {
                bindingContext.Result = ModelBindingResult.Failed();
            }


            return Task.CompletedTask;
        }
    }

    public class GeometryModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));

            // our binders here
            if (context.Metadata.ModelType == typeof(Geometry) ||
                context.Metadata.ModelType == typeof(Polygon) ||
                context.Metadata.ModelType == typeof(Point) ||
                context.Metadata.ModelType == typeof(LineString))
            {
                return new BinderTypeModelBinder(typeof(GeometryModelBinder));
            }

            // your maybe have more binders?
            // ....

            // this provider does not provide any binder for given type
            //   so we return null
            return null;
        }
    }

}
