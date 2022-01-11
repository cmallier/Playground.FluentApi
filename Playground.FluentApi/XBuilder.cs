namespace Playground.FluentApi;

public class XBuilder
{
    // Private fields
    private string? _parameterOne;
    private string? _parameterTwo;
    private string? _parameterThree;
    private string? _parameterFour;


    public XBuilder ForParameterOne( string parameterOne )
    {
        _parameterOne = parameterOne;
        return this;
    }

    public XBuilder ForParameterTwo( string parameterTwo )
    {
        _parameterTwo = parameterTwo;
        return this;
    }

    public XBuilder ForParameterThree( string parameterThree )
    {
        _parameterThree = parameterThree;
        return this;
    }

    public XBuilder ForParameterFour( string parameterFour )
    {
        _parameterFour = parameterFour;
        return this;
    }


    public string Build()
    {
        return $"p1: {_parameterOne} p2: {_parameterTwo} p3: {_parameterThree} p4: {_parameterFour}";
    }
}
