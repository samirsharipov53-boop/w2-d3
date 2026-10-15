
### Task 1 

Good luck with your task! 📚

Write a class called `Book` that represents a book with a title, author, and year of publication.

1. Create a public class called `Book`.

2. Create a constructor that takes parameters `title`, `author`, and `year` to initialize the object's properties.

3. Add a method called `GetInfo()` that will display information about the book in the format of a string.

4. Add a method called `IsPublishedRecently()` that will return `true` if the book was published after 2010, and `false` otherwise.

##

Напишите класс под названием `Book`, который представляет книгу с названием, автором и годом публикации.

1. Создайте общедоступный класс под названием `Book`.
 
2. Создайте конструктор, который принимает параметры `title`, `author` и `year` для инициализации свойств объекта.

3. Добавьте метод `GetInfo()`, который будет отображать информацию о книге в формате строки.


4. Добавьте метод `IsPublishedRecently()`, который будет возвращать `true`, если книга была опубликована после 2010 года, и `false` в противном случае.

##

Класеро бо номи `Book` созед.

1. Класи Public бо номи `Book` созед.

2. Конструкторе созед, ки барои кимат бахшидан ба хосиятҳои объект параметрҳои `title`, `author` ва `year` -ро мегирад.

3. Метод бо номи `GetInfo()` илова кунед, ки маълумотро дар бораи китоб дар чунин формат нишон медиҳад,

    масалан: "Title : Агар ҷавонӣ медонист…, Муаллиф: Башир Усмон, Соли нашр: 2019".

4. Метод бо номи `IsPublishedRecently()` илова кунед, ки агар китоб пас аз соли 2010 нашр шуда бошад, `true` ва дар акси ҳол `false` -ро бармегардонад.

```mermaid
classDiagram
    class Book {
        +Title : string
        +Author : string
        +Year : int 
        +Book(string title, string author, int year)
        +GetInfo() void
        +IsPublishedRecently() bool
    }
```
---

### Task2

Create a `Circle` class that has the following fields:

- `radius`: a double
- `PI`: a double initialized with the value `3.14159`

The class should have the following methods and Constructors:

- `Constructor`: Accepts the radius of the circle as an argument.
- `Constructor`: A no-arg constructor that sets the `radius` field to `0.0`.
- `SetRadius`: A method for the `radius` field.
- `GetRadius`: A method for the `radius` field.
- `GetArea`: Returns the area of the circle, which is calculated as `area = PI * radius * radius`.
- `GetDiameter`: Returns the diameter of the circle, which is calculated as `diameter = radius * 2`.
- `GetCircumference`: Returns the circumference of the circle, which is calculated as `circumference = 2 * PI * radius`.

Write a program that demonstrates the `Circle` class by asking the user for the circle's radius,       
creating a `Circle` object, and then reporting the circle's area, diameter, and circumference.

##

Создайте класс `Circle`, который имеет следующие поля:

- `radius`: типа double
- `PI`: типа double и инициализировано значением `3.14159`

Класс должен иметь следующие методы и конструктори:

- `Constructor`: Принимает радиус окружности в качестве аргумента.
- `Constructor`: без аргументов устанавливает поле `radius` в значение `0.0`.
- `SetRadius`: Метод для поля `radius`.
- `GetRadius`: Метод для поля `radius`.
- `GetArea`: Возвращает площадь окружности, которая вычисляется по формуле `area = PI * radius * radius`.
- `GetDiameter`: Возвращает диаметр окружности, который вычисляется по формуле `diameter = radius * 2`.
- `GetCircumference`: Возвращает длину окружности, которая вычисляется по формуле `circumference = 2 * PI * radius`.

Напишите программу, которая демонстрирует класс `Circle`, запрашивая у пользователя радиус окружности, создавая объект `Circle`, а затем выводит площадь, диаметр и длину окружности.    

##

Класси `Circle` cозед, ки дорои майдонҳои зерин аст:

