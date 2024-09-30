namespace Formula.Trigonometric;

public class FormulaSine : Formula
{
    private readonly bool _isRadian;
    
    public FormulaSine(FormulaDoubleConstant angle, bool isRadian = true) : base(angle)
    {
        _isRadian = isRadian;
    }
    
    protected override bool EvaluateInternal(out double result, params Formula[] args)
    {
        result = Math.Sin(_isRadian ? args[0].Evaluate() : args[0].Evaluate() / 180 * Math.PI);
        return args[0].IsConstant;
    }
}