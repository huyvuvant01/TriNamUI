// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerModelDescriptor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Kendo.Mvc.UI
{
  public class SchedulerModelDescriptor : ModelDescriptor
  {
    public SchedulerModelDescriptor(Type modelType, IModelMetadataProvider modelMetadataProvider)
      : base(modelType, modelMetadataProvider)
    {
    }

    public string RecurrenceId { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Id != null)
        json["id"] = (object) this.Id.Name;
      Dictionary<string, object> fields = new Dictionary<string, object>();
      json["fields"] = (object) fields;
      this.Fields.Each<ModelFieldDescriptor>((Action<ModelFieldDescriptor>) (prop =>
      {
        Dictionary<string, object> dictionary = new Dictionary<string, object>();
        Type type = typeof (ISchedulerEvent);
        string member = prop.Member;
        string name = member;
        if (type.GetProperty(name) != (PropertyInfo) null)
        {
          fields[char.ToLowerInvariant(member[0]).ToString() + member.Substring(1)] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else if (this.RecurrenceId.HasValue() && member == this.RecurrenceId)
        {
          fields["recurrenceId"] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else
          fields[member] = (object) dictionary;
        if (!prop.IsEditable)
          dictionary["editable"] = (object) false;
        dictionary["type"] = (object) prop.MemberType.ToJavaScriptType().ToLowerInvariant();
        if (!prop.MemberType.IsNullableType() && prop.DefaultValue == null)
          return;
        dictionary["defaultValue"] = prop.DefaultValue;
      }));
    }
  }
}
