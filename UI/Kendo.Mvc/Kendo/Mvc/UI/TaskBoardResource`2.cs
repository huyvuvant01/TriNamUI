// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TaskBoardResource`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class TaskBoardResource<TCard, TColumn>
    where TCard : class
    where TColumn : class
  {
    public DataSource DataSource { get; set; }

    public TaskBoardResource()
    {
    }

    public TaskBoardResource(string memberName) => this.Field = memberName;

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (!string.IsNullOrEmpty(this.DataSource.Transport.Read.Url))
        dictionary["dataSource"] = (object) this.DataSource.ToJson();
      else if (this.DataSource.Data != null)
        dictionary["dataSource"] = (object) this.DataSource.Data;
      return dictionary;
    }

    public string DataColorField { get; set; }

    public string DataTextField { get; set; }

    public string DataValueField { get; set; }

    public string Field { get; set; }

    public bool? Multiple { get; set; }

    public string Name { get; set; }

    public string Title { get; set; }

    public bool? ValuePrimitive { get; set; }

    public Kendo.Mvc.UI.TaskBoard<TCard, TColumn> TaskBoard { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string dataColorField = this.DataColorField;
      if ((dataColorField != null ? (dataColorField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataColorField"] = (object) this.DataColorField;
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTextField"] = (object) this.DataTextField;
      string dataValueField = this.DataValueField;
      if ((dataValueField != null ? (dataValueField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataValueField"] = (object) this.DataValueField;
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["field"] = (object) this.Field;
      bool? nullable = this.Multiple;
      if (nullable.HasValue)
        dictionary["multiple"] = (object) this.Multiple;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      nullable = this.ValuePrimitive;
      if (nullable.HasValue)
        dictionary["valuePrimitive"] = (object) this.ValuePrimitive;
      return dictionary;
    }
  }
}
