![logoeuro](https://github.com/krzyspie/Euro2024Challenge/assets/47896601/156b1a23-9fe7-48f8-b313-8b190773748c)

# Euro 2024 challange app

## About
The Euro 2024 Challenge app is an application where football fans will have the opportunity to bet the Euro 2024 championship.

## Why this app?
I decided to write this application because I'm personally a football fan, and I wanted to build an application from scratch. With this application, I aim to gain knowledge in software architecture, focusing mainly on modular monolith and DDD.

## Assumptions
The application will be written as a modular monolith so that in the future, it could be rewritten as microservices, which will be my next learning step. Additionally, I want to incorporate Domain-Driven Design concepts. I haven't worked on applications using DDD in my career, so by writing this app, I aim to become familiar with this concept.
I want to develop both the backend and frontend to create a fully functional app. The backend will be written in .NET 8 using C#, and for the frontend, I will use React. Since I don't have experience with React, this application is also an excellent opportunity for me to gain knowledge of the library.

## Features
- Register a user.
- Once registered, the user can create a player after logging in.
- The player can select a team they believe will win the championship.
- Before each match, the player can make predictions on the match result.
- Players will earn points for each correctly predicted match.
- A ranking of players will be presented.

## Tech stack
- .NET 8
- C#
- Postgres
- EF Core
- React
- Use channels for integral events
