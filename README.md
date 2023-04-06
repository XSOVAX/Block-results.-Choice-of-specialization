# Описание

Программа реализует обработку массива строк. Сначала пользователя просят определится с размерностью массива, затем ввести строки (для этого реализован а функция **fill_array**). После этого данный массив отправляется на обработку в функцию **array_proccessing**. После обработки печатаются только элементы длинна которых не превышает 3.

## Функция fill_array

Возвращает массив строк размером входящим в него цислом, для этого данные для массива запрашиваются от пользователя.

## Функция array_proccessing

Создает пустой массив, и увеличивает его размер командой:

    Array.Resize

как только найдется в заданном массиве элемент нужной длинны. Давая возможность внести этот элемент в этот массив для того, что бы его вернуть как решение задачи.
Например, для  введенного массива 

    ["Hello", "2", ":-)"] 

будет вернут новый массив:

    ["2"; ":-)"]

## Функиция print_array

Проходится по массиву и выводит его значения на экран в нужном формате.
