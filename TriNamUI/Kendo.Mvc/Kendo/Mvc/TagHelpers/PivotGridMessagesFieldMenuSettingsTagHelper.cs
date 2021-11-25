// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotGridMessagesFieldMenuSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("pivotgrid-messages-field-menu", ParentTag = "messages", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("operators", new string[] {})]
  [SuppressTagRendering]
  public class PivotGridMessagesFieldMenuSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PivotGridMessagesSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PivotGridMessagesSettingsTagHelper).FieldMenu = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Info { get; set; }

    public string SortAscending { get; set; }

    public string SortDescending { get; set; }

    public string FilterFields { get; set; }

    public string Filter { get; set; }

    public string Include { get; set; }

    public string Title { get; set; }

    public string Clear { get; set; }

    public string Ok { get; set; }

    public string Cancel { get; set; }

    [HtmlAttributeNotBound]
    public PivotGridMessagesFieldMenuOperatorsSettingsTagHelper Operators { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string info = this.Info;
      if ((info != null ? (info.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["info"] = (object) this.Info;
      string sortAscending = this.SortAscending;
      if ((sortAscending != null ? (sortAscending.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["sortAscending"] = (object) this.SortAscending;
      string sortDescending = this.SortDescending;
      if ((sortDescending != null ? (sortDescending.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["sortDescending"] = (object) this.SortDescending;
      string filterFields = this.FilterFields;
      if ((filterFields != null ? (filterFields.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filterFields"] = (object) this.FilterFields;
      string filter = this.Filter;
      if ((filter != null ? (filter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filter"] = (object) this.Filter;
      string include = this.Include;
      if ((include != null ? (include.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["include"] = (object) this.Include;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      string clear = this.Clear;
      if ((clear != null ? (clear.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["clear"] = (object) this.Clear;
      string ok = this.Ok;
      if ((ok != null ? (ok.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["ok"] = (object) this.Ok;
      string cancel = this.Cancel;
      if ((cancel != null ? (cancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.Cancel;
      if (this.Operators != null)
      {
        Dictionary<string, object> source = this.Operators.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["operators"] = (object) source;
      }
      return dictionary;
    }
  }
}
