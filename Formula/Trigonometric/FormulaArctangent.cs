﻿namespace Formula.Trigonometric;

public class FormulaArctangent : Formula
{
    private readonly bool _isRadian;
    
    public FormulaArctangent(FormulaDoubleConstant value, bool isRadian = true) : base(value)
    {
        _isRadian = isRadian;
    }
    
    protected override bool EvaluateInternal(out double result, params Formula[] args)
    {
        double d = args[0].Evaluate();
        if (d is < -1 or > 1) throw new ArgumentException("The argument must be between -1 and 1.");
        result = Math.Atan(d);
        if (!_isRadian) result = result * 180 / Math.PI;
        return args[0].IsConstant;
    }
}