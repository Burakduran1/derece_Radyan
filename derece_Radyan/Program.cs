
Console.WriteLine("Derece değerini giriniz:");
int derece = Convert.ToInt32(Console.ReadLine());
 double pi = 3.14;



int radyan = Convert.ToInt32(derece * pi /180)  ;
double gradyans = Convert.ToDouble(derece * 200/180) ;
Console.WriteLine(derece + " derece " + radyan + " radyan'dır." );
Console.WriteLine(gradyans + " gradyan " + gradyans + " gradyandır ");
Console.ReadLine();

