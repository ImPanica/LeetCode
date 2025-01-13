using System.Text;

namespace Algos.Reverse_Words_in_a_String;

public class ReverseWords
{
    public static string Reverse(string s)
    {
        // Разделим строку по пробелам в начале и в конце
        string[] words = s.Trim().Split(' ');

        // Переменная для хранения результата
        string reversed = "";
        // Проходим по массиву
        for (int i = words.Length-1; i >= 0; i--)
        {
            // Если строкане пустая добавляем строку
            if(words[i] != "")
                reversed += i != 0 ? $"{words[i]} " : $"{words[i]}";
        }
        
        // Возвращаем результат
        return reversed;
    }
    
    /// <summary>
    /// Улучшенный вариана с использованием StringBuilder и удалением лишних проверок
    /// </summary>
    /// <param name="s">Входная строка</param>
    /// <returns>Результат</returns>
    public static string ReverseOptionTwo(string s)
    {
        // Разделяем строку по пробелам и удаляем пустые
        string[] words = s.Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);
        
        // Переменная дял хранения резуьтата
        var reversed = new StringBuilder();
        
        // Проходим по масииву
        for (int i = words.Length -1 ; i >= 0; i--)
        {
            reversed.Append(words[i]); // Добавляем строку
            
            // Добавляем проблел
            if(i > 0) reversed.Append(' '); 
        }
        // Возврат результата
        return reversed.ToString();
    }
}