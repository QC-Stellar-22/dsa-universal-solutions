arr = [2,7,11,15]
tar = 9

for i in range(len(arr)):
    for j in range(i+1, len(arr)):
        if arr[i] + arr[j] == tar:
            print(f"Indices: ",[i, j])
            break