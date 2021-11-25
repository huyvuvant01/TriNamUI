// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ScrollViewTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-scrollview")]
  [RestrictChildren("items", new string[] {"datasource", "messages", "pageable"})]
  [OutputElementHint("div")]
  public class ScrollViewTagHelper : TagHelperBase, IDataBoundWidget<
  #nullable disable
  DataSourceTagHelper>
  {
    public ScrollViewTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      ScrollViewTagHelper scrollViewTagHelper = this;
      context.Items[(object) scrollViewTagHelper.GetType()] = (object) scrollViewTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await scrollViewTagHelper.\u003C\u003En__0(context, output);
    }

    [HtmlAttributeNotBound]
    public ScrollViewItemsTagHelper Items { get; set; }

    public string ContentHeight { get; set; }

    [HtmlAttributeNotBound]
    public DataSourceTagHelper Datasource { get; set; }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.ContentHeight.HasValue())
        dictionary["contentHeight"] = (object) this.ContentHeight;
      if (this.DatasourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DatasourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      return this.Initializer.Initialize(this.Selector, "ScrollView", (IDictionary<string, object>) dictionary);
    }

    public string DatasourceId { get; set; }

    public string OnChange { get; set; }

    public string OnRefresh { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onRefresh = this.OnRefresh;
      if ((onRefresh != null ? (onRefresh.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["refresh"] = (object) this.CreateHandler(this.OnRefresh);
      return dictionary;
    }

    public string ARIATemplate { get; set; }

    public string ARIATemplateId { get; set; }

    public bool? AutoBind { get; set; }

    public double? BounceVelocityThreshold { get; set; }

    public double? Duration { get; set; }

    public string EmptyTemplate { get; set; }

    public string EmptyTemplateId { get; set; }

    public bool? EnablePager { get; set; }

    [HtmlAttributeNotBound]
    public ScrollViewMessagesSettingsTagHelper Messages { get; set; }

    public bool? Navigatable { get; set; }

    [HtmlAttributeNotBound]
    public ScrollViewPageableSettingsTagHelper Pageable { get; set; }

    public double? Page { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public double? VelocityThreshold { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.ARIATemplateId.HasValue())
        dictionary["ARIATemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.ARIATemplateId)
        };
      else if (this.ARIATemplate.HasValue())
        dictionary["ARIATemplate"] = (object) this.ARIATemplate;
      bool? nullable1 = this.AutoBind;
      if (nullable1.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      double? nullable2 = this.BounceVelocityThreshold;
      if (nullable2.HasValue)
        dictionary["bounceVelocityThreshold"] = (object) this.BounceVelocityThreshold;
      nullable2 = this.Duration;
      if (nullable2.HasValue)
        dictionary["duration"] = (object) this.Duration;
      if (this.EmptyTemplateId.HasValue())
        dictionary["emptyTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.EmptyTemplateId)
        };
      else if (this.EmptyTemplate.HasValue())
        dictionary["emptyTemplate"] = (object) this.EmptyTemplate;
      nullable1 = this.EnablePager;
      if (nullable1.HasValue)
        dictionary["enablePager"] = (object) this.EnablePager;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      nullable1 = this.Navigatable;
      if (nullable1.HasValue)
        dictionary["navigatable"] = (object) this.Navigatable;
      if (this.Pageable != null)
      {
        Dictionary<string, object> source = this.Pageable.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable1 = this.Pageable.Enabled;
          if (nullable1.HasValue)
          {
            nullable1 = this.Pageable.Enabled;
            if (!nullable1.Value)
              goto label_26;
          }
          dictionary["pageable"] = (object) source;
          goto label_29;
        }
label_26:
        nullable1 = this.Pageable.Enabled;
        if (nullable1.HasValue)
        {
          nullable1 = this.Pageable.Enabled;
          if (nullable1.Value)
            dictionary["pageable"] = (object) this.Pageable.Enabled;
        }
      }
label_29:
      nullable2 = this.Page;
      if (nullable2.HasValue)
        dictionary["page"] = (object) this.Page;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      nullable2 = this.VelocityThreshold;
      if (nullable2.HasValue)
        dictionary["velocityThreshold"] = (object) this.VelocityThreshold;
      return dictionary;
    }
  }
}
