// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TreeListMessagesCommandsSettingsTagHelper
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
  [HtmlTargetElement("treelist-messages-commands", ParentTag = "messages", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class TreeListMessagesCommandsSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (TreeListMessagesSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as TreeListMessagesSettingsTagHelper).Commands = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Canceledit { get; set; }

    public string Create { get; set; }

    public string Createchild { get; set; }

    public string Destroy { get; set; }

    public string Edit { get; set; }

    public string Save { get; set; }

    public string Search { get; set; }

    public string Cancel { get; set; }

    public string Excel { get; set; }

    public string Pdf { get; set; }

    public string Update { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string canceledit = this.Canceledit;
      if ((canceledit != null ? (canceledit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["canceledit"] = (object) this.Canceledit;
      string create = this.Create;
      if ((create != null ? (create.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["create"] = (object) this.Create;
      string createchild = this.Createchild;
      if ((createchild != null ? (createchild.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["createchild"] = (object) this.Createchild;
      string destroy = this.Destroy;
      if ((destroy != null ? (destroy.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["destroy"] = (object) this.Destroy;
      string edit = this.Edit;
      if ((edit != null ? (edit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["edit"] = (object) this.Edit;
      string save = this.Save;
      if ((save != null ? (save.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["save"] = (object) this.Save;
      string search = this.Search;
      if ((search != null ? (search.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["search"] = (object) this.Search;
      string cancel = this.Cancel;
      if ((cancel != null ? (cancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.Cancel;
      string excel = this.Excel;
      if ((excel != null ? (excel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["excel"] = (object) this.Excel;
      string pdf = this.Pdf;
      if ((pdf != null ? (pdf.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pdf"] = (object) this.Pdf;
      string update = this.Update;
      if ((update != null ? (update.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["update"] = (object) this.Update;
      return dictionary;
    }
  }
}
