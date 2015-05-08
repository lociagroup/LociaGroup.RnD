Archestra - System Platform
===========================

## Course Description
* Scripts 
* IO points
* Alarms
* History
* Graphics

System platform is an object based environment that uses templates , instances. 

"Archestra IDE" (Integrated Development Environment)
Scripting Language is QuickScript .NET.

Objectives :
1. Create and deploy new applications using Archestra IDE
2. Model the plant floor using automation objects
3. Acquire plant floor data from PLC's and other field devices
4. Work with the alarm and history configuration in a Galaxy
5. Define the security model for a Galaxy
6. Configure application-level and device integration redundancy 
7. Configure Intragalactic communication.

Alarms : Consists of events Set, Acknowledge , Suppress, etc. Linked to each user. 

Historian :  keeps records of the events, also compresses values and stores them.

Security Model : Development and runtime interactions. 

Redundancy Model : Object Server / Backup Server.
Constantly Clones and keeps the records of the original computer. Primary and Secondary pairs. 

Decentralized data among clustered computers. 

>Note : scripting not needed to tie PLC variables with wonderware with new version.

---

## Outline

* Module 1 : Introduction
* Module 2 : Application Planning
* Module 3 : Application Infrastructure
* Module 4 : Application objects
* Module 5 : Extending The Objects
* Module 6 : Alarms and History
* Module 7 : Galaxy Maintenance
* Module 8 : Security
* Module 9 : Redundancy
* Module 10: Introduction to QuickScript.NET

## Definitions 

* Platform  - The name given to a specific computer. 


---

Introduction
============

Project Specific Work sits on top of the Microsoft Technologies + Industry Standards. SQL Server will need to be installed to run Wonderware.

On top of the .NET or SQL Server the system platform and clients are installed. "Intouch" is an HMI client. Another example of a client is called "Historian" .  

The system platform does not have a presentation layer therefore it needs a client in order to read its data. it also has function modules that can be used as equipment monitoring. The System Platform uses SQL database to store its tag counts. 

## Breaking Down System Platform

Components of System Platform :
* Application Server
* Historian Server
* Information Server 
* *Device Integration Servers (I/O Servers now known as DA Servers)*

>Top Server creates drivers for system platform and acts as an extra driver for System Platform's DA server.

Device integration servers - communicate to PLC's and retrieve the data needed for the presentation clients. Each driver is built and comes with the purchase of system platform. 


Application Server - It provides a unified environment for visualization, plant history, device communications and automation application integration. 
 * AABootstrap -  makes the computer platform ready for the system platform application server. 

* Leverage the .NET Framework for the Automation World
* Object-Based application
* One Global networked Namespace
* Centralized Configuration and Security
    * only able to define a certain subset of the system
* Multi-User development environment
* Component Based plant application model
* Audit Trail of changes
* Advanced system maintenance and diagnostics

Archestra IDE -  Application servers development environment for configuring and deploying the application (Galaxy) . 

Galaxy -  Application Servers application Configuration information and project database. 

MDT Auto-save for system platform - Change management system that can be plugged into the system for revision of all different objects. 


## Object Servers (Roles)

1. Galaxy Repository (GR)
2. Engineering Station (IDE)
3. Archestra Object Server (AOS)
4. Visualization Node (InTouch/View Node)
5. Historian Server

Multiple Roles can be consolidated together on 1 computer if necessary  (Ex. Historian + GR, GR + IDE, AOS + Visualization etc).

Galaxy Repository server can be separated from the engineering station. There are two options for modifying the Galaxy Repository 

1. Have engineering stations to connect to the galaxy repository (license limited)
2. Remote into the galaxy repository server and use the local IDE. Use this configuration with a "Terminal Services development license" install and is limited to 5 seats. 

Development license can be used to create remote galaxy repositories, galaxies (groups of platforms) do not need the repository all the time. it only needs ti for initial configuration. The clients run decentralized when configuration is completed. The 

Requirements for galaxy repository - Server based system with SQL server. 

Engineering station - IDE does not need a SQL server, just needs to point to a galaxy repository. Requires Development Studio License. 


Archestra Object server -AAEngine shows up as a service on the platform (machine)  that is used as a "Glorified Tag Server". Contains scripting alarms and events. It also creates a decentralized sharing between all servers. D/A drivers can be placed on each AOS in order to have redundant drivers

Galaxy Repository configures all the computers in the galaxy with IP based mappings that keeps the decentralized data flowing even if several platforms are removed. 

Two computers can be set to be decentralized and redundant. so two computers can support their own primary processes. when one computer goes down the tags are still exposed to the galaxy through one of the computers. You can also set each one to the be the secondary of the other. That way one computer can still run its process exposing all the tags. and it runs a secondary process as the backup for the computer that went down. 

Visualiastaion Node - An intouch HMI application. Can be supported by server or non server base operating systems. 

> Standalone intouch is not the same as Intouch for System platform

ACP  is a form of thin client viewer of the intouch application. It allows the user to view the Intouch on a thin client and allow multiple views of the different intouch clients. 

Historian Server - Operates independently from a galaxy. no platform is needed. Galaxy force feeds values such as alarms and events into the historian server.

Alarms are handled through provider and consumer. Object servers are meant to be alarm providers. The clients are meant to be Alarm consumers. They subscribe to specific objects. 

Galaxy Architecture 
----

The galaxy creates the platform instance then is sent to the machine to a bootstrapped machine. The galaxy can then set the proper role for the computer. The historian then needs to be called out explicitly if it is being used. 
 

