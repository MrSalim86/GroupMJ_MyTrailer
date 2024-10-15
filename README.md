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
  <summary><strong>Identify Subdomains</strong></summary>
  
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
  <summary><strong>Define Bounded Contexts</strong></summary>
  
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
  <summary><strong>Context Mapping</strong></summary>
  
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


## ⚙️ Tactical Domain-Driven Design

Tactical design helps to define the specific actions, events, and rules that govern the system's behavior. Below is a detailed breakdown of the steps involved:

<details>
  <summary><strong>Identify Domain Events</strong></summary>
  
  These are the critical events that occur in the system. They are typically written in the past tense since they represent something that has already happened.

  **Key Domain Events:**

  1. **Customer Registered** – When a new customer registers in the system.
  2. **Trailer Location Assigned** – When a trailer is placed at a specific location.
  3. **Trailer Booked** – When a customer books a trailer via the app.
  4. **Trailer Picked Up** – When a customer picks up a trailer.
  5. **Rental Fee Calculated** – The system calculates the rental fee based on the booking details.
  6. **Insurance Purchased** – When the customer purchases insurance for the rental.
  7. **Trailer Returned** – When the customer returns the trailer to the location.
  8. **Excess Rental Fee Applied** – If the trailer is returned late, an extra fee is added to the bill.
  9. **Payment Processed** – When the customer’s payment for insurance and any fees is processed.
  10. **Overnight Trailer Rental Booked** – A long-term, overnight rental is booked via the website.
  11. **Company Paid for Advertising** – Partner companies pay MyTrailer for the advertising service.
</details>

<details>
  <summary><strong>Identify Commands</strong></summary>
  
  These are actions that users or external systems can perform to trigger a change or event in the system.

  **Key Commands:**

  1. **Register Customer** – Command to register a new user in the system.
  2. **Book Trailer** – Command to book a specific trailer at a given location.
  3. **Select Insurance** – Command to purchase insurance for the trailer.
  4. **Confirm Trailer Pickup** – Command to confirm the customer has picked up the trailer.
  5. **Return Trailer** – Command to return the trailer to its original location.
  6. **Apply Excess Rental Fee** – Command triggered if the trailer is returned late.
  7. **Process Payment** – Command to process the customer’s payment for insurance and excess rental fees.
  8. **Assign Trailer to Location** – Command to assign a trailer to a specific location.
  9. **Book Overnight Trailer Rental** – Command to book a long-term overnight rental via the website.
</details>

<details>
  <summary><strong>Identify Aggregates</strong></summary>
  
  Aggregates represent groups of objects and entities that form a single unit for data changes. They are responsible for enforcing business rules and managing consistency.

  **Key Aggregates:**

  1. **Customer Aggregate** – Responsible for managing customer registrations, bookings, and payments.
  2. **Trailer Aggregate** – Manages the state of a trailer, including its availability, location, and booking details.
  3. **Rental Aggregate** – Manages the entire lifecycle of a rental (booking, pickup, return, fees, and insurance).
  4. **Location Aggregate** – Tracks the locations where trailers are placed, along with their availability.
  5. **Company Partnership Aggregate** – Manages the relationships between MyTrailer and the partner companies that host trailers on their sites.
</details>

<details>
  <summary><strong>Identify Policies</strong></summary>
  
  Policies represent business rules or automated decisions that are triggered by certain events.

  **Key Policies:**

  1. **Late Return Policy** – If a trailer is returned after the agreed time, an excess rental fee is applied.
  2. **Max Rental Period Policy** – Trailers can only be rented for a maximum of 24 hours or until midnight, whichever comes first.
  3. **Overnight Rental Policy** – Long-term rentals are only allowed from specialist locations and must be booked via the website.
  4. **Insurance Policy** – Customers are offered insurance for the trailer at a fixed fee (50 Kr), which is added to the payment if selected.
  5. **Advertising Payment Policy** – Partner companies are billed for the advertising service based on the number of trailers at their location.
</details>

<details>
  <summary><strong>Identify External Systems</strong></summary>
  
  These are systems outside of the MyTrailer domain that interact with the system.

  **Key External Systems:**

  1. **Payment Gateway** – Processes payments for insurance and excess rental fees.
  2. **Partner Company Systems** – Systems for the companies that host trailers, used for managing payments to MyTrailer for advertising.
  3. **Website System** – Used for managing long-term (overnight) bookings, which is separate from the app.
</details>

<details>
  <summary><strong>Event Storming Visualization: Flow of Events</strong></summary>
  
  The flow of events represents how commands trigger events, and how policies and external systems interact.

  1. **Customer Registered**
     - Command: Register Customer
     - Event: Customer Registered

  2. **Trailer Location Assigned**
     - Command: Assign Trailer to Location
     - Event: Trailer Location Assigned

  3. **Trailer Booked**
     - Command: Book Trailer
     - Event: Trailer Booked
     - Policies Triggered: Max Rental Period Policy

  4. **Insurance Purchased**
     - Command: Select Insurance
     - Event: Insurance Purchased
     - Policy Triggered: Insurance Policy

  5. **Trailer Picked Up**
     - Command: Confirm Trailer Pickup
     - Event: Trailer Picked Up

  6. **Trailer Returned**
     - Command: Return Trailer
     - Event: Trailer Returned
     - Policies Triggered: Late Return Policy, Apply Excess Rental Fee

  7. **Rental Fee Calculated**
     - Command: Calculate Rental Fee
     - Event: Rental Fee Calculated

  8. **Excess Rental Fee Applied**
     - Command: Apply Excess Rental Fee
     - Event: Excess Rental Fee Applied (if applicable)

  9. **Payment Processed**
     - Command: Process Payment
     - Event: Payment Processed
     - External System: Payment Gateway

  10. **Company Paid for Advertising**
      - Policy Triggered: Advertising Payment Policy
      - Event: Company Paid for Advertising

  11. **Overnight Trailer Rental Booked (specialist case via website)**
      - Command: Book Overnight Trailer Rental
      - Event: Overnight Trailer Rental Booked
      - Policy Triggered: Overnight Rental Policy
</details>

## C4 Diagram

### Container Diagram
![Container Diagram](MrSalim86/GroupMJ_MyTrailer/ContextDiagram.png)

### Context Diagram
![Context Diagram](path_to_your_repo/ContextDiagram.png)

