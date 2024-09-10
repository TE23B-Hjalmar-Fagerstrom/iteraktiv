Console.WriteLine("Du vaknar upp på en främande plats och ser en by. går du till byn?");
string gå = Console.ReadLine();

if (gå.ToLower() == "ja")
{
 Console.WriteLine("Du går till byn men när du kommer fram så ser du ingen. Helt blötsligt hör du en dör öppnas bakom dig och en raspig kvinno röst säga 'Kom in'. Går du in?");
 string akseptera = Console.ReadLine();

if (akseptera.ToLower() == "ja")
{
    Console.WriteLine("Du går till dör karmen och blir bemöt med ett födelsedags kallas och flera personer ropar 'Kommin födelsedags barnet'. Det är inte din födelse dag, du känner inte igen någon där. Fortsätter du in?");

string fortsätt = Console.ReadLine();

if (fortsätt.ToLower() == "ja")
{
    Console.WriteLine("Dören bakom dig smäler igen och det blir kål svar. Efter några sekunder av att stå i mörkret så tänds en tändstika och långsamt tänder ljusen på en tårta. När alla ljusen är tända så hör du hur en person börjar sjunga 'ja må du leva' och sen en till och en till. När låten kom till ett slut så var det döts tyst. Går du och blåser ut ljusen?");
    string blås = Console.ReadLine();

if (blås.ToLower() == "ja")
{
    Console.WriteLine("Du går fram till bordet och säter dig framför tårtan. Du titar runt för att försöka se ansktenen av de som precis fyrade dig men det ända du ser är deras gestalter i mörkret. Du lutar fram för att blåsa utt ljuset men när du tar ett stort andetag så täker en hand din mun och en skarp smärta i genom halsn. Du tittar ner för att se ett par fingrar med vasa nagler stika igenom halsen. När du tittar upp ser du äntligen att alla runt dig är lik, sän gick allt svart. Du är död");
}else{ 
    Console.WriteLine("Du vänder dig om och försöker desperat öppna dören men inan du viste det så var dit huvud separerat från dina axlar. Du är död");
}
}else{
    Console.WriteLine("Du börar att back från dören men inan du hiner ta ett andra steg så gerpar en skrynglig och blodig hand med klor till naglar din arm. Du hiner inte ens blinka innan din arm var separerad från din gropp. Du vänder dig så snapd du kan och börjar spring för livet men helt blötsligt är något stort och dungt på din ryg. Du faler till marken och snapt som blixten såg du något röra sig mot ditt ansikte. Allt belv svart, Du är död");
}
}else{
    Console.WriteLine("Du börjar att lämna byn men efter du går förbi två hus så är du framför huset med dören och du hör kvinno rösten ställa samma fråg fast med en mer bästämd ton. Du vänder om och börjar gå igen fast nu så springr du i en rak linje. Plösligt hör du ett annat par fotsteg bakom dig och du tittar bakom dig och ser en kvinna dränkt i blod, ögon hålor utan ögon och naglar som påminer mer av en tigers klor. Nu springer du så snapt du bara kan men du hör hur hon långsamt hiner i kap. När du hör henne kanke två meter bakom dig så hör du ett skrik som påminer mer om någon som får ont och du ser slutet av byn. När du närmar dig sista bygnade i byn så känner du att din fott börjar att åka ner, du tittar ner och ser en stor mängd trä spikar och du vet ditt öde. Allt går svart, Du är död");
}

} else {
    Console.WriteLine("Du vänder dig om och ser en skog, du börjar att gå in i skogen och efter fem minuter av att gå så hittar du en stuga med musik spelandes inne ifrån. Knakar du på?");

    string knacka = Console.ReadLine();

if (knacka.ToLower() == "ja")
{
    Console.WriteLine("Du knackar på dören och vänter men inget svar så du knackar igen fast hårdare. Musiken innefrån stugan stängdes av och du hörde fotsteg närma sig dörren men istälet att dörren öpnas och någon börjar att prata med dig så är allt du får en hög smäl och en oerhård smärta i magen. Du tittar ner och ser hur bold bara fosar ur magen och innan du viste det gick allt svart. Du är död");
}else{
    Console.WriteLine("Du går förbi stugan och går jupare in i skogen tils du stöter på en björn och innan du hiner komma på vad man gör när man stöter på en björn så rusar den imot dig. Du hinner bara spring tio meter innan du känner ett par björn klor i rygen. Du föll till marken och hör björnen lukt på dig och börja äta dig. Allt blir mörkt, du är död");
}
}


Console.ReadLine();