double consDia, consApar, custEner, custUso;
Console.Write("Consumo do aparelho (Em kWh/mês):..."); 
consApar = Convert.ToDouble(Console.ReadLine());
    
Console.Write("Horas de uso diario:...");
consDia = Convert.ToDouble(Console.ReadLine());

Console.Write("Custo de energia (Em R$/kWh):...");
custEner = Convert.ToDouble(Console.ReadLine());

custUso = consDia * consApar * custEner; 
Console.WriteLine($"Custo estimado: R$ {custUso:N2}");
