// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DataSourceRequestUrlParameters
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public static class DataSourceRequestUrlParameters
  {
    public static string Aggregates { get; set; }

    public static string Filter { get; set; }

    public static string Page { get; set; }

    public static string PageSize { get; set; }

    public static string Sort { get; set; }

    public static string Group { get; set; }

    public static string Mode { get; set; }

    public static string GroupPaging { get; set; }

    public static string IncludeSubGroupCount { get; set; }

    public static string Skip { get; set; }

    public static string Take { get; set; }

    static DataSourceRequestUrlParameters()
    {
      DataSourceRequestUrlParameters.Sort = "sort";
      DataSourceRequestUrlParameters.Group = "group";
      DataSourceRequestUrlParameters.Page = "page";
      DataSourceRequestUrlParameters.PageSize = "pageSize";
      DataSourceRequestUrlParameters.Filter = "filter";
      DataSourceRequestUrlParameters.Mode = "mode";
      DataSourceRequestUrlParameters.Aggregates = "aggregate";
      DataSourceRequestUrlParameters.GroupPaging = "groupPaging";
      DataSourceRequestUrlParameters.Skip = "skip";
      DataSourceRequestUrlParameters.Take = "take";
      DataSourceRequestUrlParameters.IncludeSubGroupCount = "includeSubGroupCount";
    }

    public static IDictionary<string, string> ToDictionary(string prefix)
    {
      Dictionary<string, string> dictionary = new Dictionary<string, string>();
      dictionary[DataSourceRequestUrlParameters.Group] = prefix + DataSourceRequestUrlParameters.Group;
      dictionary[DataSourceRequestUrlParameters.Sort] = prefix + DataSourceRequestUrlParameters.Sort;
      dictionary[DataSourceRequestUrlParameters.Page] = prefix + DataSourceRequestUrlParameters.Page;
      dictionary[DataSourceRequestUrlParameters.PageSize] = prefix + DataSourceRequestUrlParameters.PageSize;
      dictionary[DataSourceRequestUrlParameters.Filter] = prefix + DataSourceRequestUrlParameters.Filter;
      dictionary[DataSourceRequestUrlParameters.Mode] = prefix + DataSourceRequestUrlParameters.Mode;
      dictionary[DataSourceRequestUrlParameters.GroupPaging] = prefix + DataSourceRequestUrlParameters.GroupPaging;
      dictionary[DataSourceRequestUrlParameters.Skip] = prefix + DataSourceRequestUrlParameters.Skip;
      dictionary[DataSourceRequestUrlParameters.Take] = prefix + DataSourceRequestUrlParameters.Take;
      dictionary[DataSourceRequestUrlParameters.IncludeSubGroupCount] = prefix + DataSourceRequestUrlParameters.IncludeSubGroupCount;
      return (IDictionary<string, string>) dictionary;
    }
  }
}
