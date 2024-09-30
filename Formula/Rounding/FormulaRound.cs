namespace Formula.Rounding;

public class FormulaRound : Formula
{
    public FormulaRound(FormulaDoubleConstant num, int digits = 0) : base(num, new FormulaDoubleConstant(digits))
    {
        
    }
    
    protected override bool EvaluateInternal(out double result, params Formula[] args)
    {
        result = Math.Round(args[0].Evaluate(), (int)args[1].Evaluate());
        return args[0].IsConstant;
    }
}