using System;

namespace Pr{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("\nLab 3");
      
      Console.WriteLine("Choose task: ");
      int s = Convert.ToInt32(Console.ReadLine());

  switch(s){
    case 1: { task1();  break;}
    case 2: { task2();  break;}
  }
      
    }


static void task1()
{
    Console.WriteLine("\nTask1");
    Console.Write("Numner of triangle: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int [] a=new int[n*2];
    int s=0;

    Console.Write("Sides: ");
    for(int i = 0;i<a.Length;i++)
    {
      a[i]= Convert.ToInt32(Console.ReadLine());
    }

    ITriangle first = new ITriangle ();
    first.side(a[0],a[1]);


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
}

class ITriangle{
  protected int a, b;
  protected string c;

  public void side (int sa, int sb) {
      a=sa;
      b=sb;
  }

  int [] sides(int sa, int sb){
    int [] a = {sa,sb};
    return a;   
  }
  int perimeter(int sa, int sb){
    int p=sa+2*sb;
    return p;   
  }
  double area (int sa, int sb, int p1){
    int p=p1/2;
    double s= Math.Sqrt(p*(p1-sa)*(p1-sb)*(p1-sb));
    return s;   
  }

  bool correct (int sa, int sb){
    if(sa==sb) return true; 
    else return false;
  }

  public int[] sidegr{
    get{
      int [] k= {this.a,this.b};
      return k;
    }

    set{
      a=value[2];
    }
  }

  public string colorgr{

    get{
      string s=this.c;
      return s;
    }
    set{
      c=value;
    }
  }
}

}
