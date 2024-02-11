using System;

namespace Pr{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("\nLab 2");
      
      Console.WriteLine("Choose task: ");
      int s = Convert.ToInt32(Console.ReadLine());

  switch(s){
    case 1: { task1();  break;}
    case 2: { task2();  break;}
    case 3: { task3();  break;}
    case 4: { task4();  break;}
  }
      
    }


static void task1()
{
    Console.WriteLine("\nTask1");
    Console.Write("N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int [] a=new int[n];
    int s=0;

    Console.Write("Input array: ");
    for(int i = 0;i<a.Length;i++)
    {
      a[i]= Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Start: ");
    int st = Convert.ToInt32(Console.ReadLine());
    Console.Write("End: ");
    int end = Convert.ToInt32(Console.ReadLine());

    for(int i=st; i<end;i++){
        s+=a[i];
    }
    
    Console.WriteLine("S: " + s);


    Console.Write("Part2. N1: ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("N2: ");
    int n2 = Convert.ToInt32(Console.ReadLine());
    int [,] a1=new int[n1,n2];
    int s1=0;

    Console.Write("Input array: ");
    for(int i = 0;i<n1;i++)
    for(int j = 0;j<n2;j++)
    {
      a1[i,j]= Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Start i: ");
    int st1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("End i: ");
    int end1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Start j: ");
    int st2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("End j: ");
    int end2 = Convert.ToInt32(Console.ReadLine());

    for(int i = st1;i<end1;i++)
    for(int j = st2;j<end2;j++){
        s1+=a1[i,j];
    }
    
    Console.WriteLine("S1: " + s1);

}
static void task2()
{
    Console.WriteLine("\nTask2");
    Console.Write("N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int [] a=new int[n];
    int s=0;

    Console.Write("Input array: ");
    for(int i = 0;i<a.Length;i++)
    {
      a[i]= Convert.ToInt32(Console.ReadLine());
    }
    int max=0, min =100, k=0,k1=0;

    for(int i=0; i<a.Length;i++){
        if(a[i]>max) {
          max=a[i]; k=i;
          }
        if(a[i]<min) {
          min=a[i]; k1=i;
          }
    }

    Console.Write("\nMax: "+ max);
    Console.Write("\nMin: "+ min);
    Console.Write("\nK: "+ k);
    Console.Write("\nK1: "+ k1);

    if(k>k1) {Console.Write("\nMin...Max");}

    else{
      for(int i=k+1; i<k1;i++){
      s+=a[i];
      }
      Console.Write("\nS: "+ s+ "\n");
     }
}
static void task3()
{
    Console.Write("N1: ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("N2: ");
    int n2 = Convert.ToInt32(Console.ReadLine());
    int [,] a=new int[n1,n2];

    Console.Write("Input array: ");
    
    for(int i = 0;i<n1;i++)
    for(int j = 0;j<n2;j++)
    {
      a[i,j]= Convert.ToInt32(Console.ReadLine());
    }
    
    // int [,] a={{1,2,3},{4,5,6},{7,8,9},{10,11,12}};
    int t=0;
    int k=0;

    if((n1%2)==0){
      
      for(int i = 0;i<n1;i++){
        for(int j = 0;j<n2;j++)
        {
          if(k==3){k=0; break;}
          k+=1;
          t=a[i,j];
          a[i,j]=a[i+1,j];
          a[i+1,j]=t;
          Console.Write("\nA:"+ a[i,j]);
          Console.Write("\nA+:"+ a[i+1,j]);
       }
      }
    }

   Console.Write("\n\nA: ");
    for(int i = 0;i<n1;i++)
    for(int j = 0;j<n2;j++){
      if(k==3) {
        k=0; 
        Console.Write("\n   ");
      }
    Console.Write(a[i,j]+" ");
    k+=1;
    }

}
static void task4()
{
    Console.Write("N1: ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    int [,] a=new int[n1,n1];
    int [] r=new int[n1];

    Console.Write("Input array: ");
    
    for(int i = 0;i<n1;i++)
    for(int j = 0;j<n1;j++)
    {
      a[i,j]= Convert.ToInt32(Console.ReadLine());
    }

  for(int j = 0;j<n1;j++){
    for(int i = 0;i<n1;i++)
    {
      if((a[i,j]%2)!=0){
        r[j]=j;
         Console.Write("\nR: "+i+"   A: "+a[i,j]);
      }
    }}
    
    Console.Write("\nR: ");
    for(int i = 0;i<r.Length;i++){
      Console.Write(r[i]+" ");
    }
}
  }

class ITriangle{
  protected int a, b, c;

  public side (int sa, int sb) {
      a=sa;
      b=sb;
  }
}

int [] sides(int sa, int sb){
 int [] a = {s1,sb};
 return a;   
}
int perimeter(int sa, int sb){
 int p=sa+2*sb;
 return p;   
}
int area (int sa, int sb, int p1){
  int p=p1/2;
  int s= Math.Sqrt(p*(p1-sa)*(p1-sb)*(p1-sb));
 return s;   
}
int area (int sa, int sb, int p1){
  int p=p1/2;
  int s= Math.Sqrt(p*(p1-sa)*(p1-sb)*(p1-sb));
 return s;   
}
bool correct (int sa, int sb){
  if(sa==sb) return true; 
  else return false
}
