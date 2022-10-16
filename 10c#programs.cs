using System;
using System.Collections.Generic;
using static System.String;

namespace Lekstugan
{
    class Program
    {
        static void Main(string[] args)
                {
                Console.Title = "En del program";
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WindowHeight = 40;

                loop:
                Console.Clear();
                Console.WriteLine("Välj Program:");
                Console.WriteLine("1.Räkna kostnad till destination.");
                Console.WriteLine("2.Räkna liter/mil bil.");
                Console.WriteLine("3.Räkna en apparats elkostnad.");
                Console.WriteLine("4.Blanda en drink.");
                Console.WriteLine("5.Vad dina pengar idag var värda tidigare år");
                Console.WriteLine("6.Räkna arbetsgivaravgiften från nettolön");
                Console.WriteLine("7.En gåta.");
                Console.WriteLine("8.Rulla tärning.");
                Console.WriteLine("9.Kalori");
                
                string program =  Console.ReadLine();

        if (program=="1") 
        {
        program1();
        }
        else if (program=="2")
        {
        program2();
        }
        else if (program=="3")
        {
        program3();
        }
        else if (program=="4")
        {
        program4();
        }
        else if (program=="5")
        {
        program5();
        }
        else if (program=="6")
        {
        program6();
        }
        else if (program=="7")
        {
        program7();
        }
        else if (program=="8")
        {
        program8();
		}
        else if (program=="9")
        {
        program9();
        }
        else if (program=="10")
        {
        program10();
        }
        else;

           goto loop;
        }
          



            static void program1()
            {
                //Räkna bensinpriset för ett avstånd.  bensinLiter(distance * literPerKm) * bensinPris = kostnad för sträckan
                // här skapar vi variablarna. 
                double bensinPris;
                double distance;
                double literPerKm;
                double bensin;
                // Vi räknar ut bensinpris per x antal mil

                
                // här ställer vi frågorna och får in svaren som en String.
                Console.WriteLine("Hur mycket är bensinpriset idag? (kr/liter). 19,98?");
                string bensinPrisInput = (Console.ReadLine());
                Console.WriteLine("Hur långt ska du åka? (km)");
                string distanceInput = (Console.ReadLine());
                Console.WriteLine("Hur mycket bensin drar din bil? (liter/mil), 0,786?");
                string literPerKmInput = (Console.ReadLine());

                // här är en If statement inuti en while där vi vill kolla och göra om string till double så vi kan räkna.
                bool bContinue = true;
                while (bContinue)

                if (double.TryParse(bensinPrisInput, out bensinPris) && double.TryParse(distanceInput, out distance) && double.TryParse(literPerKmInput, out literPerKm))        
                {
                // här sker den sista uträkningen samt skriver ut svaret.
                bensin = ((distance/10) * literPerKm);
                Console.WriteLine("Ditt bensinpris kommer att bli " + Convert.ToInt32(bensin * bensinPris) + " kr.");
                Console.ReadLine();
                return;
                }

                else    
                {
                // Här hamnar man om man skriver ut bokstäver eller annat ist för siffror.
                Console.WriteLine("Fel.");
                Console.ReadKey();
                return;
                }
            }

            
            static void program2()
                {
                // Vi räknar ut hur mycket bilen drar per mil
                double prisPumpen;
                double distance;
                double bensinPris;
                double bensin;

                Console.WriteLine("Efter att du har tankat bilen full, sätt på mätarställningen.\nVid nästa tankning fyller du till max samt läser av mätarställningen.");
                Console.WriteLine("Vad fick du betala vid pumpen? (kr)");
                string prisPumpenInput = (Console.ReadLine());
                Console.WriteLine("Hur långt kunde du åka? (km)");
                string distanceInput = (Console.ReadLine());
                Console.WriteLine("Hur mycket är bensinpriset idag? (kr/liter). 19,98?");
                string bensinPrisInput = (Console.ReadLine());

                // här är en If statement inuti en while där vi vill kolla och göra om string till double så vi kan räkna.
                bool bContinue = true;
                while (bContinue)

                if (double.TryParse(prisPumpenInput, out prisPumpen) && double.TryParse(distanceInput, out distance) && double.TryParse(bensinPrisInput, out bensinPris))        
                {
                // här sker den sista uträkningen samt skriver ut svaret. bensinPris prisPumpen distance
                //antal liter / antal km *10
                bensin = prisPumpen / bensinPris;
                Console.WriteLine("Din bil drar " + (bensin / (distance/10)) + " liter/mil");
                Console.ReadKey();
                
                return;
                }

                else    
                {
                // Här hamnar man om man skriver ut bokstäver eller annat ist för siffror.
                Console.WriteLine("Fel.");
                Console.ReadKey();
                return;
                }


                }   

