# Lab 6 - OOP Arv

Klasser:
- [ ]  `Animal`
    - [ ] `Bird`
    - [ ] `Cat`
    - [ ] `Dog`
      - [ ] `Chihuahua`
      - [ ] `Bulldog`

Funktioner:
- [ ] `Animal`: `Eat()` `Sleep()` `MakeSound()`
    - [ ] `Bird`: `Fly()`
    - [ ] `Cat`: 
    - [ ] `Dog`: 
        - [ ] `Chihuahua`: `Taunt()`
        - [ ] `Bulldog`: `Play()`

Egenskaper:
- [ ] `Animal`: `string SkinType` `string LocomotorOrgan` `int Ears` `string BreathingOrgan` `bool HasTail`
    - [ ] `Bird`: `double WingSpan` `string Sound`
    - [ ] `Cat`: `string EyeColor`
    - [ ] `Dog`: `string Breed`
        - [ ] `Chihuahua`: `string Sass`
        - [ ] `Bulldog`: `string Friendly`

# Om Lab 6 - OOP Arv

I denna uppgift kommer du �va p� att anv�nda arv inom objektorientering. Uppgiften handlar till stor del om att t�nka ut en struktur f�r arv men ocks� delvis om att implementera den i kod.

# Vad du ska g�ra

T�nk dig att du ska skapa en grund f�r ett program som hanterar djur p� ett zoo.

- [ ] Det ska finnas en basklass som heter `Animal`
    - [ ] Klassen ska ha minst fem egenskaper som alla djur delar med varandra.
    - [ ] Klassen ska ocks� ha minst tre metoder som alla djur delar med varandra.
- [ ] Du ska skapa minst tre olika djur som �rver fr�n klassen Animal.
    - [ ] Dessa djur ska implementera minst en ny egenskap vardera och minst en ny metod vardera.
    - [ ] Dessa djur ska ocks� ha defaultv�rden f�r egenskaperna, b�de de som s�tts i klassen och de som s�tts i basklassen.
    - [ ] Alla djur m�ste ha en metod som heter `makeSound()` och som ska skriva ut djurets l�te i konsollen.
    - [ ] Det ska finnas en konstruktor som kan anv�ndas f�r att skapa nya djur.
- [ ] Ett av djuren du skapat ovan ska du sedan dela upp i tv� nya klasser som �rver fr�n det djuret.
    - [ ] Exempelvis kanske du har hund och d� kan du skapa Bulldog och Chihuahua. Resultatet blir arv i tv� niv�er.
    - [ ] Dessa djurvarianter ska ocks� implementera n�gon unik egenskap och n�gon unik metod eller i alla fall en �verlagring som g�r dem unika.
- [ ] I din Main-metod ska du initiera ett flertal olika djur och se till att de g�r sina ljud s� det syns i konsollen att djuren har l�tit.

### Extra utmaning

Vill du ha lite mer utmaning kan du f�rs�ka implementera f�ljande:

- [ ]  G�r s� att �ven m�nniska finns som ett djur.
- [ ]  Ut�ka strukturen s� att det g�rs skillnad p� d�ggdjur och reptiler.
- [ ]  Ut�ka programmet s� att det �ven finns en uppdelning mellan vilda och tama djur.
- [ ]  Ut�ka programmet s� att strukturen �ven omfattar v�xter.

# Din inl�mning

- Skicka in uppgiften i Canvas.
- Skicka in l�nken till ett Github-repo med din kod.