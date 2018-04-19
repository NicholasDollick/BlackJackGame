# BlackJackGame
A simply blackjack game with user accounts and GUI. 

Upon launch, an sqlite database is initialized and is used to hold user credentials. Usernames are stored in plaintext, passwords are argon2 encrypted. A trainer class uses information from both the player and dealer's known hand to advise the ideal move. 

**Assets**: contains elements used for display in game

**Cards**: contains all 52 faces and cardback

**src**: contains program source code


*Packages used:*
```
SQLite
EntityFramework
Liphsoft's Argon2
```
