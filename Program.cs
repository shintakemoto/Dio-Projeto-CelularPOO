using DesafioPOO.Models;

Console.Write("\n");

Console.WriteLine("---Testando Iphone---");
Smartphone iphone = new Iphone(numero: "1111-2222", modelo: "2020", imei: "1ph0n3", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("YouTube");

Console.Write("\n");

Console.WriteLine("---Testando Nokia---");
Smartphone nokia = new Iphone(numero: "3333-4444", modelo: "2021", imei: "n0k14", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Netflix");

////////////////////

Console.Write("\n");

// testes de acesso
Console.WriteLine($"Numero do Nokia : {nokia.Numero}");
nokia.Numero = "5555-6666";
Console.WriteLine($"Novo numero do Nokia : {nokia.Numero}");

// modelo protected
// Console.WriteLine($"Modelo do Nokia: {nokia.Modelo}"); 