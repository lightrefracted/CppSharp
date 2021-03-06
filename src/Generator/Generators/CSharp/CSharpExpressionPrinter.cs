﻿using CppSharp.AST;
using CppSharp.Types;

namespace CppSharp.Generators.CSharp
{
    public class CSharpExpressionPrinterResult
    {
        public string Value;

        public override string ToString()
        {
            return Value;
        }
    }

    public static class CSharpExpressionPrinterExtensions
    {
        public static CSharpExpressionPrinterResult CSharpValue(this Expression value,
            CSharpExpressionPrinter printer)
        {
            return value.Visit(printer);
        }

    }
    public class CSharpExpressionPrinter : IExpressionPrinter<CSharpExpressionPrinterResult>,
        IExpressionVisitor<CSharpExpressionPrinterResult>
    {
        public CSharpExpressionPrinterResult VisitBuiltinExpression(BuiltinTypeExpression builtinType)
        {
            return new CSharpExpressionPrinterResult()
            {
                Value = builtinType.ToString(),
            };
        }

        public string ToString(Type type)
        {
            throw new System.NotImplementedException();
        }
    }
}