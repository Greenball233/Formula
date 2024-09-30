namespace Formula.Arithmetic;

public class FormulaMultiply : Formula
{
    public FormulaMultiply(FormulaDoubleConstant num1, FormulaDoubleConstant num2) : base(num1, num2)
    {
        
    }

    protected override bool EvaluateInternal(out double result, params Formula[] args)
    {
        result = args[0].Evaluate() * args[1].Evaluate();
        return args[0].IsConstant && args[1].IsConstant;
    }
}