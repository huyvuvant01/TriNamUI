// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FileManagerTagHelper
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
  [HtmlTargetElement("kendo-filemanager")]
  [RestrictChildren("toolbar", new string[] {"dialogs", "context-menu", "views", "preview-pane", "breadcrumb", "messages", "upload", "filemanager-datasource"})]
  public class FileManagerTagHelper : TagHelperBase, IDataBoundWidget<
  #nullable disable
  FileManagerDataSourceTagHelper>
  {
    [HtmlAttributeName("datasource-id")]
    public string DataSourceId { get; set; }

    [HtmlAttributeNotBound]
    public FileManagerDataSourceTagHelper Datasource { get; set; }

    public FileManagerTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      FileManagerTagHelper managerTagHelper = this;
      context.Items[(object) managerTagHelper.GetType()] = (object) managerTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await managerTagHelper.\u003C\u003En__0(context, output);
    }

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
      if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      if (this.DataSourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DataSourceId;
      return this.Initializer.Initialize(this.Selector, "FileManager", (IDictionary<string, object>) dictionary);
    }

    public string OnNavigate { get; set; }

    public string OnSelect { get; set; }

    public string OnOpen { get; set; }

    public string OnExecute { get; set; }

    public string OnError { get; set; }

    public string OnDataBinding { get; set; }

    public string OnDataBound { get; set; }

    public string OnDrop { get; set; }

    public string OnCommand { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onNavigate = this.OnNavigate;
      if ((onNavigate != null ? (onNavigate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["navigate"] = (object) this.CreateHandler(this.OnNavigate);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      string onOpen = this.OnOpen;
      if ((onOpen != null ? (onOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.CreateHandler(this.OnOpen);
      string onExecute = this.OnExecute;
      if ((onExecute != null ? (onExecute.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["execute"] = (object) this.CreateHandler(this.OnExecute);
      string onError = this.OnError;
      if ((onError != null ? (onError.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["error"] = (object) this.CreateHandler(this.OnError);
      string onDataBinding = this.OnDataBinding;
      if ((onDataBinding != null ? (onDataBinding.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBinding"] = (object) this.CreateHandler(this.OnDataBinding);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      string onDrop = this.OnDrop;
      if ((onDrop != null ? (onDrop.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["drop"] = (object) this.CreateHandler(this.OnDrop);
      string onCommand = this.OnCommand;
      if ((onCommand != null ? (onCommand.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["command"] = (object) this.CreateHandler(this.OnCommand);
      return dictionary;
    }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public string InitialView { get; set; }

    public bool? Resizable { get; set; }

    public bool? Draggable { get; set; }

    public string UploadUrl { get; set; }

    [HtmlAttributeNotBound]
    public FileManagerUploadSettingsTagHelper Upload { get; set; }

    [HtmlAttributeNotBound]
    public FileManagerToolbarSettingsTagHelper Toolbar { get; set; }

    [HtmlAttributeNotBound]
    public FileManagerDialogsSettingsTagHelper Dialogs { get; set; }

    [HtmlAttributeNotBound]
    public FileManagerContextMenuSettingsTagHelper ContextMenu { get; set; }

    [HtmlAttributeNotBound]
    public FileManagerViewsSettingsTagHelper Views { get; set; }

    [HtmlAttributeNotBound]
    public FileManagerPreviewPaneSettingsTagHelper PreviewPane { get; set; }

    [HtmlAttributeNotBound]
    public FileManagerBreadcrumbSettingsTagHelper Breadcrumb { get; set; }

    [HtmlAttributeNotBound]
    public FileManagerMessagesSettingsTagHelper Messages { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      string initialView = this.InitialView;
      if ((initialView != null ? (initialView.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["initialView"] = (object) this.InitialView;
      if (this.Resizable.HasValue)
        dictionary["resizable"] = (object) this.Resizable;
      if (this.Draggable.HasValue)
        dictionary["draggable"] = (object) this.Draggable;
      string uploadUrl = this.UploadUrl;
      if ((uploadUrl != null ? (uploadUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["uploadUrl"] = (object) this.UploadUrl;
      if (this.Upload != null)
      {
        Dictionary<string, object> source = this.Upload.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["upload"] = (object) source;
      }
      if (this.Toolbar != null)
      {
        Dictionary<string, object> source = this.Toolbar.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Toolbar.Enabled.HasValue || this.Toolbar.Enabled.Value))
          dictionary["toolbar"] = (object) source;
        else if (this.Toolbar.Enabled.HasValue && !this.Toolbar.Enabled.Value)
          dictionary["toolbar"] = (object) this.Toolbar.Enabled;
      }
      if (this.Dialogs != null)
      {
        Dictionary<string, object> source = this.Dialogs.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["dialogs"] = (object) source;
      }
      if (this.ContextMenu != null)
      {
        Dictionary<string, object> source = this.ContextMenu.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.ContextMenu.Enabled.HasValue || this.ContextMenu.Enabled.Value))
          dictionary["contextMenu"] = (object) source;
        else if (this.ContextMenu.Enabled.HasValue && !this.ContextMenu.Enabled.Value)
          dictionary["contextMenu"] = (object) this.ContextMenu.Enabled;
      }
      if (this.Views != null)
      {
        Dictionary<string, object> source = this.Views.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["views"] = (object) source;
      }
      if (this.PreviewPane != null)
      {
        Dictionary<string, object> source = this.PreviewPane.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["previewPane"] = (object) source;
      }
      if (this.Breadcrumb != null)
      {
        Dictionary<string, object> source = this.Breadcrumb.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Breadcrumb.Enabled.HasValue || this.Breadcrumb.Enabled.Value))
          dictionary["breadcrumb"] = (object) source;
        else if (this.Breadcrumb.Enabled.HasValue && !this.Breadcrumb.Enabled.Value)
          dictionary["breadcrumb"] = (object) this.Breadcrumb.Enabled;
      }
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      return dictionary;
    }
  }
}
