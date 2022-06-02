# Puzzle Game VR

# Abstract
VR as a platform is becoming increasingly more popular as time goes on, VR as we know it today, requires the user to place a headset upon their head to view the VR world and interact with said world through controllers held with each hand allowing the user to interact with in-game objects. Its most common use-case is in gaming, VR does however have applications in other fields such as education and medicine. The following report is a look into this rising technology and details the development of a VR game, and the research, testing and design associated with it. The purpose of this project it to experiment with VR technology in hopes to create a playable game with its own virtual world, puzzles, and method of interaction with this virtual world via controllers. The research involves looking at VR, its associated technologies, VR in popular culture and its application in fields other than gaming. Furthermore, the research will look into different game engines, and web frame works that could be used in the game’s development. The rest of the body of the report details the design of the game, creation of both functional and non-functional requirement and an in depth look into the process of creating fully playable VR game.
GitHub Repository:  https://github.com/hellhound858/PuzzleGameDSP

# Acknowledgements
Just want to give credit to friends, family my supervisor Dr. Benedict Gaster, my second marker Dr. Craig Duffy and to all others who helped me develop ideas for the project.

# Table of Contents
| Title | Page Number |
| ------------- | ------------- |
| Abstract	| 1 |
| Acknowledgements	| 1 |
| Table of Contents |	2 |
| Table of Figures	| 5 |
| Introduction	| 7 |
| Aims and Objectives	| 7 |
| Chapter outline	| 8 |
| Literature Review |	9 |
| Chapter Introduction |	9 |
| Introduction to VR |	9 |
| VR in past and present media |	9 |
| The Metaverse	| 9 |
| Early Virtual Reality Headsets and Head Mounted Displays	9|
| Sensorama	| 9 |
| Myron Krueger’s Videoplace	| 9 |
| Key elements of VR in 2003	| 10 |
| VR Possibilities outside of gaming |	10 |
| VR in Education	| 10 |
| VR in Medicine	| 11 |
| Game engines	| 11 |
| Tracking technology	| 12 |
| Xbox Kinect	| 12 |
| SLAM Overview	| 13 |
| Offline-SLAM for Map Acquisition a simple example of SLAM	| 13 |
| Oculus and SLAM	| 13 |
| Application Programming Interface	| 14 |
| REST API	| 14 |
| Web frameworks in python	| 14 |
| Django	| 14 |
| Flask	| 14 |
| WebSocket Scripting	| 15 |
| Examples of VR puzzle games	| 15 |
| Tetris® Effect: Connected	| 15 |
| I Expect You To Die 2 | 16 |
| Methodology	| 18 |
| Chapter Introduction	| 18 |
| Selected Methodology	| 18 |
| Requirements	| 19 |
| Chapter introduction	| 19 | 
| The Requirements	| 19 | 
| Functional Requirements:	| 19 |
| Requirements Analysis for functional requirements:	| 22 |
| Non-functional Requirements:	| 24 | 
| Requirements Analysis for non-functional requirements:	| 25 |
| Design	| 26 |
| Introduction to Chapter	| 26 |
| High Level Design	| 26 |
| Architecture diagram	| 26 |
| Use-Case Diagram Website (Django)	| 27 |
| Use-Case diagram puzzle game VR (Unity)	| 28 |
| Database design	| 28 |
| Website Design	| 29 |
| Low Level Design	| 31 |
| Class Diagram puzzle vr game (Unity) Part 1	| 31 |
| Class Diagram puzzle vr game (Unity) Part 2	| 32 |
| 8 Queens flowcharts:	| 33 |
| 2048 Game Flowcharts	| 38 |
| Reuse of Existing Code	| 38 |
| Implementation	| 39 |
| Chapter Introduction	| 39 |
| Sprint 1:	| 39 |
| Burn Down Chart:	| 39 |
| Explanation important code completed in sprint/Reflections:	| 40 |
| Functional Requirements Testing	| 43 |
| Sprint 2:	| 44 |
| Burn Down chart:	| 44 |
| Explanation important code completed in sprint/Reflections:	| 45 |
| Functional Requirements Testing	| 49 |
| Sprint 3:	| 51 |
| Burndown chart:	| 51 |
| Explanation important code completed in sprint:	| 52 |
| Functional Requirements Testing	| 52 |
| Sprint 4:	| 54 |
| Burn-Down chart:	| 54 |
| Explanation important code completed in sprint/Reflections:	| 55 |
| Functional Requirements Testing	| 55 |
| Non-functional requirements testing:	| 56 |
| Evaluation of testing	| 56 |
| Completed Implementation Images	| 57 |
| Project Evaluation	| 62 |
| Research	| 62 |
| Requirements	| 62 |
| Methodology	| 62 |
| Design	| 62 |
| Implementation and testing	| 62 |
| Further Work and Conclusions	| 63 |
| Conclusion	| 63 |
| Future work | 63 |
| References |	64 |

