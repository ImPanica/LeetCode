namespace Algos.Arrays.Rotate_Array;

public class RotateArray
{
    public static void Rotate(int[] nums, int k)
    {
        // Преобразуем k в допусти мое кол-во шагов в пределах длинны массива
        // Если длинна массива 5 а k=7 то 7 % 5 = 2
        // В таком случае сдвиг будет произведен ан 2 позиции
        k = k % nums.Length;
        // Реверс массива
        Reverse(nums, 0, nums.Length - 1);
        // Реверс первых трех элементов
        Reverse(nums, 0, k-1);
        // Реверс остальных элементов
        Reverse(nums, k, nums.Length - 1);
    }
    
    static void Reverse(int[] nums, int start, int end)
    {
        // Проходим по циклу пока условия соблюдены
        while (start < end)
        {
            (nums[start], nums[end]) = (nums[end], nums[start]); // Меняем местами элементы
            // Изменяем позицию
            end--; 
            start++;
        }
    }
}