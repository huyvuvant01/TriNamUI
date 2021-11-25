// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Tooltip
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
  public class Tooltip : WidgetBase
  {
    private string container;

    public Tooltip(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public PopupAnimation Animation { get; } = new PopupAnimation();

    public string Container
    {
      get => this.container;
      set => this.Name = this.container = value;
    }

    public string ContentUrl { get; set; }

    public string Content { get; set; }

    public string ContentTemplateId { get; set; }

    public ClientHandlerDescriptor ContentHandler { get; } = new ClientHandlerDescriptor();

    private string Encode(string value)
    {
      value = Regex.Replace(value, "(%20)*%23%3D(%20)*", "#=", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%23(%20)*", "#", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%24%7B(%20)*", "${", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%7D(%20)*", "}", RegexOptions.IgnoreCase);
      return value;
    }

    protected override void WriteHtml(TextWriter writer) => base.WriteHtml(writer);

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.Serialize();
      writer.Write(this.Initializer.InitializeFor(this.SanitizeSelector(this.Container), nameof (Tooltip), (IDictionary<string, object>) dictionary));
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> options = this.SerializeSettings();
      if (this.Filter.HasValue())
        options["filter"] = (object) this.SanitizeSelector(this.Filter);
      IDictionary<string, object> json = this.Animation.ToJson();
      if (json.Any<KeyValuePair<string, object>>())
        options["animation"] = !(json["animation"] is bool) ? json["animation"] : (object) false;
      this.SerializeContent(options);
      return options;
    }

    private void SerializeContent(Dictionary<string, object> options)
    {
      if (this.ContentUrl.HasValue())
        options["content"] = (object) new Dictionary<string, object>()
        {
          {
            "url",
            (object) this.Encode(this.ContentUrl)
          }
        };
      else if (this.ContentHandler.HasValue())
        options["content"] = (object) this.ContentHandler;
      else if (!string.IsNullOrEmpty(this.ContentTemplateId))
      {
        string str = "#";
        if (this.IsInClientTemplate)
          str = "\\" + str;
        options["content"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.ContentTemplateId)
        };
      }
      else
      {
        if (!this.Content.HasValue())
          return;
        options["content"] = (object) WebUtility.UrlDecode(this.Content);
      }
    }

    public override void VerifySettings()
    {
      if (string.IsNullOrEmpty(this.Container))
        throw new InvalidOperationException(Exceptions.TooltipContainerShouldBeSet);
      this.ThrowIfClassIsPresent("k-" + this.GetType().GetTypeName().ToLowerInvariant() + "-rtl", Exceptions.Rtl);
    }

    private string SanitizeSelector(string selector)
    {
      if (string.IsNullOrWhiteSpace(selector))
        return string.Empty;
      if (!this.IsInClientTemplate)
        return selector;
      StringBuilder stringBuilder = new StringBuilder(selector.Length);
      int num1 = selector.IndexOf("#=");
      int num2 = selector.LastIndexOf("#");
      if (num2 > num1 && num1 > -1)
      {
        stringBuilder.Append(selector.Substring(0, num1).Replace("#", "\\#"));
        stringBuilder.Append(selector.Substring(num1, num2 - num1 + 1));
        stringBuilder.Append(selector.Substring(num2 + 1).Replace("#", "\\#"));
      }
      else
        stringBuilder.Append(selector.Replace("#", "\\#"));
      return stringBuilder.ToString();
    }

    public bool? AutoHide { get; set; }

    public bool? Callout { get; set; }

    public string Filter { get; set; }

    public bool? Iframe { get; set; }

    public double? Height { get; set; }

    public double? Width { get; set; }

    public double? ShowAfter { get; set; }

    public double? HideAfter { get; set; }

    public double? Offset { get; set; }

    public TooltipPosition? Position { get; set; }

    public TooltipShowOnEvent? ShowOn { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AutoHide.HasValue)
        dictionary1["autoHide"] = (object) this.AutoHide;
      if (this.Callout.HasValue)
        dictionary1["callout"] = (object) this.Callout;
      if (this.Iframe.HasValue)
        dictionary1["iframe"] = (object) this.Iframe;
      if (this.Height.HasValue)
        dictionary1["height"] = (object) this.Height;
      if (this.Width.HasValue)
        dictionary1["width"] = (object) this.Width;
      if (this.ShowAfter.HasValue)
        dictionary1["showAfter"] = (object) this.ShowAfter;
      if (this.HideAfter.HasValue)
        dictionary1["hideAfter"] = (object) this.HideAfter;
      if (this.Offset.HasValue)
        dictionary1["offset"] = (object) this.Offset;
      if (this.Position.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        TooltipPosition? position = this.Position;
        ref TooltipPosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["position"] = (object) str;
      }
      if (this.ShowOn.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        TooltipShowOnEvent? showOn = this.ShowOn;
        ref TooltipShowOnEvent? local = ref showOn;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["showOn"] = (object) str;
      }
      return dictionary1;
    }
  }
}
