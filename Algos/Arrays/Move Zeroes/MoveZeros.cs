namespace Algos.Move_Zeroes;

public class MoveZeros
{
    public static int[] Move(int[] nums)
    {
        // Проверяем, что длинна массива больше нуля
        if(nums.Length <= 0) return nums;
        
        // Перменная для хранения позици нуля
        int leftPosition = 0;
        
        // Проходим по массиву
        for (int i = 0; i <= nums.Length-1; i++)
        {
            // Если число не равно нулю, то меняем местами
            if (nums[i] != 0)
            {
                (nums[i], nums[leftPosition]) = (nums[leftPosition], nums[i]);
                leftPosition++;
            }
        }
        
        // Возвращаем результат
        return nums;
    }
}