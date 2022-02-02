numInputs = int(input())

coords = {
    "X-coord" : 0,
    "Y-coord" : 0
}

for i in range(numInputs):
    direction = input()
    distance = int(input())
    
    if direction == "North":
        coords["Y-coord"] += distance
    elif direction == "South":
        coords["Y-coord"] -= distance
    elif direction == "East":
        coords["X-coord"] += distance
    elif direction == "West": 
        coords["X-coord"] -= distance

print(coords["X-coord"], end=' ')
print(coords["Y-coord"])
