using System;

string? linea1 = Console.ReadLine();
if (string.IsNullOrEmpty(linea1)) return;

int n = int.Parse(linea1);
string[] entrada = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

int[] numeros = new int[n];
for (int i = 0; i < n; i++)
{
    numeros[i] = int.Parse(entrada[i]);
}

// Lógica para encontrar el máximo
int maximo = numeros[0]; 
for (int i = 1; i < n; i++) {
    if (numeros[i] > maximo) maximo = numeros[i];
    
}

int maximo = numeros[0]; 
for (int i = 1; i < n; i++) {
    if (numeros[i] > maximo) maximo = numeros[i];
    
}

// Salida limpia (solo el número)
Console.WriteLine(maximo);
