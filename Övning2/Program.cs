
while (true)
{
    Console.WriteLine("\nHuvudmeny. Välj Funktion:");
    Console.WriteLine("1. Ange ålder för att ta del av eventuella rabatter, ");
    Console.WriteLine("2. Gruppbokning av biobiljetter");
    Console.WriteLine("3. Ordmultiplikatorn");
    Console.WriteLine("4. Plocka ord ur en mening");
    Console.WriteLine("0. Avsluta programmet");
    Console.Write("Ditt val: ");

    string val = Console.ReadLine();

    switch (val)
    {
        case "0":
            Console.WriteLine("Programmet avslutas.");
            return;

        case "1":
            Console.WriteLine("Ange ålder på besökaren");
            int age = int.Parse(Console.ReadLine());

            //Om besökaren är under 20
            if (age < 20)
            {
                Console.WriteLine("Ungdomspris: 80kr");
            }

            //Om besökaren är över 64
            else if (age > 64)
            {
                Console.WriteLine("Pensionärspris: 90kr");
            }

            //Standardpris
            else
            {
                Console.WriteLine("Standardpris 120kr");
            }

            break;

        case "2":

            //Ange hur många besökare gruppen består av
            Console.WriteLine("Ange antal personer");
            int antalBesokare = int.Parse(Console.ReadLine());

            int totalAmount = 0;//Totalsumman gruppen ska betala
            for (int i = 0; i < antalBesokare; i++)
            {
                Console.WriteLine("\nÅlder besökare " + (i + 1));
                int age2 = int.Parse(Console.ReadLine());//Tar reda på besökarens ålder

                if (age2 < 20)
                {
                    totalAmount = totalAmount + 80;//Totalsumman ökar med 80kr
                    Console.WriteLine("Ungdomspris: 80kr");//Den här tog jag med för tydlighetens skull. Kanske skulle skippa den
                }

                else if (age2 > 64)
                {
                    totalAmount = totalAmount + 90;//Totalsumman ökar med 90kr
                    Console.WriteLine("Pensionärspris: 90kr");
                }

                else
                {
                    totalAmount = totalAmount + 120;//Totalsumman ökar med 120kr
                    Console.WriteLine("Standardpris 120kr");
                }

                
            }

            Console.WriteLine("\nAntal besökande: " + antalBesokare);//Kanske onödig, men här är den
            Console.WriteLine("\nTotalpris: " + totalAmount + "kr");//Totalpriset för gruppen
            break;

        case "3":
            Console.WriteLine("Skriv något du vill upprepa tio gånger");
            string upprepa = Console.ReadLine();

            for (int i = 0; i < 10; i++)

                Console.Write(upprepa);//Skriver på samma rad

                break;

        case "4":
            Console.WriteLine("Skriv en mening med minst tre ord.");
            string meningAttDela = Console.ReadLine();

            //Här delas meningen upp så fort det kommer ett mellanslag
            string[] enstakaOrd = meningAttDela.Split(" ");
           
            //Det tredje ordet skrivs ut    
            Console.WriteLine("Det tredje ordet i meningen är: " + enstakaOrd[2]);


            break;

        default:
            //Det som matades in var inte 0-4
            Console.WriteLine("Ogiltig inmatning. Försök igen.");
            break;
    }
}