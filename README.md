# Лаборанторна робота 5 (Варіант 11) 
Створити абстрактний клас Parent, що описує літак і містить: 
● pole1-швидкість; 
● pole2-висота польоту; 
● pole3-вартість; 
● Конструктор, з двома параметрами, що привласнює значення перших двох полях. ● Абстрактний метод Info- (без параметрів), який повертає рядок, що містить інформацію про  поля об'єкта; 
● Абстрактний метод Metod, що обчислює вартість об'єкта і заповнює поле pole3 На основі класу Parent реалізувати дочірній клас Child1, що описує пасажирський літак і містить: 
● Конструктор з двома параметрами: швидкість і висота. З батьківського класу викликається  конструктор з двома параметрами. 
● Перевизначити метод Info. 
● Перевизначити метод Metod. Вартість = pole1 * 1000 + pole2 * 100. 
На основі класу Parent реалізувати дочірній клас Child2, що описує винищувач і містить: 
● Конструктор з двома параметрами: швидкість і висота. З батьківського класу викликається  конструктор з двома параметрами. 
● Перевизначити метод Info. 
● Перевизначити метод Metod. Вартість = pole1 * 3000 + pole2 * 200. 
На основі класу Parent реалізувати дочірній клас Child3, що описує бомбардувальник і містить: 
● pole4 - кількість бомб; 
● Конструктор з трьома параметрами: швидкість, висота і кількість бомб. З батьківського класу  викликається конструктор з двома параметрами. 
● Перевизначити метод Info. 
● Перевизначити метод Metod. Вартість = pole1 * 1500 + pole2 * 150 + pole4 * 50. У методі Main, в циклі з п'яти витків будемо випадковим чином визначати:
● Тип літака (пасажирський, винищувач або бомбардувальник) 
o Якщо створюємо пасажирський, то визначаємо випадково швидкість і висоту і  створюємо об'єкт класу Child1. 
o Якщо створюємо винищувач, то визначаємо випадково швидкість і висоту і створюємо  об'єкт класу Child2. 
o Якщо створюємо бомбардувальник, то визначаємо випадково швидкість, висоту,  кількість бомб і створюємо об'єкт класу Child3. 
● До створеного об'єкту застосовуємо спочатку метод Metod, щоб обчислити вартість, а потім  виводимо на екран рядок зі станом об'єкта, яку повертає метод Info.
