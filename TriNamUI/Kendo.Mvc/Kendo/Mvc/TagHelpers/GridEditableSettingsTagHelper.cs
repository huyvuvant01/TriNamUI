// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridEditableSettingsTagHelper
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
  [HtmlTargetElement("editable", ParentTag = "kendo-grid", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class GridEditableSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridTagHelper).Editable = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    public bool? Confirmation { get; set; }

    public string ConfirmationHandler { get; set; }

    public string CancelDelete { get; set; }

    public string ConfirmDelete { get; set; }

    public string CreateAt { get; set; }

    public bool? Destroy { get; set; }

    public string Mode { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Update { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string confirmationHandler = this.ConfirmationHandler;
      bool? nullable;
      if ((confirmationHandler != null ? (confirmationHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["confirmation"] = (object) this.CreateHandler(this.ConfirmationHandler);
      }
      else
      {
        nullable = this.Confirmation;
        if (nullable.HasValue)
          dictionary["confirmation"] = (object) this.Confirmation;
      }
      string cancelDelete = this.CancelDelete;
      if ((cancelDelete != null ? (cancelDelete.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancelDelete"] = (object) this.CancelDelete;
      string confirmDelete = this.ConfirmDelete;
      if ((confirmDelete != null ? (confirmDelete.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["confirmDelete"] = (object) this.ConfirmDelete;
      string createAt = this.CreateAt;
      if ((createAt != null ? (createAt.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["createAt"] = (object) this.CreateAt;
      nullable = this.Destroy;
      if (nullable.HasValue)
        dictionary["destroy"] = (object) this.Destroy;
      string mode = this.Mode;
      if ((mode != null ? (mode.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["mode"] = (object) this.Mode;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      nullable = this.Update;
      if (nullable.HasValue)
        dictionary["update"] = (object) this.Update;
      return dictionary;
    }
  }
}
