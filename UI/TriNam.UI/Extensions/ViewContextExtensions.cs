using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using System.IO;
using System.Text.Encodings.Web;

namespace TriNamUI.Extensions
{
    /// <summary>
    /// ViewContextExtensions
    /// </summary>
    public static partial class ViewContextExtensions
    {
        public static T GetService<T>(this ViewContext viewContext)
        {
            return viewContext.HttpContext.GetService<T>();
        }

        public static T GetService<T>(this HttpContext context)
        {
            return (T)context.RequestServices.GetService(typeof(T));
        }

        public static ViewContext ViewContextForType<T>(this ViewContext viewContext, IModelMetadataProvider metadataProvider)
        {
            return new ViewContext(new ActionContext(viewContext.HttpContext, viewContext.RouteData, viewContext.ActionDescriptor), viewData: new ViewDataDictionary<T>(viewContext.ViewData, null), tempData: viewContext.GetService<ITempDataDictionaryFactory>().GetTempData(viewContext.HttpContext), htmlHelperOptions: new HtmlHelperOptions
            {
                ClientValidationEnabled = viewContext.ClientValidationEnabled,
                Html5DateRenderingMode = viewContext.Html5DateRenderingMode,
                ValidationSummaryMessageElement = viewContext.ValidationSummaryMessageElement,
                ValidationMessageElement = viewContext.ValidationMessageElement
            }, view: viewContext.View, writer: new StringWriter());
        }

        public static HtmlHelper<T> CreateHtmlHelper<T>(this ViewContext viewContext)
        {
            return new HtmlHelper<T>(viewContext.GetService<IHtmlGenerator>(), viewContext.GetService<ICompositeViewEngine>(), viewContext.GetService<IModelMetadataProvider>(), viewContext.GetService<IViewBufferScope>(), viewContext.GetService<HtmlEncoder>(), viewContext.GetService<UrlEncoder>(), viewContext.GetService<ModelExpressionProvider>());
        }

        public static string GetFullHtmlFieldName(this ViewContext viewContext, string name)
        {
            return viewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(name);
        }
    }
}
