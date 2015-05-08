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


Rabbit MW needs a broker that will handle the message queue. The broker needs to be on the same network. The broker can be set to be a local host. 

If the broker is set to be local at each Object server then there could be a distributed network of brokers. A routing table can be used to point each broker/Object server to any HMI's or IO servers. The routing configuration can be stored on each servers local bootstrap service. 



The scada system could be simplified so that the system only has a single server with node handlers , and three layered datastructure. 

a single server that acts as the broadcaster and the queuing server.
if all the clients wich are also visualizaiton nodes grab data and pump it to the broker 

A simple scada system would look like
an input and output for each node instance. 