        static void program3()
            {
                // Räkna vad en apparat kostar i elkostnad. Hur mkt
                Console.WriteLine("Var är det för apparat?");
                string apparat = Console.ReadLine();
                Console.WriteLine("Hur mycket kostar 1 kwh idag? (öre) 55,62?");
                string kwhPrisInput = Console.ReadLine();
                Console.WriteLine("Hur mycket watt drar din apparat?");
                string wattInput = Console.ReadLine();
                Console.WriteLine("Hur många timmar ska du ha på den?");
                string timmarInput = Console.ReadLine();
                double kwhPris;
                double watt;
                double timmar;
                double kostnad;
                
                // här är en If statement inuti en while där vi vill kolla och göra om string till double så vi kan räkna.
                bool bContinue = true;
                while (bContinue)

                if (double.TryParse(kwhPrisInput, out kwhPris) && double.TryParse(wattInput, out watt) && double.TryParse(timmarInput, out timmar))        
                {
                // här sker den sista uträkningen samt skriver ut svaret.
                // 0.00001 är kvot för att få i kr och watt ist för kilowatt och öre.
                kostnad = (kwhPris * watt * timmar * 0.00001);
                Console.WriteLine("Din " + apparat + " kan komma att kosta " + Convert.ToInt32(kostnad) + " kr att driva i " + timmar + " timmar.");
                Console.ReadLine();
                return;
                }

                else    
                {
                // Här hamnar man om man skriver ut bokstäver eller annat ist för siffror.
                Console.WriteLine("Fel.");
                Console.ReadKey();
                return;
                }
                Console.ReadLine();
                return;
            }   

