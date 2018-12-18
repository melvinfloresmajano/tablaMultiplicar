using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMultiplicar.Models
{
public class calculos
{
public List<string> Proceso(int n)
{
List<string> t = new List<string>();
int c = 1;
while (c <= 10)
{
string cadena;
cadena = n + "X" + c + " = " + (n*c);
t.Add(cadena);
c += 1;
}
return t; 
}
}
}