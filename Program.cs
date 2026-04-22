string projectName = "ACME";
string russianMessage = "\u041f\u043e\u04441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string englishOutput = "View English output:";

Console.WriteLine($@"{englishOutput} 
    c:Exercise\{projectName}\data.txt");

Console.WriteLine($@"{russianMessage}:
    c:\Exercise\{projectName}\ru-Ru\data.txt");

