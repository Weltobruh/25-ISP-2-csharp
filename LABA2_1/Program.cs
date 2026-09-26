// 12 вариант Высокий
try{
    Console.Write("Введите х:");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите у:");    
    double y = double.Parse(Console.ReadLine());

    Console.WriteLine((y<=1)&&(y>=x)&&(y>=-x));
}
catch(Exception ex){
    Console.WriteLine(ex.Message);
}