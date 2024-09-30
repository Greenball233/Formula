namespace Formula.Exponentiation;

public class FormulaLogarithm : Formula
{
    public FormulaLogarithm(FormulaDoubleConstant anti, FormulaDoubleConstant @base) : base(anti, @base)
    {
        
    }
    
    protected override bool EvaluateInternal(out double result, params Formula[] args)
    {
        result = Math.Log(args[0].Evaluate(), args[1].Evaluate());
        return args[0].IsConstant && args[1].IsConstant;
    }
}