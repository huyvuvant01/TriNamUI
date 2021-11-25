// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridColumnMenuMessagesSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("messages", ParentTag = "column-menu", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class GridColumnMenuMessagesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridColumnMenuSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridColumnMenuSettingsTagHelper).Messages = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Apply { get; set; }

    public string ButtonTitle { get; set; }

    public string Columns { get; set; }

    public string Filter { get; set; }

    public string Lock { get; set; }

    public string Reset { get; set; }

    public string SortAscending { get; set; }

    public string SortDescending { get; set; }

    public string SetColumnPosition { get; set; }

    public string Settings { get; set; }

    public string Stick { get; set; }

    public string Unstick { get; set; }

    public string Unlock { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string apply = this.Apply;
      if ((apply != null ? (apply.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["apply"] = (object) this.Apply;
      string buttonTitle = this.ButtonTitle;
      if ((buttonTitle != null ? (buttonTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["buttonTitle"] = (object) this.ButtonTitle;
      string columns = this.Columns;
      if ((columns != null ? (columns.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columns"] = (object) this.Columns;
      string filter = this.Filter;
      if ((filter != null ? (filter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filter"] = (object) this.Filter;
      string str = this.Lock;
      if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["lock"] = (object) this.Lock;
      string reset = this.Reset;
      if ((reset != null ? (reset.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["reset"] = (object) this.Reset;
      string sortAscending = this.SortAscending;
      if ((sortAscending != null ? (sortAscending.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["sortAscending"] = (object) this.SortAscending;
      string sortDescending = this.SortDescending;
      if ((sortDescending != null ? (sortDescending.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["sortDescending"] = (object) this.SortDescending;
      string setColumnPosition = this.SetColumnPosition;
      if ((setColumnPosition != null ? (setColumnPosition.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["setColumnPosition"] = (object) this.SetColumnPosition;
      string settings = this.Settings;
      if ((settings != null ? (settings.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["settings"] = (object) this.Settings;
      string stick = this.Stick;
      if ((stick != null ? (stick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["stick"] = (object) this.Stick;
      string unstick = this.Unstick;
      if ((unstick != null ? (unstick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["unstick"] = (object) this.Unstick;
      string unlock = this.Unlock;
      if ((unlock != null ? (unlock.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["unlock"] = (object) this.Unlock;
      return dictionary;
    }
  }
}
