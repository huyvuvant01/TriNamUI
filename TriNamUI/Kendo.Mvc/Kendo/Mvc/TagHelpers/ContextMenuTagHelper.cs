// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ContextMenuTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-contextmenu")]
  [RestrictChildren("items", new string[] {"popup-animation", "li", "hierarchical-datasource"})]
  [OutputElementHint("ul")]
  public class ContextMenuTagHelper : 
    TagHelperBase,
    IDataBoundWidget<
    #nullable disable
    HierarchicalDataSourceTagHelper>
  {
    [HtmlAttributeNotBound]
    public ContextMenuAnimationSettingsTagHelper Animation { get; set; }

    [HtmlAttributeName("datasource-id")]
    public string DataSourceId { get; set; }

    [HtmlAttributeNotBound]
    public HierarchicalDataSourceTagHelper Datasource { get; set; }

    [HtmlAttributeName("datatextfield")]
    public string DataTextField { get; set; }

    [HtmlAttributeName("dataurlfield")]
    public string DataUrlField { get; set; }

    [HtmlAttributeName("dataspritecssclassfield")]
    public string DataSpriteCssClassField { get; set; }

    [HtmlAttributeName("dataimageurlfield")]
    public string DataImageUrlField { get; set; }

    [HtmlAttributeName("datacontentfield")]
    public string DataContentField { get; set; }

    public ContextMenuTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      ContextMenuTagHelper contextMenuTagHelper = this;
      context.Items[(object) contextMenuTagHelper.GetType()] = (object) contextMenuTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await contextMenuTagHelper.\u003C\u003En__0(context, output);
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
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      if (this.DataSourceId.HasValue())
        dictionary1["dataSourceId"] = (object) this.DataSourceId;
      else if (this.Datasource != null)
        dictionary1["dataSource"] = (object) this.Datasource.Serialize();
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataTextField"] = (object) this.DataTextField;
      string dataUrlField = this.DataUrlField;
      if ((dataUrlField != null ? (dataUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataUrlField"] = (object) this.DataUrlField;
      string spriteCssClassField = this.DataSpriteCssClassField;
      if ((spriteCssClassField != null ? (spriteCssClassField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataSpriteCssClassField"] = (object) this.DataSpriteCssClassField;
      string dataImageUrlField = this.DataImageUrlField;
      if ((dataImageUrlField != null ? (dataImageUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataImageUrlField"] = (object) this.DataImageUrlField;
      string dataContentField = this.DataContentField;
      if ((dataContentField != null ? (dataContentField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataContentField"] = (object) this.DataContentField;
      if (this.Animation != null)
      {
        Dictionary<string, object> source = this.Animation.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Animation.Enabled.HasValue || this.Animation.Enabled.Value))
          dictionary1["animation"] = (object) source;
        else if (this.Animation.Enabled.HasValue && !this.Animation.Enabled.Value)
          dictionary1["animation"] = (object) this.Animation.Enabled;
      }
      ContextMenuOrientation? orientation = this.Orientation;
      if (orientation.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        orientation = this.Orientation;
        ref ContextMenuOrientation? local = ref orientation;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["orientation"] = (object) str;
      }
      return this.Initializer.Initialize(this.Selector, "ContextMenu", (IDictionary<string, object>) dictionary1);
    }

    public string OnClose { get; set; }

    public string OnDataBound { get; set; }

    public string OnOpen { get; set; }

    public string OnActivate { get; set; }

    public string OnDeactivate { get; set; }

    public string OnSelect { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onClose = this.OnClose;
      if ((onClose != null ? (onClose.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.CreateHandler(this.OnClose);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      string onOpen = this.OnOpen;
      if ((onOpen != null ? (onOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.CreateHandler(this.OnOpen);
      string onActivate = this.OnActivate;
      if ((onActivate != null ? (onActivate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["activate"] = (object) this.CreateHandler(this.OnActivate);
      string onDeactivate = this.OnDeactivate;
      if ((onDeactivate != null ? (onDeactivate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deactivate"] = (object) this.CreateHandler(this.OnDeactivate);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      return dictionary;
    }

    public bool? AlignToAnchor { get; set; }

    public string AppendTo { get; set; }

    public bool? CloseOnClick { get; set; }

    public bool? CopyAnchorStyles { get; set; }

    public string Filter { get; set; }

    public double? HoverDelay { get; set; }

    public string PopupCollision { get; set; }

    [HtmlAttributeNotBound]
    public ContextMenuScrollableSettingsTagHelper Scrollable { get; set; }

    public string ShowOn { get; set; }

    public string Target { get; set; }

    public ContextMenuOrientation? Orientation { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      string appendTo = this.AppendTo;
      if ((appendTo != null ? (appendTo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["appendTo"] = (object) this.AppendTo;
      bool? nullable = this.CopyAnchorStyles;
      if (nullable.HasValue)
        dictionary["copyAnchorStyles"] = (object) this.CopyAnchorStyles;
      string filter = this.Filter;
      if ((filter != null ? (filter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filter"] = (object) this.Filter;
      if (this.HoverDelay.HasValue)
        dictionary["hoverDelay"] = (object) this.HoverDelay;
      string popupCollision = this.PopupCollision;
      if ((popupCollision != null ? (popupCollision.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["popupCollision"] = (object) this.PopupCollision;
      if (this.Scrollable != null)
      {
        Dictionary<string, object> source = this.Scrollable.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable = this.Scrollable.Enabled;
          if (nullable.HasValue)
          {
            nullable = this.Scrollable.Enabled;
            if (!nullable.Value)
              goto label_15;
          }
          dictionary["scrollable"] = (object) source;
          goto label_18;
        }
label_15:
        nullable = this.Scrollable.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Scrollable.Enabled;
          if (nullable.Value)
            dictionary["scrollable"] = (object) this.Scrollable.Enabled;
        }
      }
label_18:
      string showOn = this.ShowOn;
      if ((showOn != null ? (showOn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["showOn"] = (object) this.ShowOn;
      string target = this.Target;
      if ((target != null ? (target.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["target"] = (object) this.Target;
      return dictionary;
    }
  }
}