## Requirements

|  | Development |Automation Object Server | Galaxy Repository |
|----------|----------|--|---------|
| Windows Server  | Y  | Y  | Y  |
| Windows Workstation  |   |   |   |
| SQL Server  |    |    | Y  |
| .NET Framework  | Y  | Y  | Y  |




Licensing 
--


| Code Revision | Name |
|----------|----------|
|  3.5  |  2012  |
|  3.6  |  2012 R2  |
|  4.0  |  2014   |
|  4.1  |  2014 R2  |


License File names :

* ARCHESTRA.LIC :  For wonderware applications erver 3.5 and higher. intouch 10.5 and higher;
ALL DA servers Released in 2012

* WWSUITE.LIC : intouch 10.1 and earlier;
All DA servers before 2012; Wonderware Application server 3.1.

Development studio -  allows for development inside of intouch 

Consignment License - Development license created for our system integrator community expires yearly.

Compression in the historian does not "have any" compression error when retrieved , according to  Insource. 

Installation 
---

Product based Install :
* Need to explicitly callout the bootstrap runtime.

Role Based Install : 
* Runtime Client
* Development Workstation
* System platform development server
* Historian Server Node
* Historian Client Node
* Informationa Portal

User Account : aaAdminUser can be accessed if the Username and password that was used for the install needs to be changes.  



Course Training Lab
--
1. Install License through Archestra License manager
    * inside the license folder. Select Archestra.lic
2. Launch the ARchestra IDE and verify the computer name. and create a new galaxy . use the base type. 
3. Once galaxy is created , connect to the galaxy.
4. Expand the "TrainingGalaxy" > System (These are locked because they are base templates)
    * Templates are shown on the top left pane
    * Instances are shown on the bottom left pane
5. Derive a version of the base templates. Create instances from the derived based templates.

Lab : Page 1-64


Automation Objects
--

Automation objects represent the actual equipment on the plant floor. They are created by templates. New objects can be a grouping of any datatype now called,  "user defined"  objects.

Properties :
* Inputs and outputs must be defined 
* Scripting/Logic
* Graphic Symbols
    * can embed active x objects into the graphic ie. adobe,ie,etc.
* Documentation
* Historical information
* Security
* Alarms and events


The Deployment Model
---

* Bootstrap
* WinPlatform
* Appengine
* Area ( a visual grouping of objects)
* DI Object(hook for drivers, link to the IO world)
    * Application Name
    * Group
    * Topic

Multiple app engines can be used.

Necesary for IO Comm.
- ServerNode.ServerName.Topic
- Name of server
- Access name
- Input Source (Field Attribute or PV) used to be called "Item"

Atributes that read are called 'PV' the attributes for writing are called 'CMD'

Any platform that has an instance of the appengine is an object server. Any platform that has a instance of the viewengine is a viewnode.


Alarms and Events 
----

The appengine makes the platform an archestra object server. Its the area that is the alarm filter/ alarm group. The model view shows the structure of each different area. 

The best practice is to create a master area that holds all the alarm groups in the galaxy.

intouch Alarm provider - enable intouch alarm provider on the platform level of the object server. This allows all consumers to read the alarms from the appengine provider. 

Enable Limit alarms on the IO level. Then lock the alarm limits to limit the instance level changes. This can all be done on the template of the object.


Deviation Alarms :

With a given range of the alarm and a target value a percentage value is given to see how far it can deviate from the target value. 
`Example: Cruise control is set to be in the range of 45 to 55 and the target is 50 , if the alarm is set to 5% deviation then the alarm would trigger if the system tripped +5% (major) and -5% (minor).`

In traditional intouch a scaling value was required but it is now optional. The alarms are based on the scaled value not the raw value. 

Bad quality alarming allows for the quality of an IO to be tested for quality. Discretes can be alarmed in true or false states.

Alarm subsystem - Distributed alarm manager gets fed by the Objects>$area>$winplatform> or $appengine or $Diobject and fed into the clients "Alarm Subscribers" . 

Alarms that are triggered are still alarmed even when acknowledged if the underlying value is still outside of limits. 

Historian for alarming : 

The historian information needs to be setup with the proper credentials through the SMC console. once all modules started through the management console. The historian is reayd to read in event logging. 

The name of the historian database in the SQl server is called A2ALMDB.


Backup Server/ Redundant Server
--

Network binding order must be set. The ap address of te promary server should be known. The secondary network card on the system must have a different subnet mask in comparison to the first. Heart beat errors occur when the network binding is not set correctly.

Backups are only in pair of redundant partners .

Redundandancy Configuration
1. Install 2nd network card
2. configure the archestra connection to be accessed before the RMC connection. 
3. give the RMC aconnection a fixed IP address in a different subnet than the archestra connection. 

Application Server
1. Configure the winplatforms with thier corresponding local rmc ip addresses.
2. Configure the appengine to be redundant.
3. Assign the appengines prinary and backup to the winplatforms.




Security Model
---
Access levels are given to every user . The value can be used to modify the graphics. With galaxy authentication mode an be set to one of the following
* None
* Galaxy (user created)
* OS User Based (local users)
* OS Group based (Domain users / Active Directory)

security Geroups : Groupings of instances inside the galaxy, a way to seperate objects into security groups.

'Onscan' is deployed and running
'OffScan' is deployed but idle. 
All objects have a ScanState command. It can be used for security.

Track all events of each user. can be viewed by the sql database.


Graphics 
---
