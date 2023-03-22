## Описание решения:
1. Просим пользователя ввести количество элементов массива. Эти данные из строки превращаем в число.
2. Объявляем переменную count и говорим, что она равна нулю. 
3. Создаем новый массив с названием **array**, количество элементов которого будет равно тому числу, что ввел пользователь.
4. Мы создаем метод под названием _**AddMessageToUser**_. При помощи этого метода мы будем проверять входящие данные на условие задачи *(то есть длина входящего элемента равна или меньше 3 символов)*. Если входящий элемент меньше или равен трем, то мы будем увеличивать показатель count на 1.
5. Далее мы создаем цикл for. В данном цикле мы просим от пользователя ввести элементы столько раз, сколько было указано в первом пункте. Каждый новый элемент мы помещаем в массив.
6. Выводим этот массив и показываем его пользователю.
7. Создаем новый массив с название **result**, длина которого будет равна нашему count из 4 пункта.
8. Обнуляем наш count.
9. Снова создаем цикл for. В этом цикле мы также создаем проверку, в которой проверяем каждый элемент массива array на то, меньше или равен этот элемент 3 *(то есть условию задачи)*. Если этот элемент равен, то мы помещаем этот элемент в массив result. 
10. Выводим наш массив **result** пользователю в ту же строчку, в которой был исходный массив, написанный пользователем. Если так вышло, что из 9 пункта ни один элемент не попал в новый массив, то выводимый массив будет пустым. 