namespace Formula;

public abstract class Formula
{
    public bool IsConstant { get; protected set; }
    protected double Value { get; set; }
    
    private Formula[] args;

    protected Formula(params Formula[] args)
    {
        this.args = args;
    }

    public double Evaluate()
    {
        if (IsConstant) return Value;
        if (!EvaluateInternal(out double result, args)) return result;
        IsConstant = true;
        Value = result;
        return result;
    }

    /// <returns>Whether the result is constant or not.</returns>
    protected abstract bool EvaluateInternal(out double result, params Formula[] args);
}

public class FormulaDoubleConstant : Formula
{
    public FormulaDoubleConstant(double value)
    {
        Value = value;
        IsConstant = true;
    }
    
    protected override bool EvaluateInternal(out double result, params Formula[] args)
    {
        throw new InvalidOperationException("Cannot evaluate a constant formula.");
    }
}