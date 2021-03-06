// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SpreadsheetSheetRowCellValidationSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("validation", ParentTag = "cell", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class SpreadsheetSheetRowCellValidationSettingsTagHelper : TagHelperChildBase
  {
    [HtmlAttributeName("datatype")]
    public 
    #nullable disable
    string DataType { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (SpreadsheetSheetRowCellTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SpreadsheetSheetRowCellTagHelper).Validation = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string dataType = this.DataType;
      if ((dataType != null ? (dataType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataType"] = (object) this.DataType;
      return dictionary;
    }

    public string Type { get; set; }

    public string ComparerType { get; set; }

    public string From { get; set; }

    public bool? ShowButton { get; set; }

    public string To { get; set; }

    public bool? AllowNulls { get; set; }

    public string MessageTemplate { get; set; }

    public string MessageTemplateId { get; set; }

    public string TitleTemplate { get; set; }

    public string TitleTemplateId { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      string comparerType = this.ComparerType;
      if ((comparerType != null ? (comparerType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["comparerType"] = (object) this.ComparerType;
      string from = this.From;
      if ((from != null ? (from.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["from"] = (object) this.From;
      bool? nullable = this.ShowButton;
      if (nullable.HasValue)
        dictionary["showButton"] = (object) this.ShowButton;
      string to = this.To;
      if ((to != null ? (to.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["to"] = (object) this.To;
      nullable = this.AllowNulls;
      if (nullable.HasValue)
        dictionary["allowNulls"] = (object) this.AllowNulls;
      if (this.MessageTemplateId.HasValue())
        dictionary["messageTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.MessageTemplateId)
        };
      else if (this.MessageTemplate.HasValue())
        dictionary["messageTemplate"] = (object) this.MessageTemplate;
      if (this.TitleTemplateId.HasValue())
        dictionary["titleTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TitleTemplateId)
        };
      else if (this.TitleTemplate.HasValue())
        dictionary["titleTemplate"] = (object) this.TitleTemplate;
      return dictionary;
    }
  }
}
