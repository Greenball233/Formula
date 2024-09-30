namespace Formula.Other;

public class FormulaRadianToDegree : Formula
{
    public FormulaRadianToDegree(FormulaDoubleConstant num) : base(num)
    {
    }

    protected override bool EvaluateInternal(out double result, params Formula[] args)
    {
        result = args[0].Evaluate() / Math.PI * 180.0;
        return args[0].IsConstant;
    }
}