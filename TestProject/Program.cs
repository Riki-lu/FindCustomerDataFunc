// See https://aka.ms/new-console-template for more information
using static TestProject.Algorithm;
class Program
{
    static void Main(string[] args)
    {
        string demoQuery = "Connections| where DestinationEntityType =~'AadIdentity'| extend a = a + b |let x= where a > 10.0";
        string demoQuery1 = "FactTable | lookup kind=leftouter (DimensionTable) on CommonColumn, $left.Col1 == $right.Col2";
        string demoQuery2 = "Sales | summarize NumTransactions=count()";


        var cleanQuery =PassQueryReplaceSensitive(demoQuery1);
        Console.WriteLine("Source query: "+demoQuery1);
        cleanQuery = PassQueryReplaceSensitive(demoQuery);

        Console.WriteLine("New query: " + cleanQuery);
    }
}
