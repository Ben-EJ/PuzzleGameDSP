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
| Figure Number  | Title |
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

### ASSESSMENT OF ENGINES ON PERFORMANCE ASPECTS

| Game Engine  |  Platforms | Language Support | AI Engine  | Physics Engine | Forward Compatibility | Backward Compatibility |
| ------------- | ------------- | ------------- | ------------- | ------------- | ------------- | ------------- |
| CryEngine 3  |  Win, X360, PS3, Wii U | C++, Visual Script, Lua  |   Lua-driven AI | Soft body  |  No |  Yes |
|  Hero Engine | Win  |  Hero Script | Hero Script  |  AIseek | PhysX  |  Partial | Yes |
|  Source 2 Engine | Win, Mac, Xbox 360, Wii, Linux, Android  |  C++ |  AI Director  |  Ipion | No  |  Partial |
|  Unity 4 |  BlackBerry, Win Phone, Win, OS X, Android, iOS, Apple TV, PS3/4, PS Vita, Xbox 360, Xbox One, Wii U, Wii | C#, JavaScript, Boo |   RAIN  | PhysX  | Partial| Yes |
| Unreal 4 Engine  | Windows, OS X Linux, Xbox 360/ One, PS3/4, Wii U, Android, iOS, WinRT, PS Vita  | C++, C#, GLSL, CG, HLSL  |  Kynapse  | PhysX  | Partial  |  Yes  |
| Vision Engine 8  |  Windows, Xbox 360, PS3, Wii, Wii U, iOS, Android, Win Phone, PS Vita | C++  |  Kynapse  |  Bullet, ODE, PhysX | No  |  Partial |

Figure 2 (Mishra, Shrawankar, 2016) ASSESSMENT OF ENGINES ON PERFORMANCE ASPECTS

As can be seen from figure 2 CryEngine and Hero Engine don’t support nearly as many platforms as the other four. Furthermore, Hero engine does not support any of the more popular programming languages like C++ or C#. In addition to this Hero Engine, Unity and Unreal Engine only have partial forward compatibility. 
Unreal Engine has Blueprint Visual Scripting” (Chu, Zaman, 2021, pp.188). It was created to support the workflow of designers and artists by giving them access to tools normally only accessible to programmers (Chu, Zaman, 2021, pp.188). Blueprints is object oriented visual programming system which is used to create gameplay elements (Chu, Zaman, 2021). 
Unity has many functionalities, including animation, scenes, object generation, lens control and these features are controllable by a c# program (Tsai, Jhu,Chen, Kao, Chen, 2021, pp.1401 - 1417). Unity also has plugins that can give it features like blueprints, a recent example of plugins that allow Unity to obtain this functionality include, FlowCanvas, Playmaker, Bolt and Amplify shader editor (Chu, Zaman, 2021, pp.188). 

## Tracking technology
### Xbox Kinect 
Oculus uses state of the art tracking technology that developed from a massively successful technology known as the connect Kinect, was an early example of SLAM being used. Originally developed at Microsoft Research Cambridge, and then productized by the Xbox team at Microsoft. The Kinect is made up of 3 devices, the first being Depth sensor, the second being an RGB camera and lastly a 4-microphone array, these all give 3D full body tracking, facial recognition, and voice recognition (Zhang, 2012, pp.4-12).  The Kinect senses depth using its IR camara and IR projector which make up the depth sensor (Zhang, 2012, pp.4-12). This works by the IR projector projecting dots in an area, then if the dot in said image matches dots in the known dot pattern produced by the projector it is possible to rebuild it using 3D triangulation (Zhang, 2012, pp.4-12). 

