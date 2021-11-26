// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TreeListColumnCommandTagHelper
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
  [HtmlTargetElement("treelist-column-command", ParentTag = "commands", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class TreeListColumnCommandTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (TreeListColumnCommandsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as TreeListColumnCommandsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string ClassName { get; set; }

    public string ImageClass { get; set; }

    public string Click { get; set; }

    public string Name { get; set; }

    public string Text { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string className = this.ClassName;
      if ((className != null ? (className.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["className"] = (object) this.ClassName;
      string imageClass = this.ImageClass;
      if ((imageClass != null ? (imageClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageClass"] = (object) this.ImageClass;
      string click = this.Click;
      if ((click != null ? (click.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["click"] = (object) this.CreateHandler(this.Click);
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      return dictionary;
    }
  }
}
