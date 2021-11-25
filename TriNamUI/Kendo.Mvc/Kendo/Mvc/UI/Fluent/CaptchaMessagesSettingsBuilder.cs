// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CaptchaMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class CaptchaMessagesSettingsBuilder
  {
    public CaptchaMessagesSettingsBuilder(CaptchaMessagesSettings container) => this.Container = container;

    protected CaptchaMessagesSettings Container { get; private set; }

    public CaptchaMessagesSettingsBuilder Audio(string value)
    {
      this.Container.Audio = value;
      return this;
    }

    public CaptchaMessagesSettingsBuilder ImageAlt(string value)
    {
      this.Container.ImageAlt = value;
      return this;
    }

    public CaptchaMessagesSettingsBuilder Reset(string value)
    {
      this.Container.Reset = value;
      return this;
    }

    public CaptchaMessagesSettingsBuilder Success(string value)
    {
      this.Container.Success = value;
      return this;
    }
  }
}
