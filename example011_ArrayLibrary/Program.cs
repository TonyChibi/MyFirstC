Console.Clear();
void FillArray(int [] collection){

    int length=collection.Length;
    int index=0;
    while (index<length)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }

}

void PrintArray(int []coll){
    int count=coll.Length;
    int pos=0;
    while(pos<count){
        Console.WriteLine(coll[pos]);
        pos++;
    }
}

int IndexOf(int [] coll, int find){

    int count = coll.Length;
    int index=0;
    int position=-1;
    while(index<count){
        if(coll[index]==find){
            position=index;
            break;
        }
        index++;
    }
     return position;
}

int []arr= new int [10]; 

FillArray(arr);
PrintArray(arr);
Console.WriteLine();
int pos = IndexOf(arr,4);
Console.WriteLine(pos);