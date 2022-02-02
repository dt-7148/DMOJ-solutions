flyingHeight = int(input())
numItems = int(input())

heightOfItems = []

for i in range(numItems):
    heightOfItems.append(int(input()))
    
numCollisions = 0
    
for currentItemHeight in heightOfItems:
    if currentItemHeight >= flyingHeight:
        numCollisions += 1

print(numCollisions)