![Figure 3 (Zhang, 2012, pp.4-12) Depth Map](https://github.com/[username]/[reponame]/blob/[branch]/image.jpg?raw=true)

Here is a depth map produced by the Kinect, the darker the grey the closer the object (Zhang, 2012, pp.4-12). This can then be used in conjunction with other techniques to track a person's body, Figure 3 gives the general outline of this.

![Figure 4 Body tracking (Zhang, 2012, pp.4-12)](https://github.com/[username]/[reponame]/blob/[branch]/image.jpg?raw=true)

From the depth image body part distribution is inferred, this is done per pixel as can be seen from the second part of Figure 4 above. (Shotton, Fitzgibbon, Cook, Sharp, Finocchio, Moore, Kipman, Blake, 2011). Local modes of this are then hypothesized to provide a good quality proposal for the joints in 3 dimensions, this all can also be done for multiple users(Shotton, Fitzgibbon, Cook, Sharp, Finocchio, Moore, Kipman, Blake, 2011).
## SLAM Overview 
SLAM stands for Simultaneous Localization and Mapping (MathWorks). There are many applications for SLAM including, using it with autonomous vehicles to produce maps of environments and pinpoint a vehicle in that map all at the same time (MathWorks). They can allow the vehicle to map environments and avoid obstacles and path find in that environment (MathWorks). 

There are many methods of SLAM, the first is Visual SLAM. This type of SLAM utilises images obtained from cameras and other sensors. There are two main types of this version of SLAM, Spare methods that match features of images at then utilise an algorithm like ORB-SLAM and dense methods that use algorithms like LSD-SLAM (MathWorks).
The second method of SLAM is LiDAR SLAM this version of SLAM usually uses some form of distance sensor, for example a laser sensor (MathWorks).
Both types of SLAM have advantages and disadvantages. LiDAR is not affected by light level and its angular view is quite large. Unfortunately, however, on a large-scale LiDAR is not as viable in certain situations as it can get very expensive (Huang, Zhao, Liu, 2019). Visual SLAM, however, does not do so well in low light conditions and in low texture environments (Huang, Zhao, Liu, 2019). Visual SLAM can usually be implemented at a much lower price as RGB-D cameras, used to implement it can be obtained quite cheaply (Taketomi, Uchiyama, Ikeda, 2017).

## Offline-SLAM for Map Acquisition a simple example of SLAM
There are many ways to use SLAM, a simple example of SLAM involving robots is as follows; the first phase is map learning phase. As a robot moves through an environment the sensor data is obtained, and labels are given such as place names. After this the SLAM algorithm creates a map from the data to robot collected. This data can then be used to plan paths and localization and so on (Frese, Wagner, Rofer, 2010, pp.191-198). 

## Oculus and SLAM 
SLAM tracking technology is a tracking method utilized by the Oculus Quest and Rift S (Hesch, Kozminski, Linde, 2019). On both these headsets there are three major types of sensors to work out the VR headset’s location, room aspects like where the floor is and track controllers with reference to a 3D map of the space around it that is generated continuously (Hesch, Kozminski, Linde, 2019). The three sensors include, IMUs that track the headsets orientation and position, cameras to generate a 3D map of the room, and infrared emitters mitigating the controller drift cause by having a lot of the IMU sensors (Hesch, Kozminski, Linde, 2019). 

## Application Programming Interface
APIs are powerful tools that can be used in this project, to break down what an API is, we must first learn what it stands for. It stands for Application Programming Interface(Uzayr, 2016), and is a way in which you can hide the component specification from the actual implementation or the user of said components (Souza, R.B, F, 2009). One reason for doing this is it separates the modules in to public and private modules. The public module being the API, and the private one being the implementation of said API. Any changes made to the private module do not impact the public module (Souza, R.B, F, 2009). Using APIs allows a company to give a developer functionality without said developer needing to know how it works (Souza, R.B, F, 2009).
## REST API
To give context, using REST is one way we could transmit data between a virtual reality head set and a webserver, in this case it would be the transmission of score data etc. To summarise, a REST API is a type of application programming interface that conforms to a set of constraints (Kotstein, Justus, 2021). Rest APIs have two aspects, the first is that they are a type of architectural style that can dictate how distributed hypermedia systems are built and used like the World Wide Web (Kotstein, Justus, 2021). Furthermore, this journal article goes into further detail for example the second aspect it gives is that REST is like a guide that formalises how web components like URLs and http for example should be used when creating new applications that utilise them.
## Web frameworks in python
### Django
Django is a collection of python modules designed for building web applications (Yudin et al., 2020). The Django framework can map URLS to methods, it can also render HTML webpages and it can handle cookies, session, and web security and has a REST framework (Yudin et al., 2020). Which handles all the essential of the REST API such as serialization and converting data to JSON (Yudin et al., 2020). This will be very useful for the project as this is a very reliable method of communicating between the headset and server and it comes with Django by default, so it is very likely to be tested thoroughly and a very reliable framework. Django can also support things like relational databases using object-relational mapping (Yudin et al., 2020). It has a build in database solution, known as SQLite (Yudin et al., 2020). SQL lite is a public domain software package that gives its user a relational database management system(Kreibichet et al., 2010) This is another important feature of Django that could be utilised in this project as user data will need to be stored, such as the user’s username and score. It also contains tools that allow easy authentication and authorization (Yudin et al., 2020). It is also widely used by the following websites, YouTube, Spotify, and many others (Yudin et al., 2020). It’s popularity with large technology companies is a good indicator of its quality and is another good reason to use it within the project.
### Flask
Flask is a small framework and is small enough to be called a micro framework (Grinberg et al., 2018). Flash was designed to be extendable, and you can pick and choose what you need to avoid bloat (Grinberg et al., 2018). Flash has a few dependencies, including the routing, debugging and web server gateway (Grinberg et al., 2018). However, it does not have support for accessing databases, validating web forms, or authenticating users (Grinberg et al., 2018). This is an issue for this project as we require a database to store score data from the game, also a way to authenticate users. After reviewing this book, due to flasks lack of features compared with Django, it is not a good idea to use this within the project, Django is by far the better choice due to its popularity and reliability and plethora of features and frameworks. 
## WebSocket Scripting
A WebSocket is a transfer control protocol for web applications. It provides connection in both ways meaning data can be sent to and from a server and client. However instead of connecting to an internet host and a port, it facilitates connections using URLS instead. To establish a connection between a server and client the protocol is changed from HTTP to WebSocket protocol. Once a connection is established messages can be sent back and forth between the client and the server (Lubbers, Albers, Salim,2011). This is one way in which information could be sent between the VR headset and a webserver that stores and displays score data in a database. However, the messages only need to be sent in one direction as, no messages are going to be sent to the client from the server. Therefore, using this method of data transfer not ideal for this project.

## Examples of VR puzzle games 
By looking at some high-quality games we can see what is expected from a high-quality VR game.
### Tetris® Effect: Connected
The first game we are going to look at is called Tetris® Effect: Connected. In summary, it is a game where the objective is to complete rows at the bottom of the screen. This is done by rotating different shapes to form these rows (Monstars Inc. Resonair and Stage Games, 2020).

![Figure 5 The image provided is from the game Tetris® Effect: Connected (Monstars Inc. Resonair and Stage Games 2020)](https://github.com/[username]/[reponame]/blob/[branch]/image.jpg?raw=true)

As can be seen from the image above (Figure 5) there are multiple game play elements, a scoring system, levels and elements in the scene, that is the use of vibrant and interesting colours. Some of these elements would be useful to use in the VR puzzle game, this is because they create interesting and beautiful game play to immerse the user in the game.

![Figure 6 The image provided is from the game Tetris® Effect: Connected (Monstars Inc. Resonair and Stage Games 2020)](https://github.com/[username]/[reponame]/blob/[branch]/image.jpg?raw=true)

### I Expect You To Die 2
The second game to analyse is called I Expect You to Die 2. In summary this game involves solving a selection of puzzles, the puzzles are split into missions for the player to complete where the player plays as an agent trying to defeat an enemy called Zoraxis (Schell Games 2021).

![Figure 7 The image provided is from the game I Expect You To Die 2 (Schell Games 2021)](https://github.com/[username]/[reponame]/blob/[branch]/image.jpg?raw=true)

![Figure 8 The image provided is from the game I Expect You To Die 2 (Schell Games 2021)](https://github.com/[username]/[reponame]/blob/[branch]/image.jpg?raw=true)

The gameplay above shows (Figure 7 and 8) an intricate and immersive world with high levels of detail, this level of detail, is important for immersion. As can be seen from both images (figure 7 and 8) the user is able to interact will objects using there in game hands, picking objects up, looking at them closely to solve the puzzle, read instructions and other such actions. All these small features create a sense of immersion in the world the author has created, as is the nature with VR, if the game is implemented correctly, it can make a player feel intertwined with the story and provide a real sense of emergency to solve problems that occur, like with the image above, the user is required to disarm a bomb. 
If all these elements are observed, it is possible to create an immersive and detailed world for a user to enjoy. These key elements will likely be very useful to incorporate into this project. The key elements to take away from these games, is allowing a user to interact with the world as much as possible.

# Methodology
## Chapter Introduction
This section of the report details the methodology that will be used to develop the product.
## Selected Methodology
To produce the VR game, the best methodology to use is an agile development process. Agile methods of software developments use an iterative and incremental approach to software development (Kumar, Bhatia, 2012). The type of agile method of development we have chosen is called, the scrum method. A scrum consists of sprints which are individual iterations that can last anywhere from two to four weeks each (Kumar, Bhatia, 2012). 

Planning for a sprint starts at the beginning of a sprint and the end of the sprint is used to determine what can be delivered in the next sprint (Hron, Obwegeser, 2021). A review of the sprint is then conducted at the end of the sprint to show the outcome of said sprint to the customer and to obtain feedback for the next sprint, feedback will then be used in the next sprint (Hron, Obwegeser, 2021).

Now knowing the information presented above, the game will be developed during two weeklong sprints for each stage of development.

Project setup Sprint 0: (9th Jan – 11th Jan)

This sprint will be two days long. In this sprint, basic project setup will be completed. Such as importing all libraries and packages that will be needed include Oculus integrations, creating a very basic prototype application to test all packages are working correctly and everything is setup and imported correctly.

Sprint 1: (16th Jan – 22nd Jan)

Basic game development of the puzzles will be done in this sprint. The two puzzles giving a week to produce each puzzle during the sprint I.E 8 queens puzzle and so forth. This will then be tested according to the requirements of the system. 

Sprint 2: (23rd Jan – 29th Jan)

Further game development will be done here, including the creation of the puzzle 2048.

Sprint 3: (4th Feb – 10th Feb)

Database setup will be performed in this sprint. The website will also be further developed. Testing to make sure data is stored correctly and is sent by the headset will also be done here.

Sprint 4:(11th Feb – 17th Feb)

User interface will be developed here according to the requirements specification. This will be tested along with the rest of the project to make sure everything is working correctly.

Sprint 5:(18th Feb – 25th Feb) (If needed)

This sprint will consist of making sure everything is working, correcting any bugs that may have occurred and gone unnoticed during the systems development. Final testing of the system will also be done here, making sure the system properly satisfies all requirements. 

# Requirements
## Chapter introduction
This section of the report will contain thirty-seven requirements in total. Thirty Functional and ten non-functional requirements. 

The Requirements

The Requirements are identified with an ID and the type of requirement in said ID. For example:

-VR means a requirement related to the VR game itself.

•	-VR-8Q is a VR requirement relating to 8 Queens

•	-VR-2048 is a VR requirement relating to 2048

-WS means a requirement relating to the website.

•	-WS-8Q is a website requirement relating to 8 Queens

•	-WS-2048 is a website requirement relating to 2048

-VR/WS means it is a requirement that relates to both.

•	-VR/WS-8Q is a requirement relating to both VR, the website and 8 Queens

•	-VR/WS-2048 is a requirement relating to both VR, the website and 2048

Moscow stands for must have, should have, could have, won’t (Asghar, Bhatti, Tabassum, Shah, 2017, Page 303-313).

Must have – The system must have this, and this is the highest priority.

Should have – The system should have this, this is mid priority.

Could have – This system could have this, however it is not necessary.

Won’t have – This could be added in the future, but it won’t have this at this given time.

The requirement specification column gives more detail into the requirement and why it is necessary.

## Functional Requirements:
