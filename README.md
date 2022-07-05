# Задача на C#
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- [X]Юнит-тесты
- [X]Легкость добавления других фигур
- [X]Вычисление площади фигуры без знания типа фигуры в compile-time
- [X]Проверку на то, является ли треугольник прямоугольным
### [Библиотека с фигурами](https://github.com/PaulZtx/MindBox/blob/main/MindLib%20%E2%80%94%20%D0%BA%D0%BE%D0%BF%D0%B8%D1%8F/ClassShape.cs)
### [Библиотека с unit тестами](https://github.com/PaulZtx/MindBox/blob/main/MindLibTests%20%E2%80%94%20%D0%BA%D0%BE%D0%BF%D0%B8%D1%8F/UnitTest1.cs)
# Задача SQL
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

```
CREATE TABLE Product(
	Id INT IDENTITY PRIMARY KEY, 
	[Name] NVARCHAR(255) NOT NULL
)
CREATE TABLE Category(
	Id INT IDENTITY PRIMARY KEY, 
	[Name] NVARCHAR(255) NOT NULL
)

CREATE TABLE ProductsWithCatategories(
	ProductId INT NOT NULL FOREIGN KEY REFERENCES Product(Id), 
	CategoryId INT NOT NULL FOREIGN KEY REFERENCES Category(Id),
	PRIMARY KEY(ProductId, CategoryId)
)

INSERT INTO Product 
	VALUES('Молоко'), ('Хлеб'), ('Курица'), ('Вода'), ('Макароны'), ('Масло')

INSERT INTO Category 
	VALUES('Выпечка'), ('Напитки'), ('Мясо')

INSERT INTO ProductsWithCatategories 
	VALUES(1, 2), (2, 1), (3, 3)

SELECT Product.[Name] AS 'Наименование', Category.[Name] AS 'Категория товара' FROM Product 
	LEFT JOIN ProductsWithCatategories ON ProductsWithCatategories.ProductId = Product.Id
	LEFT JOIN Category ON Category.Id = ProductsWithCatategories.CategoryId

```

![изображение](https://user-images.githubusercontent.com/36164890/177372246-654fbe56-186a-43fb-a251-879b66f10809.png)
