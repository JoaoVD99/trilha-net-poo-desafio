using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Um Nokia de fato");
Nokia nokia = new Nokia("448888-8888", "Nokia joguin cobrinha", "xxx-1111", "2GB");
nokia.Ligar();
nokia.ReceberLigacao();

Console.WriteLine("Um Iphone de fato");
Iphone iphone = new Iphone("449999-9999", "Iphone 15", "yyy-2222", "256GB");
iphone.Ligar();
iphone.ReceberLigacao();