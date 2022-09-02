void MassData(double[,] mass){
    for(int i = 0; i < mass.GetLength(0); i++){
        for(int a = 0; a < mass.GetLength(1); a++){
            mass[i, a] = new Random().Next(-30, 30) / 10.0;
        }    
    } 
}

void EchoMass(double[,] mass){
    for(int i = 0; i < mass.GetLength(0); i++){
        for(int a = 0; a < mass.GetLength(1); a++){
           Console.Write(Convert.ToString(mass[i, a]) + " ");
        } 
        Console.WriteLine();   
    }     
}



Console.WriteLine("Введите m число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n число: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] mass = new double[m, n];

MassData(mass);
EchoMass(mass);

