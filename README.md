**Задача:**

*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами*

> **Описание алгоритма**:

* Объявляем метод FilterLongerThan3, который принимает массив(array1), метод должен возвратить нам нужный массив.
* Внутри метода объявляем переменную count и size, которым присваиваем значение 0. 
* Создаём цикл for с уcловием if, где проверяем элеменит массива на <= 3,  попутно считаем кол-во  ячеек(size) в новом массиве(array2): который объявляем после первого цикла for. 
* Проходимся по массиву(array1) с условием <=3, если условие срабатывает, то записываем элемент в новый массив(array2), count это номер ячеек нового массива. 
* Возвращаем новый массив из метода. 
---
*Графическое представление метода в папке **picture**. Сама задача в папке **Task.***





