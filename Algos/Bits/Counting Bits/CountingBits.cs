namespace Algos.Bits.Counting_Bits;

public class CountingBits
{
    public static int[] CountBits(int n)
    {
        // Массив для хранения количества единиц
        var bits = new int[n+1];
        // offset хранит текущую степень двойки (1, 2, 4, 8, ...)
        var offset = 1;

        // Проходим в цикле от 1 до n
        for (int i = 1; i <= n; i++)
        {
            // Когда i достигает следующей степени двойки (2, 4, 8, ...),
            // обновляем offset до этого значения
            if (offset * 2 == i)
                offset = i;
            
            // Для числа i количество единиц равно:
            // 1 (для старшего бита) + количество единиц в (i - offset)
            // Например, для 7 (0111):
            // offset = 4, 7-4 = 3
            // bits[7] = 1 + bits[3]
            bits[i] = 1 + bits[i - offset];
        }
        
        // Возвращаем результат
        return bits;
    }
}