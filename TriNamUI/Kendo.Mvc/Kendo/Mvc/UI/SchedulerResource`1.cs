// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerResource`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class SchedulerResource<T> : JsonObject, IHideObjectMembers where T : class
  {
    public SchedulerResource(string field, IModelMetadataProvider modelMetadataProvider)
    {
      if (string.IsNullOrEmpty(field))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      this.Title = "";
      this.Field = field;
      this.Multiple = false;
      this.DataSource = new DataSource(modelMetadataProvider);
      this.ValuePrimitive = true;
    }

    public DataSource DataSource { get; private set; }

    public string Title { get; set; }

    public string Field { get; set; }

    public bool Multiple { get; set; }

    public string DataTextField { get; set; }

    public string DataValueField { get; set; }

    public string DataColorField { get; set; }

    public string DataParentValueField { get; set; }

    public bool ValuePrimitive { get; set; }

    public string Name { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (!string.IsNullOrEmpty(this.DataSource.Transport.Read.Url))
        json["dataSource"] = (object) this.DataSource.ToJson();
      else if (this.DataSource.Data != null)
        json["dataSource"] = (object) this.DataSource.Data;
      if (!string.IsNullOrEmpty(this.Title))
        json["title"] = (object) this.Title;
      json["field"] = (object) this.Field;
      if (this.Multiple)
        json["multiple"] = (object) this.Multiple;
      if (!string.IsNullOrEmpty(this.DataTextField))
        json["dataTextField"] = (object) this.DataTextField;
      if (!string.IsNullOrEmpty(this.DataValueField))
        json["dataValueField"] = (object) this.DataValueField;
      if (!string.IsNullOrEmpty(this.DataColorField))
        json["dataColorField"] = (object) this.DataColorField;
      if (!string.IsNullOrEmpty(this.DataParentValueField))
        json["dataParentValueField"] = (object) this.DataParentValueField;
      if (!this.ValuePrimitive)
        json["valuePrimitive"] = (object) this.ValuePrimitive;
      if (!this.Name.HasValue())
        return;
      json["name"] = (object) this.Name;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
