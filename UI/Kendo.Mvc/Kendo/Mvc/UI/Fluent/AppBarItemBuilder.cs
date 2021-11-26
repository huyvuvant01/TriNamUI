// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.AppBarItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class AppBarItemBuilder
  {
    public AppBarItemBuilder(AppBarItem container) => this.Container = container;

    protected AppBarItem Container { get; private set; }

    public AppBarItemBuilder ClassName(string value)
    {
      this.Container.ClassName = value;
      return this;
    }

    public AppBarItemBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public AppBarItemBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public AppBarItemBuilder Width(string value)
    {
      this.Container.Width = value;
      return this;
    }

    public AppBarItemBuilder Type(AppBarItemType value)
    {
      this.Container.Type = new AppBarItemType?(value);
      return this;
    }
  }
}
