using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "7", modelo: "Iphone 14 Pro", imei: "888888888", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "490", modelo: "Nokia Tijolão", imei: "555555555", memoria: 32);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");