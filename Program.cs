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

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = { "C#", "Git", "C#", "SQL", "Git", "C#" };

        HashSet<string> uniqueTags = new HashSet<string>();
        
        foreach (string item in input)
        {
            uniqueTags.Add(item);
        }

        Console.WriteLine($"Элементов в исходном массиве: {input.Length}");
        Console.WriteLine($"Уникальных значений (HashSet): {uniqueTags.Count}");

        Console.Write("Введите название технологии для проверки: ");
        string searchTag = Console.ReadLine();

        if (uniqueTags.Contains(searchTag))
            Console.WriteLine("Такая технология есть в наборе.");
        else
            Console.WriteLine("Такой технологии нет в наборе.");
            
        HashSet<string> tags = new HashSet<string> { "C#", "Git", "C#", "SQL", "Git", "C#" };
    }
}