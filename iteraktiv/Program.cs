Console.WriteLine("Du vaknar upp på en främande plats och ser en by. går du till byn?");
string gå = Console.ReadLine();

if (gå.ToLower() == "ja")
{
 Console.WriteLine("Du går till byn men när du kommer fram så ser du ingen. Helt blötsligt hör du en dör öppnas bakom dig och en raspig kvinno röst säga 'Kom in'. Går du in?");
 string akseptera = Console.ReadLine();

if (akseptera.ToLower() == "ja");
{
    Console.WriteLine("Du går till dör karmen och blir bemöt med ett födelsedags kallas och flera personer ropar 'Kommin födelsedags barnet'. Det är inte din födelse dag, du känner inte igen någon där. Fortsätter du in?");

string fortsätt = Console.ReadLine();

if (fortsätt.ToLower() == "ja");
{
    Console.WriteLine("Dören bakom dig smäler igen och det blir kål svar. Efter några sekunder av att stå i mörkret så tänds en tändstika och långsamt tänder ljusen på en tårta. När alla ljusen är tända så hör du hur en person börjar sjunga 'ja må du leva' och sen en till och en till. När låten kom till ett slut så var det döts tyst. Gå du och blåser ut ljusen?");
    string blås = Console.ReadLine();

if (blås.ToLower() == "ja");
{
    Console.WriteLine("Du går fram till bordet och säter dig framför tårtan. Du titar runt för att försöka se ansktenen av de som precis fyrade dig men det ända du ser är deras gestalter i mörkret. Du lutar fram för att blåsa utt ljuset men när du tar ett stort andetag så täker en hand din mun och en skarp smärta i genom halsn. Du tittar ner för att se ett par fingrar med vasa nagler stika igenom halsen. När du tittar upp ser du äntligen att alla runt dig är lik, sän gick allt svart. Du är död");
}
}
}

} else {
    Console.WriteLine("Du kår in i skogen ");
}


Console.ReadLine();