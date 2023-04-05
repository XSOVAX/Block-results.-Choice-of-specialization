string [] fill_array(int size_array){
    string[] array = new string[size_array];
    for (int i = 0; i < size_array; i++){
        Console.Write($"Введите {i + 1} из {size_array} эллемент >> ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string [] array_proccessing(string [] array){
    int size_array = array.Length;
    string[] proccessing_result = new string[size_array];
    int index_proccessin_array = 0;
    for(int i = 0; i < size_array; i++){
        string element_array = array[i];
        if(element_array.Length < 4){
            proccessing_result[index_proccessin_array] = element_array;
            index_proccessin_array++;
        }
    }
    return proccessing_result;
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
string [] data_array = fill_array(array_size);
string [] array_solved = array_proccessing(data_array);
print_array(array_solved);