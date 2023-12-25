using DesafioPOO.Models;

Iphone iphone = new Iphone("35998765432", "14 pro max", "11122233344455", int.Parse("256"));
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();

Console.WriteLine(" ");

Nokia nokia = new Nokia("35945613287", "e-122", "2224446668877", int.Parse("128"));
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();