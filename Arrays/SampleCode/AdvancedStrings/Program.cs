string s = "C# is Awesome";

Console.WriteLine(s[0]); // 'C'
Console.WriteLine(s[6]); // 'A'

for (int i = 0; i < s.Length; i++)
{
	Console.WriteLine(s[i]);
}

string s2 = s.ToUpper();
Console.WriteLine(s2);
s2 = s.ToLower();
Console.WriteLine(s2);

s2 = s.Replace("Awesome", "Amazing");
Console.WriteLine(s2);

Console.WriteLine(s.Substring(7));    // wesome
Console.WriteLine(s.Substring(7, 3)); // wes

int index;

index = s.IndexOf("z");   
Console.WriteLine(index);  // -1
index = s.IndexOf("e");    
Console.WriteLine(index);  // 8
index = s.IndexOf("e", 9);
Console.WriteLine(index);  // 12

Console.WriteLine(s.StartsWith("C#")); // true
Console.WriteLine(s.EndsWith("zzz"));  // false

s2 = s.Trim(); // trims all leading and trailing spaces
s2 = s.TrimEnd(); // trims only trailing spaces
s2 = s.TrimStart(); // trims only starting spaces

string address = "Jane Doe,100 Main St.,Pittsburgh,PA,20245";
string[] data = address.Split(",");

for (int i = 0; i < data.Length; i++)
{
	Console.WriteLine($"{data[i]}");
}

int[] nums = { 1, 3, 5, 7, 9 };

s2 = string.Join(", ", nums);
Console.WriteLine(s2);