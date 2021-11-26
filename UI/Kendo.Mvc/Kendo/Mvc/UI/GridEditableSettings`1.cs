// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridEditableSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
  public class GridEditableSettings<T> : JsonObject, IGridEditingSettings
    where T : class
  {
    private readonly Grid<T> grid;

    public GridEditableSettings(Grid<T> grid)
    {
      this.grid = grid;
      this.DisplayDeleteConfirmation = true;
      this.DefaultDataItem = new Func<T>(this.CreateDefaultItem);
      this.Confirmation = Messages.Grid_Confirmation;
      this.ConfirmDelete = Messages.Grid_ConfirmDelete;
      this.CancelDelete = Messages.Grid_CancelDelete;
      this.CreateAt = GridInsertRowPosition.Top;
    }

    public Window PopUp { get; set; }

    public string Confirmation { get; set; }

    public ClientHandlerDescriptor ConfirmationHandler { get; set; }

    public string ConfirmDelete { get; set; }

    public string CancelDelete { get; set; }

    public GridEditMode Mode { get; set; }

    public bool Enabled { get; set; }

    public bool DisplayDeleteConfirmation { get; set; }

    public Func<T> DefaultDataItem { get; set; }

    public string TemplateName { get; set; }

    public object AdditionalViewData { get; set; }

    public GridInsertRowPosition CreateAt { get; set; }

    private T CreateDefaultItem()
    {
      T instance = Activator.CreateInstance<T>();
      if (this.grid.DataSource.Schema.Model != null && this.grid.DataSource.Schema.Model.Fields.Any<ModelFieldDescriptor>())
        this.grid.DataSource.Schema.Model.Fields.Each<ModelFieldDescriptor>((Action<ModelFieldDescriptor>) (f =>
        {
          PropertyInfo property = typeof (T).GetProperty(f.Member, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
          if (!(property != (PropertyInfo) null) || !property.CanWrite || f.DefaultValue != null && !(f.DefaultValue.GetType() != typeof (ClientHandlerDescriptor)))
            return;
          property.SetValue((object) instance, f.DefaultValue, (object[]) null);
        }));
      return instance;
    }

    private IDictionary<string, object> SerializePopUp()
    {
      Dictionary<string, object> dictionary1 = this.PopUp.Serialize();
      object obj = this.PopUp.Title ?? (object) Messages.Grid_Edit;
      Dictionary<string, object> dictionary2 = new Dictionary<string, object>((IDictionary<string, object>) dictionary1)
      {
        ["title"] = obj,
        ["modal"] = (object) this.PopUp.Modal,
        ["draggable"] = (object) this.PopUp.Draggable,
        ["resizable"] = (object) this.PopUp.ResizingSettings.Enabled
      };
      if (!string.IsNullOrEmpty(this.PopUp.Width))
        dictionary2["width"] = (object) this.PopUp.Width;
      if (!string.IsNullOrEmpty(this.PopUp.Height))
        dictionary2["height"] = (object) this.PopUp.Height;
      WindowPositionSettings position = this.PopUp.Position;
      if (!string.IsNullOrEmpty(position.Left) || !string.IsNullOrEmpty(position.Top))
      {
        Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(position.Top))
          dictionary3.Add("top", position.Top);
        if (!string.IsNullOrEmpty(position.Left))
          dictionary3.Add("left", position.Left);
        dictionary2.Add("position", (object) dictionary3);
      }
      return (IDictionary<string, object>) dictionary2;
    }

    protected override void Serialize(IDictionary<string, object> json)
    {
      string input = this.grid.EditorHtml;
      if (input != null && this.IsClientBinding)
      {
        if (this.grid.IsInClientTemplate)
          input = Regex.Replace(input, "(&amp;)#([0-9]+;)", "$1\\\\#$2");
        input = input.Trim().Replace("\r\n", string.Empty).Replace("\n", string.Empty).Replace("</script>", "<\\/script>").Replace("jQuery(\"#", "jQuery(\"\\\\#").Replace("#", "\\#");
      }
      json["confirmation"] = !this.DisplayDeleteConfirmation ? (object) false : (this.ConfirmationHandler == null ? (object) this.Confirmation : (object) this.ConfirmationHandler);
      json.AddRange<KeyValuePair<string, object>>((IEnumerable<KeyValuePair<string, object>>) new Dictionary<string, object>()
      {
        ["confirmDelete"] = (object) this.ConfirmDelete,
        ["cancelDelete"] = (object) this.CancelDelete,
        ["mode"] = (object) this.Mode.ToString().ToLowerInvariant(),
        ["create"] = (object) this.IsClientBinding,
        ["update"] = (object) this.IsClientBinding,
        ["destroy"] = (object) this.IsClientBinding
      });
      json.Add<string>("template", input, (Func<bool>) (() => (uint) this.Mode > 0U)).Add<string>("createAt", this.CreateAt.ToString().ToLower(), (Func<bool>) (() => (uint) this.CreateAt > 0U)).Add<IDictionary<string, object>>("window", this.SerializePopUp(), (Func<bool>) (() => this.Mode == GridEditMode.PopUp && this.IsClientBinding));
    }

    private bool IsClientBinding
    {
      get
      {
        DataSourceType? type1 = this.grid.DataSource.Type;
        DataSourceType dataSourceType1 = DataSourceType.Ajax;
        if (!(type1.GetValueOrDefault() == dataSourceType1 & type1.HasValue))
        {
          DataSourceType? type2 = this.grid.DataSource.Type;
          DataSourceType dataSourceType2 = DataSourceType.WebApi;
          if (!(type2.GetValueOrDefault() == dataSourceType2 & type2.HasValue))
          {
            DataSourceType? type3 = this.grid.DataSource.Type;
            DataSourceType dataSourceType3 = DataSourceType.Custom;
            if (!(type3.GetValueOrDefault() == dataSourceType3 & type3.HasValue))
              return this.grid.DataSourceId.HasValue();
          }
        }
        return true;
      }
    }
  }
}
