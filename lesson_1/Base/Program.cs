// See https://aka.ms/new-console-template for more information
int a = 2;
int b = 12;
int c = 8;
int d = 1;
int e = 3;

int max = a;

if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

Console.WriteLine(max);
