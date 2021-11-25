// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.RecurrenceEditorFrequencyExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class RecurrenceEditorFrequencyExtensions
  {
    internal static string Serialize(this RecurrenceEditorFrequency value)
    {
      switch (value)
      {
        case RecurrenceEditorFrequency.Never:
          return "never";
        case RecurrenceEditorFrequency.Daily:
          return "daily";
        case RecurrenceEditorFrequency.Weekly:
          return "weekly";
        case RecurrenceEditorFrequency.Monthly:
          return "monthly";
        case RecurrenceEditorFrequency.Yearly:
          return "yearly";
        default:
          return value.ToString();
      }
    }
  }
}