# Table of Figures
| First Header  | Second Header |
| ------------- | ------------- |
| Figure 1 | VR Game and Headset Image	14 |
| Figure 2 |  (Mishra, Shrawankar, 2016) ASSESSMENT OF ENGINES ON PERFORMANCE ASPECTS.	17 |
| Figure 3 |  (Zhang, 2012, pp.4-12) Depth Map	18
| Figure 4 |  Body tracking (Zhang, 2012, pp.4-12).	19 |
| Figure 5 |  The image provided is from the game Tetris® Effect: Connected (Monstars Inc. Resonair and Stage Games 2020).	21 |
| Figure 6 |  The image provided is from the game Tetris® Effect: Connected (Monstars Inc. Resonair and Stage Games 2020).	22 |
| Figure 7 |  The image provided is from the game I Expect You To Die 2 (Schell Games 2021).	22 |
| Figure 8 |  The image provided is from the game I Expect You To Die 2 (Schell Games 2021).	23 |
| Figure 9 |  Functional requirements.	28 |
| Figure 10 |  Non-functional requirements.	30 |
| Figure 11 |  Architecture Diagram.	32 |
| Figure 12 |  Website Use Case Diagram	33 |
| Figure 13 |  VR Game Use Case Diagram	34 |
| Figure 14 |  Database Design	34 |
| Figure 15 |  Home Page UI Design	35 |
| Figure 16 |  8 Queens Leader Board Page Design	35 |
| Figure 17 |  2048 Leader Board Page Design	36 |
| Figure 18 |  About Page Design	36 |
| Figure 19 |  VR Game Class Diagram Part 1	37 |
| Figure 20 |   VR Game Class Diagram Part 2	38 |
| Figure 21 |  PossibleMovesXAxis function flowchart	39 |
| Figure 22 |  Part of PossibleMovesXAxis function flowchart	39 |
| Figure 23 |  CalcDiagonalTopRight Function Flowchart	40 |
| Figure 24 |  CalcDiagonalTopRight Function Flowchart Loops	40 |
| Figure 25 |  CalcDiagonalTopRight Function Flowchart Loops, Add Chess coordinates.	41 |
| Figure 26 |  CalcDiagonalTopLeft Function Example	42 |
| Figure 27 |  Basic Game Logic For 8 Queens	43 |
| Figure 28 |  Cube merge and move algorithm 2048 Flowchart	44 |
| Figure 30 |  Burn Down Chart Sprint 1.	45 |
| Figure 31 |  Sprint 1 tasks	46 |
| Figure 32 |  Chess Coordinate List Part A.	46 |
| Figure 33 |  Chess Coordinate List Part B.	46 |
| Figure 34 |  PossibleMovesXAxis Code Snippet	46 |
| Figure 35 | CalcDiagonalTopLeft Code Snippet	47 |
| Figure 36 |  Chess Board Example	48 |
| Figure 37 |  All Possible Moves Output Example.	48 |
| Figure 38 |  InLineOfSightQueen Code Snippet	49 |
| Figure 39 |  CalculateScore Code Snippet	49 |
| Figure 40 |  Functional requirements testing sprint 1.	50 |
| Figure 41 |  Burndown chart sprint 2.	51 |
| Figure 42 |  Sprint 2 Tasks	51 |
| Figure 43 |  cubeMoveMerge Code Snippet.	52 |
| Figure 44 |  MoveMerge Code Snippet Part 2	53 |
| Figure 45 |  2048 updated row screenshot	54 |
| Figure 46 |  LeftButton Code Snippet.	55 |
| Figure 47 |  Functional Requirement Tests Sprint 2.	56 |
| Figure 48 |  Burn Down Chart Sprint 3.	57 |
| Figure 49 |  Sprint 3 Tasks	57 |
| Figure 50 |  REST API Code Snippet	58 |
| Figure 51 |  HTTPRequest Code Snippet	58 |
| Figure 52 |  Functional Requirements Tests Sprint 3.	59 |
| Figure 53 |  Burn Down Chart Sprint 4.	60 |
| Figure 54 |  Sprint 4 Tasks	60 |
| Figure 55 |  Keyboard Code Snippet.	61 |
| Figure 56 |  Functional Requirements Test Sprint 4.	62 |
| Figure 57 |  Non-Functional Requirement Tests	62 |
| Figure 58 |  Holding Chess Piece	63 |
| Figure 59 |  8 Queens Solved |
| Figure 60 |  8 Queens Solved with Text	64 |
| Figure 61 |  8 Queens Invalid Solution	64 |
| Figure 62 |  Grid Screenshot	65 |
| Figure 63 |  Grid Screenshot Lost State |
| Figure 64 |  Grid Lost Text	65 |
| Figure 65 |  Home page	66 |
| Figure 66 |  8 Queens Leader board	66 |
| Figure 67 |  2048 Leader Board	67 |
| Figure 68 |  About Page	67 |

