// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Diagram.Fluent.DiagramShapeModelDescriptor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Kendo.Mvc.UI.Diagram.Fluent
{
  public class DiagramShapeModelDescriptor : ModelDescriptor
  {
    public DiagramShapeModelDescriptor(System.Type modelType)
      : base(modelType, (IModelMetadataProvider) new EmptyModelMetadataProvider())
    {
    }

    public string Width { get; set; }

    public string Height { get; set; }

    public string X { get; set; }

    public string Y { get; set; }

    public string Type { get; set; }

    public string Text { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Id != null)
        json["id"] = (object) this.Id.Name;
      Dictionary<string, object> fields = new Dictionary<string, object>();
      json["fields"] = (object) fields;
      this.Fields.Each<ModelFieldDescriptor>((Action<ModelFieldDescriptor>) (prop =>
      {
        Dictionary<string, object> dictionary = new Dictionary<string, object>();
        System.Type type = typeof (IDiagramShape);
        string member = prop.Member;
        if (type.GetTypeInfo().GetDeclaredProperty(member) != (PropertyInfo) null)
        {
          fields[char.ToLowerInvariant(member[0]).ToString() + member.Substring(1)] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else if (this.Width.HasValue() && member == this.Width)
        {
          fields["width"] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else if (this.Height.HasValue() && member == this.Height)
        {
          fields["height"] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else if (this.X.HasValue() && member == this.X)
        {
          fields["x"] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else if (this.Y.HasValue() && member == this.Y)
        {
          fields["y"] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else if (this.Type.HasValue() && member == this.Type)
        {
          fields["type"] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else if (this.Text.HasValue() && member == this.Text)
        {
          fields["text"] = (object) dictionary;
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