- `radius`: a double
- `PI`: a double бо арзиши '3.14159'

Kласc бояд методхо ва конструкторҳои зерин дошта бошад:

- `Constructor`: Радиуси давраро ҳамчун аргумент қабул мекунад.
- `Constructor` : бе параметр кимати `0.0` ро ба майдони `radius` муқаррар мекунад.
- `SetRadius`: Метод барои кимат додан ба `radius`.
- `GetRadius`: Методи барои гирифтани `radius`
- `GetArea`: Масохати давраро бармегардонад, ки он ҳамчун `Area = PI * radius * radius` ҳисоб карда мешавад.
- `GetDiameter`: Диаметри давраро бармегардонад, ки он ҳамчун `Diameter = radius * 2` ҳисоб карда мешавад.
- `GetCircumference`: Дарози давраро бармегардонад, ки он ҳамчун `Circumference = 2 * PI * radius` ҳисоб карда мешавад.

Барномае нависед, ки аз истифодабаранда радиуси доираро пурсад ва сипас масохат, диаметр ва дарозии давраро чоп кунад.

```mermaid
classDiagram
    class Circle {
        - radius : double
        - pi :  3.14
        +Circle(double radius)
        +Circle() 
        +SetRadius(double radius) void
        +GetRadius() double
        +GetArea() double
        +GetDiameter() double
        +GetCircumference() double
    }
```
---

### Task 3
The `Date` class models a calendar date with day, month, and year.

#### Class Members

- 3 private instance variables: `day`, `month`, and `year`.
- Constructors, public getters, and setters for the private instance variables.
- `SetDate()` method that sets the day, month, and year.
- `GetMonth()`, `GetYear()`, and `GetDay()` methods to retrieve the respective values.
- `ToString()` method that returns the date in the format `DD/MM/YYYY` with leading zeros for `DD` and `MM`, if applicable.

##

Класс `Date` моделирует календарную дату с днем, месяцем и годом.

#### Члены класса

- 3 частные переменные экземпляра: `day`, `month` и `year`.
- Конструкторы, публичные геттеры и сеттеры для частных переменных экземпляра.
- Метод `SetDate()`, который устанавливает день, месяц и год.
- Методы `GetMonth()`, `GetYear()` и `GetDay()` для получения соответствующих значений.
- Метод `ToString()`, который возвращает дату в формате `DD/MM/YYYY` с ведущим нулем для `DD` и `MM`, если применимо.

##

Класс `Date` санаи тақвими бо рӯз, моҳ ва сол.

#### Аъзоёни синф

- 3 тағирёбандаи хусусӣ: `day`, `month` ва `year`.
- Конструкторхо, пропертихо ва тағирёбандаҳои хусусӣ.
- Усули `SetDate()`, ки рӯз, моҳ ва солро муқаррар мекунад.
- Усулҳои `GetMonth()`, `GetYear()` ва `GetDay()` барои гирифтани арзишҳои мувофиқ.
- Усули `ToString()`, ки санаро дар формати `DD/MM/YYYY` бо сифр `DD` ва `MM` бармегардонад, агар мувофиқ бошад.

```mermaid
classDiagram
    class Date {
        - day : int
        - month : int
        - year : int
        +Day : int
        +Month : int
        +Year : int
        +Date()
        +Date(int day)
        +Date(int day, int month)
        +Date(int day, int month, int year)
        SetDate(int day, int month, int year) void
        GetDay() int
        GetMonth() int
        GetYear() int
        ToString() string
    }
```
**Input**
```
day : 1
month : 12
year : 2023
```
**Output**

```
01/12/2023
```
---

### Task 4

Let's say we have a task to create a simple system for managing bank accounts. Create a `BankAccount` class that has the following characteristics:

