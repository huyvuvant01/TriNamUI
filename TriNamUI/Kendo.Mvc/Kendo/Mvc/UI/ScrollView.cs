// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ScrollView
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ScrollView : 
    WidgetBase,
    INavigationItemComponent<ScrollViewItem>,
    INavigationItemContainer<ScrollViewItem>
  {
    public ScrollView(ViewContext viewContext)
      : base(viewContext)
    {
      this.DataSource = new DataSource(this.ModelMetadataProvider);
    }

    public DataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    public IList<ScrollViewItem> Items { get; private set; } = (IList<ScrollViewItem>) new List<ScrollViewItem>();

    public Action<ScrollViewItem> ItemAction { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      ScrollViewHtmlBuilder builder = new ScrollViewHtmlBuilder(this);
      IHtmlNode ScrollViewTag = builder.ScrollViewTag();
      if (this.Items.Any<ScrollViewItem>())
        this.Items.Each<ScrollViewItem>((Action<ScrollViewItem>) (item => this.WriteItem(item, ScrollViewTag, builder)));
      ScrollViewTag.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.DataSourceId.HasValue())
      {
        dictionary["dataSourceId"] = (object) this.DataSourceId;
      }
      else
      {
        if (string.IsNullOrEmpty(this.DataSource.Transport.Read.Url))
        {
          DataSourceType? type = this.DataSource.Type;
          DataSourceType dataSourceType = DataSourceType.Custom;
          if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
            goto label_5;
        }
        dictionary["dataSource"] = (object) this.DataSource.ToJson();
      }
label_5:
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (ScrollView), (IDictionary<string, object>) dictionary));
    }

    private void WriteItem(ScrollViewItem item, IHtmlNode parentTag, ScrollViewHtmlBuilder builder)
    {
      if (this.ItemAction != null)
        this.ItemAction(item);
      if (!item.Visible)
        return;
      builder.ItemContentTag(item).AppendTo(parentTag);
    }

    public string ARIATemplate { get; set; }

    public string ARIATemplateId { get; set; }

    public bool? AutoBind { get; set; }

    public double? BounceVelocityThreshold { get; set; }

    public double? Duration { get; set; }

    public string EmptyTemplate { get; set; }

    public string EmptyTemplateId { get; set; }

    public bool? EnablePager { get; set; }

    public ScrollViewMessagesSettings Messages { get; } = new ScrollViewMessagesSettings();

    public bool? Navigatable { get; set; }

    public ScrollViewPageableSettings Pageable { get; } = new ScrollViewPageableSettings();

    public double? Page { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public double? VelocityThreshold { get; set; }

    public string ContentHeight { get; set; }

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
      Dictionary<string, object> source1 = this.Messages.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source1;
      nullable1 = this.Navigatable;
      if (nullable1.HasValue)
        dictionary["navigatable"] = (object) this.Navigatable;
      Dictionary<string, object> source2 = this.Pageable.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
      {
        dictionary["pageable"] = (object) source2;
      }
      else
      {
        nullable1 = this.Pageable.Enabled;
        if (nullable1.HasValue)
          dictionary["pageable"] = (object) this.Pageable.Enabled;
      }
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
      string contentHeight = this.ContentHeight;
      if ((contentHeight != null ? (contentHeight.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentHeight"] = (object) this.ContentHeight;
      return dictionary;
    }
  }
}
