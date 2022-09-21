Console.Clear();
Console.WriteLine("****Välkommen till Tobaksmuseet!****\n\nVi hoppas verkligen att du skall trivas under ditt besök hos oss!");
Console.WriteLine("För att påbörja din virtuella rundtur, var god tryck valfri tangent.");
Console.ReadKey(true);
Console.Clear();

Entre();

static void Entre()
{

    Console.WriteLine("Du befinner dig nu i vår entré.\n");
    Console.WriteLine("Här finns det tre dörrar att välja mellan, eller så kan du lämna museet. Vill du: \n\n");
    Console.WriteLine("[1] Gå igenom den norra dörren till exhibitionhall 1?");
    Console.WriteLine("[2] Gå igenom den västra dörren till exhibitionhall 2?");
    Console.WriteLine("[3] Gå igenom den östra dörren till vårt café?");
    Console.WriteLine("[4] Lämna muséet?");

    int val = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    switch (val)
    {
        case 1:
            Rum1();
            break;

        case 2:
            Rum2();
            break;

        case 3:
            Cafe();
            break;

        case 4:
            Console.WriteLine("Välkommen åter! Hoppas ditt beök hos oss har varit lärorikt.");
            Thread.Sleep(3000);
            Environment.Exit(0);
            break;

    }
}

static void Rum1()
{
    Console.WriteLine("Du befinner dig i exhibitionhall 1");
    int val;
    while (true)
    {
        Console.WriteLine("Vill du: \n");
        Console.WriteLine("[1]- Se närmre på processen när man utvinner salt från saltvatten?");
        Console.WriteLine("[2]- Gå vidare till cafét genom den östra dörren?");
        Console.WriteLine("[3]- Gå tillbaka till entrén?");

        val = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        switch (val)
        {
            case 1:
                Console.WriteLine("Fantastiskt hur man kan utvinna så fint salt, eller hur?\n\n");
                break;
            case 2:
                Cafe();
                break;

            case 3:
                Entre();
                break;
        }
    }

}

static void Rum2()
{
    Console.WriteLine("Välkommen till exhibitionhall 2!\n\nHär kan du kolla på våra vackra pipor eller\nse närmre på våra vackra fotografier från Himalaya.\n");

    int val;

    while (true)
    {
        Console.WriteLine("Vill du: \n");
        Console.WriteLine("[1] Titta närmare på våra handgjorda pipor?");
        Console.WriteLine("[2] Titta på våra bilder från Himalaya?");
        Console.WriteLine("[3] Vill du återvända till entrén?");

        val = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        switch (val)
        {
            case 1:
                Console.WriteLine("Fantastiska pipor. Verkligen otroligt hantverk.\n");
                break;

            case 2:
                Console.WriteLine("Du avnjuter helt fantastiska bilder föreställande Himalaya.\n");
                break;

            case 3:
                Entre();
                break;
        }
    }

}

static void Cafe()
{
    int val;
    while (true)
    {

        Console.WriteLine("Du befinner dig i museets café.\nVill du:\n");
        Console.WriteLine("[1] Fika?");
        Console.WriteLine("[2] Ta den västra dörren till exhibitionhall 1?");
        Console.WriteLine("[3] Ta den södra dörren till vår gift shop?");
        Console.WriteLine("[4] Gå tillbaka till entren?");


        val = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        switch (val)
        {
            case 1:
                Console.WriteLine("Du blir serverad ganska torra bullar men ett smakrikt kaffe!\n");
                break;

            case 2:
                Rum1();
                break;

            case 3:
                GiftShoop();
                break;

            case 4:
                Entre();
                break;
        }
    }
}

static void GiftShoop()
{
    Console.WriteLine("Välkommen till giftshopen! Här kan du köpa presententer\noch andra minnen från ditt besök.\n");

    int val;
    while (true)
    {
        Console.WriteLine("Vill du: \n");
        Console.WriteLine("[1] Köpa med dig hem en fin present?");
        Console.WriteLine("[2] Lämna giftshopen?");

        val = Convert.ToInt32(Console.ReadLine());

        Console.Clear();


        switch (val)
        {
            case 1:
                Console.WriteLine("Du köper en fin present som kommer\nhjälpa dig att minnas ditt besök på museet.");
                break;

            case 2:
                Cafe();
                break;

        }
    }
}