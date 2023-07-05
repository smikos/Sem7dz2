int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



int [,] GenerateArray2DDD(int rows, int columns,int min, int max)
{
    
    int [,] numbers = new int [rows, columns];
    Random rnd = new Random ();
    
    for (int i = 0; i <numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
           numbers[i,j] = rnd.Next (min,max +1) ;
         
    }
    }
    return numbers;
}


void PrintArray2D(int [,] numbers)
{

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
         
         System.Console.Write($"{numbers[i,j]}\t"); 

        }
        System.Console.WriteLine();
       
        
    }

}

int [] poisk( int[,] numbers) 
{
    int [] number = new int [2];
    int a= ReadInt( "Ведите число > ");
    int b= ReadInt( "Ведите число > ");
    number[0]=a;
    number[1]=b;
    for (int i = 0; i <numbers.GetLength(0); i++)
    {
        if (a == i)
        {
            number[0]= i;
        }
       
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
           if ( b == j)
           {
            
            number[1]=j;
           }
           
          
        }
        
    }
   
    return number;
}

void PrintArray2(int [] number)
{
    for (int i = 0; i < number.Length; i++)
    {
       
          System.Console.Write(number[i]+" " ); 
          
        }

       System.Console.WriteLine(); 
}

void Print(int [] number,int[,] numbers)
{
    if (!(number[0]>=numbers.GetLength(0) || number[1]>=numbers.GetLength(1)))
    {
System.Console.WriteLine(numbers [number[0],number[1]]);
    }
    else System.Console.WriteLine("такого числа в масиве нет");
}

int[,] array = GenerateArray2DDD(4,4,0,6);
int [] rin = poisk( array) ;
PrintArray2D(array);
PrintArray2(rin);
Print(rin,array);
