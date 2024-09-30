namespace Formula.Other;

public class FormulaAbsolute : Formula
{
    public FormulaAbsolute(FormulaDoubleConstant num) : base(num)
    {
    }
    
    protected override bool EvaluateInternal(out double result, params Formula[] args)
    {
        result = Math.Abs(args[0].Evaluate());
        return args[0].IsConstant;
    }
}