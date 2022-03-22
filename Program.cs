// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
/*
char[] characters = { 'V', 'a', 'l', 'e', 'r', 'a' };
string myName = new string(characters);

string equals = "valera";

for (int i = 0; i < myName.Length; i++)
{
    Console.WriteLine(myName[i]);
}

Console.WriteLine(myName);

Console.WriteLine($"Is {equals} the same as {myName}? \n{equals.Equals(myName, StringComparison.OrdinalIgnoreCase)}");


double price = 0.1234567;
int num = 30200000;
string formatedString = String.Format("The price is {0} {1} eur", price, "$");

string formatedString2 = $"The price is {price.ToString("P")} {num} {myName} eur";
Console.WriteLine(num.ToString("N"));  

Console.WriteLine(formatedString);

Console.WriteLine(formatedString2);
*/
/* 
char[] data = { 'a', 'b', 'c' };

string str = new string(data);

foreach (char c in data)
{
    Console.Write(c);
}
Console.WriteLine();
float price = 0.1234567f;
int num = 302;
String formatedString = String.Format("The price is {0} eur", price.ToString("0.00"));
Console.WriteLine(formatedString);  

string numStr = String.Format("Number {0, 0:D5}", num);
Console.WriteLine(numStr);

// Decimal formatting  
decimal money = 99.95m;
string moneyStr = String.Format("Money {0, 0:C2}", money);
Console.WriteLine(moneyStr);

// DateTime formatting  
DateTime now = DateTime.Now;
string dtStr = String.Format("{0:d} at {0:t}", now);
Console.WriteLine(dtStr);


Console.WriteLine(str.Equals("aBc", StringComparison.OrdinalIgnoreCase));
Console.WriteLine(str);
string answerInString = "true";
bool answerInBoolean = bool.Parse(answerInString);
Console.WriteLine(answerInBoolean);

float numb = 7834f;
Console.WriteLine($"C -> {numb:c5}");

String data1 = String.Format("{0,-35} {1,-20} {2,-10} {3, -10} \n",
"Title", "Publisher", "Price", "Year");
Console.WriteLine(data1);
*/














// Step 1: create new Regex.
Regex regex = new Regex(@"\d+");

// Step 2: call Match on Regex instance.
Match match = regex.Match("a55516afafaf515");

// Step 3: test for Success.
if (match.Success)
{
    Console.WriteLine("MATCH VALUE: " + match.Value);
}
Console.WriteLine(regex.IsMatch("a55a"));



string loremIpsumString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Mattis pellentesque id nibh tortor id. Diam volutpat commodo sed egestas egestas. Suspendisse faucibus interdum posuere lorem ipsum dolor sit amet. Tellus elementum sagittis vitae et leo duis ut diam. Sed id semper risus in hendrerit gravida rutrum quisque. Sed id semper risus in. Malesuada fames ac turpis egestas maecenas pharetra convallis posuere morbi. Ullamcorper dignissim cras tincidunt lobortis feugiat vivamus at. Dolor morbi non arcu risus quis varius. Tristique sollicitudin nibh sit amet commodo nulla facilisi. Vel risus commodo viverra maecenas accumsan. Lorem";

Regex regex2 = new Regex("Lorem"); // ^ -  text should start // .* -  any character any number of times // $ends with specific text


Console.WriteLine($"This should match a word - Lorem {regex2.IsMatch(loremIpsumString)}");

String bankIBAN1 = "LV30UNLA0987654321231"; // correct format
String bankIBAN2 = "LV300UNLA098765432123"; // uncorrect format
Regex re = new Regex("[A-Z]{2}[0-9]{2}[A-Z]{4}[0-9]{13}");
if(re.IsMatch(bankIBAN1))
{
    Console.WriteLine($"{bankIBAN1} is in correct format!");
}
//true
if (re.IsMatch(bankIBAN2))
{

}
else
{
    Console.WriteLine($"{bankIBAN2} is in incorrect format!");
}
