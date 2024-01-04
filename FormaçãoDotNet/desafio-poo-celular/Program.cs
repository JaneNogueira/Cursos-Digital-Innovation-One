
﻿using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "622102102", modelo: "500", imei: "121a6596252362", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("IPhone:");
Smartphone iphone = new Iphone(numero: "1541542323", modelo: "6 Plus", imei: "451221220d1211", memoria: 264);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");