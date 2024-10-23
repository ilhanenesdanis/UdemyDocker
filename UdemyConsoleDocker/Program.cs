using System.Diagnostics;

Stopwatch sw = Stopwatch.StartNew();
int i =1;
while (i<1000){
    System.Console.WriteLine("Hello "+i);
    i++;
    
}
sw.Stop();
System.Console.WriteLine(sw.ElapsedMilliseconds);

