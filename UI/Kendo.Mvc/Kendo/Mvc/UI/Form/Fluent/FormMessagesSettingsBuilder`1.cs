// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Form.Fluent.FormMessagesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Form.Fluent
{
  public class FormMessagesSettingsBuilder<T>
  {
    private readonly FormMessagesSettings container;

    public FormMessagesSettingsBuilder(FormMessagesSettings settings) => this.container = settings;

    public FormMessagesSettingsBuilder<T> Submit(string value)
    {
      this.container.Submit = value;
      return this;
    }

    public FormMessagesSettingsBuilder<T> Clear(string value)
    {
      this.container.Clear = value;
      return this;
    }

    public FormMessagesSettingsBuilder<T> Optional(string value)
    {
      this.container.Optional = value;
      return this;
    }
  }
}
