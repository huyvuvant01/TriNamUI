// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TagHelperBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Infrastructure;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  public abstract class TagHelperBase : TagHelper
  {
    internal static readonly 
    #nullable disable
    string DeferredScriptsKey = "$DeferredScriptsKey$";
    private static readonly Regex StringFormatExpression = new Regex("(?<=\\{\\d:)(.)*(?=\\})", RegexOptions.Compiled);
    private static readonly Regex UnicodeEntityExpression = new Regex("\\\\+u(\\d+)\\\\*#(\\d+;)", RegexOptions.Compiled);
    protected const string MinimumValidator = "min";
    protected const string MaximumValidator = "max";

    [HtmlAttributeNotBound]
    [ViewContext]
    public ViewContext ViewContext { get; set; }

    [HtmlAttributeNotBound]
    protected IKendoHtmlGenerator Generator { get; set; }

    [HtmlAttributeNotBound]
    public IJavaScriptInitializer Initializer { get; set; }

    public string Name { get; set; }

    [HtmlAttributeNotBound]
    public string Id { get; set; }

    public string Selector => this.IdPrefix + this.Id;

    public string IdPrefix => !this.IsInClientTemplate ? "#" : "\\#";

    public bool IsInClientTemplate { get; set; }

    public bool Deferred { get; set; }

    public TagHelperBase(IKendoHtmlGenerator generator)
    {
      this.Generator = generator;
      this.Initializer = (IJavaScriptInitializer) new JavaScriptInitializer();
    }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
      this.VerifySettings();
      this.WriteHtml(output);
      string str = this.GetInitializationScript();
      if (this.IsInClientTemplate)
        str = WebUtility.HtmlDecode(TagHelperBase.UnicodeEntityExpression.Replace(str, (MatchEvaluator) (m => WebUtility.HtmlDecode(Regex.Unescape("\\u" + m.Groups[1].Value + "#" + m.Groups[2].Value)))));
      string encoded = this.WrapInScriptTag(str);
      if (this.Deferred)
        this.AppendScriptToContext(str);
      else
        output.PostElement.SetHtmlContent(encoded);
    }

    private void AppendScriptToContext(string script)
    {
      IDictionary<object, object> items = this.ViewContext.HttpContext.Items;
      List<KeyValuePair<string, string>> keyValuePairList = new List<KeyValuePair<string, string>>();
      if (items.ContainsKey((object) TagHelperBase.DeferredScriptsKey))
        keyValuePairList = (List<KeyValuePair<string, string>>) items[(object) TagHelperBase.DeferredScriptsKey];
      else
        items[(object) TagHelperBase.DeferredScriptsKey] = (object) keyValuePairList;
      keyValuePairList.Add(new KeyValuePair<string, string>(this.Name, script));
    }

    private string WrapInScriptTag(string initializationScript)
    {
      string str = "<script>" + initializationScript + "</script>";
      if (this.IsInClientTemplate)
        str = str.Replace("</script>", "<\\/script>");
      return str;
    }

    protected virtual void VerifySettings()
    {
    }

    protected abstract void WriteHtml(TagHelperOutput output);

    protected abstract string GetInitializationScript();

    protected virtual Dictionary<string, object> SerializeSettings() => this.SerializeEvents();

    protected abstract Dictionary<string, object> SerializeEvents();

    protected void GenerateId(TagHelperOutput output)
    {
      string fullHtmlFieldName = this.ViewContext.GetFullHtmlFieldName(this.Name);
      if (output.Attributes.ContainsName("id"))
      {
        this.Id = output.Attributes["id"].Value.ToString();
        this.Name = string.IsNullOrEmpty(fullHtmlFieldName) ? this.Id : fullHtmlFieldName;
      }
      else
        this.Id = fullHtmlFieldName;
      this.Id = this.Generator.SanitizeId(this.Id);
    }

    protected ClientHandlerDescriptor CreateHandler(string handler) => new ClientHandlerDescriptor()
    {
      HandlerName = handler
    };

    protected TValue? GetRangeValidationParameter<TValue>(ModelExplorer explorer, string parameter) where TValue : struct => explorer.Metadata.ValidatorMetadata.Where<object>((Func<object, bool>) (attr => attr is RangeAttribute)).FirstOrDefault<object>() is RangeAttribute rangeAttribute ? new TValue?((TValue) Convert.ChangeType(parameter == "min" ? rangeAttribute.Minimum : rangeAttribute.Maximum, typeof (TValue))) : new TValue?();

    protected string ExtractEditFormat(string format) => string.IsNullOrEmpty(format) ? string.Empty : TagHelperBase.StringFormatExpression.Match(format).ToString();

    protected Dictionary<string, object> ToDictionaryHandler(
      IDictionary<string, string> rules)
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      foreach (string key in (IEnumerable<string>) rules.Keys)
        dictionary[key] = (object) this.CreateHandler(rules[key]);
      return dictionary;
    }
  }
}
