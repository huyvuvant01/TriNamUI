// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CaptchaBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class CaptchaBuilder : WidgetBuilderBase<Captcha, CaptchaBuilder>
  {
    public CaptchaBuilder(Captcha component)
      : base(component)
    {
    }

    public CaptchaBuilder CaptchaImage(string captchaImage)
    {
      this.Container.CaptchaImage = captchaImage;
      return this;
    }

    public CaptchaBuilder AudioHandler(Action<CrudOperationBuilder> configurator)
    {
      this.Container.AudioHandler = new CrudOperation();
      configurator(new CrudOperationBuilder(this.Container.AudioHandler, this.Container.ViewContext, this.Container.UrlGenerator));
      return this;
    }

    public CaptchaBuilder AudioHandler(string url)
    {
      this.Container.AudioHandler = new CrudOperation();
      this.Container.AudioHandler.Url = url;
      return this;
    }

    public CaptchaBuilder AudioHandlerFunction(string handler)
    {
      this.Container.AudioHandlerFunction = new ClientHandlerDescriptor();
      this.Container.AudioHandlerFunction.HandlerName = handler;
      return this;
    }

    public CaptchaBuilder Handler(Action<CrudOperationBuilder> configurator)
    {
      this.Container.Handler = new CrudOperation();
      configurator(new CrudOperationBuilder(this.Container.Handler, this.Container.ViewContext, this.Container.UrlGenerator));
      return this;
    }

    public CaptchaBuilder Handler(string url)
    {
      this.Container.Handler = new CrudOperation();
      this.Container.Handler.Url = url;
      return this;
    }

    public CaptchaBuilder HandlerFunction(string handler)
    {
      this.Container.HandlerFunction = new ClientHandlerDescriptor();
      this.Container.HandlerFunction.HandlerName = handler;
      return this;
    }

    public CaptchaBuilder ValidationHandler(Action<CrudOperationBuilder> configurator)
    {
      this.Container.ValidationHandler = new CrudOperation();
      configurator(new CrudOperationBuilder(this.Container.ValidationHandler, this.Container.ViewContext, this.Container.UrlGenerator));
      return this;
    }

    public CaptchaBuilder ValidationHandler(string url)
    {
      this.Container.ValidationHandler = new CrudOperation();
      this.Container.ValidationHandler.Url = url;
      return this;
    }

    public CaptchaBuilder ValidationHandlerFunction(string handler)
    {
      this.Container.ValidationHandlerFunction = new ClientHandlerDescriptor();
      this.Container.ValidationHandlerFunction.HandlerName = handler;
      return this;
    }

    public CaptchaBuilder AudioButton(bool value)
    {
      this.Container.AudioButton = new bool?(value);
      return this;
    }

    public CaptchaBuilder CaptchaId(string value)
    {
      this.Container.CaptchaId = value;
      return this;
    }

    public CaptchaBuilder DataCaptchaField(string value)
    {
      this.Container.DataCaptchaField = value;
      return this;
    }

    public CaptchaBuilder DataCaptchaIdField(string value)
    {
      this.Container.DataCaptchaIdField = value;
      return this;
    }

    public CaptchaBuilder Messages(
      Action<CaptchaMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.Captcha = this.Container;
      configurator(new CaptchaMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public CaptchaBuilder ResetButton(bool value)
    {
      this.Container.ResetButton = new bool?(value);
      return this;
    }

    public CaptchaBuilder ValidateOnBlur(bool value)
    {
      this.Container.ValidateOnBlur = new bool?(value);
      return this;
    }

    public CaptchaBuilder ValidateOnBlur()
    {
      this.Container.ValidateOnBlur = new bool?(true);
      return this;
    }

    public CaptchaBuilder VolumeControl(bool value)
    {
      this.Container.VolumeControl = new bool?(value);
      return this;
    }

    public CaptchaBuilder Events(Action<CaptchaEventBuilder> configurator)
    {
      configurator(new CaptchaEventBuilder(this.Container.Events));
      return this;
    }
  }
}
