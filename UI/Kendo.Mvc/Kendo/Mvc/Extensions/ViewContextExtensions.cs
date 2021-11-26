// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.ViewContextExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using System.IO;
using System.Text.Encodings.Web;

namespace Kendo.Mvc.Extensions
{
  public static class ViewContextExtensions
  {
    public static T GetService<T>(this ViewContext viewContext) => viewContext.HttpContext.GetService<T>();

    public static T GetService<T>(this HttpContext context) => (T) context.RequestServices.GetService(typeof (T));

    public static ViewContext ViewContextForType<T>(
      this ViewContext viewContext,
      IModelMetadataProvider metadataProvider)
    {
      ActionContext actionContext = new ActionContext(viewContext.HttpContext, viewContext.RouteData, viewContext.ActionDescriptor);
      ViewDataDictionary<T> viewDataDictionary1 = new ViewDataDictionary<T>(viewContext.ViewData, (object) null);
      ITempDataDictionary tempData1 = viewContext.GetService<ITempDataDictionaryFactory>().GetTempData(viewContext.HttpContext);
      HtmlHelperOptions htmlHelperOptions1 = new HtmlHelperOptions()
      {
        ClientValidationEnabled = viewContext.ClientValidationEnabled,
        Html5DateRenderingMode = viewContext.Html5DateRenderingMode,
        ValidationSummaryMessageElement = viewContext.ValidationSummaryMessageElement,
        ValidationMessageElement = viewContext.ValidationMessageElement
      };
      IView view = viewContext.View;
      ViewDataDictionary<T> viewDataDictionary2 = viewDataDictionary1;
      ITempDataDictionary tempData2 = tempData1;
      StringWriter stringWriter = new StringWriter();
      HtmlHelperOptions htmlHelperOptions2 = htmlHelperOptions1;
      return new ViewContext(actionContext, view, (ViewDataDictionary) viewDataDictionary2, tempData2, (TextWriter) stringWriter, htmlHelperOptions2);
    }

    public static HtmlHelper<T> CreateHtmlHelper<T>(this ViewContext viewContext) => new HtmlHelper<T>(viewContext.GetService<IHtmlGenerator>(), viewContext.GetService<ICompositeViewEngine>(), viewContext.GetService<IModelMetadataProvider>(), viewContext.GetService<IViewBufferScope>(), viewContext.GetService<HtmlEncoder>(), viewContext.GetService<UrlEncoder>(), viewContext.GetService<ModelExpressionProvider>());

    public static string GetFullHtmlFieldName(this ViewContext viewContext, string name) => viewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(name);
  }
}
