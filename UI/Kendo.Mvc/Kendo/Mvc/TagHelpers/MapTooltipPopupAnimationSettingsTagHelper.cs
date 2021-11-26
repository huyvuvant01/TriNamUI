// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MapTooltipPopupAnimationSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("popup-animation", ParentTag = "tooltip", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("close", new string[] {"open"})]
  [SuppressTagRendering]
  public class MapTooltipPopupAnimationSettingsTagHelper : PopupAnimationSettingsTagHelper
  {
    protected override void AddSelfToParent(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in (IEnumerable<KeyValuePair<object, object>>) context.Items)
        this.SetAnimation(keyValuePair.Value);
    }

    private void SetAnimation(object item)
    {
      if (!(item is MapTooltipTagHelper))
        return;
      (item as MapTooltipTagHelper).Animation = this;
    }
  }
}
