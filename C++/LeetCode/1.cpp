#include<iostream>
using namespace std;

int main(){
    int arr[] = {2,7,11,15};
    int tar = 9;
    int n = sizeof(arr)/sizeof(arr[0]);

    for(int i=0; i<n; i++){
        for(int j=i+1; j<n; j++){
            if(arr[i] + arr[j] == tar){
                cout << "Indices: [" << i << ", " << j << "]" << endl;
                break;
            }
        }
    }
    return 0;
}