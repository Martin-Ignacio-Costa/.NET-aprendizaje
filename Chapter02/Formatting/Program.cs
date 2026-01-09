using System.Globalization;


CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
    );

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
    );

WriteLine("{0} {1} lived in {2}.",
    arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");

WriteLine("{0} {1} lived in {2}.",
    "Roger", "Cevung", "Stockholm");

//WriteLine("{0} {1} lived in {2} and worked in the {3} team at {4}.",
//    arg0: "Roger", arg1: "Cevung", arg2: "Stockholm", arg3: "Education", arg4: "Optmizely");

WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
WriteLine();

WriteLine(format: "{0,-10} {1,6}",
    "Name", "Count");

WriteLine(format: "{0,-10} {1,6:N0}",
    applesText, applesCount);

WriteLine(format: "{0,-10} {1,6:N0}",
    bananasText, bananasCount);

decimal value = 0.325M;
WriteLine("Currency: {0:C}, Percentage: {0:0.0%}", value);

WriteLine("Type your first name and press ENTER: ");
string? firstName = ReadLine();
WriteLine("Type your age and press ENTER: ");
string age = ReadLine()!;
WriteLine($"Hello {firstName}, you look good for {age}.");