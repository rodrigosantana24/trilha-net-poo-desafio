using DesafioPOO.Models;

Console.WriteLine("Classe Iphone, testes: ");
var iphone = new Iphone("81985361435", "Modelo Iphone 01", "1111-2222", 64);

iphone.Numero = "777777777";
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Classe Nokia, testes: ");

var nokia = new Nokia("81985361435", "Modelo Nokia 01", "1111-2222", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");