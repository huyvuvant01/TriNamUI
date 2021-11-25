// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Diagram.DiagramConnectionModelDescriptor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI.Diagram.Fluent;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Kendo.Mvc.UI.Diagram
{
  public class DiagramConnectionModelDescriptor : ModelDescriptor
  {
    public DiagramConnectionModelDescriptor(
      System.Type modelType,
      IModelMetadataProvider modelMetadataProvider)
      : base(modelType, modelMetadataProvider)
    {
    }

    public string From { get; set; }

    public string To { get; set; }

    public string FromX { get; set; }

    public string FromY { get; set; }

    public string ToX { get; set; }

    public string ToY { get; set; }

    public string Type { get; set; }

    public string Text { get; set; }

    public string FromConnector { get; set; }

    public string ToConnector { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Id != null)
        json["id"] = (object) this.Id.Name;
      Dictionary<string, object> fields = new Dictionary<string, object>();
      json["fields"] = (object) fields;
      this.Fields.Each<ModelFieldDescriptor>((Action<ModelFieldDescriptor>) (prop =>
      {
        Dictionary<string, object> dictionary = new Dictionary<string, object>();
        System.Type type = typeof (IDiagramConnection);
        string member = prop.Member;
        if (type.GetTypeInfo().GetDeclaredProperty(member) != (PropertyInfo) null)
        {
          fields[char.ToLowerInvariant(member[0]).ToString() + member.Substring(1)] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else if (this.From.HasValue() && member == this.From)
        {
          fields["from"] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else if (this.To.HasValue() && member == this.To)
        {
          fields["to"] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else if (this.FromX.HasValue() && member == this.FromX)
        {
          fields["fromX"] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else if (this.FromY.HasValue() && member == this.FromY)
        {
          fields["fromY"] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else if (this.ToX.HasValue() && member == this.ToX)
        {
          fields["toX"] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else if (this.ToY.HasValue() && member == this.ToY)
        {
          fields["toY"] = (object) dictionary;
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
        else if (this.FromConnector.HasValue() && member == this.FromConnector)
        {
          fields["fromConnector"] = (object) dictionary;
          dictionary["from"] = (object) member;
        }
        else if (this.ToConnector.HasValue() && member == this.ToConnector)
        {
          fields["toConnector"] = (object) dictionary;
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
