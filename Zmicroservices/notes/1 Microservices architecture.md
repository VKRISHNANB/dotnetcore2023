Architecting container and microservice-based applications
---
Containers ```aren’t``` mandatory for a microservice architecture.  
Enterprise applications can be complex and are often composed of multiple services instead of a single service-based application.  

It is important to have an understanding of architectural approaches, such as  
 
    1. the microservices, and 
    1. Domain-Driven Design (DDD) patterns plus 
    1. Container orchestration concepts  

---
Microservices architecture
---
A microservices architecture is an approach to building a server application as a set of **small services**.  

Each service runs in its own process and communicates with other processes using protocols such as HTTP/HTTPS, WebSockets, or AMQP.    

Each microservice implements a specific end-to-end domain or business capability within a certain context boundary, and each must be developed autonomously and be deployable independently  

Each microservice should own its related domain data model and domain logic (sovereignty and decentralized data management) and could be based on different data storage technologies (SQL, NoSQL) and different programming languages.  

**What size should a microservice be?**  

    When developing a microservice, size shouldn’t be the important point.  
    
    Instead, the important point should be to create ```loosely coupled``` services so you have autonomy of development, deployment, and scale, for each service.  
    
    Of course, when identifying and designing microservices, you should try to make them as small as possible as long as you don’t have too many direct dependencies with other microservices.  

    More important than the size of the microservice is the <u>internal cohesion it must have and its independence from other services</u>.  

**Why a microservices architecture?**  
    It provides long-term **agility**.  
    Microservices enable **better maintainability** in complex, large, and highly-scalable systems by letting you create applications based on many independently deployable services that each have granular and autonomous lifecycles.  