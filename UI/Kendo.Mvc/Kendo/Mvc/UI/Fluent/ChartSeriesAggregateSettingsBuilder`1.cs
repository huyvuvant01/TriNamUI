// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesAggregateSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesAggregateSettingsBuilder<T> where T : class
  {
    public ChartSeriesAggregateSettingsBuilder(ChartSeriesAggregateSettings<T> container) => this.Container = container;

    protected ChartSeriesAggregateSettings<T> Container { get; private set; }

    public ChartSeriesAggregateSettingsBuilder<T> Close(
      ChartSeriesAggregate value)
    {
      this.Container.CloseHandler = (ClientHandlerDescriptor) null;
      this.Container.Close = new ChartSeriesAggregate?(value);
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> CloseHandler(
      string handler)
    {
      this.Container.Close = new ChartSeriesAggregate?();
      this.Container.CloseHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> CloseHandler(
      Func<object, object> handler)
    {
      this.Container.Close = new ChartSeriesAggregate?();
      this.Container.CloseHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> High(
      ChartSeriesAggregate value)
    {
      this.Container.HighHandler = (ClientHandlerDescriptor) null;
      this.Container.High = new ChartSeriesAggregate?(value);
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> HighHandler(
      string handler)
    {
      this.Container.High = new ChartSeriesAggregate?();
      this.Container.HighHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> HighHandler(
      Func<object, object> handler)
    {
      this.Container.High = new ChartSeriesAggregate?();
      this.Container.HighHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> Low(
      ChartSeriesAggregate value)
    {
      this.Container.LowHandler = (ClientHandlerDescriptor) null;
      this.Container.Low = new ChartSeriesAggregate?(value);
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> LowHandler(
      string handler)
    {
      this.Container.Low = new ChartSeriesAggregate?();
      this.Container.LowHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> LowHandler(
      Func<object, object> handler)
    {
      this.Container.Low = new ChartSeriesAggregate?();
      this.Container.LowHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> Open(
      ChartSeriesAggregate value)
    {
      this.Container.OpenHandler = (ClientHandlerDescriptor) null;
      this.Container.Open = new ChartSeriesAggregate?(value);
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> OpenHandler(
      string handler)
    {
      this.Container.Open = new ChartSeriesAggregate?();
      this.Container.OpenHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> OpenHandler(
      Func<object, object> handler)
    {
      this.Container.Open = new ChartSeriesAggregate?();
      this.Container.OpenHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> Lower(
      ChartSeriesAggregate value)
    {
      this.Container.LowerHandler = (ClientHandlerDescriptor) null;
      this.Container.Lower = new ChartSeriesAggregate?(value);
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> LowerHandler(
      string handler)
    {
      this.Container.Lower = new ChartSeriesAggregate?();
      this.Container.LowerHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> LowerHandler(
      Func<object, object> handler)
    {
      this.Container.Lower = new ChartSeriesAggregate?();
      this.Container.LowerHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> Mean(
      ChartSeriesAggregate value)
    {
      this.Container.MeanHandler = (ClientHandlerDescriptor) null;
      this.Container.Mean = new ChartSeriesAggregate?(value);
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> MeanHandler(
      string handler)
    {
      this.Container.Mean = new ChartSeriesAggregate?();
      this.Container.MeanHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> MeanHandler(
      Func<object, object> handler)
    {
      this.Container.Mean = new ChartSeriesAggregate?();
      this.Container.MeanHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> Median(
      ChartSeriesAggregate value)
    {
      this.Container.MedianHandler = (ClientHandlerDescriptor) null;
      this.Container.Median = new ChartSeriesAggregate?(value);
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> MedianHandler(
      string handler)
    {
      this.Container.Median = new ChartSeriesAggregate?();
      this.Container.MedianHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> MedianHandler(
      Func<object, object> handler)
    {
      this.Container.Median = new ChartSeriesAggregate?();
      this.Container.MedianHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> Outliers(
      ChartSeriesAggregate value)
    {
      this.Container.OutliersHandler = (ClientHandlerDescriptor) null;
      this.Container.Outliers = new ChartSeriesAggregate?(value);
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> OutliersHandler(
      string handler)
    {
      this.Container.Outliers = new ChartSeriesAggregate?();
      this.Container.OutliersHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> OutliersHandler(
      Func<object, object> handler)
    {
      this.Container.Outliers = new ChartSeriesAggregate?();
      this.Container.OutliersHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> Q1(
      ChartSeriesAggregate value)
    {
      this.Container.Q1Handler = (ClientHandlerDescriptor) null;
      this.Container.Q1 = new ChartSeriesAggregate?(value);
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> Q1Handler(
      string handler)
    {
      this.Container.Q1 = new ChartSeriesAggregate?();
      this.Container.Q1Handler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> Q1Handler(
      Func<object, object> handler)
    {
      this.Container.Q1 = new ChartSeriesAggregate?();
      this.Container.Q1Handler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> Q3(
      ChartSeriesAggregate value)
    {
      this.Container.Q3Handler = (ClientHandlerDescriptor) null;
      this.Container.Q3 = new ChartSeriesAggregate?(value);
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> Q3Handler(
      string handler)
    {
      this.Container.Q3 = new ChartSeriesAggregate?();
      this.Container.Q3Handler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> Q3Handler(
      Func<object, object> handler)
    {
      this.Container.Q3 = new ChartSeriesAggregate?();
      this.Container.Q3Handler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> Upper(
      ChartSeriesAggregate value)
    {
      this.Container.UpperHandler = (ClientHandlerDescriptor) null;
      this.Container.Upper = new ChartSeriesAggregate?(value);
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> UpperHandler(
      string handler)
    {
      this.Container.Upper = new ChartSeriesAggregate?();
      this.Container.UpperHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesAggregateSettingsBuilder<T> UpperHandler(
      Func<object, object> handler)
    {
      this.Container.Upper = new ChartSeriesAggregate?();
      this.Container.UpperHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
