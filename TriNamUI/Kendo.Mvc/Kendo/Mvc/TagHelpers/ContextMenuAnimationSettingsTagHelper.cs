﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ContextMenuAnimationSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("popup-animation", ParentTag = "kendo-contextmenu", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("close", new string[] {"open"})]
  [SuppressTagRendering]
  public class ContextMenuAnimationSettingsTagHelper : PopupAnimationSettingsTagHelper
  {
    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ContextMenuTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ContextMenuTagHelper).Animation = this;
    }
  }
}
