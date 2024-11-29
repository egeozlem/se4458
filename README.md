# SE4458 Midterm

- SE4458 midterm airline company api.
- swagger: /swagger/index.html
- presentation video link: 

# Endpoints
- /api/v1.0/flight/querryFlight
  - returns all the flights with available seats
  - 3 items per page.
- /api/v1.0/flight/insertFlight
  - insert specified flight to the database (only admins)
   - admin only writes from, to, date and capacity.
- /api/v1.0/flight/AdminQuerry
  - returns all the flights with empty seats (only admins).
  - 3 items per page
- /api/v1.0/ticket/buyTicket
  - adds a new ticket for specified flight id into the database.
  - customer only writes flight id, passanger id and name.
- /api/v1.0/ticket/checkIn
   - checks in the ticket provided by customer.
   
# Data Models
### Flights
 - Id: int
 - From: varchar
 - To: varchar
 - Date: DateTime
 - Capacity: int
 - AvailableSeats: int
### Passengers
 - Id: int
 - PassengerName: varchar
 
### Tickets
- Id: int
- FlightId: int
- PassangerName: varchar
- CheckedIn: bool
- PassengerId: int

