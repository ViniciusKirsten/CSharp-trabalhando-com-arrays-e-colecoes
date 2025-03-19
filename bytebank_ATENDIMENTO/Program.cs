Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

//testaArrayInt();
//TestaBuscarPalavra();

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
    
    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        acumulador+= idades[i];
        int idade = idades[i];
        Console.WriteLine($"indice [{i}] = {idade}");
    }
    int media = acumulador/idades.Length;
    Console.WriteLine($"Média de idades = {media}");
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];
    
    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i+1}º Palavra");
        arrayDePalavras[i] = Console.ReadLine();
    }
    Console.Write("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }
        
    }
}

//uma classe do tipo ARRAY

Array amostra = Array.CreateInstance(typeof(double), 5);
//preciso passar o valor e o indice que eu quero
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(5.9, 3);
amostra.SetValue(10, 4);
amostra.SetValue(6.9, 5);