// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ListViewEditingSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI
{
  public class ListViewEditingSettings<T> : IListViewEditingSettings where T : class
  {
    public ListViewEditingSettings() => this.DefaultDataItem = new Func<T>(this.CreateDefaultItem);

    public bool Enabled { get; set; }

    public string TemplateName { get; set; }

    public Func<T> DefaultDataItem { get; set; }

    private T CreateDefaultItem() => Activator.CreateInstance<T>();
  }
}
