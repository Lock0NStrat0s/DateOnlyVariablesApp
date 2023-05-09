
DateTime today = DateTime.Now;

DateOnly birthday = DateOnly.Parse(s: "6/11/1998");

Console.WriteLine(birthday.ToString(format: "MMMM dd, yyyy"));

Console.WriteLine(value: $"Today full format: {today}");
Console.WriteLine(value: $"Today just date: {today.Date}");
Console.WriteLine(value: $"Birthday full format: {birthday}");