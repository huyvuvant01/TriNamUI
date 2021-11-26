// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ListView`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


#nullable enable
namespace Kendo.Mvc.UI
{
  public class ListView<T> : WidgetBase where T : 
  #nullable disable
  class
  {
    private readonly ListViewSettingsSerializer<T> settingsSerializer;

    public ListView(ViewContext viewContext)
      : base(viewContext)
    {
      this.settingsSerializer = new ListViewSettingsSerializer<T>(this);
      this.Scrollable = new ListViewScrollableSettings<T>();
      this.DataSource = new DataSource(this.ModelMetadataProvider)
      {
        Type = new DataSourceType?(DataSourceType.Ajax),
        ServerAggregates = true,
        ServerFiltering = true,
        ServerGrouping = true,
        ServerPaging = true,
        ServerSorting = true
      };
      this.DataSource.ModelType(typeof (T));
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag(string.IsNullOrEmpty(this.TagName) ? "div" : this.TagName, this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      if (this.Pageable.Enabled)
        this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>()
        {
          {
            "id",
            (object) (this.Id + "_pager")
          },
          {
            "class",
            (object) "k-pager-wrap"
          }
        }).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (!this.DataSourceId.HasValue())
      {
        dictionary["dataSource"] = (object) this.DataSource.ToJson();
        DataSourceType? type = this.DataSource.Type;
        DataSourceType dataSourceType = DataSourceType.Custom;
        if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue) || this.DataSource.CustomType == "aspnetmvc-ajax")
          this.ProcessDataSource();
      }
      if (this.ContentElement != null)
        dictionary["contentElement"] = (object) this.ContentElement;
      this.InitializeEditor();
      this.settingsSerializer.Serialize((IDictionary<string, object>) dictionary);
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (ListView<T>), (IDictionary<string, object>) dictionary));
    }

    private void ProcessDataSource()
    {
      if (this.Pageable.Enabled && this.DataSource.PageSize == 0)
        this.DataSource.PageSize = 10;
      this.DataSource.Process(DataSourceRequestModelBinder.CreateDataSourceRequest(this.ModelMetadataProvider.GetMetadataForType(typeof (T)), this.ValueProvider, string.Empty), true);
    }

    private void InitializeEditor()
    {
      if (!this.Editable.Enabled)
        return;
      Regex regex = new Regex("(?<=data-val-regex-pattern=\")([^\"]*)", RegexOptions.Multiline);
      HtmlHelper<T> htmlHelper = this.ViewContext.CreateHtmlHelper<T>();
      ViewContext viewContext = this.ViewContext.ViewContextForType<T>(this.ModelMetadataProvider);
      htmlHelper.Contextualize(viewContext);
      StringBuilder sb = new StringBuilder();
      using (StringWriter stringWriter = new StringWriter(sb))
      {
        if (this.Editable.TemplateName.HasValue())
          HtmlHelperEditorExtensions.EditorForModel(htmlHelper, this.Editable.TemplateName).WriteTo((TextWriter) stringWriter, this.HtmlEncoder);
        else
          htmlHelper.EditorForModel().WriteTo((TextWriter) stringWriter, this.HtmlEncoder);
      }
      this.EditorHtml = regex.Replace(sb.ToString(), (MatchEvaluator) (match => match.Groups[0].Value.Replace("\\", this.IsInClientTemplate ? "\\\\\\\\" : "\\\\")));
    }

    public override void VerifySettings()
    {
      base.VerifySettings();
      if (string.IsNullOrEmpty(this.ClientTemplateId))
        throw new NotSupportedException(string.Format(Exceptions.CannotBeNullOrEmpty, (object) "ClientTemplateId"));
      if (string.IsNullOrEmpty(this.TagName))
        throw new NotSupportedException(string.Format(Exceptions.CannotBeNullOrEmpty, (object) "TagName"));
      if (this.Editable.Enabled && this.DataSource.Schema.Model.Id == null && !this.DataSourceId.HasValue())
        throw new NotSupportedException(Exceptions.DataKeysEmpty);
      if (this.AutoBind.HasValue && (!this.IsClientBinding || this.IsClientBinding && this.DataSource.Data != null))
        throw new NotSupportedException(Exceptions.CannotSetAutoBindIfBoundDuringInitialization);
    }

    private bool IsClientBinding
    {
      get
      {
        DataSourceType? type1 = this.DataSource.Type;
        DataSourceType dataSourceType1 = DataSourceType.Ajax;
        if (!(type1.GetValueOrDefault() == dataSourceType1 & type1.HasValue))
        {
          DataSourceType? type2 = this.DataSource.Type;
          DataSourceType dataSourceType2 = DataSourceType.WebApi;
          if (!(type2.GetValueOrDefault() == dataSourceType2 & type2.HasValue))
          {
            DataSourceType? type3 = this.DataSource.Type;
            DataSourceType dataSourceType3 = DataSourceType.Custom;
            return type3.GetValueOrDefault() == dataSourceType3 & type3.HasValue;
          }
        }
        return true;
      }
    }

    public DataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    public string ClientTemplateId { get; set; }

    public string ClientAltTemplateId { get; set; }

    public PageableSettings Pageable { get; } = new PageableSettings();

    public ListViewScrollableSettings<T> Scrollable { get; private set; }

    public ListViewEditingSettings<T> Editable { get; } = new ListViewEditingSettings<T>();

    public string EditorHtml { get; set; }

    public bool? AutoBind { get; set; }

    public bool? Bordered { get; set; }

    public string Borders { get; set; }

    public string ContentElement { get; set; }

    public string Layout { get; set; }

    public ListViewFlexSettings<T> Flex { get; } = new ListViewFlexSettings<T>();

    public ListViewGridSettings<T> Grid { get; } = new ListViewGridSettings<T>();

    public bool? Navigatable { get; set; }

    public string TagName { get; set; }

    public ListViewSelectableSettings<T> Selectable { get; } = new ListViewSelectableSettings<T>();

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      if (this.Bordered.HasValue)
        dictionary["bordered"] = (object) this.Bordered;
      string borders = this.Borders;
      if ((borders != null ? (borders.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["borders"] = (object) this.Borders;
      string layout = this.Layout;
      if ((layout != null ? (layout.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["layout"] = (object) this.Layout;
      Dictionary<string, object> source1 = this.Flex.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["flex"] = (object) source1;
      Dictionary<string, object> source2 = this.Grid.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["grid"] = (object) source2;
      if (this.Navigatable.HasValue)
        dictionary["navigatable"] = (object) this.Navigatable;
      string tagName = this.TagName;
      if ((tagName != null ? (tagName.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["tagName"] = (object) this.TagName;
      return dictionary;
    }
  }
}
