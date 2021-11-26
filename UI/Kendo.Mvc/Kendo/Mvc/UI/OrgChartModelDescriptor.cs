// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.OrgChartModelDescriptor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class OrgChartModelDescriptor : ModelDescriptor
  {
    public OrgChartModelDescriptor(Type modelType, IModelMetadataProvider modelMetadataProvider)
      : base(modelType, modelMetadataProvider)
    {
    }

    public string ParentId { get; set; }

    public object Expanded { get; set; }

    public string Name { get; set; }

    public string Title { get; set; }

    public string Avatar { get; set; }

    public string HasChildren { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Id != null)
        json["id"] = (object) this.Id.Name;
      if (this.ParentId.HasValue())
        json["parentId"] = (object) this.ParentId;
      if (this.Name.HasValue())
        json["name"] = (object) this.Name;
      if (this.Title.HasValue())
        json["title"] = (object) this.Title;
      if (this.Avatar.HasValue())
        json["avatar"] = (object) this.Avatar;
      if (this.HasChildren.HasValue())
        json["hasChildren"] = (object) this.HasChildren;
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
