﻿# Упражнения: Повторения (цикли)

Задачи за упражнение в клас и за домашно към курса [„Основи на програмирането&quot; @ СофтУни](https://softuni.bg/courses/programming-basics).

## 1.Числа от 1 до 100

Напишете програма, която отпечатва числата от 1 до 100, по едно на ред.

| **вход** | **изход** |
| --- | --- |
| (няма) | 1 <br/> 2 <br/> 3 <br/> … <br/> 98 <rb/> 99 <br/> 100 |

 **Тествайте** решението си в **judge**  **системата** : [https://judge.softuni.bg/Contests/Practice/Index/154#0](https://judge.softuni.bg/Contests/Practice/Index/154#0). Трябва да получите **100 точки** (напълно коректно решение).

## 2.Числа до 1000, завършващи на 7

Напишете програма, която отпечатва числата в диапазона **[****1 ****…**** 10 ****0**** 0****]**, които **завършват на 7**.

| **вход** | **изход** |
| --- | --- |
| (няма) | 7 <br/> 17 <br/> 27 <br/> … <br/> 997 |

**Тествайте** решението си в **judge**  **системата** : [https://judge.softuni.bg/Contests/Practice/Index/154#1](https://judge.softuni.bg/Contests/Practice/Index/154#1).

>**Подсказка** :можете да завъртите **for** -цикъл от 1 до 1000и да проверите всяко число дали завършва на 7. Едно число **num** завършва на 7, когато **(num% 10 ==7)**.

## 3.Всички латински букви

Напишете програма, която отпечатва всички букви от латинската азбука: **a** , **b** , **c** , …, **z**.

**Тествайте** решението си в **judge**  **системата** : [https://judge.softuni.bg/Contests/Practice/Index/154#](https://judge.softuni.bg/Contests/Practice/Index/154#2) [2](https://judge.softuni.bg/Contests/Practice/Index/154#2).

> **Подсказка** :можете да завъртите **for** -цикъл от **&#39;a&#39;** до **&#39;z&#39;** (освен числа може да въртите в цикъл и букви).

## 4.Сумиране на числа

Да се напише програма, която **въвежда**  **n**  **цели числа и ги сумира**.

- От първия ред на входа се въвежда броят числа **n**.
- От следващите **n** реда се въвежда по едно цяло число.

Програмата трябва да прочете числата, да ги сумира и да отпечата сумата им. Примери:

| **вход** | **изход** |  **вход** | **изход** |   **вход** | **изход** |   
| --- | --- | --- | --- | --- | --- | 
| 2 <br/> 10 <br/> 20 | 30 | 3 <br/> -10 <br/> -20 <br/> -30 | -60 | 4 <br/> 45 <br/> -20 <br/> 7 <br/> 11 | 43 |

| **вход** | **изход** |  **вход** | **изход** |
|--- | --- | --- | --- |
| 1 <br/> 999 | 999 | 0 | 0 |

**Тествайте** решението си в **judge**  **системата** : [https://judge.softuni.bg/Contests/Practice/Index/154#](https://judge.softuni.bg/Contests/Practice/Index/154#3) [3](https://judge.softuni.bg/Contests/Practice/Index/154#3).

> **Подсказки** :
> - Първо въведете едно число **n** (броят числа, които предстои да бъдат въведени).
> - Инициализирайте **sum** = **0** (в началото няма още прочетени числа, и съответно сумата е празна).
> - В цикъл **n**  **пъти** прочетете по едно цяло число **num** и го прибавете към сумата ( **sum** = ****sum**** + **num** ).
> - Накрая в **sum** трябва да се е запазила сумата на прочетените числа. Отпечатайте я.

## 5.Най-голямо число

Напишете програма, която въвежда **n**** цели числа**(**n**&gt; 0) и намира**най-голямото **измежду тях. Първо се въвежда броят числа** n **, а след това самите** n**числа, по едно на ред. Примери:

| **вход** | **изход** | **вход** | **изход** |  **вход** | **изход** |   
| --- | --- | --- | --- | --- | --- | 
| 2 <br/> 100 <br/> 99 | 100 | 3 <br/> -10 <br/> 20 <br/> -30 | 20 | 4 <br/> 45 <br/> -20 <br/> 7 <br/> 99 | 99 |

| **вход** | **изход** | **вход** | **изход** |
| --- | --- | --- | --- |
| 1 <br/> 999 | 999 | 2 <br/> -1 <br/> -2 | -1 |

**Тествайте** решението си в **judge**  **системата** : [https://judge.softuni.bg/Contests/Practice/Index/154#](https://judge.softuni.bg/Contests/Practice/Index/154#4) [4](https://judge.softuni.bg/Contests/Practice/Index/154#4).

> **Подсказки** :
> - Първо въведете едно число **n** (броят числа, които предстои да бъдат въведени).
> - Въведете от конзолата първото число. Сложете текущият максимум **max** да е прочетеното число.
> - В цикъл **n** -1 пъти **прочетете по едно цяло число** num **. Ако прочетеното число** num **е по-голямо от текущият максимум** max **, запомнете** num **в** max.
> - Накрая в **max** трябва да се е запазило най-голямото число. Отпечатайте го.

## 6.Най-малко число

Напишете програма, която въвежда **n**** цели числа**(**n**&gt; 0) и намира**най-малкото **измежду тях. Първо се въвежда броят числа** n **, а след това самите** n**числа, по едно на ред. Примери:

| **вход** | **изход** | **вход** | **изход** | **вход** | **изход** |  
| --- | --- | --- | --- | --- | --- | 
| 2 <br/> 100 <br/> 99 | 99 | 3 <br/> -10 <br/> 20 <br/> -30 | -30 | 4 <br/> 45 <br/> -20 <br/> 7 <br/> 99 | -20 |

| **вход** | **изход** | **вход** | **изход** |
| --- | --- | --- | --- |
| 1 <br/> 999 | 999 | 2 <br/> -1 <br/> -2 | -2 |

**Тествайте** решението си в **judge**  **системата** : [https://judge.softuni.bg/Contests/Practice/Index/154#](https://judge.softuni.bg/Contests/Practice/Index/154#5) [5](https://judge.softuni.bg/Contests/Practice/Index/154#5).

> **Подсказки** : задачата е абсолютно аналогична с предходната.

## 7.Лява и дясна сума

Да се напише програма, която въвежда **2\***** n **цели числа и проверява дали** сумата на първите **** n **** числа**(лява сума) е равна на**сумата на вторите **** n **** числа**(дясна сума). При равенство печата &quot;**Yes **&quot; +** сумата **; иначе печата &quot;** No **&quot; +** разликата**.Разликата се изчислява като положително число (по абсолютна стойност). Примери:

| **вход** | **изход** | **коментар** |  
| --- | --- | --- | 
| 2 <br/> 10 <br/> 90 <br/> 60 <br/> 40 | Yes, sum = 100 | 10+90 = 60+40 = 100 | 
|2 <br/> 90 <br/> 9 <br/> 50 <br/> 50 | No, diff = 1 | 90+9 ≠ 50+50Difference = \|99-100\| = 1 |

**Тествайте** решението си в **judge**  **системата** : [https://judge.softuni.bg/Contests/Practice/Index/154#](https://judge.softuni.bg/Contests/Practice/Index/154#6) [6](https://judge.softuni.bg/Contests/Practice/Index/154#6).

> **Подсказки** :
> - Въведете **n**.
> - Въведетепървите **n** числа ( **лявата** половина) и ги сумирайте.
> - Въведетеоще **n** числа ( **дясната** половина) и ги сумирайте.
> - Изчислете **разликата** между сумите по абсолютна стойност: **Math.Abs(leftSum****-****rightSum)**.
> - Ако разликата е **0** , отпечатайте &quot; **Yes**&quot; + **сумата** ; иначе отпечатайте &quot; **No**&quot; + **разликата**.

## 8.Четна / нечетна сума

Да се напише програма, която въвежда **n** цели числа и проверява дали **сумата от числата на четни позиции** е равна на **сумата на числата на нечетни позиции**. При равенство да се отпечата &quot; **Yes**&quot; + **сумата** ; иначе да се отпечата &quot; **No**&quot; + **разликата**.Разликата се изчислява по абсолютна стойност. Примери:

| **вход** | **изход** | **коментар** |   
| --- | --- | --- |
| 4 <br/> 10 <br/> 50 <br/> 60 <br/> 20 | Yes <br/> Sum = 70 | 10+60 = 50+20 = 70 |
| 4 <br/> 3 <br/> 5 <br/> 1 <br/> -2 | NoDiff = 1 | 3+1 ≠ 5-2Diff = \|4-3\| = 1 |
| 3 <br/> 5 <br/> 8 <br/> 1 | No <br/> Diff = 2 | 5+1 ≠ 8Diff =\|6-8\| = 2 |

**Тествайте** решението си в **judge**  **системата** : [https://judge.softuni.bg/Contests/Practice/Index/154#](https://judge.softuni.bg/Contests/Practice/Index/154#7) [7](https://judge.softuni.bg/Contests/Practice/Index/154#7).

> **Подсказки** :Въведете числата едно по едно и изчислете двете **суми** (числа на **четни** позиции и числа на **нечетни** позиции). Както в предходната задача, изчислете абсолютна стойност на разликата и отпечатайте резултата (&quot; **Yes**&quot; + **сумата** при разлика 0 или &quot; **No**&quot; + **разликата** в противен случай).

## 9.Сумиране на гласните букви

Да се напише програма, която въвежда **текст** (стринг) и изчислява и отпечатва **сумата от стойностите на гласните букви** според таблицата по-долу:

| буква | a | e | i | o | u |
| --- | --- | --- | --- | --- | --- |
| стойност | 1 | 2 | 3 | 4 | 5 |

Примери:

| **вход** | **изход** | **коментар** |
| --- | --- | --- |
| hello | 6 | e+o = 2+4 = 6 |
| hi | 3 | i = 3 |
| bamboo | 9 | a+o+o = 1+4+4 = 9 |
| beer | 4 | e+e= 2+2 = 4 |

**Тествайте** решението си в **judge**  **системата** : [https://judge.softuni.bg/Contests/Practice/Index/154#](https://judge.softuni.bg/Contests/Practice/Index/154#8) [8](https://judge.softuni.bg/Contests/Practice/Index/154#8).

> **Подсказки** :
> - Прочетете входния текст **s**. Нулирайте сумата.
> - Завъртете цикъл от **0** до **s.Length-1** (дължината на текста -1).
> - Проверете всяка буква **s[i]** дали е гласна и съответно добавете към сумата стойността й.


## 10.\* Елемент, равен на сумата на останалите

Да се напише програма, която въвежда **n** цели числа и проверява дали сред тях съществува число, което е равно на сумата на всички останали. Ако има такъв елемент, печата &quot; **Yes**&quot; + **неговата стойност** ; иначе печата &quot; **No**&quot; + **разликата между най-големия елемент и сумата на останалите** (по абсолютна стойност). Примери:

| **вход** | **изход** | **коментари** |
| --- | --- | --- |
| 7 <br/> 3 <br/> 4 <rb/> 1 <br/> 1 <br/> 2  <br/> **12** <br/> 1 | Yes <br/> Sum = 12 | 3 + 4 + 1 + 2 + 1 + 1 = 12 |
| 4 <br/> **6** <br/> 1 <br/> 2 <br/> 3 | Yes <br/> Sum = 6 | 1 + 2 + 3 = 12 |
| 3 <br/> 1 <br/> 1 <br/> 10 | No <br/> Diff = 8 | \|10 - (1 + 1)\| = 8 |
| 3 <br/> 5 <br/> 5 <br/> 1 | No <br/> Diff = 1 | \|5 - (5 + 1)\| = 1 |

**Тествайте** решението си в **judge**  **системата** : [https://judge.softuni.bg/Contests/Practice/Index/154#](https://judge.softuni.bg/Contests/Practice/Index/154#9) [9](https://judge.softuni.bg/Contests/Practice/Index/154#9).

> **Подсказка** :изчислете **сумата** на всички елементи и **най-големият** от тях и проверете търсеното условие.

## 11.\* Четни / нечетни позиции

Напишете програма, която чете **n** **числа** и пресмята сумата **,** минимума **и** максимума **на числата на четни и нечетни** позиции (броим от 1).Когато няма минимален / максимален елемент, отпечатайте &quot;**No**&quot;. Примери:

| **вход** | **изход** |  **вход** | **изход** |  
| --- | --- | --- | --- | 
| 6 <br/> **2**  <br/> 3  <br/> **5**  <br/> 4 **2**  <br/> 1 | OddSum=9, OddMin=2, OddMax=5, EvenSum=8, EvenMin=1, EvenMax=4 | 2  <br/> **1.5**  <br/> -2.5 | OddSum=1.5, OddMin=1.5, OddMax=1.5, EvenSum=-2.5, EvenMin=-2.5, EvenMax=-2.5 |
| 1  <br/> **1** | OddSum=1, OddMin=1, OddMax=1, EvenSum=0, EvenMin=No, EvenMax=No | 0 | OddSum=0, OddMin=No, OddMax=No, EvenSum=0, EvenMin=No, EvenMax=No |

| **вход** | **изход** | **вход** | **изход** |  
| --- | --- | --- | --- | 
| 5  <br/> **3**  <br/> -2  <br/> **8**  <br/> 11  <br/> **-3** | OddSum=8, OddMin=-3, OddMax=8, EvenSum=9, EvenMin=-2, EvenMax=11  | 4 <br/> 1.5  <br/> **1.75**  <br/> 1.5  <br/> **1.75** | OddSum=3, OddMin=1.5, OddMax=1.5, EvenSum=3.5, EvenMin=1.75, EvenMax=1.75 |  
| 1  <br/> **-5** | OddSum=-5, OddMin=-5, OddMax=-5, EvenSum=0, EvenMin=No, EvenMax=No | 3  <br/> **-1**  <br/> -2 <br/>  **-3** | OddSum=-4, OddMin=-3, OddMax=-1, EvenSum=-2, EvenMin=-2, EvenMax=-2 |

**Тествайте** решението си в **judge**  **системата** : [https://judge.softuni.bg/Contests/Practice/Index/154#](https://judge.softuni.bg/Contests/Practice/Index/154#10) [10](https://judge.softuni.bg/Contests/Practice/Index/154#10).

> **Подсказки** :
> - Задача обединява няколко предходни задачи: намиране на **минимум** , намиране на **максимум** , намиране на **сума** и обработка на елементите от **четни и нечетни позиции**. Припомнете си ги.
> - Работете с **дробни числа** (не цели). Сумата, минимумът и максимумът също са дробни числа.
> - Използвайте **неутрална начална стойност** при намиране на минимум / максимум, например **1000000000.0** и **-1000000000.0**. Ако получите накрая неутралната стойност, печатайте &quot; **No**&quot;.

## 12.\* Еднакви двойки

Дадени са 2\ ***n** числа.Първото и второто формират **двойка** , третото и четвъртото също и т.н. Всяка двойка има **стойност** – сумата от съставящите я числа. Напишете програма, която проверява **дали всички двойки имат еднаква стойност** или печата **максималната разлика** между две последователни двойки. Ако всички двойки имат еднаква стойност, отпечатайте &quot; **Yes, value=…** &quot; + **стойността**. В противен случай отпечатайте &quot; **No, maxdiff=…** &quot; + **максималната разлика**. Примери:

| **вход** | **изход** | **коментари** |   
| --- | --- | --- | 
| 3 <br/> 1 <br/> 2 <br/> 0 <br/> 3 <br/> 4 <br/> -1 | Yes, value=3 | стойности = {3, 3, 3}  <br/> еднакви стойности |
| 2 <br/> 1 <br/> 2 <br/> 2 <br/> 2 | No, maxdiff=1 | стойности = {3, 4} <br/> разлики = {1} <br/> макс. разлика = 1 |
| 4 <br/> 1 <br/> 1 <br/> 3 <br/> 1 <br/> 2 <br/> 2 <br/> 0 <br/> 0 | No, maxdiff=4 | стойности = {2, 4, 4, 0} <br/> разлики = {2, 0, 4} <br/> макс. разлика = 4 | 
|1 <br/> 5 <br/> 5 | Yes, value=10 | стойности = {10} <br/> една стойностеднакви стойности |
| 2 <br/> -1 <br/> 0 <br/> 0 <br/> -1 | Yes, value=-1 | стойности = {-1, -1} <br/> еднакви стойности |   
| 2 <br/> -1 <br/> 2 <br/> 0 <br/> -1 | No, maxdiff=2 | стойности = {1, -1} <br/> разлики = {2} <br/> макс. разлика = 2 |

**Тествайте** решението си в **judge**  **системата** : [https://judge.softuni.bg/Contests/Practice/Index/154#](https://judge.softuni.bg/Contests/Practice/Index/154#11) [11](https://judge.softuni.bg/Contests/Practice/Index/154#11).

> **Подсказки** :
> - Прочитайте входните числа **по двойки**. За всяка двойка пресмятайте **сумата**.
> - Докато четете входните двойки, за всяка двойка без първата пресмятайте **разликата с предходната**. За целта пазете в отделна променлива сумата на предходната двойка.
> - Намерете **най-голямата разлика** между две двойки. Ако е **0** , печатайте &quot; **Yes**&quot; иначе &quot; **No**&quot; + разликата.