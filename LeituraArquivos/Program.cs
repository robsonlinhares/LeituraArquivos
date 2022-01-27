const string filePath = @"C:\Labs\arquivo.txt";

//var data = File.ReadAllText(filePath);
//Console.WriteLine(data);

//var data = File.ReadAllLines(filePath);
//var count = 0;

//foreach (var line in data)
//{
//    count++;
//    Console.WriteLine($"Linha: {count} - {line}");
//}

using var file = new StreamReader(filePath);
string? line;

while ((line = file.ReadLine()) != null)
    Console.WriteLine(line);

file.Close();