        static void program4()
            {
                // Blanda en drink!
                Console.Clear();
                Loopempty:
                        Console.WriteLine("Vad kallas drinken?");
                          string drinkName;
                         drinkName = Console.ReadLine();
                if (IsNullOrEmpty(drinkName))
                        {
                        Console.WriteLine("testa igen");
                        goto Loopempty;
                        }




                Console.WriteLine("Nu behöver vi följande: En ingredients, Volymen i cl och Alkoholhalten. \ntex. \"Vodka [ENTER] 6 [ENTER] 40 [ENTER]\"");
                Console.WriteLine("");
                //skapa veriablarna

                double antalCl;
                double antalAlco;
                bool klar = false;
                int ingredients = 0;                
                string klarText; //ska vi säga instruktion eller räkna ingredienser i promp
                string liquidInput; // beskriver vad som skrevs i promp
                string antalClText;
                string antalAlcoText;

                //listor
                List<string> liquidList = new List<string>(20);
                List<double> clList = new List<double>(); 
                List<double> alcoList = new List<double>();
                
                

                //här startar utfrågningen:
                
                while (!klar)
                {
                ingredients++;

switch (ingredients)

                {
                    case 1:
                klarText = "Skriv en ingrediens.";
                break;
                    case 2:
                Console.Clear();
                klarText = "Du har nu registerat " + (ingredients - 1) + " st ingredientser. För att slutföra skriv Klar.\nAnnars fortsätt... Cola [ENTER] 33 [ENTER] 0 [ENTER]?\" etc.\nSkriv en ingrediens.";
                break;
                    default:
                Console.Clear();
                klarText = "Du har nu registerat " + (ingredients - 1) + " st ingredientser. För att slutföra skriv Klar.\nSkriv en ingrediens.";
                break;
                }


Loopempty1:
                Console.WriteLine(klarText);
                liquidInput = Console.ReadLine();
                if (IsNullOrEmpty(liquidInput))
                        {
                        Console.WriteLine("testa igen");
                        goto Loopempty1;
                        }
                if (liquidInput == "klar" || liquidInput == "klart" || liquidInput == "klar." || liquidInput == "klart.")
                        {
                            // här är man om man skriver "klar" 
                            klar = true;
                            goto klar;
                        }
                        else 
                        {

                        } 


               
  
                LoopCl:
                Console.WriteLine("Hur många Cl " + liquidInput + "?");
                antalClText = Console.ReadLine();

                    if (double.TryParse(antalClText, out antalCl))
                    {

                    }
                    else 
                    {
                        Console.WriteLine("testa igen");
                        goto LoopCl;
                    }

                    LoopAlco:
                Console.WriteLine("Hur mycket alkohol-% det finns i " + liquidInput + "?");
                antalAlcoText = Console.ReadLine();


                    if (double.TryParse(antalAlcoText, out antalAlco))
                    {

                    }
                    else 
                    {
                        Console.WriteLine("testa igen");
                        goto LoopAlco;
                    }
                

                // dags för listor


                liquidList.Add(liquidInput);
                clList.Add(antalCl);
                alcoList.Add(antalAlco);


                }
                        klar:
        if (ingredients == 1)
        {return;}


        Console.WriteLine("");

        Console.Clear();

        ingredients--;
        int indexVarible = 0;
        double sumCl = 0;
        double sumAlco = 0;
        

        while (ingredients != indexVarible)
            {
            Console.WriteLine(liquidList[indexVarible] + ". Volym: " + clList[indexVarible] + "cl. Alcoholhalt: " + alcoList[indexVarible] + "%.");

            sumCl = sumCl + clList[indexVarible];
            
            if (alcoList[indexVarible] != 0 || clList[indexVarible] != 0)
            {
            sumAlco = sumAlco + alcoList[indexVarible] * clList[indexVarible]; 
            }
            indexVarible++;
            }
            sumAlco = sumAlco / sumCl ; 
            sumAlco = Math.Round(sumAlco, 2);

            Console.WriteLine("");
            Console.WriteLine(drinkName + " är en dryck med " + sumCl + "cl volym och en alcoholhalt på " + sumAlco + "%.");
            Console.ReadLine();
 


                
            }





