Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

void testaArrayInt()
{
    //uma das maneiras que eu tenho para escrever um array em C#
    int[] idades = new int[5];

    //adicionando valores através de indices
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;
    
    Console.WriteLine($"Tamanho do array: {idades.Length}");

    for (int i = 0; i < idades.Length; i++)
    {
    }
}