--select
select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

select * from Customers where City= 'London'

select * from Products where CategoryID=1 or CategoryID=3

--or da iki şartttan biri gerçekleştirilmeli
-- and ise ikisi de gerçekleştirilmeli

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products where CategoryID=1  order by UnitPrice desc    --asc ascending   --desc descending

select count(*) from Products  --product tablosunda kaç ürün var

select COUNT(*) adet from Products where CategoryID=2   --adet yazan kısım column name verilir.

select CategoryID, COUNT(*) from Products where UnitPrice>20 group by CategoryID having COUNT(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10
--inner join sadece iki tabloda eşleşenleri bir araya getirir. eşleşmeyen data varsa onu getirmez

select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID= od.OrderID

select * from Customers c left join Orders o
on c.CustomerID= o.CustomerID
where o. CustomerID is null

--dto  data transformation object
-- left join solda olup sağda olmayanları da getir demek



