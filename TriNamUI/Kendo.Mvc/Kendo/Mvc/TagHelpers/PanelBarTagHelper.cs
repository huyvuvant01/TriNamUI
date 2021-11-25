// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PanelBarTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-panelbar")]
  [RestrictChildren("animation", new string[] {"messages", "items", "hierarchical-datasource", "li"})]
  [OutputElementHint("ul")]
  public class PanelBarTagHelper : ItemsCollectionTagHelperBase
  {
    [HtmlAttributeName("bind-to")]
    public 
    #nullable disable
    IEnumerable<PanelBarItemBase> BindTo { get; set; }

    [HtmlAttributeNotBound]
    public PanelBarItemsTagHelper Items { get; set; }

    [HtmlAttributeName("dataimageurlfield")]
    public string DataImageUrlField { get; set; }

    [HtmlAttributeName("dataspritecssclassfield")]
    public string DataSpriteCssClassField { get; set; }

    [HtmlAttributeName("datatextfield")]
    public string DataTextField { get; set; }

    [HtmlAttributeName("dataurlfield")]
    public string DataUrlField { get; set; }

    public PanelBarTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      PanelBarTagHelper panelBarTagHelper = this;
      context.Items[(object) panelBarTagHelper.GetType()] = (object) panelBarTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await panelBarTagHelper.\u003C\u003En__0(context, output);
      if (panelBarTagHelper.BindTo == null)
        return;
      foreach (PanelBarItemBase panelBarItemBase in panelBarTagHelper.BindTo)
        output.Content.AppendHtml((IHtmlContent) panelBarItemBase.ConvertToTagHelper().EnhanceItem());
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("ul", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "ul";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.DataSourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DataSourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      string dataImageUrlField = this.DataImageUrlField;
      if ((dataImageUrlField != null ? (dataImageUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataImageUrlField"] = (object) this.DataImageUrlField;
      string spriteCssClassField = this.DataSpriteCssClassField;
      if ((spriteCssClassField != null ? (spriteCssClassField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataSpriteCssClassField"] = (object) this.DataSpriteCssClassField;
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTextField"] = (object) this.DataTextField;
      string dataUrlField = this.DataUrlField;
      if ((dataUrlField != null ? (dataUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataUrlField"] = (object) this.DataUrlField;
      return this.Initializer.Initialize(this.Selector, "PanelBar", (IDictionary<string, object>) dictionary);
    }

    public string OnActivate { get; set; }

    public string OnCollapse { get; set; }

    public string OnContentLoad { get; set; }

    public string OnDataBound { get; set; }

    public string OnError { get; set; }

    public string OnExpand { get; set; }

    public string OnSelect { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onActivate = this.OnActivate;
      if ((onActivate != null ? (onActivate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["activate"] = (object) this.CreateHandler(this.OnActivate);
      string onCollapse = this.OnCollapse;
      if ((onCollapse != null ? (onCollapse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collapse"] = (object) this.CreateHandler(this.OnCollapse);
      string onContentLoad = this.OnContentLoad;
      if ((onContentLoad != null ? (onContentLoad.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentLoad"] = (object) this.CreateHandler(this.OnContentLoad);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      string onError = this.OnError;
      if ((onError != null ? (onError.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["error"] = (object) this.CreateHandler(this.OnError);
      string onExpand = this.OnExpand;
      if ((onExpand != null ? (onExpand.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["expand"] = (object) this.CreateHandler(this.OnExpand);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      return dictionary;
    }

    public bool? AutoBind { get; set; }

    public string ExpandMode { get; set; }

    public bool? LoadOnDemand { get; set; }

    [HtmlAttributeNotBound]
    public PanelBarMessagesSettingsTagHelper Messages { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      string expandMode = this.ExpandMode;
      if ((expandMode != null ? (expandMode.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["expandMode"] = (object) this.ExpandMode;
      if (this.LoadOnDemand.HasValue)
        dictionary["loadOnDemand"] = (object) this.LoadOnDemand;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      return dictionary;
    }
  }
}
