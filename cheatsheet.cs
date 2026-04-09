using System;

// ============================================================
//  CHEATSHEET — 10/04/2026 DAY 1
// ------------------------------------------------------------

class Cheatsheet
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Section1_Variables();
        Section2_Nullable();
        Section3_StringInterpolation();
        Section4_VerbatimStrings();
        Section5_Arithmetic();
        Section6_Modulo();
        Section7_Comparison();
        Section8_Logical();
        Section9_IfElse();
        Section10_WhileLoop();
        Section11_Methods();
        Section12_MathClass();
        // Section13_SafeInput() — commented out, it blocks waiting for input.
        // Uncomment and run separately to test it.
        // Section13_SafeInput();
    }

    // ============================================================
    // SECTION 1 — VARIABLES AND TYPES
    // ============================================================
    // Every variable has a TYPE. The type decides what the box holds.
    // Declaration = make the box. Assignment = put something in it.
    // `var` = lazy mode; compiler infers the type from the value.
    // SUFFIXES: `L` = long literal, `m` = decimal literal.
    // RULE: money = decimal, not double. Double loses precision.
    // ============================================================
    static void Section1_Variables()
    {
        Console.WriteLine("\n== SECTION 1: VARIABLES ==");

        // Explicit types
        int jobNumber = 26104;
        string clientName = "NSW Surveys";
        double lotArea = 612.5;
        bool isSignedOff = false;
        decimal invoiceAmount = 1250.00m;   // 'm' suffix = decimal
        long bigNumber = 999999999999L;     // 'L' suffix = long
        char grade = 'A';                   // single quotes for char

        // var — compiler infers the type
        var inferredInt = 69;               // compiler sees int
        var inferredString = "hello";       // compiler sees string
        var inferredDouble = 3.14;          // compiler sees double
        var inferredDecimal = 3.14m;        // compiler sees decimal (because of 'm')

        Console.WriteLine($"Job: {jobNumber}, Client: {clientName}");
        Console.WriteLine($"Lot: {lotArea}, Signed: {isSignedOff}, Invoice: {invoiceAmount}");
        Console.WriteLine($"Big: {bigNumber}, Grade: {grade}");
        Console.WriteLine($"var inferred: {inferredInt}, {inferredString}, {inferredDouble}, {inferredDecimal}");

        // GOTCHA: 3.50 (no suffix) is a DOUBLE, not a decimal.
        // Doubles don't track trailing zeros — this prints "3.5" not "3.50".
        double trailingZero = 3.50;
        decimal trailingZeroDec = 3.50m;
        Console.WriteLine($"double 3.50 prints as: {trailingZero}   (loses the zero)");
        Console.WriteLine($"decimal 3.50m prints as: {trailingZeroDec}   (keeps the zero)");
    }

    // ============================================================
    // SECTION 2 — NULLABLE TYPES
    // ============================================================
    // `string?` means "string that is allowed to be null".
    // `int?`, `bool?`, `double?` etc — value types need the ? too.
    // Without the ?, the compiler won't let you assign null.
    // ============================================================
    static void Section2_Nullable()
    {
        Console.WriteLine("\n== SECTION 2: NULLABLE ==");

        string? maybeName = null;       // allowed because of ?
        maybeName = "PTE WU";           // reassign later
        Console.WriteLine($"maybeName: {maybeName}");

        int? maybeScore = null;         // int that can hold null
        maybeScore = 85;
        Console.WriteLine($"maybeScore: {maybeScore}");

        // Without the ?, this would be a compile error:
        // int forbidden = null;         // ERROR
    }

    // ============================================================
    // SECTION 3 — STRING INTERPOLATION
    // ============================================================
    // $"..."  → embed variables directly in a string with {braces}.
    // No more "hello " + name + ", you are " + age — that's the old way.
    // ============================================================
    static void Section3_StringInterpolation()
    {
        Console.WriteLine("\n== SECTION 3: STRING INTERPOLATION ==");

        string name = "PTE WU";
        int age = 29;
        double height = 1.80;

        // $ prefix + {variable} inside the string
        Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}m");

        // You can put expressions inside the braces, not just variables
        Console.WriteLine($"Next year: {age + 1}");
        Console.WriteLine($"Height in cm: {height * 100}");
    }

    // ============================================================
    // SECTION 4 — VERBATIM STRINGS
    // ============================================================
    // @"..." → treat the string LITERALLY.
    // No escape sequences, newlines preserved, backslashes are backslashes.
    // Use for: file paths, multiline text, ASCII art.
    // ============================================================
    static void Section4_VerbatimStrings()
    {
        Console.WriteLine("\n== SECTION 4: VERBATIM STRINGS ==");

        // Normal string — \n is a newline
        string normal = "Line 1\nLine 2";
        Console.WriteLine(normal);

        // Verbatim string — \n is literally a backslash and an n
        string verbatim = @"C:\Users\PTE_WU\Documents";
        Console.WriteLine(verbatim);

        // Multiline verbatim string — newlines preserved as-is
        string art = @"
      _.-'''''-._
    .'  _     _  '.
   /   (o)   (o)   \
  |                 |
    '.  `'''''`  .'
      '-.......-'
";
        Console.WriteLine(art);
    }

    // ============================================================
    // SECTION 5 — ARITHMETIC OPERATORS
    // ============================================================
    // + - * / %   and casting with (double)
    // INT / INT = INT (decimal chopped off, not rounded).
    // To get a real decimal answer, at least one side must be double.
    // ============================================================
    static void Section5_Arithmetic()
    {
        Console.WriteLine("\n== SECTION 5: ARITHMETIC ==");

        int a = 17;
        int b = 5;

        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} * {b} = {a * b}");
        Console.WriteLine($"{a} / {b} = {a / b}         (int division, remainder chopped)");
        Console.WriteLine($"(double){a} / {b} = {(double)a / b}   (cast to get real answer)");

        // Compound assignment
        int x = 10;
        x += 5;     // x = x + 5   → 15
        x -= 2;     // x = x - 2   → 13
        x *= 2;     // x = x * 2   → 26
        x /= 4;     // x = x / 4   → 6
        x++;        // x = x + 1   → 7
        x--;        // x = x - 1   → 6
        Console.WriteLine($"After +=,-=,*=,/=,++,-- : {x}");
    }

    // ============================================================
    // SECTION 6 — MODULO (%)
    // ============================================================
    // % gives the REMAINDER after integer division.
    // 17 % 5 = 2 because 17 = 3*5 + 2.
    // NOT absolute value. Absolute value is Math.Abs().
    // USES: even/odd check, wrapping values, extracting last digit.
    // ============================================================
    static void Section6_Modulo()
    {
        Console.WriteLine("\n== SECTION 6: MODULO ==");

        Console.WriteLine($"17 % 5 = {17 % 5}   (remainder)");
        Console.WriteLine($"20 % 5 = {20 % 5}   (clean divide, remainder 0)");
        Console.WriteLine($"690 % 207 = {690 % 207}  (the puzzle: returns 69)");

        // Even/odd check
        int n = 8;
        bool isEven = (n % 2 == 0);
        Console.WriteLine($"{n} is even: {isEven}");
    }

    // ============================================================
    // SECTION 7 — COMPARISON OPERATORS
    // ============================================================
    // ==  equal to         (NOT = which is assignment)
    // !=  not equal to
    // <   less than
    // >   greater than
    // <=  less than or equal
    // >=  greater than or equal
    // All return a BOOL.
    // ============================================================
    static void Section7_Comparison()
    {
        Console.WriteLine("\n== SECTION 7: COMPARISON ==");

        int a = 5;
        int b = 10;

        Console.WriteLine($"{a} == {b} : {a == b}");
        Console.WriteLine($"{a} != {b} : {a != b}");
        Console.WriteLine($"{a} <  {b} : {a < b}");
        Console.WriteLine($"{a} >  {b} : {a > b}");
        Console.WriteLine($"{a} <= {b} : {a <= b}");
        Console.WriteLine($"{a} >= {b} : {a >= b}");

        // Strings compare by CONTENT with ==, not by reference
        string s1 = "hello";
        string s2 = "hello";
        Console.WriteLine($"\"{s1}\" == \"{s2}\" : {s1 == s2}");
    }

    // ============================================================
    // SECTION 8 — LOGICAL OPERATORS
    // ============================================================
    // &&  AND  (both must be true)
    // ||  OR   (at least one must be true)
    // !   NOT  (flips true/false)
    // SHORT-CIRCUIT: && and || stop early if the answer is already decided.
    // Use that for null checks: if (x != null && x.IsActive) — safe even if x is null.
    // ============================================================
    static void Section8_Logical()
    {
        Console.WriteLine("\n== SECTION 8: LOGICAL ==");

        bool isSignedOff = true;
        decimal invoice = 1250m;

        bool readyToClose = isSignedOff && invoice > 0;
        bool needsAttention = !isSignedOff || invoice == 0;
        bool eitherWay = isSignedOff || invoice > 0;

        Console.WriteLine($"readyToClose (AND)    : {readyToClose}");
        Console.WriteLine($"needsAttention (NOT/OR): {needsAttention}");
        Console.WriteLine($"eitherWay (OR)        : {eitherWay}");
    }

    // ============================================================
    // SECTION 9 — IF / ELSE / ELSE IF
    // ============================================================
    // if (bool) { ... } else if (bool) { ... } else { ... }
    // Top to bottom, first match wins.
    // ALWAYS use braces even for one-liners. No exceptions.
    // ============================================================
    static void Section9_IfElse()
    {
        Console.WriteLine("\n== SECTION 9: IF/ELSE ==");

        int score = 75;

        if (score >= 90)
        {
            Console.WriteLine("Excellent");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Good");
        }
        else if (score >= 50)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }

    // ============================================================
    // SECTION 10 — WHILE LOOP
    // ============================================================
    // while (condition) { body }
    // Runs body as long as condition is true.
    // INFINITE LOOP DANGER: something inside must eventually change the condition.
    // Two common patterns:
    //   1. FLAG PATTERN: bool running = true; while (running) { ... running = false; }
    //   2. WHILE TRUE + BREAK: while (true) { ... if (done) break; }
    // break    = exit the loop entirely
    // continue = skip to the top of the loop, re-check condition
    // ============================================================
    static void Section10_WhileLoop()
    {
        Console.WriteLine("\n== SECTION 10: WHILE LOOP ==");

        // Pattern 1 — flag
        int i = 0;
        bool running = true;
        while (running)
        {
            Console.Write($"{i} ");
            i++;
            if (i >= 5) running = false;
        }
        Console.WriteLine();

        // Pattern 2 — while(true) + break
        int j = 0;
        while (true)
        {
            Console.Write($"{j} ");
            j++;
            if (j >= 5) break;
        }
        Console.WriteLine();
    }

    // ============================================================
    // SECTION 11 — METHODS
    // ============================================================
    // Declaration = the recipe. Call = tell someone to follow it.
    // `static` = belongs to the class itself, no instance needed.
    // `void`   = returns nothing.
    // Parentheses matter: Sex  (the method), Sex()  (run the method).
    // Methods can call other methods. Main → Greet → Farewell etc.
    // ============================================================
    static void Section11_Methods()
    {
        Console.WriteLine("\n== SECTION 11: METHODS ==");
        Greet();
        Greet();
        Greet();
    }

    static void Greet()
    {
        Console.WriteLine("G'day PTE WU");
        Farewell();
    }

    static void Farewell()
    {
        Console.WriteLine("  (and out)");
    }

    // ============================================================
    // SECTION 12 — MATH CLASS
    // ============================================================
    // Math.Abs(x)      — absolute value (strip the sign)
    // Math.Min(a, b)   — smaller of two
    // Math.Max(a, b)   — larger of two
    // Math.Round(x)    — round to nearest
    // Math.Floor(x)    — always round down
    // Math.Ceiling(x)  — always round up
    // Math.Sqrt(x)     — square root
    // Math.Pow(x, y)   — x to the power of y
    // Math.PI          — the constant 3.14159...
    // ============================================================
    static void Section12_MathClass()
    {
        Console.WriteLine("\n== SECTION 12: MATH ==");
        Console.WriteLine($"Math.Abs(-7)     = {Math.Abs(-7)}");
        Console.WriteLine($"Math.Min(3, 9)   = {Math.Min(3, 9)}");
        Console.WriteLine($"Math.Max(3, 9)   = {Math.Max(3, 9)}");
        Console.WriteLine($"Math.Round(3.7)  = {Math.Round(3.7)}");
        Console.WriteLine($"Math.Floor(3.7)  = {Math.Floor(3.7)}");
        Console.WriteLine($"Math.Ceiling(3.2)= {Math.Ceiling(3.2)}");
        Console.WriteLine($"Math.Sqrt(16)    = {Math.Sqrt(16)}");
        Console.WriteLine($"Math.Pow(2, 10)  = {Math.Pow(2, 10)}");
        Console.WriteLine($"Math.PI          = {Math.PI}");
    }

    // ============================================================
    // SECTION 13 — SAFE USER INPUT (commented out — blocks on input)
    // ============================================================
    // Console.ReadLine()  — reads a whole line as string (waits for Enter)
    // Console.Read()      — reads ONE character and returns its ASCII code.
    //                       Almost never what you want. Use ReadLine instead.
    // int.Parse(s)        — converts string to int. CRASHES on bad input.
    // int.TryParse(s, out result) — tries to convert. Returns bool (success?).
    //                              The parsed value goes into `result`.
    //                              Doesn't crash on bad input. USE THIS.
    // `out` keyword — lets a method return a second value via a parameter.
    // ============================================================
    static void Section13_SafeInput()
    {
        while (true)
        {
            Console.Write("Enter a number: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                Console.WriteLine($"You entered: {result}");
                break;  // exit the loop, we got a valid number
            }
            else
            {
                Console.WriteLine($"'{input}' is not a number, try again.");
            }
        }
    }
}
