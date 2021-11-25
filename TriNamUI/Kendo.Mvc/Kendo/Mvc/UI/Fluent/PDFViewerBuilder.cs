// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerBuilder : WidgetBuilderBase<PDFViewer, PDFViewerBuilder>
  {
    public PDFViewerBuilder(PDFViewer component)
      : base(component)
    {
    }

    public PDFViewerBuilder PdfjsProcessing(
      Action<PDFViewerPdfjsProcessingSettingsBuilder> configurator)
    {
      this.Container.PdfjsProcessing.PDFViewer = this.Container;
      configurator(new PDFViewerPdfjsProcessingSettingsBuilder(this.Container.PdfjsProcessing));
      return this;
    }

    public PDFViewerBuilder DplProcessing(
      Action<PDFViewerDplProcessingSettingsBuilder> configurator)
    {
      this.Container.DplProcessing.PDFViewer = this.Container;
      configurator(new PDFViewerDplProcessingSettingsBuilder(this.Container.DplProcessing));
      return this;
    }

    public PDFViewerBuilder Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public PDFViewerBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public PDFViewerBuilder DefaultPageSize(
      Action<PDFViewerDefaultPageSizeSettingsBuilder> configurator)
    {
      this.Container.DefaultPageSize.PDFViewer = this.Container;
      configurator(new PDFViewerDefaultPageSizeSettingsBuilder(this.Container.DefaultPageSize));
      return this;
    }

    public PDFViewerBuilder Page(double value)
    {
      this.Container.Page = new double?(value);
      return this;
    }

    public PDFViewerBuilder Scale(double value)
    {
      this.Container.Scale = new double?(value);
      return this;
    }

    public PDFViewerBuilder ZoomMin(double value)
    {
      this.Container.ZoomMin = new double?(value);
      return this;
    }

    public PDFViewerBuilder ZoomMax(double value)
    {
      this.Container.ZoomMax = new double?(value);
      return this;
    }

    public PDFViewerBuilder ZoomRate(double value)
    {
      this.Container.ZoomRate = new double?(value);
      return this;
    }

    public PDFViewerBuilder View(Action<PDFViewerViewSettingsBuilder> configurator)
    {
      this.Container.View.PDFViewer = this.Container;
      configurator(new PDFViewerViewSettingsBuilder(this.Container.View));
      return this;
    }

    public PDFViewerBuilder Toolbar(
      Action<PDFViewerToolbarSettingsBuilder> configurator)
    {
      this.Container.Toolbar.Enabled = new bool?(true);
      this.Container.Toolbar.PDFViewer = this.Container;
      configurator(new PDFViewerToolbarSettingsBuilder(this.Container.Toolbar));
      return this;
    }

    public PDFViewerBuilder Toolbar(bool enabled)
    {
      this.Container.Toolbar.Enabled = new bool?(enabled);
      return this;
    }

    public PDFViewerBuilder Messages(
      Action<PDFViewerMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.PDFViewer = this.Container;
      configurator(new PDFViewerMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public PDFViewerBuilder Document(string handler)
    {
      this.Container.Document = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public PDFViewerBuilder Document(Func<object, object> handler)
    {
      this.Container.Document = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public PDFViewerBuilder Events(Action<PDFViewerEventBuilder> configurator)
    {
      configurator(new PDFViewerEventBuilder(this.Container.Events));
      return this;
    }
  }
}
