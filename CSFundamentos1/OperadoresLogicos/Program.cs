﻿Console.WriteLine("## Operadores Lógivos ##\n");

bool c1 = 5 >= 7;
bool c2 = 9 != 8;
bool resultado;

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c1 = {c2}");

//operador AND --> &&
resultado = c1 && c2;
Console.WriteLine($"Operador AND(&&): {resultado}");

//operador OR --> ||
resultado = c1 || c2;
Console.WriteLine($"Operador OR(||): {resultado}");

//operador NOT --> !
resultado = !c1;
Console.WriteLine($"Operador NOT(!): {resultado}");

Console.ReadLine();