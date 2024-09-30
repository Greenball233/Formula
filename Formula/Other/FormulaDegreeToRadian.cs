namespace Formula.Other;

public class FormulaDegreeToRadian : Formula
{
    public FormulaDegreeToRadian(FormulaDoubleConstant num) : base(num)
    {
    }
    protected override bool EvaluateInternal(out double result, params Formula[] args)
    {
        result = args[0].Evaluate() / 180.0 * Math.PI;
        return args[0].IsConstant;
    }
}