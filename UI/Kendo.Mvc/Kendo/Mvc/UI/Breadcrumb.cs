// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Breadcrumb
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Breadcrumb : WidgetBase
  {
    public string Tag { get; set; }

    public Breadcrumb(ViewContext viewContext)
      : base(viewContext)
    {
      this.Tag = "nav";
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag(this.Tag, this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Breadcrumb), (IDictionary<string, object>) dictionary));
    }

    public bool? BindToLocation { get; set; }

    public string DelimiterIcon { get; set; }

    public bool? Editable { get; set; }

    public List<BreadcrumbItem> Items { get; set; } = new List<BreadcrumbItem>();

    public double? Gap { get; set; }

    public BreadcrumbMessagesSettings Messages { get; } = new BreadcrumbMessagesSettings();

    public bool? Navigational { get; set; }

    public string RootIcon { get; set; }

    public string Value { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.BindToLocation.HasValue)
        dictionary["bindToLocation"] = (object) this.BindToLocation;
      string delimiterIcon = this.DelimiterIcon;
      if ((delimiterIcon != null ? (delimiterIcon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["delimiterIcon"] = (object) this.DelimiterIcon;
      if (this.Editable.HasValue)
        dictionary["editable"] = (object) this.Editable;
      IEnumerable<Dictionary<string, object>> source1 = this.Items.Select<BreadcrumbItem, Dictionary<string, object>>((Func<BreadcrumbItem, Dictionary<string, object>>) (i => i.Serialize()));
      if (source1.Any<Dictionary<string, object>>())
        dictionary["items"] = (object) source1;
      if (this.Gap.HasValue)
        dictionary["gap"] = (object) this.Gap;
      Dictionary<string, object> source2 = this.Messages.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source2;
      if (this.Navigational.HasValue)
        dictionary["navigational"] = (object) this.Navigational;
      string rootIcon = this.RootIcon;
      if ((rootIcon != null ? (rootIcon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["rootIcon"] = (object) this.RootIcon;
      string str = this.Value;
      if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["value"] = (object) this.Value;
      return dictionary;
    }
  }
}
