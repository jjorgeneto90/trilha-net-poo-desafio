using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone ip = new Iphone("123456", "3310","123123", 8);
Nokia nk = new Nokia("444444", "15 pro", "321321", 16);


ip.InstalarAplicativo("whatsapp");
ip.ReceberLigacao();
ip.Ligar();

nk.Ligar();
nk.ReceberLigacao();
nk.InstalarAplicativo("facebook");
