# Руководство пользователя.

## Старт программы.
* Откройте Visual Studio Code.
* Перейдите в каталог с программой.
* Введите в терминале *dotnet run*.

## Ввод данных.

После запуска программы в окне терминала появится сообщение:
> Введите колличество эллементов массива:

Вам необходимо ввести целое, положительное число, которое будет определять колличество элементов в массиве. В противном случае, программа завершится с ошибкой. Далее появится сообщение: 
> Введите массив. 
>
> Введите 1 элемент: 

Вам необходимо поочередно ввести все элементы массива. Допускается ввод любых символов. После ввода каждого элемента необходимо нажать клавишу Enret. Колличество элементов было определено вами на предыдущем этапе.

## Работа программы. Вывод результатов.

Программа определит элементы, чья длина не превышает трех символов, и сформирует из них новый массив. Если таковых нет, будет сформирован пустой массив.

## Примеры работы программы.

 [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] \
 [“1234”, “1567”, “-2”, “computer science”] → [“-2”] \
 [“Russia”, “Denmark”, “Kazan”] → []