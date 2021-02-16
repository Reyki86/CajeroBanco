using System;

class Program {
    static void Main(string[] args) {
    int monto;
    int limite_retiro;
    string repeat="";
    int cantidad_billete_1000=18;
    int cantidad_billete_500=19;
    int cantidad_billete_200=23;
    int cantidad_billete_100=50;
    
    Console.WriteLine("Porfavor digite su banco: ");

    string banco = Console.ReadLine();
    
    if (banco=="FDP INVESTMENTS"){
        limite_retiro=20000;
        Console.WriteLine("Su limite de retiro es 20,000");
    }
    else{limite_retiro=10000;
        Console.WriteLine("Su limite de retiro es 10,000");}
    
    while (repeat!="n"){
                
        int billete_1000=0;
        int billete_500=0;
        int billete_200=0;
        int billete_100=0;
        
        Console.WriteLine("Billetes de 1000 restantes: "+cantidad_billete_1000);
        Console.WriteLine("Billetes de 500 restantes: "+cantidad_billete_500);
        Console.WriteLine("Billetes de 200 restantes: "+cantidad_billete_200);
        Console.WriteLine("Billetes de 100 restantes: "+cantidad_billete_100);
        
        Console.WriteLine("Digite el monto a retirar: ");
            
        monto=Int32.Parse(Console.ReadLine());
        
        while (monto>limite_retiro){
            Console.WriteLine("Porfavor digite un monto menor al limite de retiro");
            
            monto=Int32.Parse(Console.ReadLine());
        }
            
        while (monto>=1000 && cantidad_billete_1000>0){
            monto-=1000;
            billete_1000+=1;
            cantidad_billete_1000-=1;
        }
        while (monto>=500 && cantidad_billete_500>0){
            monto-=500;
            billete_500+=1;
            cantidad_billete_500-=1;
        }
        while (monto>=200 && cantidad_billete_200>0){
            monto-=200;
            billete_200+=1;
            cantidad_billete_200-=1;
        }
        while (monto>=100 && cantidad_billete_100>0){
            monto-=100;
            billete_100+=1;
            cantidad_billete_100-=1;
        }
        
        if(cantidad_billete_1000==0 && cantidad_billete_500==0 && cantidad_billete_200==0 && cantidad_billete_100==0)
        {
            Console.WriteLine("Los billetes se han agotado");
            break;
        }
        
        if (monto>0){Console.WriteLine("Su monto no puede ser dispensado");}
        else{
            Console.WriteLine(billete_1000+" billetes de 1000");
            Console.WriteLine(billete_500+" billetes de 500"); 
            Console.WriteLine(billete_200+" billetes de 200"); 
            Console.WriteLine(billete_100+" billetes de 100"); 
        }
        
        Console.WriteLine("Desea realizar otro retiro? (y/n)");
            
        repeat=(Console.ReadLine());
        while (repeat!="n" && repeat!="y" && repeat!="Y" && repeat!="N" ){
            Console.WriteLine("Porfavor digite una respuesta valida");
            repeat=(Console.ReadLine());
        }
        


        
    }
}
}