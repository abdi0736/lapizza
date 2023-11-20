
using lapizza;

    /*
    * brug af kundekatalog
    */

    KundeKatalog katalog = new KundeKatalog();
    katalog.Tilføj(kunde0);
    katalog.Tilføj(new Kunde(777,"sams","90145677"))
        
    //Opret Kunde
    Kunde kunde1=new Kunde(444,"Dennis","22303540");
    //Console.WriteLine(kunde1);

    Kunde kunde2 = new Kunde(333,"Abdi", "12345697");
    //Console.Writeline(kunde2);

    Kunde kunde3 = new Kunde(111,"sol", "97647382");
    //Console.WriteLine(kunde3);

    /*
     * BRUG AF KUNDE KATALOG
     */

    KundeKatalog katalog = new KundeKatalog();


    //Tilføjelse af Kunde
    katalog.Tilføj(kunde1);
    katalog.Tilføj(new Kunde(431, "Omar", "21723036"));




    // Slet kunde
    katalog.Slet(111); // Slet kunden med NUMMER 111




    // Opdater kunde
    Kunde opdateretKunde = new Kunde(111, "Opdateret Navn", "12345678");


    Kunde opdateretKundeResultat = katalog.Opdater(opdateretKunde.kundenummer, opdateretKunde.Navn, opdateretKunde.Tlf);


    if (opdateretKundeResultat != null)
    {
        Console.WriteLine($"Kunde opdateret: {opdateretKundeResultat}");
    }
    else
    {
        Console.WriteLine("FEJL: Kunde ikke opdateres. Kundenummeret findes ikke prøv igen.");
    }



    // udskrivelse af kundekataloget
    Console.WriteLine(katalog);

    try
    {
        Kunde kunde22 = katalog.HentKunde(431);
        Console.WriteLine(kunde431);
    }
    catch (KeyNotFoundException knfe)
    {
        Console.WriteLine("FEJL: " + knfe.Message);
    }


    try
    { //    exception
        Console.WriteLine(katalog.HentKunde(431));

    }
    catch(KeyNotFoundException knfe)
    {
        Console.WriteLine("FEJL: " + knfe.Message);
    }
    catch(Exception L)

    //Finde kunde ud fra telefonnummer

    {
        //Console.WriteLine(L.Message);
    }

    Console.WriteLine(katalog.HentKundeUdFraTlf("21723036"));









