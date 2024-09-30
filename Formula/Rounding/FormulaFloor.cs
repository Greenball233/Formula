namespace Formula.Rounding;

public class FormulaFloor : Formula
{
    public FormulaFloor(FormulaDoubleConstant num) : base(num)
    {
        
    }
    
    protected override bool EvaluateInternal(out double result, params Formula[] args)
    {
        result = Math.Floor(args[0].Evaluate());
        return args[0].IsConstant;
    }
}