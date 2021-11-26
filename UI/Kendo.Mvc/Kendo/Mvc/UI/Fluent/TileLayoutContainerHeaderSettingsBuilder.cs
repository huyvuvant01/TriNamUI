// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TileLayoutContainerHeaderSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class TileLayoutContainerHeaderSettingsBuilder
  {
    public TileLayoutContainerHeaderSettingsBuilder(TileLayoutContainerHeaderSettings container) => this.Container = container;

    protected TileLayoutContainerHeaderSettings Container { get; private set; }

    public TileLayoutContainerHeaderSettingsBuilder Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public TileLayoutContainerHeaderSettingsBuilder TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public TileLayoutContainerHeaderSettingsBuilder Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }
  }
}
