LociaGroup.RnD
==============

Research and development software repository

SCADA Architecture Orverview


* Decentralized distributed application across all platforms.
* Run a "Tag server" on each platform that shares teh tags in a decentralized way. Using clustered network.
* Certain connections have direct access to a PLC 
* Mappings of dataflow between platforms is all stored at each computer.
* Bootstrapping platforms allows each machine to know its configuration. 
* Drivers for communicating to PLC
    * Modbus
    * DNP
    * Etc.
* Drivers need to be created for the system. 
* How will it communicate?
* drivers should be plug an playable. With an interface to the main system.The IO server sould handle drivers.
* 


Server Roles 
- IO Server (Handles Drivers)
- Object Server (Reads data from IO server for HMI)
    - Compresses real time data
    - Publishes real time data for HMI viewers.
- HMI Viewer (Drawn GUI with data fed from Object Server)
- HMI Developer (interface to draw the gui from known tags)


The HMI viewer, can be a webbrowser that shows a generated graphics.

RabbitMQ data accross the object server and the HMIV clients. 

each HMIV can read off the buffer or broadcast on the buffer. 




