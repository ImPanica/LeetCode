namespace Algos.Is_Subsequence;

public class Subsequence
{
    public static bool IsSubsequence(string s, string t)
    {
        // Если входная строка пустая то возвращаем true
        if(string.IsNullOrEmpty(s)) return true;
        // Если проверочная строка пустая то возвращаем false
        if(string.IsNullOrEmpty(t)) return false;
        
        // Переменная для хранения позиции
        var leftPosition = 0;

        // Проходим по массиву и проверяем чтобы длинна левого курсора не была больше длинны входящей строки
        for (var i = 0; i < t.Length && leftPosition < s.Length; i++) // Проверка
        {
            if (t[i] == s[leftPosition]) // Если нашли совпадение
                leftPosition++; // изменяем позицию
        }
        // Возврат результата
        return leftPosition == s.Length;
    }
}