# Introduction
In the past few years VR has become more and more popular, in both popular culture and in areas like the gaming industry. It has also seen use in both medical fields and in education. Some examples of VR appearing in popular culture include a very recent example, a movie called Ready Player One, originally adapted from a book written by Ernest Cline (Cline et al., 2011). There have also been other examples of VR like technology appearing in books such as in Virtual Light (Gibson et al., 1993) written by William Gibson. Both books will be further explained in the research section of the report. Certain concepts exist surrounding VR like the metaverse, this will also be explored further in the research section of the report. 
There are currently many headsets that exist in the real world outside of fiction such as the HTC Vive (HTC Vive) and Oculus Quest 2(Meta). These headsets have their own benefits and drawbacks, but the one that we will be concentrating on in this project is the Oculus quest 2. Developed by Meta, formally known as Facebook. This headset has become very popular, due to its price and plethora of features. 
Aims and Objectives
1.	Research VR, its concepts, applications, and associated technologies.
2.	Research game engines and web framework to help create the game.
3.	Identify appropriate requirements for the game.
4.	Identify an appropriate methodology to use when developing the game.
5.	Create a fully working VR Puzzle Game for the Quest 2:
•	Create the 8 Queens puzzle.
•	Create 2048 puzzle.
6.	Create a website to display score data in leader boards for both puzzles.
7.	Create a REST API to allow communication between the headset and webserver.
8.	Evaluate the project, including the report and the developed program.
This report documents the research, design and development of a VR game that involves puzzles. More specifically the 8 Queens Puzzle and the 2048 Puzzle. The 8 Queens puzzle involves placing a set of 8 queens on a chessboard in such a way that none of them can attack each other. 2048 is a game in which a user moves and merges cubes to make a 2048 cube. Merging involves adding two identical cubes together so a 2 cube and a 2 cube to make a cube with the cube of the two previous cubes, in this example a 4 cube will be created. The game is won by adding two 1024 cubes together to make 2048 and the game is lost by have no moves or merges to make.
 The game will be created using a game engine, in this case Unity, the language of choice is C#. 
Also, a website will be developed alongside the game to display scores submitted by players in a leader board for each of the puzzles. 
The main motivation to undertake this project is, VR as a platform has a lot of potential, in terms of its both future and current applications. As a technology it has come very far in such a short period of time, with the technology developing rapidly in such as short span of time. This project is a method in which we can explore this rising technology further.

# Chapter outline
(Chapter 1) Literature Review
The literature review contain research done at the beginning of the project, the research will include VR research on, its concepts, applications, and associated technologies. Research will also include a look at game engines and web framework that will be used to create the game.
(Chapter 2) Requirements
The requirements will contain two tables, the first being functional requirements, which involve functions of the system and the second being the non-functional requirements, which involve constraints on certain functionality.
(Chapter 3) Methodology
The methodology section will detail the development methodology that will be used during the development process in this case Agile Scrum, it will include and outline sprints and the tasks that will be likely undertaken during them.
(Chapter 4) Design
The design section will contain a list of design diagrams, including but not limited to, class diagrams, use-case diagrams, flowcharts, and UI design.
(Chapter 5) Implementation
This chapter will detail the implementation process, brief explanations of key code written during each sprint with screenshots of said code.
(Chapter 6) Project Evaluation
This is where the whole project is evaluated and reflected upon.
(Chapter 7) Further work and Conclusions
The section details further work to be undertaken in the future and final conclusions on the project.

# Literature Review
## Chapter Introduction
This chapter of the report contains my research on VR technologies.
## Introduction to VR

There have been many representations of VR in the media, in the form of books and films. 
VR in past and present media
The first book, William Gibson’s Virtual Light, in summary, is about a pair of glasses which allow a person to view information by feeding it into that person’s optic nerve (Gibson et al., 1993). Ready player one is a dystopian future in which people use virtual reality to escape the tough reality of life. The VR world they go to is called the Oasis (Cline et al., 2011). 

