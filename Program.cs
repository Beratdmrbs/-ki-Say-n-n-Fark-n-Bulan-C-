double sayi1 = 0, sayi2 = 0;
Console.Write("Birinci sayıyı giriniz:");
sayi1 = Convert.ToDouble(Console.ReadLine());
Console.Write("İkinci sayıyı giriniz:");
sayi2 = Convert.ToDouble(Console.ReadLine());

if (sayi1 >= sayi2)
    Console.WriteLine("FARK={0}", sayi1 - sayi2);
else
    Console.WriteLine("FARK={0}", sayi2 - sayi1);

Console.ReadKey();
