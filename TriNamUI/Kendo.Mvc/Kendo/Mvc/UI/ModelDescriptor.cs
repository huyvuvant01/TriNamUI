// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ModelDescriptor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ModelDescriptor : JsonObject
  {
    public ModelDescriptor(Type modelType, IModelMetadataProvider modelMetadataProvider) => this.Fields = this.Translate(modelMetadataProvider.GetMetadataForType(modelType));

    public IList<ModelFieldDescriptor> Fields { get; }

    public IDataKey Id { get; set; }

    public DataSource ChildrenDataSource { get; set; }

    public string ChildrenMember { get; set; }

    public string HasChildrenMember { get; set; }

    public string IsDirectoryMember { get; set; }

    public ModelFieldDescriptor AddDescriptor(string member)
    {
      ModelFieldDescriptor modelFieldDescriptor1 = this.Fields.FirstOrDefault<ModelFieldDescriptor>((Func<ModelFieldDescriptor, bool>) (f => f.Member == member));
      if (modelFieldDescriptor1 != null)
        return modelFieldDescriptor1;
      ModelFieldDescriptor modelFieldDescriptor2 = new ModelFieldDescriptor()
      {
        Member = member
      };
      this.Fields.Add(modelFieldDescriptor2);
      return modelFieldDescriptor2;
    }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Id != null)
        json["id"] = (object) this.Id.Name;
      json.Add<string>("hasChildren", this.HasChildrenMember, new Func<bool>(((StringExtensions) this.HasChildrenMember).HasValue));
      if (this.ChildrenDataSource != null)
        json["children"] = (object) this.ChildrenDataSource.ToJson();
      else if (this.ChildrenMember.HasValue())
        json["children"] = (object) this.ChildrenMember;
      if (this.Fields.Count <= 0)
        return;
      Dictionary<string, object> fields = new Dictionary<string, object>();
      json["fields"] = (object) fields;
      this.Fields.Each<ModelFieldDescriptor>((Action<ModelFieldDescriptor>) (prop =>
      {
        Dictionary<string, object> dictionary = new Dictionary<string, object>();
        fields[prop.Member] = (object) dictionary;
        if (!prop.IsEditable)
          dictionary["editable"] = (object) false;
        dictionary["type"] = (object) prop.MemberType.ToJavaScriptType().ToLowerInvariant();
        if (prop.MemberType.IsNullableType() || prop.DefaultValue != null)
        {
          object obj = prop.DefaultValue;
          if (prop.MemberType.IsEnumType() && obj is Enum)
          {
            Type underlyingType = Enum.GetUnderlyingType(prop.MemberType.GetNonNullableType());
            obj = Convert.ChangeType(obj, underlyingType);
          }
          dictionary["defaultValue"] = obj;
        }
        if (!string.IsNullOrEmpty(prop.From))
          dictionary["from"] = (object) prop.From;
        bool? isNullable = prop.IsNullable;
        if (isNullable.HasValue)
        {
          isNullable = prop.IsNullable;
          if (isNullable.Value)
            dictionary["nullable"] = (object) true;
        }
        if (!prop.Parse.HasValue())
          return;
        dictionary["parse"] = (object) prop.Parse;
      }));
    }

    private IList<ModelFieldDescriptor> Translate(ModelMetadata metadata) => (IList<ModelFieldDescriptor>) metadata.Properties.Select<ModelMetadata, ModelFieldDescriptor>((Func<ModelMetadata, ModelFieldDescriptor>) (p => new ModelFieldDescriptor()
    {
      Member = p.PropertyName,
      MemberType = p.ModelType,
      IsEditable = !p.IsReadOnly
    })).ToList<ModelFieldDescriptor>();

    private object CreateDataItem(Type modelType) => Activator.CreateInstance(modelType);
  }
}
