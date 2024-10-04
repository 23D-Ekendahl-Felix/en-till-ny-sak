int spelarpengar = 100;

while (spelarpengar > 0){
    Console.WriteLine($"Du har {spelarpengar} KR kvar");

      Console.WriteLine("Vad vill du köpa?");
      Console.WriteLine("1. en banan :10kr");
      Console.WriteLine("2. två bananer :20kr");
      Console.WriteLine("3. tre bananer :50kr");
    Console.WriteLine ("4 mistori box :30kr");

      string köpa = "";
       while (köpa != "1" && köpa != "2" && köpa != "3" && köpa != "4"){
        köpa = Console.ReadLine();
       }

       int prisköpa = 0;

       if (köpa == "1"){
        prisköpa = 10;
       }

  else if (köpa == "2")
  {
    prisköpa = 20;
  }

  else if (köpa == "3")
  {
    prisköpa = 50;
  }

  else if (köpa == "4")
  {
    prisköpa = 30;
  }


    Console.WriteLine("Hur många vill du köpa?");
  int numköpa = 0;
  while (numköpa == 0)
   {
    string num = Console.ReadLine();
    bool success = int.TryParse(num, out numköpa);
    if (success == false)
    {
      Console.WriteLine("Du måste skriva en siffra!");
    }
  }

  int sistapris = prisköpa * numköpa;

  if (sistapris <= spelarpengar)
  {
    Console.WriteLine("Ja, det går bra.");
    spelarpengar -= sistapris;
  }
  else
  {
    Console.WriteLine("Nej, det har du inte råd med!");
  }

}


Console.WriteLine("Nu har du slut på pengar!");
Console.WriteLine("Tryck på ENTER för att avsluta");
Console.ReadLine();