1. `accountId`(int): A unique account identifier that is assigned when the account is created and cannot be changed after that.
2. `balance`(decimal): The current account balance, which can only be changed using methods.
3. `OwnerName`(string): Account owner name.
4. `isFrozen`(bool): Flag indicating whether the account is frozen (no transactions allowed).
5. Methods `Deposit(amount:decimal)` and `Withdraw(amount:decimal)`: Two methods for depositing funds into an account and withdrawing funds from an account. Both methods must handle possible errors such as negative amounts, insufficient funds, and frozen accounts.
6. Method `FreezeAccount()`: Method for freezing an account.
7. Method `UnfreezeAccount()`: Method for unfreezing an account.

Your job is to implement this class and use it in your program to demonstrate the functionality.

##

Допустим, у нас есть задача по созданию простой системы управления счетами в банке. Создайте класс `BankAccount`, который имеет следующие характеристики:

1. `accountId`(int): Уникальный идентификатор счета, который присваивается при создании счета и не может быть изменен после этого.
2. `balance`(decimal): Текущий баланс счета, который можно изменять только с использованием методов.
3. `OwnerName`(string): Имя владельца счета.
4. `isFrozen`(bool): Флаг, указывающий, заморожен ли счет (нельзя проводить операции).
5. Методы `Deposit(amount:decimal)` и `Withdraw(amount:decimal)`: Два метода для внесения средств на счет и снятия средств со счета. Оба метода должны обрабатывать возможные ошибки, такие как отрицательные суммы, недостаточно средств и замороженные счета.
6. Метод `FreezeAccount()`: Метод для заморозки счета.
7. Метод `UnfreezeAccount()`: Метод для разморозки счета.

Ваша задача - реализовать этот класс и использовать его в программе для демонстрации функциональности.

##

Фарз мекунем, ки дар назди мо вазифа меистад, ки системаи оддии идораи суратхисобхои банкиро ба вучуд оварем. Синфи 'BankAccount' эҷод кунед, ки дорои хусусиятҳои зерин аст:

1. `accountId`(int): Идентификатори беназири ҳисоб, ки ҳангоми эҷоди ҳисоб таъин карда мешавад ва баъд аз он тағир дода намешавад.
2. `balance`(decimal): Бақияи ҳисоби ҷорӣ, ки онро танҳо бо истифода аз усулҳо тағир додан мумкин аст.
3. `OwnerName`(string): Номи соҳиби ҳисоб.
4. `isFrozen`(bool): махкам будани ҳисобро нишон медиҳад (ҳеҷ амалиёт иҷозат дода намешавад).
5. Усулҳои `Deposit(amount:decimal)` ва `Боздошт()`: Ду усули гузоштани маблағ ба суратҳисоб ва гирифтани маблағ аз суратҳисоб. Ҳарду усул бояд хатогиҳои эҳтимолиро, аз қабили маблағи манфӣ, маблағҳои нокифоя ва ҳисобҳои махкамро ҳал кунанд.
6. Усули `FreezeAccount()`: Усули махкам кардани ҳисоб.
7. Усули `UnfreezeAccount()`: Усули кушодани ҳисоб.

Вазифаи шумо ин аст, ки ин классро амалӣ кунед ва функсияхои онро истифода баред.

```mermaid
classDiagram
    class BankAccount {
        - accountId:int
        - balance:decimal
        + OwnerName:string
        - isFrozen:bool
        +BankAccount(accountId:int, balance:decimal, ownerName:string)
        +Deposit(amount:decimal)void
        +Withdraw(amount:decimal)void
        +FreezeAccount()void
        +UnfreezeAccount()void
    }
```

```csharp
// Пример использования класса BankAccount
BankAccount account = new BankAccount(1001, "John Doe", 5000.00m);

// Внесение и снятие средств, заморозка и разморозка счета
account.Deposit(1000.00m);
account.Withdraw(200.00m);

account.FreezeAccount();
account.Deposit(500.00m); // Не должно выполниться из-за замороженного счета

account.UnfreezeAccount();
account.Deposit(500.00m); // Должно выполниться после разморозки счета

Console.ReadKey();
```
