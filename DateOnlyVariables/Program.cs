
DateTime today = DateTime.Now;

DateOnly birthday = DateOnly.Parse(s: "6/11/1998");

Console.WriteLine(birthday.ToString(format: "MMMM dd, yyyy"));

Console.WriteLine(value: $"Today full format: {today}");        //DateTime full
Console.WriteLine(value: $"Today just date: {today.Date}");     //DateTime "date only" (has time set to midnight)
Console.WriteLine(value: $"Birthday full format: {birthday}");  //Date Only