string [] fill_array(string [] array){
    int size_array = array.Length;
    for (int i = 0; i < size_array; i++){
        Console.Write($"Введите {i + 1} из {size_array} эллемент >> ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void print_array(string[] array){
    int size_array = array.Length;
    Console.Write("[");
    if(size_array > 0){
        Console.Write($"{array[0]}");
        for(int i = 1; i < size_array; i++){
            Console.Write($"; {array[i]}");
        }
    }
    Console.WriteLine("]");
}

Console.Write("Введите размер массива >> ");
int array_size = Convert.ToInt32(Console.ReadLine());
string [] data_array = new string[array_size];
data_array = fill_array(data_array);
print_array(data_array);