Console.Clear();
int []arr={1,2,3,4,5,6,7,4,8,124,9};
int n=arr.Length;
int find=4;
int index=0;
while(index<n){

    if (arr[index]==find){
        Console.WriteLine(index);
        break;
    }

    index++;
}