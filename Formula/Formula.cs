namespace Formula;

public abstract class Formula
{
    public bool IsConstant { get; protected set; }
    protected double Value { get; set; }

    private readonly Formula[] _args;

    protected Formula(params Formula[] args)
    {
        _args = args;
    }

    public double Evaluate()
    {
        if (IsConstant) return Value;
        if (!EvaluateInternal(out double result, _args)) return result;
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

public class FormulaVariable : Formula
{
    public string Name { get; private set; }

    private readonly Func<double> _action;

    public FormulaVariable(string name, Func<double> action)
    {
        Name = name;
        _action = action;
    }

    protected override bool EvaluateInternal(out double result, params Formula[] args)
    {
        result = _action();
        return false;
    }
}