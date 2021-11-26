// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceSchemaModelFieldTaghelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("field", ParentTag = "fields", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("validation", new string[] {})]
  [SuppressTagRendering]
  public class DataSourceSchemaModelFieldTaghelper : TagHelperCollectionItemBase
  {
    private 
    #nullable disable
    object _defaultValue;

    private bool DefaultValueIsNull { get; set; }

    public object DefaultValue
    {
      get => this._defaultValue;
      set
      {
        if (value == null)
          this.DefaultValueIsNull = true;
        this._defaultValue = value;
      }
    }

    public string Name { get; set; }

    public string Type { get; set; }

    public bool? Editable { get; set; }

    public string Parse { get; set; }

    public bool? Nullable { get; set; }

    public string From { get; set; }

    [HtmlAttributeNotBound]
    public DataSourceSchemaModelFieldValidationTagHelper Validation { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DataSourceSchemaModelFieldTaghelper modelFieldTaghelper = this;
      System.Type type = modelFieldTaghelper.GetType();
      context.Items[(object) type] = (object) modelFieldTaghelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      modelFieldTaghelper.AddSelfToParent(context);
      context.Items[(object) type] = (object) null;
      type = (System.Type) null;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (DataSourceSchemaModelFieldsTagHelper);
      (context.Items[(object) type] as DataSourceSchemaModelFieldsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.DefaultValue != null)
        dictionary["defaultValue"] = this.DefaultValue;
      else if (this.DefaultValueIsNull)
        dictionary["defaultValue"] = (object) this.CreateHandler("null");
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      if (this.Editable.HasValue)
        dictionary["editable"] = (object) this.Editable;
      if (this.Nullable.HasValue)
        dictionary["nullable"] = (object) this.Nullable;
      string from = this.From;
      if ((from != null ? (from.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["from"] = (object) this.From;
      string parse = this.Parse;
      if ((parse != null ? (parse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["parse"] = (object) this.CreateHandler(this.Parse);
      if (this.Validation != null)
      {
        Dictionary<string, object> source = this.Validation.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["validation"] = (object) source;
      }
      return dictionary;
    }
  }
}
