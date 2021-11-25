// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.NotificationTemplateBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class NotificationTemplateBuilder : IHideObjectMembers
  {
    private readonly NotificationTemplateSettings templateSettings;

    public NotificationTemplateBuilder(NotificationTemplateSettings templateSettings) => this.templateSettings = templateSettings;

    public NotificationTemplateBuilder Type(string value)
    {
      this.templateSettings.Type = value;
      return this;
    }

    public NotificationTemplateBuilder ClientTemplateID(string value)
    {
      this.templateSettings.ClientTemplateID = value;
      return this;
    }

    public NotificationTemplateBuilder ClientTemplate(string value)
    {
      this.templateSettings.ClientTemplate = value;
      return this;
    }

    System.Type IHideObjectMembers.GetType() => this.GetType();
  }
}
