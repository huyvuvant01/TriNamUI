// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RecurrenceEditorFrequencyBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class RecurrenceEditorFrequencyBuilder : IHideObjectMembers
  {
    private readonly RecurrenceEditor container;

    public RecurrenceEditorFrequencyBuilder(RecurrenceEditor container) => this.container = container;

    public RecurrenceEditorFrequencyBuilder Add(
      RecurrenceEditorFrequency frequency)
    {
      this.container.Frequencies.Add(frequency);
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
