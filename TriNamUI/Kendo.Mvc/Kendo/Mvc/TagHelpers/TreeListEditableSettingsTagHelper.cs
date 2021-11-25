// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TreeListEditableSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("editable", ParentTag = "kendo-treelist", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class TreeListEditableSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (TreeListTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as TreeListTagHelper).Editable = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    [HtmlAttributeNotBound]
    public TreeListEditableMoveSettingsTagHelper Move { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public TreeListEditMode? Mode { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.Move != null)
      {
        Dictionary<string, object> source = this.Move.Serialize();
        bool? enabled;
        if (source.Any<KeyValuePair<string, object>>())
        {
          enabled = this.Move.Enabled;
          if (enabled.HasValue)
          {
            enabled = this.Move.Enabled;
            if (!enabled.Value)
              goto label_5;
          }
          dictionary1["move"] = (object) source;
          goto label_8;
        }
label_5:
        enabled = this.Move.Enabled;
        if (enabled.HasValue)
        {
          enabled = this.Move.Enabled;
          if (enabled.Value)
            dictionary1["move"] = (object) this.Move.Enabled;
        }
      }
label_8:
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      if (this.Mode.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        TreeListEditMode? mode = this.Mode;
        ref TreeListEditMode? local = ref mode;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["mode"] = (object) str;
      }
      return dictionary1;
    }
  }
}
