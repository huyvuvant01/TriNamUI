// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ScrollViewPageableSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ScrollViewPageableSettingsBuilder
  {
    public ScrollViewPageableSettingsBuilder(ScrollViewPageableSettings container) => this.Container = container;

    protected ScrollViewPageableSettings Container { get; private set; }

    public ScrollViewPageableSettingsBuilder ARIATemplate(
      string value)
    {
      this.Container.ARIATemplate = value;
      return this;
    }

    public ScrollViewPageableSettingsBuilder ARIATemplateId(
      string templateId)
    {
      this.Container.ARIATemplateId = templateId;
      return this;
    }
  }
}
