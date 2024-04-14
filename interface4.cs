using System;
interface Polygon{
void Area(int a,int b);
}
interface Color{
void getColor();
}
class Rectangle:Polygon,Color{
public void Area(int a,int b){
int area=a*b;
Console.WriteLine("Area of rectangle:"+area);
}
public void getColor(){
Console.WriteLine("red");
}
}
class Program{
static void Main() {
Rectangle r=new Rectangle();
r.Area(6,10);
r.getColor();
}
}
