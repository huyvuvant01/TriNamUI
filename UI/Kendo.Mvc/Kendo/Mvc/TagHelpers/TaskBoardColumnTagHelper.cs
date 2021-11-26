// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TaskBoardColumnTagHelper
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
  [HtmlTargetElement("column", ParentTag = "taskboard-columns", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class TaskBoardColumnTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (TaskBoardColumnsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as TaskBoardColumnsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Text { get; set; }

    public string Status { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      string status = this.Status;
      if ((status != null ? (status.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["status"] = (object) this.Status;
      return dictionary;
    }
  }
}
