// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListMessagesCommandsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListMessagesCommandsSettingsBuilder<T> where T : class
  {
    public TreeListMessagesCommandsSettingsBuilder(TreeListMessagesCommandsSettings<T> container) => this.Container = container;

    protected TreeListMessagesCommandsSettings<T> Container { get; private set; }

    public TreeListMessagesCommandsSettingsBuilder<T> Canceledit(
      string value)
    {
      this.Container.Canceledit = value;
      return this;
    }

    public TreeListMessagesCommandsSettingsBuilder<T> Create(
      string value)
    {
      this.Container.Create = value;
      return this;
    }

    public TreeListMessagesCommandsSettingsBuilder<T> Createchild(
      string value)
    {
      this.Container.Createchild = value;
      return this;
    }

    public TreeListMessagesCommandsSettingsBuilder<T> Destroy(
      string value)
    {
      this.Container.Destroy = value;
      return this;
    }

    public TreeListMessagesCommandsSettingsBuilder<T> Edit(
      string value)
    {
      this.Container.Edit = value;
      return this;
    }

    public TreeListMessagesCommandsSettingsBuilder<T> Save(
      string value)
    {
      this.Container.Save = value;
      return this;
    }

    public TreeListMessagesCommandsSettingsBuilder<T> Search(
      string value)
    {
      this.Container.Search = value;
      return this;
    }

    public TreeListMessagesCommandsSettingsBuilder<T> Cancel(
      string value)
    {
      this.Container.Cancel = value;
      return this;
    }

    public TreeListMessagesCommandsSettingsBuilder<T> Excel(
      string value)
    {
      this.Container.Excel = value;
      return this;
    }

    public TreeListMessagesCommandsSettingsBuilder<T> Pdf(
      string value)
    {
      this.Container.Pdf = value;
      return this;
    }

    public TreeListMessagesCommandsSettingsBuilder<T> Update(
      string value)
    {
      this.Container.Update = value;
      return this;
    }
  }
}
