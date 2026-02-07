#  Customer Support Ticket System

## Overview
This is a Customer Support Ticket System developed using:
- WinForms (C#) as Desktop Client
- ASP.NET Web API as Backend
- MySQL as Database

The desktop application communicates only via Web API.

## Tech Stack
- C# WinForms
- ASP.NET Web API
- Entity Framework Core
- MySQL
- JSON over HTTP

## Features
### User
- Login
- Create tickets
- View own tickets
- Add comments

### Admin
- View all tickets
- Assign tickets
- Update ticket status
- Add internal comments
- View ticket history

## Database
- Users
- Tickets
- TicketStatusHistory
- TicketComments

## How to Run
1. Run MySQL and execute `database.sql`
2. Open API project and update connection string
3. Run ASP.NET Web API
4. Run WinForms project
5. Login as User/Admin

## Notes
- Server time used for dates
- Role-based access implemented
icketSystemManagement
