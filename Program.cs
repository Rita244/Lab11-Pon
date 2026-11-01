// ### Часть 1. List<T>


// using System;
// using System.Collections.Generic;

// public class Student
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
    
//     public Student(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         List<Student> students = new List<Student>
//         {
//             new Student("Иван", 20),
//             new Student("Мария", 19),
//             new Student("Петр", 21)
//         };

//         Console.WriteLine($"Всего студентов в списке: {students.Count}");

//         students.Add(new Student("Алексей", 22));
//         Console.WriteLine("Студент Алексей успешно добавлен.");

//         if (students.Count > 0)
//         {
//             students.RemoveAt(0);
//             Console.WriteLine("Первый студент удален.");
//         }

//         if (students.Count > 0)
//         {
//             Student firstStudent = students[0];
//             Console.WriteLine($"Первый студент в списке сейчас: {firstStudent.Name}, возраст: {firstStudent.Age}");
//         }

//         string searchName = "Мария";
//         bool isStudentExists = students.Exists(s => s.Name == searchName);

//         if (isStudentExists)
//             Console.WriteLine($"Студент с именем {searchName}: Есть");
//         else
//             Console.WriteLine($"Студента с именем {searchName}: Нет");

//         Console.WriteLine("Полный список студентов:");
//         foreach (Student student in students)
//         {
//             Console.WriteLine($"   - Имя: {student.Name}, Возраст: {student.Age}");
//         }
//     }
// }

// Синтаксис доступа по индексу идентичен — используются квадратные скобки [], нумерация с 0
// Массив имеет фиксированный размер и минимум методов
//Список (List<T>) — динамический (сам расширяется при добавлении элементов) 
//меет богатый набор встроенных методов (Add, Remove, Find)


// ### Часть 2. Dictionary<TKey,TValue>

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Dictionary<string, double> prices = new()
//         {
//             ["Хлеб"] = 45.5,
//             ["Молоко"] = 89
//         };

//         prices["Сыр"] = 350;
//         prices["Масло"] = 180;

//         Console.WriteLine($"Цена Хлеба: {prices["Хлеб"]}");

//         prices["Хлеб"] = 50; 
//         prices["Колбаса"] = 400; 

//         Console.WriteLine($"Количество товаров (Count): {prices.Count}");

//         if (prices.ContainsKey("Молоко"))
//             Console.WriteLine("Товар 'Молоко' есть в словаре.");

//         Console.Write("Введите название товара для поиска: ");
//         string searchItem = Console.ReadLine();

//         if (prices.TryGetValue(searchItem, out double price))
//             Console.WriteLine($"Цена товара '{searchItem}': {price}");
//         else
//             Console.WriteLine("Товар не найден.");

//         Console.WriteLine("\nСписок всех товаров:");
//         foreach (KeyValuePair<string, double> item in prices)
//         {
//             Console.WriteLine($"- {item.Key}: {item.Value}");
//         }
//     }
// }



// ---

// ### Часть 3. HashSet<T>


// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         string[] input = { "C#", "Git", "C#", "SQL", "Git", "C#" };
//         HashSet<string> uniqueTags = new HashSet<string>();

//         foreach (string item in input)
//         {
//             uniqueTags.Add(item);
//         }

//         Console.WriteLine($"В массиве: {input.Length}, Уникальных: {uniqueTags.Count}");

//         Console.Write("Введите технологию: ");
//         string searchTag = Console.ReadLine();

//         if (uniqueTags.Contains(searchTag))
//             Console.WriteLine("Есть");
//         else
//             Console.WriteLine("Нет");

//         HashSet<string> tags = new HashSet<string> { "C#", "Git", "C#", "SQL", "Git", "C#" };
//     }
// }

// Количество элементов меньше, потому что HashSet хранит только уникальные значения
// При попытке добавить дубликат
// его игнорирует и не увеличивает свой размер


// ### Часть 4. Выбор коллекции

// 1. Коллекция: List. Причина: это простой список,
// в который легко добавлять новые товары и удалять их
// 2. Коллекция: Dictionary. Причина: он хранит данные парами имя+номер телефона, 
// что позволяет мгновенно находить номер по имени
// 3. Коллекция: HashSet. Причина: он создан специально для того,
//  чтобы хранить только уникальные вещи. Повторяющиеся теги он просто не пропустит


// ## Итоговая задача. Каталог игр

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         List<string> gamesList = new List<string> { "Minecraft", "Terraria", "Portal" };

//         Console.Write("Добавить игру: ");
//         string newGame = Console.ReadLine();
//         if (!string.IsNullOrWhiteSpace(newGame))
//         {
//             gamesList.Add(newGame);
//         }

//         Console.WriteLine("\nИгры:");
//         for (int i = 0; i < gamesList.Count; i++)
//         {
//             Console.WriteLine($"{i + 1}. {gamesList[i]}");
//         }

//         Dictionary<string, double> gamePrices = new Dictionary<string, double>
//         {
//             { "Minecraft", 1999.00 },
//             { "Terraria", 699.00 },
//             { "Portal", 499.00 }
//         };

//         Console.Write("\nВведите игру для поиска цены: ");
//         string priceSearch = Console.ReadLine();

//         if (gamePrices.TryGetValue(priceSearch, out double price))
//         {
//             Console.WriteLine($"Цена: {price:F2}");
//         }
//         else
//         {
//             Console.WriteLine("Игра не найдена.");
//         }

//         string genresString = "RPG,Sandbox,Action,RPG,Strategy,Action,Sandbox";
//         string[] genresArray = genresString.Split(',');
//         HashSet<string> genresSet = new HashSet<string>(genresArray);

//         Console.WriteLine($"\nУникальных жанров: {genresSet.Count}");

//         Console.Write("\nВведите жанр: ");
//         string genreSearch = Console.ReadLine();

//         if (genresSet.Contains(genreSearch))
//         {
//             Console.WriteLine("Такой жанр есть.");
//         }
//         else
//         {
//             Console.WriteLine("Такого жанра нет.");
//         }
//     }
// }



// ## Самостоятельные задания

// ### ★ List<T>

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         List<int> nums = new List<int> { 1, 2, 1, 3, 1, 4 };

//         Console.Write("Какое число удалить? ");
//         int target = int.Parse(Console.ReadLine());

//         nums.RemoveAll(n => n == target);

//         foreach (int n in nums) Console.Write(n + " ");
//     }
// }


// ### ★★ Dictionary

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Dictionary<string, int> stock = new Dictionary<string, int>();
//         stock["Яблоки"] = 10;
//         stock["Груши"] = 5;

//         Console.Write("Введите товар: ");
//         string item = Console.ReadLine();

//         if (stock.TryGetValue(item, out int count))
//             Console.WriteLine($"Количество: {count}");
//         else
//             Console.WriteLine("Товар не найден");
//     }
// }


// ### ★★★ Выбор коллекции

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         List<string> readers = new List<string> { "Иван", "Мария" };

//         Dictionary<string, string> books = new Dictionary<string, string>();
//         books["Пушкин"] = "Сказки";

//         HashSet<string> genres = new HashSet<string> { "Роман", "Поэма", "Роман" };

//         Console.WriteLine($"Читателей: {readers.Count}");
//         Console.WriteLine($"Книга Пушкина: {books["Пушкин"]}");
//         Console.WriteLine($"Уникальных жанров: {genres.Count}");
//     }
// // }

// // List — удобно хранить список читателей (можно добавлять/удалять)
// // Dictionary — быстро искать книгу по автору
// // HashSet — хранит только уникальные жанры 
