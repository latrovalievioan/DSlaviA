# Linear lists

## Array
- All elements are subsequent in memory

### Dynamic Array
- Cap - the maximum capacity
- Size - the current size

#### Adding an item
When adding a new item in the array, we want to check if the array has the capacity
to add the new item (size < cap).

- If the array doesn't have the capacity:
    - Create a new array with double the capacity of the previous.
    - Copy all items from the previous array to the new one.
    - Delete the old array (if the language has garbage collection this happens automatically).
    - Add the new item to the end of the new array.
    - Update the capacity, update the size.
- Add the new item to the end of the array.
- Update the size of the array.


## Linked List

- Linked lists are easy to add items to

### SLL
- Every node in the linked list have two segments - value and pointer to the next node

### DLL
- Evry node in the dll has treee segments - value, pointer to next and pointer to prev

# Maps

## Ordered keys

## Not ordered keys (hashmap)

# Heap (trees)

- Every node is a heap
