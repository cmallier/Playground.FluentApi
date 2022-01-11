using Playground.FluentApi;

namespace Playgroung.FlientApi;

class Program
{
    static void Main()
    {
        // Example 1 : Simple FluentApi
        string container = new XBuilder()
                               .ForParameterOne( "1" )
                               .ForParameterTwo( "2" )
                               .ForParameterThree( "3" )
                               .ForParameterFour( "4" )
                               .Build();

        Console.WriteLine( container );


        // Example 2 : Force parameters and order
        string container2 = YBuilder.Create()
                            .ForParameterOne( "1" )
                            .ForParameterTwo( "2" )
                            .ForParameterThree( "3" )
                            .ForParameterFour( "4" )
                            .Build();
        
        Console.WriteLine( container2 );
    }
}
