using _12AprelTaskHome;

internal class Program
{
    private static void Main(string[] args)
    {
        Weapon weapon = new Weapon();
       
        int b = 1;
        for(int i=0;i<b;i++) 
        {
            b++;
        string a=Console.ReadLine();
            if (a == "1")
            {

                weapon.Fire("kalasnikov ", 50);
            }
            if (a == "2")
            {
                weapon.Fill();
            }
            if (a == "3")
            {

                weapon.PullTrigger();
            }
            if(a== "4")
            {
                break;
            }
        }
       
    }
}