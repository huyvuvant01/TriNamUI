// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.FilterParser
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Kendo.Mvc.Infrastructure.Implementation
{
  public class FilterParser
  {
    private readonly IList<FilterToken> tokens;
    private int currentTokenIndex;

    public FilterParser(string input) => this.tokens = new FilterLexer(input).Tokenize();

    public IFilterNode Parse() => this.tokens.Count > 0 ? this.Expression() : (IFilterNode) null;

    private IFilterNode Expression() => this.OrExpression();

    private IFilterNode OrExpression()
    {
      IFilterNode firstArgument = this.AndExpression();
      if (this.Is(FilterTokenType.Or))
        return this.ParseOrExpression(firstArgument);
      if (!this.Is(FilterTokenType.And))
        return firstArgument;
      this.Expect(FilterTokenType.And);
      return (IFilterNode) new AndNode()
      {
        First = firstArgument,
        Second = this.OrExpression()
      };
    }

    private IFilterNode AndExpression()
    {
      IFilterNode firstArgument = this.ComparisonExpression();
      return this.Is(FilterTokenType.And) ? this.ParseAndExpression(firstArgument) : firstArgument;
    }

    private IFilterNode ComparisonExpression()
    {
      IFilterNode firstArgument = this.PrimaryExpression();
      return this.Is(FilterTokenType.ComparisonOperator) || this.Is(FilterTokenType.Function) ? this.ParseComparisonExpression(firstArgument) : firstArgument;
    }

    private IFilterNode PrimaryExpression()
    {
      if (this.Is(FilterTokenType.LeftParenthesis))
        return this.ParseNestedExpression();
      if (this.Is(FilterTokenType.Function))
        return this.ParseFunctionExpression();
      if (this.Is(FilterTokenType.Boolean))
        return this.ParseBoolean();
      if (this.Is(FilterTokenType.DateTime))
        return this.ParseDateTimeExpression();
      if (this.Is(FilterTokenType.Property))
        return this.ParsePropertyExpression();
      if (this.Is(FilterTokenType.Number))
        return this.ParseNumberExpression();
      if (this.Is(FilterTokenType.String))
        return this.ParseStringExpression();
      if (this.Is(FilterTokenType.Null))
        return this.ParseNullExpression();
      throw new FilterParserException("Expected primaryExpression");
    }

    private IFilterNode ParseOrExpression(IFilterNode firstArgument)
    {
      this.Expect(FilterTokenType.Or);
      IFilterNode filterNode = this.OrExpression();
      return (IFilterNode) new OrNode()
      {
        First = firstArgument,
        Second = filterNode
      };
    }

    private IFilterNode ParseComparisonExpression(IFilterNode firstArgument)
    {
      if (this.Is(FilterTokenType.ComparisonOperator))
      {
        FilterToken token = this.Expect(FilterTokenType.ComparisonOperator);
        IFilterNode filterNode = this.PrimaryExpression();
        return (IFilterNode) new ComparisonNode()
        {
          First = firstArgument,
          FilterOperator = token.ToFilterOperator(),
          Second = filterNode
        };
      }
      FilterToken token1 = this.Expect(FilterTokenType.Function);
      FunctionNode functionNode = new FunctionNode();
      functionNode.FilterOperator = token1.ToFilterOperator();
      functionNode.Arguments.Add(firstArgument);
      functionNode.Arguments.Add(this.PrimaryExpression());
      return (IFilterNode) functionNode;
    }

    private IFilterNode ParseAndExpression(IFilterNode firstArgument)
    {
      this.Expect(FilterTokenType.And);
      IFilterNode filterNode = this.ComparisonExpression();
      return (IFilterNode) new AndNode()
      {
        First = firstArgument,
        Second = filterNode
      };
    }

    private IFilterNode ParseNullExpression()
    {
      FilterToken filterToken = this.Expect(FilterTokenType.Null);
      return (IFilterNode) new NullNode()
      {
        Value = (object) filterToken.Value
      };
    }

    private IFilterNode ParseStringExpression()
    {
      FilterToken filterToken = this.Expect(FilterTokenType.String);
      return (IFilterNode) new StringNode()
      {
        Value = (object) filterToken.Value
      };
    }

    private IFilterNode ParseBoolean()
    {
      FilterToken filterToken = this.Expect(FilterTokenType.Boolean);
      return (IFilterNode) new BooleanNode()
      {
        Value = (object) Convert.ToBoolean(filterToken.Value)
      };
    }

    private IFilterNode ParseNumberExpression()
    {
      FilterToken filterToken = this.Expect(FilterTokenType.Number);
      return (IFilterNode) new NumberNode()
      {
        Value = (object) Convert.ToDouble(filterToken.Value, (IFormatProvider) CultureInfo.InvariantCulture)
      };
    }

    private IFilterNode ParsePropertyExpression()
    {
      FilterToken filterToken = this.Expect(FilterTokenType.Property);
      return (IFilterNode) new PropertyNode()
      {
        Name = filterToken.Value
      };
    }

    private IFilterNode ParseDateTimeExpression()
    {
      FilterToken filterToken = this.Expect(FilterTokenType.DateTime);
      return (IFilterNode) new DateTimeNode()
      {
        Value = (object) DateTime.ParseExact(filterToken.Value, "yyyy-MM-ddTHH-mm-ss", (IFormatProvider) null)
      };
    }

    private IFilterNode ParseNestedExpression()
    {
      this.Expect(FilterTokenType.LeftParenthesis);
      IFilterNode filterNode = this.Expression();
      this.Expect(FilterTokenType.RightParenthesis);
      return filterNode;
    }

    private IFilterNode ParseFunctionExpression()
    {
      FilterToken token = this.Expect(FilterTokenType.Function);
      FunctionNode functionNode = new FunctionNode()
      {
        FilterOperator = token.ToFilterOperator()
      };
      this.Expect(FilterTokenType.LeftParenthesis);
      functionNode.Arguments.Add(this.Expression());
      while (this.Is(FilterTokenType.Comma))
      {
        this.Expect(FilterTokenType.Comma);
        functionNode.Arguments.Add(this.Expression());
      }
      this.Expect(FilterTokenType.RightParenthesis);
      return (IFilterNode) functionNode;
    }

    private FilterToken Expect(FilterTokenType tokenType)
    {
      if (!this.Is(tokenType))
        throw new FilterParserException("Expected " + tokenType.ToString());
      FilterToken filterToken = this.Peek();
      ++this.currentTokenIndex;
      return filterToken;
    }

    private bool Is(FilterTokenType tokenType)
    {
      FilterToken filterToken = this.Peek();
      return filterToken != null && filterToken.TokenType == tokenType;
    }

    private FilterToken Peek() => this.currentTokenIndex < this.tokens.Count ? this.tokens[this.currentTokenIndex] : (FilterToken) null;
  }
}
