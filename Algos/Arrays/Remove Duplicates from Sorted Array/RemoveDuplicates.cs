namespace Algos.Arrays.Remove_Duplicates_from_Sorted_Array;

public class RemoveDuplicates
{
    public static int RemoveDuplicatesFromArray(int[] nums)
    {
        // Указатель на левую позицую
        // Ставим на единицу так, как первый будет всегда уникальным
        var leftPosition = 1;
        
        // Проходим по массиву и проверяем дубликаты
        for (int i = 1; i < nums.Length; i++)
        {
            // Сравниваем текущий элемент с пердыдущим и если они не равны
            if (nums[i] != nums[i-1])
            {
                // Перемещаем элемент на позицию левого курсора
                nums[leftPosition] = nums[i];
                // Изменяем курсор
                leftPosition++;
            }
        }
        
        // Возвращаем результат
        return leftPosition;
    }
}