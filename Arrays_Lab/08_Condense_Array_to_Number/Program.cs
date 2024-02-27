int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 10 20 30 40

for (int i = 0; i <inputNums.Length-1; i++) // 10 20 30 40..... n= 2 -> n-1
{
    for (int j = 0; j < inputNums.Length-1-i; j++)//n = 4(purvonachalno n) - 1(za da ne smqtame poslednoto) - 0 = 3
    {
        inputNums[j] = inputNums[j] + inputNums[j + 1];//10 + 20 i gi slogi otpred 
    }
}
Console.WriteLine(inputNums[0]);//0 zashoto subranite chisla gi slagame otpred

