using System;
using System.Collections;

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
    List<Place> a= new List<Place>();

    // Place [] ar = new Place [2];

    int [] n=new int[4];
    string [] s=new string[6];

    Console.Write("Place id: ");
    for(int i = 0;i<2;i++)
    {
      n[i]= Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Place location: ");
    for(int i = 0;i<2;i++)
    {
      s[i]= Convert.ToString(Console.ReadLine());
    }

    Console.Write("Region size(big/medium/small): ");
    for(int i = 2;i<4;i++)
    {
      s[i]= Convert.ToString(Console.ReadLine());
    }
    Console.Write("Town nation(ukr/usa/uk): ");
    for(int i = 4;i<6;i++)
    {
      s[i]= Convert.ToString(Console.ReadLine());
    }
    Console.Write("Metropolis population: ");
    for(int i = 2;i<4;i++)
    {
      n[i]= Convert.ToInt32(Console.ReadLine());
    }


  /*  ar.SetValue(n[0],0); //id 1
    ar.SetValue(n[1],1); //id 2
    ar.SetValue(s[0],2); //loc 1
    ar.SetValue(s[1],3); //loc 2
    ar.SetValue(s[2],4); //size 1
    ar.SetValue(s[3],5); //size 2
    ar.SetValue(s[4],7); //nation 1
    ar.SetValue(s[5],8); //nation 2
    ar.SetValue(n[2],9); //population 1
    ar.SetValue(n[3],10); //population 2
*/
     a.Add(new Region(s[0], n[0], s[2]));
     a.Add(new Region(s[1], n[1], s[3]));
     a.Add(new Town(s[0], n[0], s[4]));
     a.Add(new Town(s[1], n[1], s[5]));
     a.Add(new Metropolis(s[0], n[0], n[2]));
     a.Add(new Metropolis(s[1], n[1], n[3]));


    // BaseAI p = new Pl(b);
    //            b.start();

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


class Place {

    public string loc;
    public int id;

    public String Location() {
        return loc;
    }

    public int id_doc() {
        return id;
    }

    public Place(String loc, int id) {
        this.loc = loc;
        this.id = id;
    }

    public void Show() {
        Console.Write("Place: "+ id+" "+ loc+"\n");
    }
}

class Region : Place {

    string size;

    public Region(string loc, int id, string size) : base(loc,id) {
        this.size = size;
    }

    public String getSize() {
        return size;
    }

    public void Show() {

        Console.Write(id+ " Place "+ loc+"Region " +size+"\n");
    }

}

class Town : Place {

    string nation;

    public Town(string loc, int id, string nation) : base(loc,id){
        this.nation = nation;
    }

    public string getNation() {
        return nation;
    }

    public void Show() {
      Console.Write(id+ " Place "+ loc+"Town " +nation+"\n");
    }
}

class Metropolis : Place {

    int population;

    public Metropolis(string loc, int id, int population) : base(loc,id){
        this.population = population;
    }

    public int getPopulation() {
        return population;
    }

    public void Show() {
        Console.Write(id+ " Place "+ loc+"Metropolis " +population+"\n");
    }

}

/*
abstract class BaseAI {

    public List<Place> p;

    public BaseAI(List<Place> p) {
        this.p = p;
    }

    public void run() {

    }
}

class Pl : BaseAI {

    public Pl(List<Place> p) : base(p){
    }

    public void run() {

        for (Place p) {

                Comparator<Place> com = new Comparator<Place>() {
                    public int compare(Place i, Place j) {
                        if (i.name == j.name) {
                            return 0;
                        } else
                            return 1;

                    }
                };

                Comparator<Place> com1 = new Comparator<Place>() {
                    public int compare(Place i, Place j) {
                        if (i.id > j.id) {
                            return 1;
                        } else if (i.id < j.id) {
                            return -1;
                        } else
                            return 0;
                    
                };

                p.sort(com);

                Console.Write("\nR: ");
                p.Show();

                p.sort(com1);

                Console.Write("\nR: ");
                p.Show();

                }
        }
        }}
*/

}