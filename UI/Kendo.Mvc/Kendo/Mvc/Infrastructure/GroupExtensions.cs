// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.GroupExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


#nullable enable
namespace Kendo.Mvc.Infrastructure
{
  internal static class GroupExtensions
  {
    public static int LeafIndexOf(this 
    #nullable disable
    IGroup group, object item) => !group.HasSubgroups ? group.Items.IndexOf(item) : group.Subgroups.LeafIndexOf(item);

    public static int LeafIndexOf(this IEnumerable<IGroup> groups, object item)
    {
      int num1 = 0;
      foreach (IGroup group in groups)
      {
        int num2 = group.LeafIndexOf(item);
        if (num2 >= 0)
          return num1 + num2;
        num1 += group.ItemCount;
      }
      return -1;
    }

    public static IEnumerable Leaves(this IEnumerable<IGroup> groups)
    {
      foreach (IGroup group in groups)
      {
        foreach (object leaf in group.Leaves())
          yield return leaf;
      }
    }

    public static IEnumerable Leaves(this IGroup group) => !group.HasSubgroups ? group.Items : group.Subgroups.Leaves();

    public static int LeavesCount(this IEnumerable<IGroup> groups) => groups.Sum<IGroup>((Func<IGroup, int>) (g => !g.HasSubgroups ? g.ItemCount : g.Subgroups.LeavesCount()));

    internal static int GroupUniqueKey(this IEnumerable<IGroup> groups, IGroup group) => GroupExtensions.GetGroupSequenceUniqueKey((IEnumerable<IGroup>) groups.GetParentsAndSelf(group));

    private static int GetGroupSequenceUniqueKey(IEnumerable<IGroup> groups)
    {
      int num = 0;
      bool flag = true;
      foreach (IGroup group in groups)
      {
        int groupKeyHashCode = GroupExtensions.GetGroupKeyHashCode(group);
        if (flag)
        {
          flag = false;
          num = groupKeyHashCode * 397;
        }
        else
          num ^= groupKeyHashCode;
      }
      return num ^ groups.Count<IGroup>();
    }

    private static int GetGroupKeyHashCode(IGroup group) => group.Key != null ? group.Key.GetHashCode() : 0;

    internal static IList<IGroup> GetParentsAndSelf(
      this IEnumerable<IGroup> groups,
      IGroup targetGroup)
    {
      foreach (IGroup group in groups)
      {
        IList<IGroup> andSelfRecursive = GroupExtensions.GetParentsAndSelfRecursive((IList<IGroup>) new List<IGroup>()
        {
          group
        }, targetGroup);
        if (andSelfRecursive.Count > 0)
          return andSelfRecursive;
      }
      return (IList<IGroup>) new List<IGroup>();
    }

    private static IList<IGroup> GetParentsAndSelfRecursive(
      IList<IGroup> parents,
      IGroup targetGroup)
    {
      IGroup group = parents.Last<IGroup>();
      if (group == targetGroup)
        return parents;
      if (group.HasSubgroups)
      {
        foreach (IGroup subgroup in group.Subgroups)
        {
          parents.Add(subgroup);
          IList<IGroup> andSelfRecursive = GroupExtensions.GetParentsAndSelfRecursive(parents, targetGroup);
          if (andSelfRecursive.Count > 0)
            return andSelfRecursive;
          parents.Remove(subgroup);
        }
      }
      return (IList<IGroup>) new List<IGroup>();
    }
  }
}
