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

Strategic design helps to break down complex business domains into manageable parts. Below is a detailed breakdown of the process:

<details>
  <summary><strong> Identify Subdomains</strong></summary>
  
  In this step, we break down the overall domain into subdomains, which represent different areas of business responsibility.

  **Subdomains:**

  - **Rental Management (Core Domain):**
    - Manages the entire trailer rental process: from booking, pickup, return, and handling late fees.
    - This is the most critical part of the system since it directly supports the business value.
  
  - **Billing and Payment (Supporting Subdomain):**
    - Responsible for calculating rental fees (e.g., for late returns) and processing payments.
    - Handles optional insurance fees as well.
  
  - **Insurance Management (Supporting Subdomain):**
    - Manages the optional insurance product that customers can add to their rental.
  
  - **Location Management (Supporting Subdomain):**
    - Tracks which trailers are available at which locations and ensures the inventory is spread across partner locations.
  
  - **Partnership Management (Supporting Subdomain):**
    - Manages agreements with partners (like Jem og Fix) who provide space for the trailers and handles billing for advertising.
  
  - **Customer Management (Supporting Subdomain):**
    - Handles customer registration, authentication, and profile management, including rental history and payment preferences.
  
  - **Authentication (Generic Subdomain):**
    - Manages user authentication and authorization. While necessary, this is generic and not specific to the trailer rental business.
  
  - **Long-Term Rental (Generic Subdomain):**
    - Manages long-term or overnight trailer rentals, which are typically handled via the website rather than the app.
</details>

<details>
  <summary><strong>Step 3: Define Bounded Contexts</strong></summary>
  
  Each subdomain is implemented as a **Bounded Context**, which defines clear boundaries around where specific business rules and models apply.

  **Bounded Contexts:**

  - **Rental Context (Core Domain):**
    - Handles trailer bookings, pickups, returns, and late fees. Governs rules like maximum rental periods, trailer availability, and the rental lifecycle.
  
  - **Billing Context:**
    - Manages the calculation of fees for rentals, insurance, and late returns. Integrates with external payment systems to process payments.
  
  - **Insurance Context:**
    - Manages insurance options for trailer rentals, including purchasing, pricing, and occasional claims processing.
  
  - **Location Context:**
    - Tracks trailer availability at different partner locations and ensures they are ready for customer pickup.
  
  - **Partnership Context:**
    - Manages partner agreements with companies like Jem og Fix for trailer placement and advertising. Handles payments and agreements between MyTrailer and partners.
  
  - **Customer Context:**
    - Manages customer registration, authentication, and profile details, linking rental history and payment preferences to customer accounts.
  
  - **Authentication Context:**
    - Handles user login, registration, and access control. Although necessary, it is a generic function.
  
  - **Long-Term Rental Context:**
    - Manages long-term trailer rentals, often handled through the website and separate from short-term rentals.
</details>

<details>
  <summary><strong>Step 4: Context Mapping</strong></summary>
  
  In this step, we identify the relationships between the different **Bounded Contexts** to understand how data flows and dependencies are managed.

  **Context Mapping:**

  - **Rental Context ↔ Billing Context (Customer-Supplier):**
    - Upstream (Rental Context): Provides booking and rental information to the Billing Context.
    - Downstream (Billing Context): Uses the rental data to calculate fees and process payments.
  
  - **Rental Context ↔ Location Context (Customer-Supplier):**
    - Upstream (Location Context): Provides information about available trailers at specific locations.
    - Downstream (Rental Context): Uses location data to allow customers to book available trailers.
  
  - **Rental Context ↔ Insurance Context (Partnership):**
    - Partnership: The Rental Context allows the Insurance Context to manage insurance options during rental bookings.
  
  - **Billing Context ↔ External Payment System (Anticorruption Layer):**
    - The external payment system processes payments. An Anticorruption Layer (ACL) is used to shield the Billing Context from changes in the payment provider.
  
  - **Partnership Context ↔ Partner Systems (Conformist):**
    - The Partnership Context integrates with partner company systems (like Jem og Fix) to manage trailer placement and advertising agreements.
  
  - **Customer Context ↔ Rental Context:**
    - The Customer Context provides customer information (profile, payment preferences) to the Rental Context during bookings.
  
  - **Authentication Context ↔ All Other Contexts:**
    - The Authentication Context secures access to the system and integrates with other contexts to authorize user actions.
</details>
