// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FileManager
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class FileManager : WidgetBase
  {
    public FileManager(ViewContext viewContext)
      : base(viewContext)
    {
      this.DataSource = new DataSource(this.ModelMetadataProvider);
      this.UploadAction = new RequestSettings();
    }

    public DataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    public RequestSettings UploadAction { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (string.IsNullOrEmpty(this.DataSourceId))
      {
        if (string.IsNullOrEmpty(this.DataSource.Transport.Read.Url))
        {
          DataSourceType? type = this.DataSource.Type;
          DataSourceType dataSourceType = DataSourceType.Custom;
          if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
          {
            if (this.DataSource.Data != null)
            {
              dictionary["dataSource"] = (object) this.DataSource.Data;
              goto label_7;
            }
            else
              goto label_7;
          }
        }
        dictionary["dataSource"] = (object) this.DataSource.ToJson();
      }
      else
        dictionary["dataSourceId"] = (object) this.DataSourceId;
label_7:
      if (!this.UploadUrl.HasValue() && this.UploadAction.HasValue())
        dictionary["uploadUrl"] = (object) this.UploadAction.GenerateUrl(this.ViewContext, this.UrlGenerator);
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (FileManager), (IDictionary<string, object>) dictionary));
    }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public string InitialView { get; set; }

    public bool? Resizable { get; set; }

    public bool? Draggable { get; set; }

    public string UploadUrl { get; set; }

    public FileManagerUploadSettings Upload { get; } = new FileManagerUploadSettings();

    public FileManagerToolbarSettings Toolbar { get; } = new FileManagerToolbarSettings();

    public FileManagerDialogsSettings Dialogs { get; } = new FileManagerDialogsSettings();

    public FileManagerContextMenuSettings ContextMenu { get; } = new FileManagerContextMenuSettings();

    public FileManagerViewsSettings Views { get; } = new FileManagerViewsSettings();

    public FileManagerPreviewPaneSettings PreviewPane { get; } = new FileManagerPreviewPaneSettings();

    public FileManagerBreadcrumbSettings Breadcrumb { get; } = new FileManagerBreadcrumbSettings();

    public FileManagerMessagesSettings Messages { get; } = new FileManagerMessagesSettings();

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
      Dictionary<string, object> source1 = this.Upload.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["upload"] = (object) source1;
      Dictionary<string, object> source2 = this.Toolbar.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["toolbar"] = (object) source2;
      else if (this.Toolbar.Enabled.HasValue)
        dictionary["toolbar"] = (object) this.Toolbar.Enabled;
      Dictionary<string, object> source3 = this.Dialogs.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["dialogs"] = (object) source3;
      Dictionary<string, object> source4 = this.ContextMenu.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["contextMenu"] = (object) source4;
      else if (this.ContextMenu.Enabled.HasValue)
        dictionary["contextMenu"] = (object) this.ContextMenu.Enabled;
      Dictionary<string, object> source5 = this.Views.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary["views"] = (object) source5;
      Dictionary<string, object> source6 = this.PreviewPane.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary["previewPane"] = (object) source6;
      Dictionary<string, object> source7 = this.Breadcrumb.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary["breadcrumb"] = (object) source7;
      else if (this.Breadcrumb.Enabled.HasValue)
        dictionary["breadcrumb"] = (object) this.Breadcrumb.Enabled;
      Dictionary<string, object> source8 = this.Messages.Serialize();
      if (source8.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source8;
      return dictionary;
    }
  }
}
