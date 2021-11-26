// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesFactory<T> where T : class
  {
    public ChartSeriesFactory(List<ChartSeries<T>> container) => this.Container = container;

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected List<ChartSeries<T>> Container { get; private set; }

    public virtual ChartSeriesBuilder<T> Area(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "area",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Area<TValue>(
      Expression<Func<T, TValue>> expression)
    {
      ChartSeries<T> container = !typeof (T).IsPlainType() || expression.IsBindable() ? new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "area",
        Field = expression.MemberWithoutInstance()
      } : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Area<TValue, TCategory>(
      Expression<Func<T, TValue>> expression,
      Expression<Func<T, TCategory>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!expression.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "area",
        Field = expression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Area(
      string memberName,
      string categoryMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "area",
        Name = memberName.AsTitle(),
        Field = memberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Bar(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "bar",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Bar<TValue>(
      Expression<Func<T, TValue>> valueExpression)
    {
      ChartSeries<T> container = !typeof (T).IsPlainType() || valueExpression.IsBindable() ? new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "bar",
        Field = valueExpression.MemberWithoutInstance()
      } : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Bar<TValue, TCategory>(
      Expression<Func<T, TValue>> valueExpression,
      Expression<Func<T, TCategory>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!valueExpression.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "bar",
        Field = valueExpression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Bar(
      string valueMemberName,
      string categoryMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "bar",
        Name = valueMemberName.AsTitle(),
        Field = valueMemberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> BoxPlot(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "boxPlot",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> BoxPlot<TValue>(
      Expression<Func<T, TValue>> lowerExpression,
      Expression<Func<T, TValue>> q1Expression,
      Expression<Func<T, TValue>> medianExpression,
      Expression<Func<T, TValue>> q3Expression,
      Expression<Func<T, TValue>> upperExpression)
    {
      if (typeof (T).IsPlainType() && (!lowerExpression.IsBindable() || !q1Expression.IsBindable() || !medianExpression.IsBindable() || !q3Expression.IsBindable() || !upperExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "boxPlot",
        LowerField = lowerExpression.MemberWithoutInstance(),
        Q1Field = q1Expression.MemberWithoutInstance(),
        MedianField = medianExpression.MemberWithoutInstance(),
        Q3Field = q3Expression.MemberWithoutInstance(),
        UpperField = upperExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> BoxPlot<TValue>(
      Expression<Func<T, TValue>> lowerExpression,
      Expression<Func<T, TValue>> q1Expression,
      Expression<Func<T, TValue>> medianExpression,
      Expression<Func<T, TValue>> q3Expression,
      Expression<Func<T, TValue>> upperExpression,
      Expression<Func<T, TValue>> meanExpression,
      Expression<Func<T, IList<TValue>>> outliersExpression)
    {
      if (typeof (T).IsPlainType() && (!lowerExpression.IsBindable() || !q1Expression.IsBindable() || !medianExpression.IsBindable() || !q3Expression.IsBindable() || !upperExpression.IsBindable() || !meanExpression.IsBindable() || !outliersExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "boxPlot",
        LowerField = lowerExpression.MemberWithoutInstance(),
        Q1Field = q1Expression.MemberWithoutInstance(),
        MedianField = medianExpression.MemberWithoutInstance(),
        Q3Field = q3Expression.MemberWithoutInstance(),
        UpperField = upperExpression.MemberWithoutInstance(),
        MeanField = meanExpression.MemberWithoutInstance(),
        OutliersField = outliersExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> BoxPlot(
      string lowerMemberName,
      string q1MemberName,
      string medianMemberName,
      string q3MemberName,
      string upperMemberName,
      string meanMemberName = null,
      string outliersMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "boxPlot",
        Name = lowerMemberName.AsTitle() + ", " + q1MemberName.AsTitle() + ", " + medianMemberName.AsTitle() + ", " + q3MemberName.AsTitle() + ", " + upperMemberName.AsTitle(),
        LowerField = lowerMemberName,
        Q1Field = q1MemberName,
        MedianField = medianMemberName,
        Q3Field = q3MemberName,
        UpperField = upperMemberName,
        MeanField = meanMemberName,
        OutliersField = outliersMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Bubble(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "bubble",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Bubble<TXValue, TYValue, TSizeValue>(
      Expression<Func<T, TXValue>> xValueExpression,
      Expression<Func<T, TYValue>> yValueExpression,
      Expression<Func<T, TSizeValue>> sizeExpression)
    {
      if (typeof (T).IsPlainType() && (!xValueExpression.IsBindable() || !yValueExpression.IsBindable() || !sizeExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "bubble",
        XField = xValueExpression.MemberWithoutInstance(),
        YField = yValueExpression.MemberWithoutInstance(),
        SizeField = sizeExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Bubble<TXValue, TYValue, TSizeValue>(
      Expression<Func<T, TXValue>> xValueExpression,
      Expression<Func<T, TYValue>> yValueExpression,
      Expression<Func<T, TSizeValue>> sizeExpression,
      Expression<Func<T, string>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!xValueExpression.IsBindable() || !yValueExpression.IsBindable() || !sizeExpression.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "bubble",
        XField = xValueExpression.MemberWithoutInstance(),
        YField = yValueExpression.MemberWithoutInstance(),
        SizeField = sizeExpression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Bubble(
      string xMemberName,
      string yMemberName,
      string sizeMemberName,
      string categoryMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "bubble",
        Name = xMemberName.AsTitle() + ", " + yMemberName.AsTitle(),
        XField = xMemberName,
        YField = yMemberName,
        SizeField = sizeMemberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Bullet(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "bullet",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Bullet<TValue, TCategory>(
      Expression<Func<T, TValue>> currentExpression,
      Expression<Func<T, TCategory>> targetExpression)
    {
      if (typeof (T).IsPlainType() && (!currentExpression.IsBindable() || !targetExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "bullet",
        CurrentField = currentExpression.MemberWithoutInstance(),
        TargetField = targetExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Bullet(
      string currentMemberName,
      string targetMemberName)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "bullet",
        Name = currentMemberName.AsTitle() + ", " + targetMemberName.AsTitle(),
        CurrentField = currentMemberName,
        TargetField = targetMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Candlestick(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "candlestick",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Candlestick<TValue>(
      Expression<Func<T, TValue>> openExpression,
      Expression<Func<T, TValue>> highExpression,
      Expression<Func<T, TValue>> lowExpression,
      Expression<Func<T, TValue>> closeExpression)
    {
      if (typeof (T).IsPlainType() && (!openExpression.IsBindable() || !highExpression.IsBindable() || !lowExpression.IsBindable() || !closeExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "candlestick",
        OpenField = openExpression.MemberWithoutInstance(),
        HighField = highExpression.MemberWithoutInstance(),
        LowField = lowExpression.MemberWithoutInstance(),
        CloseField = closeExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Candlestick(
      string openMemberName,
      string highMemberName,
      string lowMemberName,
      string closeMemberName)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "candlestick",
        Name = openMemberName.AsTitle() + ", " + highMemberName.AsTitle() + ", " + lowMemberName.AsTitle() + ", " + closeMemberName.AsTitle(),
        OpenField = openMemberName,
        HighField = highMemberName,
        LowField = lowMemberName,
        CloseField = closeMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Column(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "column",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Column<TValue>(
      Expression<Func<T, TValue>> valueExpression)
    {
      ChartSeries<T> container = !typeof (T).IsPlainType() || valueExpression.IsBindable() ? new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "column",
        Field = valueExpression.MemberWithoutInstance()
      } : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Column<TValue, TCategory>(
      Expression<Func<T, TValue>> valueExpression,
      Expression<Func<T, TCategory>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!valueExpression.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "column",
        Field = valueExpression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Column(
      string valueMemberName,
      string categoryMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "column",
        Name = valueMemberName.AsTitle(),
        Field = valueMemberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Donut(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "donut",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Donut<TValue>(
      Expression<Func<T, TValue>> expressionValue,
      Expression<Func<T, string>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!expressionValue.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "donut",
        Field = expressionValue.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Donut(
      string valueMemberName,
      string categoryMemberName)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "donut",
        Name = valueMemberName.AsTitle(),
        Field = valueMemberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Funnel(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "funnel",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Funnel<TValue>(
      Expression<Func<T, TValue>> expressionValue,
      Expression<Func<T, string>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!expressionValue.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "funnel",
        Field = expressionValue.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Funnel(
      string valueMemberName,
      string categoryMemberName)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "funnel",
        Name = valueMemberName.AsTitle(),
        Field = valueMemberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> HorizontalWaterfall(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "horizontalWaterfall",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> HorizontalWaterfall<TValue>(
      Expression<Func<T, TValue>> valueExpression)
    {
      ChartSeries<T> container = !typeof (T).IsPlainType() || valueExpression.IsBindable() ? new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "horizontalWaterfall",
        Field = valueExpression.MemberWithoutInstance()
      } : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> HorizontalWaterfall<TValue, TCategory>(
      Expression<Func<T, TValue>> valueExpression,
      Expression<Func<T, TCategory>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!valueExpression.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "horizontalWaterfall",
        Field = valueExpression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> HorizontalWaterfall(
      string valueMemberName,
      string categoryMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "horizontalWaterfall",
        Name = valueMemberName.AsTitle(),
        Field = valueMemberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Line(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "line",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Line<TValue>(
      Expression<Func<T, TValue>> expression)
    {
      ChartSeries<T> container = !typeof (T).IsPlainType() || expression.IsBindable() ? new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "line",
        Field = expression.MemberWithoutInstance()
      } : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Line<TValue, TCategory>(
      Expression<Func<T, TValue>> expression,
      Expression<Func<T, TCategory>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!expression.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "line",
        Field = expression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Line(
      string memberName,
      string categoryMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "line",
        Name = memberName.AsTitle(),
        Field = memberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> OHLC(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "ohlc",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> OHLC<TValue>(
      Expression<Func<T, TValue>> openExpression,
      Expression<Func<T, TValue>> highExpression,
      Expression<Func<T, TValue>> lowExpression,
      Expression<Func<T, TValue>> closeExpression)
    {
      if (typeof (T).IsPlainType() && (!openExpression.IsBindable() || !highExpression.IsBindable() || !lowExpression.IsBindable() || !closeExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "ohlc",
        OpenField = openExpression.MemberWithoutInstance(),
        HighField = highExpression.MemberWithoutInstance(),
        LowField = lowExpression.MemberWithoutInstance(),
        CloseField = closeExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> OHLC(
      string openMemberName,
      string highMemberName,
      string lowMemberName,
      string closeMemberName)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "ohlc",
        Name = openMemberName.AsTitle() + ", " + highMemberName.AsTitle() + ", " + lowMemberName.AsTitle() + ", " + closeMemberName.AsTitle(),
        OpenField = openMemberName,
        HighField = highMemberName,
        LowField = lowMemberName,
        CloseField = closeMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Pie(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "pie",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Pie<TValue>(
      Expression<Func<T, TValue>> expressionValue,
      Expression<Func<T, string>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!expressionValue.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "pie",
        Field = expressionValue.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Pie(
      string valueMemberName,
      string categoryMemberName)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "pie",
        Name = valueMemberName.AsTitle(),
        Field = valueMemberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> PolarArea(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "polarArea",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> PolarArea<TXValue, TYValue>(
      Expression<Func<T, TXValue>> xValueExpression,
      Expression<Func<T, TYValue>> yValueExpression)
    {
      if (typeof (T).IsPlainType() && (!xValueExpression.IsBindable() || !yValueExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "polarArea",
        XField = xValueExpression.MemberWithoutInstance(),
        YField = yValueExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> PolarArea(
      string xMemberName,
      string yMemberName)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "polarArea",
        Name = xMemberName.AsTitle() + ", " + yMemberName.AsTitle(),
        XField = xMemberName,
        YField = yMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> PolarLine(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "polarLine",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> PolarLine<TXValue, TYValue>(
      Expression<Func<T, TXValue>> xValueExpression,
      Expression<Func<T, TYValue>> yValueExpression)
    {
      if (typeof (T).IsPlainType() && (!xValueExpression.IsBindable() || !yValueExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "polarLine",
        XField = xValueExpression.MemberWithoutInstance(),
        YField = yValueExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> PolarLine(
      string xMemberName,
      string yMemberName)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "polarLine",
        Name = xMemberName.AsTitle() + ", " + yMemberName.AsTitle(),
        XField = xMemberName,
        YField = yMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> PolarScatter(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "polarScatter",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> PolarScatter<TXValue, TYValue>(
      Expression<Func<T, TXValue>> xValueExpression,
      Expression<Func<T, TYValue>> yValueExpression)
    {
      if (typeof (T).IsPlainType() && (!xValueExpression.IsBindable() || !yValueExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "polarScatter",
        XField = xValueExpression.MemberWithoutInstance(),
        YField = yValueExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> PolarScatter(
      string xMemberName,
      string yMemberName)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "polarScatter",
        Name = xMemberName.AsTitle() + ", " + yMemberName.AsTitle(),
        XField = xMemberName,
        YField = yMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RadarArea(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "radarArea",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RadarArea<TValue>(
      Expression<Func<T, TValue>> valueExpression)
    {
      ChartSeries<T> container = !typeof (T).IsPlainType() || valueExpression.IsBindable() ? new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "radarArea",
        Field = valueExpression.MemberWithoutInstance()
      } : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RadarArea<TValue, TCategory>(
      Expression<Func<T, TValue>> valueExpression,
      Expression<Func<T, TCategory>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!valueExpression.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "radarArea",
        Field = valueExpression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RadarArea(
      string valueMemberName,
      string categoryMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "radarArea",
        Name = valueMemberName.AsTitle(),
        Field = valueMemberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RadarColumn(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "radarColumn",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RadarColumn<TValue>(
      Expression<Func<T, TValue>> valueExpression)
    {
      ChartSeries<T> container = !typeof (T).IsPlainType() || valueExpression.IsBindable() ? new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "radarColumn",
        Field = valueExpression.MemberWithoutInstance()
      } : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RadarColumn<TValue, TCategory>(
      Expression<Func<T, TValue>> valueExpression,
      Expression<Func<T, TCategory>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!valueExpression.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "radarColumn",
        Field = valueExpression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RadarColumn(
      string valueMemberName,
      string categoryMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "radarColumn",
        Name = valueMemberName.AsTitle(),
        Field = valueMemberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RadarLine(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "radarLine",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RadarLine<TValue>(
      Expression<Func<T, TValue>> valueExpression)
    {
      ChartSeries<T> container = !typeof (T).IsPlainType() || valueExpression.IsBindable() ? new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "radarLine",
        Field = valueExpression.MemberWithoutInstance()
      } : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RadarLine<TValue, TCategory>(
      Expression<Func<T, TValue>> valueExpression,
      Expression<Func<T, TCategory>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!valueExpression.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "radarLine",
        Field = valueExpression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RadarLine(
      string valueMemberName,
      string categoryMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "radarLine",
        Name = valueMemberName.AsTitle(),
        Field = valueMemberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RangeArea(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "rangeArea",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RangeArea<TValue>(
      Expression<Func<T, TValue>> fromExpression,
      Expression<Func<T, TValue>> toExpression)
    {
      if (typeof (T).IsPlainType() && (!fromExpression.IsBindable() || !toExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "rangeArea",
        FromField = fromExpression.MemberWithoutInstance(),
        ToField = toExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RangeArea<TValue, TCategory, TColor>(
      Expression<Func<T, TValue>> fromExpression,
      Expression<Func<T, TValue>> toExpression,
      Expression<Func<T, TCategory>> categoryExpression,
      Expression<Func<T, TColor>> colorExpression)
    {
      if (typeof (T).IsPlainType() && (!fromExpression.IsBindable() || !toExpression.IsBindable() || !categoryExpression.IsBindable() || !colorExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "rangeArea",
        FromField = fromExpression.MemberWithoutInstance(),
        ToField = toExpression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance(),
        ColorField = colorExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RangeArea(
      string fromMemberName,
      string toMemberName,
      string categoryMemberName = null,
      string colorMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "rangeArea",
        Name = fromMemberName.AsTitle() + ", " + toMemberName.AsTitle(),
        FromField = fromMemberName,
        ToField = toMemberName,
        CategoryField = categoryMemberName,
        ColorField = colorMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RangeBar(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "rangeBar",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RangeBar<TValue>(
      Expression<Func<T, TValue>> fromExpression,
      Expression<Func<T, TValue>> toExpression)
    {
      if (typeof (T).IsPlainType() && (!fromExpression.IsBindable() || !toExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "rangeBar",
        FromField = fromExpression.MemberWithoutInstance(),
        ToField = toExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RangeBar<TValue, TCategory>(
      Expression<Func<T, TValue>> fromExpression,
      Expression<Func<T, TValue>> toExpression,
      Expression<Func<T, TCategory>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!fromExpression.IsBindable() || !toExpression.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "rangeBar",
        FromField = fromExpression.MemberWithoutInstance(),
        ToField = toExpression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RangeBar(
      string fromMemberName,
      string toMemberName,
      string categoryMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "rangeBar",
        Name = fromMemberName.AsTitle() + ", " + toMemberName.AsTitle(),
        FromField = fromMemberName,
        ToField = toMemberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RangeColumn(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "rangeColumn",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RangeColumn<TValue>(
      Expression<Func<T, TValue>> fromExpression,
      Expression<Func<T, TValue>> toExpression)
    {
      if (typeof (T).IsPlainType() && (!fromExpression.IsBindable() || !toExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "rangeColumn",
        FromField = fromExpression.MemberWithoutInstance(),
        ToField = toExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RangeColumn<TValue, TCategory>(
      Expression<Func<T, TValue>> fromExpression,
      Expression<Func<T, TValue>> toExpression,
      Expression<Func<T, TCategory>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!fromExpression.IsBindable() || !toExpression.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "rangeColumn",
        FromField = fromExpression.MemberWithoutInstance(),
        ToField = toExpression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> RangeColumn(
      string fromMemberName,
      string toMemberName,
      string categoryMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "rangeColumn",
        Name = fromMemberName.AsTitle() + ", " + toMemberName.AsTitle(),
        FromField = fromMemberName,
        ToField = toMemberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Scatter(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "scatter",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Scatter<TXValue, TYValue>(
      Expression<Func<T, TXValue>> xValueExpression,
      Expression<Func<T, TYValue>> yValueExpression)
    {
      if (typeof (T).IsPlainType() && (!xValueExpression.IsBindable() || !yValueExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "scatter",
        XField = xValueExpression.MemberWithoutInstance(),
        YField = yValueExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Scatter(
      string xMemberName,
      string yMemberName)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "scatter",
        Name = xMemberName.AsTitle() + ", " + yMemberName.AsTitle(),
        XField = xMemberName,
        YField = yMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> ScatterLine(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "scatterLine",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> ScatterLine<TXValue, TYValue>(
      Expression<Func<T, TXValue>> xValueExpression,
      Expression<Func<T, TYValue>> yValueExpression)
    {
      if (typeof (T).IsPlainType() && (!xValueExpression.IsBindable() || !yValueExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "scatterLine",
        XField = xValueExpression.MemberWithoutInstance(),
        YField = yValueExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> ScatterLine(
      string xMemberName,
      string yMemberName)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "scatterLine",
        Name = xMemberName.AsTitle() + ", " + yMemberName.AsTitle(),
        XField = xMemberName,
        YField = yMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalArea(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalArea",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalArea<TValue>(
      Expression<Func<T, TValue>> expression)
    {
      ChartSeries<T> container = !typeof (T).IsPlainType() || expression.IsBindable() ? new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalArea",
        Field = expression.MemberWithoutInstance()
      } : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalArea<TValue, TCategory>(
      Expression<Func<T, TValue>> expression,
      Expression<Func<T, TCategory>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!expression.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalArea",
        Field = expression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalArea(
      string memberName,
      string categoryMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalArea",
        Name = memberName.AsTitle(),
        Field = memberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalBoxPlot(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalBoxPlot",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalBoxPlot<TValue>(
      Expression<Func<T, TValue>> lowerExpression,
      Expression<Func<T, TValue>> q1Expression,
      Expression<Func<T, TValue>> medianExpression,
      Expression<Func<T, TValue>> q3Expression,
      Expression<Func<T, TValue>> upperExpression)
    {
      if (typeof (T).IsPlainType() && (!lowerExpression.IsBindable() || !q1Expression.IsBindable() || !medianExpression.IsBindable() || !q3Expression.IsBindable() || !upperExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalBoxPlot",
        LowerField = lowerExpression.MemberWithoutInstance(),
        Q1Field = q1Expression.MemberWithoutInstance(),
        MedianField = medianExpression.MemberWithoutInstance(),
        Q3Field = q3Expression.MemberWithoutInstance(),
        UpperField = upperExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalBoxPlot<TValue>(
      Expression<Func<T, TValue>> lowerExpression,
      Expression<Func<T, TValue>> q1Expression,
      Expression<Func<T, TValue>> medianExpression,
      Expression<Func<T, TValue>> q3Expression,
      Expression<Func<T, TValue>> upperExpression,
      Expression<Func<T, TValue>> meanExpression,
      Expression<Func<T, IList<TValue>>> outliersExpression)
    {
      if (typeof (T).IsPlainType() && (!lowerExpression.IsBindable() || !q1Expression.IsBindable() || !medianExpression.IsBindable() || !q3Expression.IsBindable() || !upperExpression.IsBindable() || !meanExpression.IsBindable() || !outliersExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalBoxPlot",
        LowerField = lowerExpression.MemberWithoutInstance(),
        Q1Field = q1Expression.MemberWithoutInstance(),
        MedianField = medianExpression.MemberWithoutInstance(),
        Q3Field = q3Expression.MemberWithoutInstance(),
        UpperField = upperExpression.MemberWithoutInstance(),
        MeanField = meanExpression.MemberWithoutInstance(),
        OutliersField = outliersExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalBoxPlot(
      string lowerMemberName,
      string q1MemberName,
      string medianMemberName,
      string q3MemberName,
      string upperMemberName,
      string meanMemberName = null,
      string outliersMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalBoxPlot",
        Name = lowerMemberName.AsTitle() + ", " + q1MemberName.AsTitle() + ", " + medianMemberName.AsTitle() + ", " + q3MemberName.AsTitle() + ", " + upperMemberName.AsTitle(),
        LowerField = lowerMemberName,
        Q1Field = q1MemberName,
        MedianField = medianMemberName,
        Q3Field = q3MemberName,
        UpperField = upperMemberName,
        MeanField = meanMemberName,
        OutliersField = outliersMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalBullet(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalBullet",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalBullet<TValue, TCategory>(
      Expression<Func<T, TValue>> currentExpression,
      Expression<Func<T, TCategory>> targetExpression)
    {
      if (typeof (T).IsPlainType() && (!currentExpression.IsBindable() || !targetExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalBullet",
        CurrentField = currentExpression.MemberWithoutInstance(),
        TargetField = targetExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalBullet(
      string currentMemberName,
      string targetMemberName)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalBullet",
        Name = currentMemberName.AsTitle() + ", " + targetMemberName.AsTitle(),
        CurrentField = currentMemberName,
        TargetField = targetMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalLine(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalLine",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalLine<TValue>(
      Expression<Func<T, TValue>> expression)
    {
      ChartSeries<T> container = !typeof (T).IsPlainType() || expression.IsBindable() ? new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalLine",
        Field = expression.MemberWithoutInstance()
      } : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalLine<TValue, TCategory>(
      Expression<Func<T, TValue>> expression,
      Expression<Func<T, TCategory>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!expression.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalLine",
        Field = expression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalLine(
      string memberName,
      string categoryMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalLine",
        Name = memberName.AsTitle(),
        Field = memberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalRangeArea(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalRangeArea",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalRangeArea<TValue>(
      Expression<Func<T, TValue>> fromExpression,
      Expression<Func<T, TValue>> toExpression)
    {
      if (typeof (T).IsPlainType() && (!fromExpression.IsBindable() || !toExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalRangeArea",
        FromField = fromExpression.MemberWithoutInstance(),
        ToField = toExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalRangeArea<TValue, TCategory, TColor>(
      Expression<Func<T, TValue>> fromExpression,
      Expression<Func<T, TValue>> toExpression,
      Expression<Func<T, TCategory>> categoryExpression,
      Expression<Func<T, TColor>> colorExpression)
    {
      if (typeof (T).IsPlainType() && (!fromExpression.IsBindable() || !toExpression.IsBindable() || !categoryExpression.IsBindable() || !colorExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalRangeArea",
        FromField = fromExpression.MemberWithoutInstance(),
        ToField = toExpression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance(),
        ColorField = colorExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> VerticalRangeArea(
      string fromMemberName,
      string toMemberName,
      string categoryMemberName = null,
      string colorMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "verticalRangeArea",
        Name = fromMemberName.AsTitle() + ", " + toMemberName.AsTitle(),
        FromField = fromMemberName,
        ToField = toMemberName,
        CategoryField = categoryMemberName,
        ColorField = colorMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Waterfall(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "waterfall",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Waterfall<TValue>(
      Expression<Func<T, TValue>> valueExpression)
    {
      ChartSeries<T> container = !typeof (T).IsPlainType() || valueExpression.IsBindable() ? new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "waterfall",
        Field = valueExpression.MemberWithoutInstance()
      } : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Waterfall<TValue, TCategory>(
      Expression<Func<T, TValue>> valueExpression,
      Expression<Func<T, TCategory>> categoryExpression)
    {
      if (typeof (T).IsPlainType() && (!valueExpression.IsBindable() || !categoryExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "waterfall",
        Field = valueExpression.MemberWithoutInstance(),
        CategoryField = categoryExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> Waterfall(
      string valueMemberName,
      string categoryMemberName = null)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "waterfall",
        Name = valueMemberName.AsTitle(),
        Field = valueMemberName,
        CategoryField = categoryMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> HeatMap(IEnumerable data)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "heatmap",
        Data = data
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> HeatMap<TValue, TXValue, TYValue>(
      Expression<Func<T, TValue>> valueExpression,
      Expression<Func<T, TXValue>> xValueExpression,
      Expression<Func<T, TYValue>> yValueExpression)
    {
      if (typeof (T).IsPlainType() && (!valueExpression.IsBindable() || !xValueExpression.IsBindable() || !yValueExpression.IsBindable()))
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "heatmap",
        Field = valueExpression.MemberWithoutInstance(),
        XField = xValueExpression.MemberWithoutInstance(),
        YField = yValueExpression.MemberWithoutInstance()
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }

    public virtual ChartSeriesBuilder<T> HeatMap(
      string valueMemberName,
      string xMemberName,
      string yMemberName)
    {
      ChartSeries<T> container = new ChartSeries<T>()
      {
        Chart = this.Chart,
        Type = "heatmap",
        Name = valueMemberName.AsTitle() + ", " + xMemberName.AsTitle() + ", " + yMemberName.AsTitle(),
        Field = valueMemberName,
        XField = xMemberName,
        YField = yMemberName
      };
      this.Container.Add(container);
      return new ChartSeriesBuilder<T>(container);
    }
  }
}
