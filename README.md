TR:
Pozitif bir tamsayı N veriliyor.
1 ile N (dahil) arasındaki pozitif tam sayılardan oluşan bir S kümesi, aşağıdaki koşulu sağlıyorsa iyi bir küme olarak adlandırılır:

S içindeki her bir x ve y elemanı için, x'in y'ye bölümünden kalan 1 değildir.

Mümkün olan en fazla sayıda eleman içeren bir iyi küme S oluşturun.

Kısıtlar
1 ≤ N ≤ 2 × 10^5

Girdi
Girdi standart girişten aşağıdaki formatta verilir:

N

Çıktı
Oluşturduğunuz iyi kümenin eleman sayısı k ve elemanları S = {S₁, S₂, ..., S_k} olsun.
Aşağıdaki formatta çıktı verin:

k
S₁ S₂ ... S_k

Birden fazla geçerli çözüm varsa, herhangi biri kabul edilecektir.

Örnek Girdi:
5

Örnek Çıktı:
2
3 5

Örneğin, {3,5} ve {2} iyi kümelerdir. Öte yandan, {2,3,5} ve {1,2,3,4,5} iyi kümeler değildir.

Üç veya daha fazla eleman içeren iyi bir küme yoktur, bu yüzden {3,5} maksimum eleman sayısına sahip iyi kümelerden biridir.

Örnek Girdi:
2

Örnek Çıktı:
1
2


----------------------------------------------------------------


ENG:
Problem Statement
You are given a positive integer 
N. A set 
S of positive integers between 
1 and 
N (inclusive) is called a good set if it satisfies the following condition:

For every pair of elements 
x and 
y in 
S, the remainder when 
x is divided by 
y is not 
1.
Construct one good set with the maximum possible number of elements.

Constraints
1≤N≤2×10 
5
 
Input
The input is given from Standard Input in the following format:

N
Output
Let 
k be the number of elements of the good set 
S you constructed, and let 
S={S 
1
​
 ,S 
2
​
 ,…,S 
k
​
 } be its elements. Output in the following format:

k
S 
1
​
  S 
2
​
  … S 
k
​
 
If multiple solutions exist, any of them will be accepted.

Sample Input 1
Copy
5
Sample Output 1
Copy
2
3 5
For example, 
{3,5} and 
{2} are good sets. On the other hand, 
{2,3,5} and 
{1,2,3,4,5} are not good sets.

No good set with three or more elements exists, so 
{3,5} is one of the good sets with the maximum number of elements.

Sample Input 2
Copy
2
Sample Output 2
Copy
1
2 


---------------------------------------------


Problem Özeti ve Analiz
Koşul:
S kümesindeki her x, y için:
x % y != 1 olmalı.

Yani herhangi iki sayı arasında "bölümünden kalan 1" durumu olmamalı.

Yaklaşım
En büyük iyi kümeyi bulmak istiyoruz.

Örnekten yola çıkarak, {3,5} iyi, {2,3,5} kötü.

Gözlemler:

1'i asla eklemiyoruz, çünkü 1 % x her zaman 1 olabilir.

"Bölümünden kalan 1" sorununu önlemek için genellikle "ardışık sayılar" veya "belirli farklarda olanlar" sorun çıkarır.

Örnek 1’den büyük tek sayılar seçilebilir gibi görünüyor (örnek {3,5} gibi).

Basit ve hızlı çözüm önerisi:
2’den başlayıp N’ye kadar tek sayıları seçmek iyi küme oluşturur.

Çünkü tek sayılar arasındaki mod işlemi 1 kalanı üretmez (örneğin 3 % 5 = 3, 5 % 3 = 2, hiçbiri 1 değil).

Ayrıca 2’yi eklersek 3 % 2 = 1 olur ve bu yüzden 2 ve 3 birlikte olamaz.

Yani cevap: 2’den N’ye kadar olan tek sayılar.
