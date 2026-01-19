# Simulační model pokladen obchodního domu

## Popis projektu

Tento projekt simuluje proces odbavení zákazníků u pokladen v obchodním domě. Cílem simulace je optimalizovat dobu čekání ve frontách a analyzovat, jak různé parametry (počet zákazníků, počet pokladen, počet položek v košíku) ovlivňují efektivitu obsluhy.

Program umožňuje uživatelsky definovat různé parametry simulace, jako je počet pokladen, intenzita příchodů zákazníků a rozsah počtu položek v košíku. Na základě těchto parametrů simulace generuje náhodné příchody zákazníků a simuluje jejich odbavení v pokladnách. Na konci simulace program vypíše statistiky, jako je průměrná doba čekání a maximální délka fronty.

## Funkce

* **Generování zákazníků**: Simulace příchodu zákazníků v náhodných časových intervalech.
* **Simulace pokladen**: Simulace obsluhy zákazníků u pokladen v závislosti na počtu položek.
* **Výpočet statistik**: Zobrazení průměrné doby čekání, maximální délky fronty a počtu obsloužených zákazníků.
* **Vizualizace na konzoli**: Zobrazení průběhu simulace a výsledků na konzoli.

## Parametry simulace

* **Počet pokladen**: Počet pokladen, které budou obsluhovat zákazníky.
* **Doba simulace (v sekundách)**: Celková doba simulace.
* **Lambda (intenzita příchodů)**: Průměrný počet zákazníků, kteří přicházejí za sekundu.
* **Rozsah počtu položek**: Minimální a maximální počet položek, které může zákazník mít v košíku.

## Příklad výstupu

Výpis parametrů před začátkem simulace:

```
Enter the number of registers (cashiers): 4
Enter the duration of the simulation (in seconds): 60
Enter the average customer arrival rate (customers per second): 1.2
Enter the minimum number of items per customer: 2
Enter the maximum number of items per customer: 7
```

Simulace běží:

```
Simulace běží...

Čas: 17 s
Pokladna 1: ###################### (22 zákazníků)
Pokladna 2: ###################### (22 zákazníků)
Pokladna 3: ###################### (22 zákazníků)
Pokladna 4: ###################### (22 zákazníků)
Pokladna 5: ##################### (21 zákazníků)
Pokladna 6: ##################### (21 zákazníků)
Průměrná doba čekání: 8.8 s
Maximální délka fronty: 22
Celkově obslouženo: 0 zákazníků
```

## Chyby a řešení

* **Neplatný vstup**: Pokud zadáte neplatnou hodnotu (např. záporné číslo), program vás požádá o opravu.
* **Chybný rozsah položek**: Pokud je minimální počet položek větší než maximální, program vás upozorní a požádá o nové zadání.

## Licencování

Tento projekt je licencován pod licencí MIT. Pro více informací si přečtěte soubor LICENSE.
