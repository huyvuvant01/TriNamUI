﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Rendering.IKendoHtmlGenerator
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;

namespace Kendo.Mvc.Rendering
{
  public interface IKendoHtmlGenerator
  {
    TagBuilder GenerateInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      string type,
      IDictionary<string, object> htmlAttributes);

    TagBuilder GenerateColorInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      IDictionary<string, object> htmlAttributes);

    TagBuilder GenerateRangeInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      IDictionary<string, object> htmlAttributes);

    TagBuilder GenerateDateInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      IDictionary<string, object> htmlAttributes);

    TagBuilder GenerateDateTimeInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      IDictionary<string, object> htmlAttributes);

    TagBuilder GenerateTimeInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      IDictionary<string, object> htmlAttributes);

    TagBuilder GenerateNumericInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      IDictionary<string, object> htmlAttributes);

    TagBuilder GenerateTextInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      IDictionary<string, object> htmlAttributes);

    TagBuilder GenerateRadioInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      IDictionary<string, object> htmlAttributes);

    TagBuilder GenerateMultiSelect(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      IDictionary<string, object> htmlAttributes);

    TagBuilder GenerateTextarea(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      IDictionary<string, object> htmlAttributes);

    TagBuilder GenerateTag(
      string tagName,
      ViewContext viewContext,
      string id,
      string name,
      IDictionary<string, object> htmlAttributes);

    TagBuilder GenerateHiddenForCheckbox(
      ViewContext viewContext,
      string name,
      IDictionary<string, object> htmlAttributes);

    TagBuilder GenerateTag(string tagName, IDictionary<string, object> htmlAttributes);

    TagBuilder GeneratePseudoBuilder(
      ViewContext viewContext,
      ModelExplorer explorer,
      string name);

    string SanitizeId(string id);

    TagBuilder GenerateBoundElement(
      string elementType,
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      string type,
      IDictionary<string, object> htmlAttributes);
  }
}
