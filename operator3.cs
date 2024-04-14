using System;
class Triangle{
public double a,ma,surface;
public Triangle(double a,double ma){
this.a=a;
this.ma=ma;
this.surface=(a*ma)/2;
}
public Triangle(double surface){
this.surface=surface;
}
public static Triangle operator + (Triangle tri1,Triangle tri2){
Triangle res=new Triangle(tri1.surface+tri2.surface);
return res;
}
}
class Program{
static void Main() {
Triangle tri1=new Triangle(7,13);
Triangle tri2=new Triangle(7,16);
Triangle tri3=tri1+tri2;
Console.WriteLine($"The third triangle {nameof(tri3)} with surface is:{tri3.surface}");
}
}
