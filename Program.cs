using System;

namespace Usuario_em_forma_Ascendente
{
    class Program
    {


        static void Main(string[] args)
        {
            int numero;
            int temp;
            
            try
            {
                //solicita a informação de quantos numeros vai usar
                Console.WriteLine("Informe quantos números você quer usar :");
                numero = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[numero];
                //recebe os numeros do usuário
                for (int i = 0; i < numero; i++)
                {
                    Console.Write("Informe o no. " + i + " Valor:");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                //realiza a ordenação 
                for (int i = 0; i < numero; i++)
                {
                    for (int j = 0; j < numero - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("Ordenando em Ordem Ascendente : ");
                //imprime os numeros ordenados
                for (int i = 0; i < numero; i++)
                {
                    Console.WriteLine(array[i]);
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();

            }

        }
    }
}