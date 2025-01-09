using System.Collections;

namespace Algos.Majority_Element;

public class MajorityElement
{
    public static int MajorityToElement(int[] nums)
    {
        // Словарь для подсчета
        Dictionary<int, int> dict = new Dictionary<int, int>();

        // Проходим по массиву
        foreach (var num in nums)
        {
            // Если  в словаре есть, то увеличиваем value
            if(dict.ContainsKey(num)) dict[num]++;
            
            // Если в словаре нет, то дабавляем
            else dict[num] = 1; 
            
            // Возвращаем количество вхождений если оно больше n/2
            if (dict[num] > nums.Length / 2)
                return num;
        }
        
        return -1; // Если массив не верный
    }
}