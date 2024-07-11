// Ejercicio 1
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// ● Filtrar y mostrar solo los números pares de la lista numbers.
var pares = numbers.Where(n => n % 2 == 0).ToList();
Console.WriteLine("Números pares de la lista:");
foreach (var item in pares)
{
    Console.WriteLine(item);
}

// ● Usando LINQ, calcular la suma de todos los números impares en la lista numbers.
var sumaImpares = numbers.Where(n => n % 2 != 0).Sum();
Console.WriteLine("La suma de los números impares es: " + sumaImpares);

// ● Ordenar de manera descendente los números mayores que 5 en la lista numbers.
var descendente = numbers.Where(n => n > 5).OrderByDescending(n => n).ToList();
Console.WriteLine("Ordenar de manera descendente:");
foreach (var item in descendente)
{
    Console.WriteLine(item);
}

// ● Contar cuántos números son menores o iguales a 3 en la lista numbers.
var contar = numbers.Count(n => n <= 3);
Console.WriteLine("Números menores o iguales a 3: " + contar);

// ● Seleccionar cada número en la lista numbers y multiplicarlo por 2.
var multiplicado = numbers.Select(n => n * 2);
Console.WriteLine("Números multiplicados de la lista:");
foreach (var item in multiplicado)
{
    Console.WriteLine(item);
}

//Ejercicio 2
List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

// ● Ordenar los nombres en la lista names alfabéticamente.
var ordenados = names.OrderBy(n => n).ToList();
Console.WriteLine("Ordenar alfabéticamente:");
foreach (var item in ordenados)
{
    Console.WriteLine(item);
}
// ● Seleccionar los nombres en la lista names que empiezan con la letra 'A'.
var aLetra = names.Where(n => n.StartsWith("A")).ToList();
Console.WriteLine("Nombres que empiezan con 'A':");
foreach (var item in aLetra)
{
    Console.WriteLine(item);
}

// ● Contar cuántos nombres en la lista names tienen más de 5 caracteres.
var mayores5 = names.Count(n => n.Length > 5);
Console.WriteLine("Nombres con más de 5 caracteres: " + mayores5);

// ● Concatenar todos los nombres de la lista names en una sola cadena separada por espacios.
var concatenado = string.Join(" ", names);
Console.WriteLine("Nombres concatenados: " + concatenado);

// ● Encontrar y mostrar el nombre más largo en la lista names.
var maximo = names.OrderByDescending(n => n.Length).FirstOrDefault();
Console.WriteLine("Nombres más largo: " + maximo);

//Ejercicio 3
List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };

// ● Verificar si todas las palabras en la lista words tienen más de 3 caracteres.
var todasMayores = words.All(w => w.Length > 3);
Console.WriteLine("Todas las palabras tienen más de 3 caracteres: " + todasMayores);

// ● Encontrar y mostrar la primera palabra en la lista words que empieza con la letra 'b'.
var encontradosB = words.FirstOrDefault(w => w.StartsWith("b"));
Console.WriteLine("Primera palabra que empieza con 'b': " + encontradosB);

// ● Contar cuántas palabras en la lista words contienen la letra 'e'.
var contenganE = words.Count(w => w.Contains("e"));
Console.WriteLine("Primera palabra que empieza con 'e': " + contenganE);

// ● Seleccionar todas las palabras en la lista words y convertirlas a mayúsculas.
var mayusculas = words.Select(w => w.ToUpper());
Console.WriteLine("Palabras en mayúsculas:");
foreach (var item in mayusculas)
{
    Console.WriteLine(item);
}

// ● Verificar si alguna palabra en la lista words termina con la letra 'y'.
var terminaY = words.Any(n => n.EndsWith("y"));
Console.WriteLine("Alguna palabra termina con 'y': " + terminaY);

//Ejercicio 4
List<int> data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9 };
List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13 };

// ● Combinar y ordenar las listas data y moreData de forma ascendente.
var combinadosOrdenados = data.Concat(moreData).OrderBy(n => n);
Console.WriteLine("Lista combinada y ordenada: ");
foreach (var item in combinadosOrdenados)
{
    Console.WriteLine(item);
}

// ● Calcular la suma de todos los números pares en la lista data.
var suma = data.Where(n => n % 2 == 0).Sum();
Console.WriteLine("Suma de números pares en data: " + suma);

// ● Encontrar el número más grande en la lista data.
var numeroGrande = data.OrderByDescending(n => n).FirstOrDefault();
Console.WriteLine("Número más grande en data: " + numeroGrande);

// ● Unir las listas data y moreData, eliminando los elementos duplicados.
var unidos = data.Union(moreData).Distinct();
Console.WriteLine("Unidos sin duplicados: ");
foreach (var item in unidos)
{
    Console.WriteLine(item);
}

// ● Calcular el promedio de la lista moreData y seleccionar los números en data que son mayores que ese promedio.
var promedioMoreData = moreData.Average();
var mayoresPromedio = moreData.Where(n => n > promedioMoreData);
Console.WriteLine("Números en data mayores que el promedio de moreData: ");
foreach (var numero in mayoresPromedio)
{
    Console.WriteLine(numero);
}

// ● Contar cuántos números en la lista moreData son números primos(te recomiendo crear una función independiente que valide si el número es primo o no lo es, luego esa funciona pasala al método LINQ adecuado).
static bool EsPrimo(int num)
{
    if (num <= 1) return false;
    if (num <= 3) return true;
    if (num % 2 == 0 || num % 3 == 0) return false;

    int i = 5;
    while (i * i <= num)
    {
        if (num % i == 0 || num % (i + 2) == 0) return false;
        i += 6;
    }
    return true;
}
var primosMoreData = moreData.Count(n=>EsPrimo(n));
Console.WriteLine("Números en moreData que son primos: " + primosMoreData);