using System;

using System.Text.RegularExpressions;

public class Program

{

    public static void Main(String[] args)

    {

        int n = int.Parse(Console.ReadLine());

        int[] num = new int[n];

        for (int i = 0; i < n; i++)

        {

            num[i] = int.Parse(Console.ReadLine());

        }

        Console.WriteLine(MajorityElement(num));

    }



    public static int MajorityElement(int[] nums)

    {

        int major = nums[0];

        int contadorMajor = 1;

        for (int count = 0; count < nums.Length; count++)

        {

            int numeroAtual = nums[count];

            int contadorNumeroAtual = 1;

            for (int count2 = 1; count2 < nums.Length;count2++)

            {

                if(nums[count2] == numeroAtual)

                {

                    contadorNumeroAtual++;

                }

            }

            if (contadorNumeroAtual>contadorMajor)

            {

                contadorMajor = contadorNumeroAtual;

                major = numeroAtual;  

            }

           

        }

        return major;

    }

}

