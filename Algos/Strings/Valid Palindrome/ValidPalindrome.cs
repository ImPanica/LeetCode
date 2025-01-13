namespace Algos.Strings.Valid_Palindrome;

public class ValidPalindrome
{
    #region First

    public static bool IsPalindromeFirst(string s)
    {
        // Если длинна строки 1 то будет true
        if(s.Length == 1) return true;
        
        // Устанавливаем указатели
        var leftPosition = 0;
        var rightPosition = s.Length-1;
    
        while (leftPosition <= rightPosition)
        {
            // Проверка, что символ слева буквенно-цифровой и позиция слева меньше позиции справа
            while (leftPosition < rightPosition && !IsAlphaNumber(s[leftPosition]))
            {
                leftPosition++;
            }
            // Проверка, что символ справа буквенно-цифровой и позиция справа больше позиции слева
            while (rightPosition > leftPosition && !IsAlphaNumber(s[rightPosition]))
            {
                rightPosition--;
            }
            // Сравниваем символы
            if(char.ToLower(s[leftPosition]) != char.ToLower(s[rightPosition])) return false;
            
            // Изменяем значения указателей
            leftPosition++;
            rightPosition--;
        }
        // Возвращаем результат
        return true;
    }
    
    /// <summary>
    /// Проверка является ли символ числом или латинским символом
    /// </summary>
    /// <param name="c">Символ для проверки</param>
    /// <returns>Результат</returns>
    private static bool IsAlphaNumber(char c)
    {
        return (c >= 97 && c <= 122 || c >= 48 && c <= 57 || c >= 65 && c <= 90);
    }

    #endregion

    #region Second

    public static bool IsPalindromeSecond(string s)
    {
        // Приводим к новой строке удаляя все кроме чисел и букв
        var result = new string(s.ToLower().Where(c => char.IsLetterOrDigit(c)).ToArray());
        // Делаем реверс строки и сравниваем
        return result == new string(result.Reverse().ToArray());
    }

    #endregion

    #region Third

    /// <summary>
    /// Проверка на палиндром используя встроенные методы
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static bool IsPalindromeThird(string s)
    {
        // Если длинна строки 1 то будет true
        if(s.Length == 1) return true;
        
        // Устанавливаем указатели
        var leftPosition = 0;
        var rightPosition = s.Length-1;
    
        // Проходим по строке
        while (leftPosition <= rightPosition)
        {
            // Проверка, что символ слева буквенно-цифровой и позиция слева меньше позиции справа
            while (leftPosition < rightPosition && !char.IsLetterOrDigit(s[leftPosition]))
            {
                leftPosition++;
            }
            // Проверка, что символ справа буквенно-цифровой и позиция справа больше позиции слева
            while (rightPosition > leftPosition && !char.IsLetterOrDigit(s[rightPosition]))
            {
                rightPosition--;
            }
            // Сравниваем символы
            if(char.ToLower(s[leftPosition]) != char.ToLower(s[rightPosition])) return false;
            
            // Изменяем значения указателей
            leftPosition++;
            rightPosition--;
        }
        // Возвращаем результат
        return true;
    }

    #endregion
}