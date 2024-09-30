namespace Formula.Exponentiation;

public class FormulaPower : Formula
{
    public FormulaPower(FormulaDoubleConstant @base, FormulaDoubleConstant power) : base(@base, power)
    {
        
    }
    
    protected override bool EvaluateInternal(out double result, params Formula[] args)
    {
        result = Math.Pow(args[0].Evaluate(), args[1].Evaluate());
        return args[0].IsConstant && args[1].IsConstant;
    }
}