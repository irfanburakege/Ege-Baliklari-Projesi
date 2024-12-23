EgeDeniziB Project
This project simulates managing various fish data from the Aegean Sea using different data structures. The program includes the use of stacks, queues, and priority queues to manage and manipulate fish data effectively.

Overview
The project consists of different classes that represent various data structures and their operations. The main objective is to demonstrate how fish data can be managed using these structures, including adding, removing, and displaying information about the fish.

Key Features:
EgeDeniziB Class: Represents a fish from the Aegean Sea, including its name, alternative names, size, and environment information.
BalıkYığıtı (Stack): A stack that holds fish data using Last In First Out (LIFO) principle.
BalıkKuyruğu (Queue): A queue that stores fish data using First In First Out (FIFO) principle.
ÖncelikliBalıkKuyruk (Priority Queue): A priority queue that manages fish based on their names in alphabetical order.
TamsayıKuyruğu (Integer Queue): A queue that simulates customer data with processing time and calculates average processing times.
ÖncelikliTamSayıKuyruğu (Priority Integer Queue): A priority queue that manages customer data based on their integer values, with the smallest value being the highest priority.
Requirements
.NET Framework (or .NET Core)
C# compiler
Classes Overview
1. EgeDeniziB Class
This class holds the details of a fish, including:

BalıkAdı: Fish's name
DiğerAdı: Fish's alternative name
Boyut: Fish's size
Bilgi: Additional information about the fish
Ortam: A list of environments where the fish is found
2. BalıkYığıtı (Stack Class)
This class implements a stack to manage fish data. It supports operations like:

push(EgeDeniziB b): Adds a fish to the stack.
pop(): Removes and returns the top fish from the stack.
peek(): Returns the top fish without removing it.
3. BalıkKuyruğu (Queue Class)
This class implements a queue to manage fish data using FIFO. Operations include:

insert(EgeDeniziB b): Adds a fish to the end of the queue.
remove(): Removes and returns the fish from the front of the queue.
peekFront(): Returns the fish at the front without removing it.
4. ÖncelikliBalıkKuyruk (Priority Queue Class)
This class handles fish data with a priority based on the fish's name, with the fish having the alphabetically smallest name being of the highest priority. Operations include:

ekle(EgeDeniziB b): Adds a fish to the priority queue.
sil(): Removes and returns the highest-priority fish.
5. TamsayıKuyruğu (Integer Queue Class)
Simulates a queue of customers, where each customer has a number of items and processing time is calculated. Operations include:

ekle(int j): Adds a customer to the queue.
sil(): Removes a customer from the front of the queue and calculates their processing time.
6. ÖncelikliTamSayıKuyruğu (Priority Integer Queue Class)
Manages customers based on priority, where the customer with the smallest number of items has the highest priority. Operations include:

ekle(int b): Adds a customer to the priority queue.
sil(): Removes and returns the highest-priority customer.
