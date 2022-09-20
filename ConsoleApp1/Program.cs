using System.Security.Principal;
using System.Threading.Channels;


/*string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

/*Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);#1#
openingPosition += 1;
int length = closingPosition - openingPosition;

Console.WriteLine(message.Substring(openingPosition,length));*/

/*string message = "What is the value <span>between the tags</span>";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPostition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPostition - openingPosition;
Console.WriteLine(message.Substring(openingPosition,length));*/
/*
string customerName = "Mr. Jones";


string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine("");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}");
Console.WriteLine("");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.Given your current volume, your potential profit would be {newProfit:C}");

Console.WriteLine("Here's a quick comparison:\n");
Console.WriteLine($"Here a thing {currentProduct}");


string comparisonMessage = "";
*/

// Your logic here


//comparisonMessage = String.Format("{0}{1:P2}        {2:C}\n{3}{4:P2}        {5:C}", currentProduct.PadRight(25),currentReturn,currentProfit,newProduct.PadRight(25),newReturn,newProfit);


//comparisonMessage += currentProduct.PadRight(25)+ currentReturn.ToString().PadRight(25) + currentProfit + "\n" + newProduct.PadRight(25) + newReturn.ToString().PadRight(25) + newProfit;


/*comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);



comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);*/

/*string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);*/



/*const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
const string openSpan = "<span>";
const string closeSpan = "</span>";
const string openDiv = "<div>";
const string closeDiv = "</div>";

string quantity = "";
string output = "";
quantity += "Quantity: ";


// Your work here
int openingPosition = input.IndexOf(openSpan);
int closingPosition = input.IndexOf(closeSpan);
openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
quantity += input.Substring(openingPosition, length);
Console.WriteLine(quantity);

openingPosition = input.IndexOf(openDiv);
closingPosition = input.IndexOf(closeDiv);
openingPosition += openDiv.Length;
length = closingPosition - openingPosition;
output = input.Substring(openingPosition, length);
output = output.Replace("&trade", "&reg");
Console.WriteLine(output);*/

/*const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string spanTag = "<span>";

//Quantity Extraction
int quantityStart = input.IndexOf(spanTag);
int quantityEnd = input.IndexOf("</span>");
quantityStart += spanTag.Length;
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);

output = input.Replace("&trade", "&reg");

//Remove the opening <div> tag
int divStart = input.IndexOf("<div");
int divEnd = input.IndexOf(">");
int divLength = divEnd - divStart;
divLength += 1;
output = output.Remove(divStart, divLength);

//Remove the closing <div> tag
int divCloseStart = output.IndexOf("</div");
int divCloseEnd = output.IndexOf(">", divCloseStart);
int divCloseLength = divCloseEnd - divCloseStart;
divCloseLength += 1;
output = output.Remove(divCloseStart, divCloseLength);

Console.WriteLine($"Quantity : {quantity}");
Console.WriteLine($"Output: {output}");
*/
dynamic[] array1 = null;
int[] array2 = { 1, 2, 3 };
string message = array1?.Length.ToString()??"Empty array";
//Console.WriteLine(array1?[0]?"empty":"not empty"));
//Console.WriteLine(message);