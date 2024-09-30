namespace Formula.Rounding;

public class FormulaCeiling : Formula
{
    public FormulaCeiling(FormulaDoubleConstant num) : base(num)
    {
        
    }
    
    protected override bool EvaluateInternal(out double result, params Formula[] args)
    {
        result = Math.Ceiling(args[0].Evaluate());
        return args[0].IsConstant;
    }
}