Logical architecture versus physical architecture
---
```Microservices is a logical architecture```  
Building microservices doesn’t require the use of any specific technology.  

Docker containers aren’t mandatory to create a microservice-based architecture.  

Microservices could also be run as plain processes.  

A microservice could be physically implemented as a single service, process, or container.

This parity between **business microservice**, and **physical service** or container isn’t necessarily required in all cases when you build a large and complex application composed of many dozens or even hundreds of services.  

The logical architecture and logical boundaries of a system do not necessarily map one-to-one to the physical or deployment architecture. 

A business microservice or Bounded Context is a logical architecture that might coincide (or not) with physical architecture. 

A business microservice or Bounded Context must be **autonomous** by allowing code and state to be independently versioned, deployed, and scaled.  

The logical architecture of microservices doesn’t always have to coincide with the physical deployment architecture.

A logical microservice   
    1. could map to one or more (physical) services, or  
    2. this could map to a single service   

     