// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ModelDescriptorExtentions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Linq;

namespace Kendo.Mvc.UI
{
  internal static class ModelDescriptorExtentions
  {
    public static bool IsReadOnly(this DataSource dataSource, string fieldName) => dataSource.Schema.Model.Fields.Any<ModelFieldDescriptor>((Func<ModelFieldDescriptor, bool>) (f => f.Member == fieldName && !f.IsEditable));
  }
}
