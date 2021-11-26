// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.WidgetBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Infrastructure;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;


#nullable enable
namespace Kendo.Mvc.UI
{
  public abstract class WidgetBase : IHtmlAttributesContainer
  {
    internal static readonly 
    #nullable disable
    string DeferredScriptsKey = "$DeferredScriptsKey$";
    private static readonly Regex UnicodeEntityExpression = new Regex("\\\\+u(\\d+)\\\\*#(\\d+;)", RegexOptions.Compiled);

    public WidgetBase(ViewContext viewContext)
    {
      this.Events = (IDictionary<string, object>) new Dictionary<string, object>();
      this.HtmlAttributes = (IDictionary<string, object>) new RouteValueDictionary();
      this.IsSelfInitialized = true;
      this.Initializer = (IJavaScriptInitializer) new JavaScriptInitializer();
      this.ViewContext = viewContext;
      this.Activate();
    }

    public IDictionary<string, object> Events { get; private set; }

    public string Id => this.Generator.SanitizeId(this.HtmlAttributes.ContainsKey("id") ? (string) this.HtmlAttributes["id"] : this.ViewContext.GetFullHtmlFieldName(this.Name));

    public IJavaScriptInitializer Initializer { get; set; }

    public bool IsInClientTemplate { get; private set; }

    public bool IsSelfInitialized { get; set; }

    public bool HasDeferredInitialization { get; set; }

    public IDictionary<string, object> HtmlAttributes { get; set; }

    public IHtmlHelper HtmlHelper { get; set; }

    public IModelMetadataProvider ModelMetadataProvider { get; set; }

    public string Name { get; set; }

    public ModelExplorer Explorer { get; set; }

    public string Selector => this.IdPrefix + this.Id;

    public string IdPrefix => !this.IsInClientTemplate ? "#" : "\\#";

    public ViewContext ViewContext { get; private set; }

    public IValueProvider ValueProvider
    {
      get
      {
        IValueProviderFactory[] array = this.ViewContext.GetService<IOptions<MvcOptions>>().Value.ValueProviderFactories.ToArray<IValueProviderFactory>();
        ValueProviderFactoryContext context = new ValueProviderFactoryContext(this.ViewContext.GetService<IActionContextAccessor>().ActionContext);
        for (int index = 0; index < array.Length; ++index)
          array[index].CreateValueProviderAsync(context);
        return (IValueProvider) new CompositeValueProvider(context.ValueProviders);
      }
    }

    protected IKendoHtmlGenerator Generator { get; set; }

    public IUrlGenerator UrlGenerator { get; set; }

    public HtmlEncoder HtmlEncoder { get; set; }

    public void Render() => this.RenderHtml(this.ViewContext.Writer);

    protected virtual Dictionary<string, object> SerializeSettings() => new Dictionary<string, object>(this.Events);

    public HtmlString ToClientTemplate()
    {
      this.IsInClientTemplate = true;
      string input = this.ToHtmlString().Replace("</script>", "<\\/script>");
      return new HtmlString(WebUtility.HtmlDecode(WidgetBase.UnicodeEntityExpression.Replace(input, (MatchEvaluator) (m => WebUtility.HtmlDecode(Regex.Unescape("\\u" + m.Groups[1].Value + "#" + m.Groups[2].Value))))));
    }

    public string ToHtmlString()
    {
      using (StringWriter stringWriter = new StringWriter())
      {
        this.RenderHtml((TextWriter) stringWriter);
        return stringWriter.ToString();
      }
    }

    public virtual void VerifySettings()
    {
      if (!this.Name.Contains("<#=") && this.Name.IndexOf(" ") != -1)
        throw new InvalidOperationException(Exceptions.NameCannotContainSpaces);
      this.ThrowIfClassIsPresent("k-" + this.GetType().Name.ToLowerInvariant() + "-rtl", Exceptions.Rtl);
    }

    public abstract void WriteInitializationScript(TextWriter writer);

    public virtual void ProcessSettings()
    {
    }

    protected virtual void RenderHtml(TextWriter writer)
    {
      this.ProcessSettings();
      this.WriteHtml(writer);
    }

    protected virtual void WriteHtml(TextWriter writer)
    {
      this.VerifySettings();
      if (!this.IsSelfInitialized || this.HasDeferredInitialization)
        return;
      writer.Write("<script>");
      this.WriteInitializationScript(writer);
      writer.Write("</script>");
    }

    public virtual void WriteDeferredScriptInitialization()
    {
      StringWriter stringWriter = new StringWriter();
      this.WriteInitializationScript((TextWriter) stringWriter);
      this.AppendScriptToContext(stringWriter.ToString());
    }

    private void Activate()
    {
      this.Generator = this.GetService<IKendoHtmlGenerator>();
      this.HtmlHelper = this.GetService<IHtmlHelper>();
      this.HtmlEncoder = this.GetService<HtmlEncoder>();
      this.ModelMetadataProvider = this.GetService<IModelMetadataProvider>();
      this.UrlGenerator = this.GetService<IUrlGenerator>();
      ((IViewContextAware) this.HtmlHelper).Contextualize(this.ViewContext);
      if (this.Generator == null)
        throw new Exception("Kendo services are not registered. Please call services.AddKendo() in ConfigureServices method of your project.");
    }

    protected TService GetService<TService>() => this.ViewContext.GetService<TService>();

    private void AppendScriptToContext(string script)
    {
      IDictionary<object, object> items = this.ViewContext.HttpContext.Items;
      List<KeyValuePair<string, string>> keyValuePairList = new List<KeyValuePair<string, string>>();
      if (items.ContainsKey((object) WidgetBase.DeferredScriptsKey))
        keyValuePairList = (List<KeyValuePair<string, string>>) items[(object) WidgetBase.DeferredScriptsKey];
      else
        items[(object) WidgetBase.DeferredScriptsKey] = (object) keyValuePairList;
      keyValuePairList.Add(new KeyValuePair<string, string>(this.Name, script));
    }
  }
}
