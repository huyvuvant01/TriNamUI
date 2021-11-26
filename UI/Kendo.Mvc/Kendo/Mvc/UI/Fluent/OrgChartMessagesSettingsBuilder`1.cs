// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.OrgChartMessagesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class OrgChartMessagesSettingsBuilder<T> where T : class
  {
    public OrgChartMessagesSettingsBuilder(OrgChartMessagesSettings<T> container) => this.Container = container;

    protected OrgChartMessagesSettings<T> Container { get; private set; }

    public OrgChartMessagesSettingsBuilder<T> Label(string value)
    {
      this.Container.Label = value;
      return this;
    }

    public OrgChartMessagesSettingsBuilder<T> Create(string value)
    {
      this.Container.Create = value;
      return this;
    }

    public OrgChartMessagesSettingsBuilder<T> Edit(string value)
    {
      this.Container.Edit = value;
      return this;
    }

    public OrgChartMessagesSettingsBuilder<T> Destroy(string value)
    {
      this.Container.Destroy = value;
      return this;
    }

    public OrgChartMessagesSettingsBuilder<T> DestroyContent(
      string value)
    {
      this.Container.DestroyContent = value;
      return this;
    }

    public OrgChartMessagesSettingsBuilder<T> DestroyTitle(
      string value)
    {
      this.Container.DestroyTitle = value;
      return this;
    }

    public OrgChartMessagesSettingsBuilder<T> Cancel(string value)
    {
      this.Container.Cancel = value;
      return this;
    }

    public OrgChartMessagesSettingsBuilder<T> Save(string value)
    {
      this.Container.Save = value;
      return this;
    }

    public OrgChartMessagesSettingsBuilder<T> MenuLabel(string value)
    {
      this.Container.MenuLabel = value;
      return this;
    }

    public OrgChartMessagesSettingsBuilder<T> UploadAvatar(
      string value)
    {
      this.Container.UploadAvatar = value;
      return this;
    }

    public OrgChartMessagesSettingsBuilder<T> Parent(string value)
    {
      this.Container.Parent = value;
      return this;
    }

    public OrgChartMessagesSettingsBuilder<T> Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public OrgChartMessagesSettingsBuilder<T> Title(string value)
    {
      this.Container.Title = value;
      return this;
    }

    public OrgChartMessagesSettingsBuilder<T> None(string value)
    {
      this.Container.None = value;
      return this;
    }

    public OrgChartMessagesSettingsBuilder<T> Expand(string value)
    {
      this.Container.Expand = value;
      return this;
    }

    public OrgChartMessagesSettingsBuilder<T> Collapse(string value)
    {
      this.Container.Collapse = value;
      return this;
    }
  }
}
