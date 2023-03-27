State and data in Docker applications
---
A Container is an instance of a process.  
A process doesn’t maintain persistent state.  
A container images, like processes, have multiple instances and will eventually be killed.  
If container's are  managed with a container orchestrator, then they might get moved from one node or VM to another.  

**The following solutions are used to manage data in Docker applications:**  

From the Docker host:

    Docker has two options for containers to store files in the host machine, so that the files are persisted even after the container stops:  

        1. volumes, and  
        1. bind mounts  
        1. If you’re running Docker on Linux you can also use a **tmpfs mount**  
        1. If you’re running Docker on Windows you can also use **a named pipe**  

        
![State](https://docs.docker.com/storage/images/types-of-mounts.png)

1. **Volumes** are stored in a part of the host filesystem which is managed by Docker ```(/var/lib/docker/volumes/ on Linux)```. Non-Docker processes should not modify this part of the filesystem. <u>Volumes are the best way to persist data in Docker</u>.

2. **Bind mounts** may be stored anywhere on the host system. They may even be important system files or directories. Non-Docker processes on the Docker host or a Docker container can modify them at any time.

3. **tmpfs mounts** are stored in the host system’s memory only, and are never written to the host system’s filesystem.

From remote storage:  
    Remote relational databases like **Azure SQL Database** or **NoSQL** databases like Azure Cosmos DB, or cache services like **Redis**.

From the Docker container:  
    **Overlay File System**. 
        This Docker feature implements a ```copy-on-write``` task that stores updated information to the root file system of the container. 
        That information is “on top” of the original image on which the container is based.
        If the container is deleted from the system, those changes are lost.
        Therefore, <u>while it’s possible to save the state of a container within its local storage,</u> designing a system around this would conflict with the premise of container design, which by default is **stateless**.
    