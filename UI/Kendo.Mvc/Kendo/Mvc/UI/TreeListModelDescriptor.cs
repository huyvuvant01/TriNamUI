// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeListModelDescriptor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class TreeListModelDescriptor : ModelDescriptor
  {
    public TreeListModelDescriptor(Type modelType, IModelMetadataProvider modelMetadataProvider)
      : base(modelType, modelMetadataProvider)
    {
    }

    public string ParentId { get; set; }

    public object Expanded { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Id != null)
        json["id"] = (object) this.Id.Name;
      if (this.ParentId.HasValue())
        json["parentId"] = (object) this.ParentId;
      Dictionary<string, object> fields = new Dictionary<string, object>();
      json["fields"] = (object) fields;
      if (this.Expanded is bool)
        json["expanded"] = (object) (bool) this.Expanded;
      this.Fields.Each<ModelFieldDescriptor>((Action<ModelFieldDescriptor>) (prop =>
      {
        Dictionary<string, object> dictionary = new Dictionary<string, object>();
        string member = prop.Member;
        if (member == this.Expanded as string)
        {
          fields["expanded"] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else
          fields[member] = (object) dictionary;
        if (!prop.IsEditable)
          dictionary["editable"] = (object) false;
        bool? isNullable = prop.IsNullable;
        dictionary["nullable"] = !isNullable.HasValue ? (!(member == this.ParentId) || prop.DefaultValue != null ? (object) false : (object) true) : (object) prop.IsNullable;
        dictionary["type"] = (object) prop.MemberType.ToJavaScriptType().ToLowerInvariant();
        if (!prop.MemberType.IsNullableType() && prop.DefaultValue == null && (prop.IsNullable.HasValue && (!prop.IsNullable.HasValue || prop.IsNullable.Value) || prop.DefaultValue == null))
          return;
        dictionary["defaultValue"] = prop.DefaultValue;
      }));
    }
  }
}
