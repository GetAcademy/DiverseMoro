/*
UkesOppgave - Uke 4:

Etter den fjerde uken skal du kunne løse denne oppgaven

Lag en klasse som representerer en bil. Klassen skal ha følgende egenskaper:
Merke(string)
Registreringsnummer(string)
Årgang(int)
Antall kilometer(int)
*/

using DiverseMoro;

var car = new Car("Nissan Leaf", "EL23555", 2013, 60000);
car.AddKilometers(20);
//car.Kilometers = -10;
Console.WriteLine(car.Name);

/*

Lag også en klasse som representerer en bilforhandler. 
Denne klassen skal ha følgende egenskaper:
Navn(string)
Adresse(string)
En liste av biler (List<Bil>)

Implementer følgende funksjonalitet i bilforhandler-klassen:
En metode som legger til en bil i listen over biler
*/
var dealership = new Dealership(
    "Ærlige Harrys bilbutikk", 
    "Veien 1");
dealership.AddCar(car);
/*
En metode som fjerner en bil fra listen over biler, 
basert på registreringsnummeret til bilen
*/

dealership.RemoveCar("EL23555");
dealership.RemoveCar("AB12345");

/*
En metode som returnerer en liste over alle biler som er 
mer enn X år gamle
*/

var oldCars = dealership.GetOlderCars(5);

/*
En metode som returnerer en liste over alle biler som har 
kjørt mer enn Y kilometer
*/

var longDrivingCars = 
    dealership.GetLongDrivingCars(20000);
var longDrivingCars2 =
    dealership.GetLongDrivingCars(90000);

/*

Eks. på kode som skal fungere med klassene:

Lag så Unittester som tester at klassene fungerer som de skal
*/