// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeMapBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeMapBuilder : WidgetBuilderBase<TreeMap, TreeMapBuilder>
  {
    public TreeMapBuilder(TreeMap component)
      : base(component)
    {
    }

    public TreeMapBuilder DataSource(
      Action<HierarchicalDataSourceBuilder<object>> configurator)
    {
      configurator(new HierarchicalDataSourceBuilder<object>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public TreeMapBuilder Colors(Action<TreeMapColorRangeFactory> configurator)
    {
      configurator(new TreeMapColorRangeFactory(this.Component));
      return this;
    }

    public TreeMapBuilder AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public TreeMapBuilder Theme(string value)
    {
      this.Container.Theme = value;
      return this;
    }

    public TreeMapBuilder ValueField(string value)
    {
      this.Container.ValueField = value;
      return this;
    }

    public TreeMapBuilder ColorField(string value)
    {
      this.Container.ColorField = value;
      return this;
    }

    public TreeMapBuilder TextField(string value)
    {
      this.Container.TextField = value;
      return this;
    }

    public TreeMapBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public TreeMapBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public TreeMapBuilder Colors(params string[] value)
    {
      this.Container.Colors = value;
      return this;
    }

    public TreeMapBuilder Type(TreeMapType value)
    {
      this.Container.Type = new TreeMapType?(value);
      return this;
    }

    public TreeMapBuilder Events(Action<TreeMapEventBuilder> configurator)
    {
      configurator(new TreeMapEventBuilder(this.Container.Events));
      return this;
    }
  }
}