        static void program5()
            {
            Console.WriteLine("\nSkriv en summa och få hur mycket det var värt ett tidigare år (baserat på inflationen i konsumentpriserna).\n1831 års är tidigast. Summan du skriver räknas från 2021.\n");
              


List<double> prisList = new List<double>();
List<double> inflationList = new List<double>(); 
double[] pris = {63, 65, 65, 64, 65, 66, 65, 67, 71, 70, 68, 69, 70, 67, 62, 65, 68, 69, 68, 67, 67, 68, 70, 72, 77, 83, 91, 92, 82, 77, 81, 84, 86, 82, 78, 78, 81, 86, 89, 84, 80, 82, 86, 92, 96, 95, 95, 95, 89, 83, 88, 90, 87, 87, 84, 80, 76, 73, 76, 79, 81, 83, 82, 79, 75, 76, 75, 78, 81, 85, 86, 84, 85, 86, 85, 87, 89, 93, 95, 94, 94, 97, 99, 99, 100, 115, 130, 164, 241, 266, 271, 221, 184, 174, 174, 177, 171, 169, 171, 168, 162, 157, 155, 151, 152, 155, 157, 162, 165, 170, 193, 219, 234, 235, 234, 233, 234, 241, 255, 256, 260, 304, 326, 328, 330, 339, 356, 372, 388, 391, 407, 416, 436, 449, 463, 487, 519, 540, 551, 566, 605, 650, 689, 735, 808, 887, 979, 1090, 1200, 1286, 1461, 1638, 1778, 1937, 2092, 2246, 2341, 2440, 2582, 2748, 3036, 3319, 3395, 3553, 3631, 3723, 3740, 3760, 3754, 3772, 3809, 3902, 3986, 4063, 4078, 4097, 4152, 4244, 4390, 4378, 4434, 4550, 4590, 4588, 4580, 4578, 4623, 4706, 4798, 4884, 4908, 5014}; 
prisList.AddRange(pris);

//prisnivå där 0 är 1830 års kr och 191 (sista) är 2021 års krona
// hämtar från : https://www.scb.se/hitta-statistik/statistik-efter-amne/priser-och-konsumtion/konsumentprisindex/konsumentprisindex-kpi/pong/tabell-och-diagram/konsumentprisindex-kpi/inflation-i-sverige/
 // från excel: (( index1 / index0 -1)*100; math 1st decimal)
int index2 = 0;
double addToListVar = 0;

        for (int index=0; index != 191; index++)
        {
        index2 = index + 1 ;
        addToListVar = ((prisList[index]/prisList[index2]-1)*100);
        inflationList.Add(addToListVar);
        }

   // Checkers     Console.WriteLine("test prislistan: max och mini:" + prisList[0] + "   " + prisList[191]);
  // Checkers      Console.WriteLine("test inflationslistan: max och mini:" + inflationList[0] + "   " + inflationList[10] + "   " + inflationList[190]);

        

            int pengar = 0;
            int year = 0;

              bool loop1 = true; 
              while(loop1)
                {
                Console.WriteLine("\nHur mycket pengar vill du använda dig av?");
                try
                {
                     pengar = Convert.ToInt32(Console.ReadLine());
                



                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nFel: "+ex.Message);
                    continue;
                }

                Console.WriteLine("\nVilket år vill du tillbaka till? (1831-2020)");
                try
                {
                     year = Convert.ToInt32(Console.ReadLine());
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nFel : "+ex.Message);
                }
              loop1 = false;
                }// 


try{

int thisYear = 2021;
int yearNumber = 190 - (thisYear - year) ; // då får vi typ 66 dvs 1955

double valueMoney = 0.0;
double inflation = 0.0;
double siffraInflation = 0.0;



valueMoney = Convert.ToDouble(pengar); // valueMoney är alltså det inmatadade värdet år 2021
// (inflationList[0]) är inflatiaonen år 2021


for (int i = 190; i > yearNumber; i--)
{
     inflation = inflationList[i];
     siffraInflation = inflation*0.01+1.0;
     valueMoney = siffraInflation * valueMoney;
}

Console.WriteLine(" \n" + pengar + "kr år 2021 var värt " + Math.Round(valueMoney, 0) + "kr år " + year);


}
catch (Exception ex)
                {
                    Console.WriteLine("\nFel : "+ex.Message);
                }


// prislistan börjar på 1830 och slutar på 2021 i index 0 och sista 191
// inflationslistan börjar på 1831 och slutar på 2021 i index 0 och sista 190.
// värdet (pengarna) för 2020 från 2021 är (inflationList2021*0,01+1)*Värde(pengarna 2021))
// värdet (pengarna) för 2019 från 2021 är då (inflationList2020*0,01+1)*(inflationList2021*0,01+1)*Värde(pengarna 2021))

        Console.ReadKey();



                Console.ReadLine();
                return;
            }  




        static void program6()
            // Räkna arbetsgivaravgiften från nettolön
            {
                string lönInput;
                double lön;
                double arbetsgivaravgift;
                double arbetsgivaravgiftTotalt;
                double kvot = 31.42;

                Console.WriteLine("Lön innan skatt?");
                lönInput = Console.ReadLine();
            if(double.TryParse(lönInput, out lön))
                {
                arbetsgivaravgift = lön * kvot/100;
                arbetsgivaravgiftTotalt = arbetsgivaravgift + lön;
                Console.WriteLine("Arbetsgivaravgiften är då " + arbetsgivaravgift + " kr.\nTotalt är din kostnad för arbetsgivaren " + arbetsgivaravgiftTotalt + " kr.\n\nAvser kvot 31,42 kvot som gäller i normalfallet år 2022.");


                Console.ReadKey();
                return;
                }
            else
                {
                Console.WriteLine("Fel");
                Console.ReadKey();
                return;
                }
                
            }    

        static void program7()
            {
                // 
                Console.WriteLine("Vad går och går men kommer aldrig fram till dörren?");
                string svar; 
                svar = Console.ReadLine();
            if (svar == "klockan" | svar == "Klockan" | svar == "Klockan!" | svar == "Klockan." | svar == "klockan." | svar == "klockan!")
            {
                Console.WriteLine("Rätt!");
                Console.ReadKey();
            }
            
            else
            {
            Console.WriteLine("Fel");
            Console.ReadKey();
            }
            return;
            }   

