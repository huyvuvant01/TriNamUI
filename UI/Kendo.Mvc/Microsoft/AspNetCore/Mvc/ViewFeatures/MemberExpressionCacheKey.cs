// Decompiled with JetBrains decompiler
// Type: Microsoft.AspNetCore.Mvc.ViewFeatures.MemberExpressionCacheKey
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Microsoft.AspNetCore.Mvc.ViewFeatures
{
  internal readonly struct MemberExpressionCacheKey
  {
    public MemberExpressionCacheKey(Type modelType, MemberExpression memberExpression)
    {
      this.ModelType = modelType;
      this.MemberExpression = memberExpression;
      this.Members = (MemberInfo[]) null;
    }

    public MemberExpressionCacheKey(Type modelType, MemberInfo[] members)
    {
      this.ModelType = modelType;
      this.Members = members;
      this.MemberExpression = (MemberExpression) null;
    }

    public MemberExpressionCacheKey MakeCacheable()
    {
      List<MemberInfo> memberInfoList = new List<MemberInfo>();
      foreach (MemberInfo memberInfo in this)
        memberInfoList.Add(memberInfo);
      return new MemberExpressionCacheKey(this.ModelType, memberInfoList.ToArray());
    }

    public MemberExpression MemberExpression { get; }

    public Type ModelType { get; }

    public MemberInfo[] Members { get; }

    public MemberExpressionCacheKey.Enumerator GetEnumerator() => new MemberExpressionCacheKey.Enumerator(in this);

    public struct Enumerator
    {
      private readonly MemberInfo[] _members;
      private int _index;
      private MemberExpression _memberExpression;

      public Enumerator(in MemberExpressionCacheKey key)
      {
        this.Current = (MemberInfo) null;
        this._members = key.Members;
        this._memberExpression = key.MemberExpression;
        this._index = -1;
      }

      public MemberInfo Current { get; private set; }

      public bool MoveNext()
      {
        if (this._members != null)
        {
          ++this._index;
          if (this._index >= this._members.Length)
            return false;
          this.Current = this._members[this._index];
          return true;
        }
        if (this._memberExpression == null)
          return false;
        this.Current = this._memberExpression.Member;
        this._memberExpression = this._memberExpression.Expression as MemberExpression;
        return true;
      }
    }
  }
}
