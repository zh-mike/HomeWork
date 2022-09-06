Console.Write("Введите чтсло: ");
int numb = Convert.ToInt32(Console.ReadLine());
int i = 0;
while(i < numb){
    i++;
    if(i % 2 == 0) Console.Write(i +" ");
}
