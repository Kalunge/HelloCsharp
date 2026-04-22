// Invoice generating App

Console.WriteLine("Generating Invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoide: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");

Console.Write(@"c:\invoices");  

// Verbatim String literal
// Console.WriteLine(@" c:\source\repos
//     (this is where your code goes)");
// Kon'nichiwa World
// Console.WriteLine("\u3053\u3093\u306B\u306F World!");
    
// Generating Japanese Invoices
// Nihon no seikyu-sho o seisei suru ni wa:
Console.Write("\n\nu65e5\u672c\u306e\ubacb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t"); 
// User command to run the application
Console.WriteLine(@"c:\invoices\AppContext.exe -j");