using DesafioPOO.Models;

Smartphone iphone = new Iphone("88888-8888", "iPhone 15", "987654321", 256);
Smartphone nokia = new Nokia("99999 - 9999", "Nokia Tijolão", "123456789", 64);

iphone.Ligar();
iphone.InstalarAplicativo("telegram");

nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");