        static void program8()
            {
            //Rulla en tärning.
            Console.WriteLine("Tryck valfri knapp och få ett slumpmässigt värde mellan 1 och 6.");
            Console.ReadLine();
            Random rnd = new Random();
            
                Console.WriteLine(rnd.Next(1, 7) + " blev det!"); // returns random integers >= 10 and < 19
                Console.ReadLine();
                return;
            }   

        static void program9()
            {
                // Räknar ut kaloribränning
                Console.WriteLine("Ditt ungefärliga energibehov kan du räkna ut genom den beprövade Harris&Benedict-ekvationen från 1919:");
                Console.WriteLine();
                Console.WriteLine("Hur mkt väger du: (kg)");
                string kgInput = Console.ReadLine();
                Console.WriteLine("Hur lång är du: (cm)");
                string cmInput = Console.ReadLine();
                Console.WriteLine("Hur gammal är du:");                 
                string ageInput = Console.ReadLine();       
                Console.WriteLine("Skriv ett \'m\' för man och \'f\' för kvinna:");
                string mOrKInput = Console.ReadLine();
                Console.WriteLine("Nu behöver vi din stress- och aktivitetsfaktor från 1,2 - 2,0, \ndär 1,2 är en dag framför datorn och 2,0 är en idrottsmans dag inom en konditionsgren:"); 
                string aktivitetInput = Console.ReadLine();
            
                double kg;
                double cm;
                double age;
                double aktivitet;
                double energiintag;
                double viktnedgang;

                    // här är en If statement inuti en while där vi vill kolla och göra om string till double så vi kan räkna.
                bool bContinue = true;
                while (bContinue)

                if (String.Equals(mOrKInput, "m", StringComparison.OrdinalIgnoreCase) && double.TryParse(kgInput, out kg) && double.TryParse(cmInput, out cm) && double.TryParse(ageInput, out age) && double.TryParse(aktivitetInput, out aktivitet))    
                {
                    double BEE;
                    BEE = (66.5 + (13.75*kg) + (5.003*cm) - (6.775*age));
                    energiintag = BEE * aktivitet;
                    viktnedgang = energiintag - 500;
                    Console.WriteLine("Du behöver detta kaloriintag för att bibehålla din vikt: " + Convert.ToInt32(energiintag) + " kcal/dag.\nDu behöver hålla dig på detta för att gå ner 0,5kg/vecka: " + Convert.ToInt32(viktnedgang) + " kcal/dag.\nDitt basala energibehov vid vila (BEE): " + Convert.ToInt32(BEE) + " kcal/dag.");
                                

                Console.ReadKey();
                
                return;
                }
                    else if (String.Equals(mOrKInput, "f", StringComparison.OrdinalIgnoreCase) && double.TryParse(kgInput, out kg) && double.TryParse(cmInput, out cm) && double.TryParse(ageInput, out age) && double.TryParse(aktivitetInput, out aktivitet)) 
                {
                    double BEE;
                    BEE = (66.5 + (13.75*kg) + (5.003*cm) - (6.775*age));
                    energiintag = BEE * aktivitet;
                    viktnedgang = energiintag - 500;
                Console.WriteLine("Du behöver detta kaloriintag för att bibehålla din vikt: " + Convert.ToInt32(energiintag) + " kcal/dag.\nDu behöver hålla dig på detta för att gå ner 0,5kg/vecka: " + Convert.ToInt32(viktnedgang) + " kcal/dag.\nDitt basala energibehov vid vila (BEE): " + Convert.ToInt32(BEE) + " kcal/dag.");
                                
                    Convert.ToInt32(energiintag);
                    Console.ReadKey();
                
                    return;
                }


                    else    
                {
                    // Här hamnar man om man skriver ut bokstäver eller annat ist för siffror.
                    Console.WriteLine("Fel.");
                    Console.ReadKey();
                    return;
                }
            }
        static void program10()
            {
                // 
                Console.WriteLine("Made by me, Daniel Åhlander 2022.");

                Console.ReadLine();
                return;
            }   
        
        
    }
}
