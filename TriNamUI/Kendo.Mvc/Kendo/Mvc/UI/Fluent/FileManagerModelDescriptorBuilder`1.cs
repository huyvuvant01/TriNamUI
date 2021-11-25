// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerModelDescriptorBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerModelDescriptorBuilder<TModel> : HierarchicalModelDescriptorBuilder<TModel>
    where TModel : class
  {
    public FileManagerModelDescriptorBuilder(
      ModelDescriptor model,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(model, viewContext, urlGenerator)
    {
    }

    public HierarchicalModelDescriptorBuilder<TModel> IsDirectory(
      string fieldName)
    {
      this.model.IsDirectoryMember = fieldName;
      return (HierarchicalModelDescriptorBuilder<TModel>) this;
    }
  }
}
