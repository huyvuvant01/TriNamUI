﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.Form.AspFormTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kendo.Mvc.TagHelpers.Form
{
  [HtmlTargetElement("kendo-form")]
  [HtmlTargetElement("wizard-step-form")]
  public class AspFormTagHelper : Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper
  {
    public AspFormTagHelper(IHtmlGenerator generator)
      : base(generator)
    {
    }
  }
}
