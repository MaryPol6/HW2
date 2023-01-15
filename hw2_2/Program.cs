using static System.Console;
Clear();
int n = int.Parse(ReadLine());
if(n>100) {
    if(n>999){
            while(n>999)
            {
                n/=10;
            }
    WriteLine(n%10);
    }
    else {WriteLine(n%10);}
}


else {WriteLine("Третьей цифры нет");}

    
