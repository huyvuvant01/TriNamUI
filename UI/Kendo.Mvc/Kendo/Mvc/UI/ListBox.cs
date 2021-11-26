// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ListBox
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ListBox : WidgetBase
  {
    private readonly ListBoxSettingsSerializer settingsSerializer;

    public string DataSourceId { get; set; }

    public DataSource DataSource { get; private set; }

    public ListBox(ViewContext viewContext)
      : base(viewContext)
    {
      this.settingsSerializer = new ListBoxSettingsSerializer(this);
      this.DataSource = new DataSource(this.ModelMetadataProvider);
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("select", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      this.settingsSerializer.Serialize((IDictionary<string, object>) dictionary);
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (ListBox), (IDictionary<string, object>) dictionary));
    }

    public override void VerifySettings()
    {
      base.VerifySettings();
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

    public bool? AutoBind { get; set; }

    public string ConnectWith { get; set; }

    public string DataTextField { get; set; }

    public string DataValueField { get; set; }

    public ListBoxDraggableSettings Draggable { get; } = new ListBoxDraggableSettings();

    public string[] DropSources { get; set; }

    public bool? Navigatable { get; set; }

    public ListBoxMessagesSettings Messages { get; } = new ListBoxMessagesSettings();

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public ListBoxToolbarSettings Toolbar { get; } = new ListBoxToolbarSettings();

    public ListBoxSelectable? Selectable { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary1["autoBind"] = (object) this.AutoBind;
      string connectWith = this.ConnectWith;
      if ((connectWith != null ? (connectWith.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["connectWith"] = (object) this.ConnectWith;
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataTextField"] = (object) this.DataTextField;
      string dataValueField = this.DataValueField;
      if ((dataValueField != null ? (dataValueField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataValueField"] = (object) this.DataValueField;
      Dictionary<string, object> source1 = this.Draggable.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["draggable"] = (object) source1;
      else if (this.Draggable.Enabled.HasValue)
        dictionary1["draggable"] = (object) this.Draggable.Enabled;
      string[] dropSources = this.DropSources;
      if ((dropSources != null ? (((IEnumerable<string>) dropSources).Any<string>() ? 1 : 0) : 0) != 0)
        dictionary1["dropSources"] = (object) this.DropSources;
      if (this.Navigatable.HasValue)
        dictionary1["navigatable"] = (object) this.Navigatable;
      Dictionary<string, object> source2 = this.Messages.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["messages"] = (object) source2;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      Dictionary<string, object> source3 = this.Toolbar.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["toolbar"] = (object) source3;
      if (this.Selectable.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ListBoxSelectable? selectable = this.Selectable;
        ref ListBoxSelectable? local = ref selectable;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["selectable"] = (object) str;
      }
      return dictionary1;
    }
  }
}
