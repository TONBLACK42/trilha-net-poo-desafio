using DesafioPOO.Models;

//Feito!
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "987623469",modelo:"Modelo 1", imei: "1111111111",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "12345678",modelo:"Modelo 2", imei: "2222222222",memoria:128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegran");
iphone.ReceberLigacao();
