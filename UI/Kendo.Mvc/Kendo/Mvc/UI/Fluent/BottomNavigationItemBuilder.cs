// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.BottomNavigationItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class BottomNavigationItemBuilder
  {
    public BottomNavigationItemBuilder(BottomNavigationItem container) => this.Container = container;

    protected BottomNavigationItem Container { get; private set; }

    public BottomNavigationItemBuilder Data(object data)
    {
      this.Container.Data = data;
      return this;
    }

    public BottomNavigationItemBuilder Attributes(object attributes)
    {
      this.Container.Attributes = attributes;
      return this;
    }

    public BottomNavigationItemBuilder Url(string value)
    {
      this.Container.Url = value;
      return this;
    }

    public BottomNavigationItemBuilder Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public BottomNavigationItemBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public BottomNavigationItemBuilder Encoded(bool value)
    {
      this.Container.Encoded = new bool?(value);
      return this;
    }

    public BottomNavigationItemBuilder IconClass(string value)
    {
      this.Container.IconClass = value;
      return this;
    }

    public BottomNavigationItemBuilder CssClass(string value)
    {
      this.Container.CssClass = value;
      return this;
    }

    public BottomNavigationItemBuilder Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public BottomNavigationItemBuilder Selected(bool value)
    {
      this.Container.Selected = new bool?(value);
      return this;
    }

    public BottomNavigationItemBuilder Selected()
    {
      this.Container.Selected = new bool?(true);
      return this;
    }

    public BottomNavigationItemBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public BottomNavigationItemBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }
  }
}
