// String.Empty // по умолчанию строки инициализируются как пустая строка
// индексы начинаются с 0 и похэтому таблица "2 строки и 5 столбцов" будет выглядить вот так:
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]


// string[,] table = new string[2,5]; // 2 строки и 5 столбцов
// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++) // идем по строчкам
// {
//     for (int columns = 0; columns < 5; columns++) // идем по колонкам
//     {
//     Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


int [,] matrix  = new int [3, 4];

// for (int i = 0; i < 3; i++) // идем по строчкам
// {
//     for (int j = 0; j < 4; j++) // идем по колонкам
//     {
//     Console.Write($" {matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

for (int i = 0; i < matrix.GetLength(0); i++) // идем по строчкам
{
    for (int j = 0; j < matrix.GetLength(1); j++) // идем по колонкам
    {
    Console.Write($" {matrix[i, j]} ");
    }
    Console.WriteLine();
}