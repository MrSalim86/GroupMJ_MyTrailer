# 🌟 GroupMJ_MyTrailer 🌟

## 👥 Contributors:
- **Mohamed Salim**
  - [LinkedIn](https://www.linkedin.com/in/mohamed-salim/)
  
- **Jamal Ahmed**
  - [LinkedIn](https://www.linkedin.com/in/jamal-ahmed/)

---

## 📜 Scenarieoversigt:
**MyTrailer** tilbyder trailerudlejning via partnere som f.eks. Jem & Fix og Fog, hvor kunder kan leje trailere til korttidsbrug. Vores mål er at gøre det nemt for kunderne at leje en trailer gennem en mobilapp.

Med appen kan kunderne:
- Vælge en trailer fra en specifik lokation.
- Leje trailere i op til 24 timer.
- Tilkøbe ekstra services som forsikring.
- Undgå bøder ved at aflevere traileren til tiden.
- Booke langtidsleje (overnatning) via en separat hjemmeside.

---

## 🎯 Forretningsmål:
- **Facilitere trailerudlejning** via en brugervenlig mobilapp.
- **Administrere trailer-tilgængelighed** på forskellige partnerlokationer.
- **Håndtere betalinger** for forsikringer og gebyrer ved forsinket aflevering.
- **Vedligeholde samarbejder** med virksomheder, der stiller parkeringsplads til rådighed for trailere.
- **Separat håndtering** af langtidsleje fra korttidsleje.

---

## 📱 Teknologistak:
- [Tilføj teknologistak her, f.eks. React, Node.js, MySQL osv.]

## 🚀 Installation og Opsætning:
1. Klon repositoryet:
   ```bash
   git clone https://github.com/MrSalim86/GroupMJ_MyTrailer.git


## 🔎 Strategic Domain-Driven Design

Strategisk design hjælper med at opdele komplekse forretningsdomæner i overskuelige dele. Her følger en uddybning af processen:

<details>
  <summary><strong>Trin 2: Identificer Subdomæner</strong></summary>
  
  Vi opdeler det overordnede domæne i subdomæner, som hver repræsenterer forskellige ansvarsområder inden for forretningen.

  **Subdomæner:**

  - **Udlejningsstyring (Kernedomæne):**
    - Håndterer hele trailerudlejningsprocessen: fra booking, afhentning, returnering og håndtering af gebyrer for forsinkede afleveringer.
    - Det vigtigste område i systemet, da det direkte understøtter forretningsværdien.
  
  - **Fakturering og betaling (Understøttende subdomæne):**
    - Ansvarlig for beregning af lejegebyrer og forsinkelsesgebyrer samt håndtering af betalinger.
    - Håndterer også valgfrie forsikringsgebyrer.
  
  - **Forsikringsstyring (Understøttende subdomæne):**
    - Håndterer den valgfrie forsikring, som kunderne kan tilføje til deres lejeaftale.
  
  - **Lokationsstyring (Understøttende subdomæne):**
    - Sporer hvilke trailere, der er tilgængelige på hvilke lokationer, og sørger for, at trailerbeholdningen fordeles på partnerlokationerne.
  
  - **Samarbejdshåndtering (Understøttende subdomæne):**
    - Styrer aftalerne med partnere, som f.eks. Jem og Fix, der stiller plads til rådighed for trailere.
  
  - **Kundehåndtering (Understøttende subdomæne):**
    - Håndterer kunderegistrering, godkendelse og profiladministration.
  
  - **Autentifikation (Generisk subdomæne):**
    - Håndterer brugergodkendelse og adgangsrettigheder.
  
  - **Langtidsleje (Generisk subdomæne):**
    - Styrer langtidsleje af trailere, som typisk håndteres via hjemmesiden.
</details>

<details>
  <summary><strong>Trin 3: Definer Bounded Contexts</strong></summary>
  
  Hvert subdomæne implementeres som en **Bounded Context**, der definerer klare grænser, hvor specifikke forretningsregler og modeller gælder.

  **Bounded Contexts:**
  
  - **Udlejningskontekst (Kernedomæne):**
    - Håndterer booking, afhentning, returnering og forsinkelsesgebyrer.
  
  - **Faktureringskontekst:**
    - Styrer beregning af gebyrer og håndtering af betalinger.
  
  - **Forsikringskontekst:**
    - Håndterer forsikringsmuligheder for trailerudlejning.
  
  - **Lokationskontekst:**
    - Sporer tilgængelighed af trailere på forskellige lokationer.
  
  - **Samarbejdskontekst:**
    - Håndterer aftaler med partnervirksomheder som Jem og Fix.
  
  - **Kundekontekst:**
    - Håndterer kunderegistrering og profiloplysninger.
  
  - **Autentifikationskontekst:**
    - Håndterer brugerlogin og adgangskontrol.
  
  - **Langtidslejekontekst:**
    - Håndterer langtidsleje af trailere.
</details>

<details>
  <summary><strong>Trin 4: Kontekstmapping</strong></summary>
  
  Vi identificerer nu relationerne mellem de forskellige **Bounded Contexts** for at forstå, hvordan data flyder og afhængigheder håndteres.

  **Kontekstmapping:**
  
  - **Udlejningskontekst ↔ Faktureringskontekst (Kunde-leverandør):**
    - Udlejningskonteksten leverer data til faktureringskonteksten til beregning af gebyrer og betalinger.
  
  - **Udlejningskontekst ↔ Lokationskontekst (Kunde-leverandør):**
    - Lokationskonteksten giver oplysninger om trailerens tilgængelighed til udlejningskonteksten.
  
  - **Faktureringskontekst ↔ Eksternt Betalingssystem (Anticorruption Layer):**
    - Eksterne betalingssystemer håndterer betalinger via et Anticorruption Layer.
</details>
