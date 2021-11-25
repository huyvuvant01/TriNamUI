// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ImageEditorToolbarSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ImageEditorToolbarSettingsBuilder
  {
    public ImageEditorToolbarSettingsBuilder(ImageEditorToolbarSettings container) => this.Container = container;

    protected ImageEditorToolbarSettings Container { get; private set; }

    public ImageEditorToolbarSettingsBuilder Items(
      Action<ImageEditorToolbarSettingsItemFactory> configurator)
    {
      configurator(new ImageEditorToolbarSettingsItemFactory(this.Container.Items)
      {
        ImageEditor = this.Container.ImageEditor
      });
      return this;
    }

    public ImageEditorToolbarSettingsBuilder Click(string handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ImageEditorToolbarSettingsBuilder Click(
      Func<object, object> handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ImageEditorToolbarSettingsBuilder Close(string handler)
    {
      this.Container.Close = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ImageEditorToolbarSettingsBuilder Close(
      Func<object, object> handler)
    {
      this.Container.Close = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ImageEditorToolbarSettingsBuilder Open(string handler)
    {
      this.Container.Open = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ImageEditorToolbarSettingsBuilder Open(
      Func<object, object> handler)
    {
      this.Container.Open = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ImageEditorToolbarSettingsBuilder Toggle(string handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ImageEditorToolbarSettingsBuilder Toggle(
      Func<object, object> handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ImageEditorToolbarSettingsBuilder OverflowClose(
      string handler)
    {
      this.Container.OverflowClose = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ImageEditorToolbarSettingsBuilder OverflowClose(
      Func<object, object> handler)
    {
      this.Container.OverflowClose = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ImageEditorToolbarSettingsBuilder OverflowOpen(
      string handler)
    {
      this.Container.OverflowOpen = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ImageEditorToolbarSettingsBuilder OverflowOpen(
      Func<object, object> handler)
    {
      this.Container.OverflowOpen = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
