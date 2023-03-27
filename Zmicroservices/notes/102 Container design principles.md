Container design principles
---
Container image instance represents a **single process**.

By defining a container image as a process boundary, you can create primitives that can be used to scale the process or to batch it.

Containers might represent 
    1. **long-running processes** like ```web servers```, but can also represent 
    1. **Short-lived processes** like batch jobs, which formerly might have been implemented as Azure WebJobs.

If the process fails, the container ends, and the orchestrator takes over.

If the orchestrator was configured to keep five instances running and one fails, the orchestrator will create another container instance to replace the failed process.

