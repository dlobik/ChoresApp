# ChoresApp

A C# console application designed to assign chores of various difficulties to roommates.

This is a project I am working on in my free-time. The eventual goal is to convert this to a web application or possibly even a mobile app.
Designed to assist young college students with the task of assigning chores and keeping their living space clean.

The algorithm I hope to design with this program, will give each individual chore a difficulty level, and each roommates 
choreDifficulty(CD) level will be tracked each week. Logic will be added to ensure that all roommates total chorePoints(CP) are within a certain
tolerance of eachother.

(Making sure that one roommate isn't getting all of the easy chores and one roommate getting all of the hard chores) 
Being able to have the logic adjust assigning rates when needed... 

EX: If roommate1 has 10 chore points, and roommate2 has 20
    assign roommate1 "harder" chores / assign roommate2 "easier" chores ***(by harder and easier, obviously mean chores with lower CP assigned to them)
    
---------------------------------------------------------------------------------------------    
 Future Goals
 ---------------------------------------------------------------------------------------------
 
 1. Add DB of some sort.
 
 2. Email roommates list of weekly chores (manually)
 
 3. Automate #2 so chores are sent out at a set time (perhaps Sunday at 11:59pm????.... Could be changed based on user preference)
 
 4. Add a way for roommates to report a roommate not completing their chores, this deducts CP's from you (You want to have a high number of CP's
    higher number of CP's = number of easier CD chores you get assigned)
    
 5. Add a way to peer review chore completion, so that if a roommate does a chore with CD level 7, but half asses it, only award 5-6 points.
    OR if a roommate goes above and beyond, option to give them kudos or extra CP's.
    
 6.  ........
