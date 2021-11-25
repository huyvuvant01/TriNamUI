// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ActionSheetBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ActionSheetBuilder : WidgetBuilderBase<ActionSheet, ActionSheetBuilder>
  {
    public ActionSheetBuilder(ActionSheet component)
      : base(component)
    {
    }

    public ActionSheetBuilder Items(Action<ActionSheetItemFactory> configurator)
    {
      configurator(new ActionSheetItemFactory(this.Container.Items)
      {
        ActionSheet = this.Container
      });
      return this;
    }

    public ActionSheetBuilder Title(string value)
    {
      this.Container.Title = value;
      return this;
    }

    public ActionSheetBuilder Events(Action<ActionSheetEventBuilder> configurator)
    {
      configurator(new ActionSheetEventBuilder(this.Container.Events));
      return this;
    }
  }
}
