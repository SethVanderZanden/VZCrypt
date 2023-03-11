// See https://aka.ms/new-console-template for more information
using VZCrypt;

Console.WriteLine("Hello, World!");

string test = "Thisisasentence";

string key = "";
key = key.GenerateKey();

Console.WriteLine(key);
test = test.EncryptString(key);
Console.WriteLine(test);
var test2 = test.DecryptString(key);
Console.WriteLine(test2);