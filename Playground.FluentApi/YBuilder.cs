namespace Playground.FluentApi;

public class YBuilder : IParameterOne, IParameterTwo, IParameterThree, IParameterFour, IYBuilder
{
    // Private fields
    private string _parameterOne;
    private string _parameterTwo;
    private string _parameterThree;
    private string _parameterFour;


    // Constructor
    private YBuilder()
    {
    }

    public static YBuilder Create()
    {
        return new YBuilder();
    }

    public IParameterTwo ForParameterOne( string parameterOne )
    {
        _parameterOne = parameterOne;
        return this;
    }

    public IParameterThree ForParameterTwo( string parameterTwo )
    {
        _parameterTwo = parameterTwo;
        return this;
    }

    public IParameterFour ForParameterThree( string parameterThree )
    {
        _parameterThree = parameterThree;
        return this;
    }

    public YBuilder ForParameterFour( string parameterFour )
    {
        _parameterFour = parameterFour;
        return this;
    }

    IYBuilder IParameterFour.ForParameterFour( string parameterFour )
    {
        _parameterFour = parameterFour;
        return this;
    }

    public string Build()
    {
        return $"p1: {_parameterOne} p2: {_parameterTwo} p3: {_parameterThree} p4: {_parameterFour}";
    }
}

public interface IParameterOne
{
    public IParameterTwo ForParameterOne( string parameterOne );
}

public interface IParameterTwo
{
    public IParameterThree ForParameterTwo( string parameterTwo );
}

public interface IParameterThree
{
    public IParameterFour ForParameterThree( string parameterThree );
}

public interface IParameterFour
{
    public IYBuilder ForParameterFour( string parameterFour );
}

public interface IYBuilder
{
    public string Build();
}