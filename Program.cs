string [] fill_array(string [] array){
    int size_array = array.Length;
    for (int i = 0; i < size_array; i++){
        Console.Write($"Введите {i + 1} из {size_array} эллемент >> ");
        array[i] = Console.ReadLine();
    }
    return array;
}



Console.Write("Введите размер массива >> ");
int array_size = Convert.ToInt32(Console.ReadLine());
string [] my_array = new string[array_size];
my_array = fill_array(my_array);