## The Metaverse
The Metaverse can be described as a 3-dimensional virtual universe (Dionisio, III, Gilbert, 2013). This however differs from the concept of cyberspace that represents all shared online and virtual space across all dimensions (Dionisio, III, Gilbert, 2013). There are multiple different versions of the metaverse, the first example is an enlarged virtual world, and another is a large network of virtual worlds (Dionisio, III, Gilbert, 2013). The second example can be seen in ready player one. The virtual universe is split into multiple virtual worlds (Cline et al., 2011) that players can explore interact with, they are able to travel to other worlds inside the universe. 
All these examples show how virtual reality has been represented over the years. However, today the technology is far more primitive compared with the previously given fictional examples.
To illustrate how VR works in reality, one could look to early examples of VR headsets and VR like devices that have previously been developed in the past.
Early Virtual Reality Headsets and Head Mounted Displays
## Sensorama
An early example of a VR headset was the Sensorama( Craig, R. Sherman,  D. Will, 2009). This piece of literature describes early VR technology. “The Sensorama was the brainchild of cinematographer and inventor Morton Heilig”( Craig,Sherman,Will, 2009).  As described by the writer of this literature the system “was lacking a major component of the modern virtual reality system: response based on user’s actions”( Craig,Sherman,Will, 2009). Early headsets were very basic, this simply means that the system did not allow a user’s actions to have any impact on the virtual world unlike modern day headsets that allow a user to interact with the virtual world using controllers or in some cases the user’s hands. 
## Myron Krueger’s Videoplace
“Krueger’s artificial reality provided a second-person view of a virtual world in which participants could watch themselves within the world” ”( Craig,Sherman,Will, 2009). Craig, R. Sherman literature also talks about another early VR headset such as Myron Krueger’s Video Place. This headset gave the user a “second-person point of view” of themselves. No games could be played on this headset and the user did not have any devices or other sensors attached to their body ( Craig,Sherman,Will, 2009). Unlike some modern-day VR headsets that use full body tracking that require sensors to be placed all over the user’s body including head, legs and arms depending on what degree of tracking you want. In terms of features, from what is conveyed in the paper, these headsets are very limited in terms of functionality and are nothing like the headsets we have today.
## Key elements of VR in 2003
There are a few key elements of VR that have been identified in the past, this information will help with the creation of the puzzle game and help to mitigate any mistakes that could be made during design.
The paper written by Sherman details four key elements of virtual reality. 
A virtual world is the context of a medium (Sherman, Craig, 2003). In the case of this project this would refer to the game world. This will also tie into the writers next point regarding immersion. This is because a virtual world, if created correctly helps give a sense of immersion and improves the experience of the player.
It must have immersion, into a different reality or another point of view (Sherman, Craig, 2003). It must have both Physical and mental immersion, this can be split into two, mental immersion can often be referred to as having a mental presence within the world (Sherman, Craig, 2003) and physical immersion is when, a body enters into a medium (Sherman, Craig, 2003). Both points apply today, If the VR experience will be greatly affected if immersion is broken, so during development extra attention must be paid to this as one of the major causes of breaking immersion is frame drops whilst playing a VR game, therefore it is imperative that my code is optimised.
It must have sensory feedback, “VR allows participants to select their vantage point by positioning their body and to affect events in the virtual world” (Sherman, Craig 2003). This refers to moving your arm for example in the VR worlds and have it match up with the real world. This is a very good point and will be taken into consideration, the main method of movement, and interaction in with the Quest 2 is using the controllers. This does provide a degree of sensory feedback, referred to in this point by the writer.
The final key element according to the writer is, Interactivity. “For virtual reality to seem authentic, it should respond to user actions, namely, be interactive” (Sherman, Craig, 2003). In the case of current day VR this could be seen to be tied to the act of a user performing an action and getting a reaction. For example, a player pushes a box with their in-game hand and the box moves back in response. This also could be seen to further immersion which ties into the writers second point.
## VR Possibilities outside of gaming
### VR in Education
There are many applications for VR outside of gaming for entertainment. There also are applications for VR in the educational sector, for example in the research paper by (Holly, Pirker, Resch, Brettschuh, Gutl, 2021, pp.107-119), the paper shows how learning environments like Marroon (GameLabGraz), are environments designed to provide an interactive learning environment for students and allows students to perform experiments in a VR environment. The experiment that the researchers performed consisted of testing several factors for the game, Immersion, and engagement, learning value from both the teachers and learner’s respective perspectives (Holly, Pirker, Resch, Brettschuh, Gutl, 2021, pp.107-119). It would be useful to utilise some of these testing criteria namely immersion in this project as found in other papers during this literature review, immersion is a factor considered as one of the key elements of VR. In summary, the response was positive in all areas of study. Most students and teachers were happy with the level of immersion and engagement, and on average most students and teachers concluded that it had a high learning value (Holly, Pirker, Resch, Brettschuh, Gutl, 2021, pp.107-119). 

### VR in Medicine 
VR also has applications in medicine as out lined in this study by (Pourmand, Davis, Marchak, Whiteside, Sikka, 2018, pp.1-6). The study delves into how VR can be used to distract patients from many types of pain, including acute pain (Pourmand, Davis, Marchak, Whiteside, Sikka, 2018, pp.1-6). It concluded that VR has become an important option for helping with pain management and how the evidence in said study shows how VR can be effective at distracting patients from many types of pain including acute and chronic short-term (Pourmand, Davis, Marchak, Whiteside, Sikka, 2018, pp.1-6). The study references a paper that goes on to run some experiments on hospitalized patients, it was noted in the study that patients, had a significant drop in pain by around 24% in the VR group of patents compared to the 13% drop in pain in the control group (Tashjian, 2017, pp.e9). 
## Game engines
The Wikipedia definition of a game engine is as follows, "A game engine is a software framework primarily designed for the development of video games, and generally includes relevant libraries and support programs. The "engine" terminology is like the term "software engine" used in the software industry" (Wikipedia, 2021). 
For further clarification this is what is defined as a game engine in comparison between famous Game Engines and Eminent Games journal article. Game engines are sets of tools that allow a programmer to, perform game related tasks like interpretation and physics related tasks and for focusing on the niceties that make the game great(Mishra, Shrawankar, 2016, pp. 69). 

![alt text](https://github.com/[username]/[reponame]/blob/[branch]/image.jpg?raw=true)
