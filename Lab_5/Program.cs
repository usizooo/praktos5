using System;

namespace Lab_5
{
    class Program
    {
        static public void Main()
        {
            MenuItem root = new MenuItem("Root", new List<MenuItem>
            {
                new MenuItem("Форма торта", new List<MenuItem>
                {
                    new MenuItem("Круг", new List<MenuItem>(), new PartOfCake(500)),
                    new MenuItem("Квадрат", new List<MenuItem>(), new PartOfCake(500)),
                    new MenuItem("Прямоугольник", new List<MenuItem>(), new PartOfCake(700)),
                    new MenuItem("Сердечко", new List<MenuItem>(), new PartOfCake(600)),
                }),
                new MenuItem("Размер торта", new List<MenuItem>
                {
                    new MenuItem("Маленький", new List<MenuItem>(), new PartOfCake(1000)),
                    new MenuItem("Обычный", new List<MenuItem>(), new PartOfCake(1200)),
                    new MenuItem("Большой", new List<MenuItem>(), new PartOfCake(1500)),
                }),
                new MenuItem("Вкус коржей", new List<MenuItem>
                {
                    new MenuItem("Ванильный", new List<MenuItem>(), new PartOfCake(200)),
                    new MenuItem("Шоколадный", new List<MenuItem>(), new PartOfCake(200)),
                    new MenuItem("Карамельный", new List<MenuItem>(), new PartOfCake(350)),
                    new MenuItem("Ягодный", new List<MenuItem>(), new PartOfCake(400)),
                    new MenuItem("Кокосовый", new List<MenuItem>(), new PartOfCake(450)),
                }),
                new MenuItem("Количество коржей", new List<MenuItem>
                {
                    new MenuItem("1 корж", new List<MenuItem>(), new PartOfCake(500)),
                    new MenuItem("2 коржа", new List<MenuItem>(), new PartOfCake(1000)),
                    new MenuItem("3 коржа", new List<MenuItem>(), new PartOfCake(2000)),
                    new MenuItem("4 коржа", new List<MenuItem>(), new PartOfCake(3000)),
                }),
                new MenuItem("Глазурь", new List<MenuItem>
                {
                    new MenuItem("Шоколад", new List<MenuItem>(), new PartOfCake(100)),
                    new MenuItem("Крем", new List<MenuItem>(), new PartOfCake(200)),
                    new MenuItem("Бизе", new List<MenuItem>(), new PartOfCake(150)),
                    new MenuItem("Драже", new List<MenuItem>(), new PartOfCake(100)),
                    new MenuItem("Ягоды", new List<MenuItem>(), new PartOfCake(300)),
                }),
                new MenuItem("Декор", new List<MenuItem>
                {
                    new MenuItem("Шоколадная", new List<MenuItem>(), new PartOfCake(500)),
                    new MenuItem("Кремовая", new List<MenuItem>(), new PartOfCake(600)),
                    new MenuItem("Ягодная", new List<MenuItem>(), new PartOfCake(700)),
                }),
                new MenuItem("Конец заказа", new List<MenuItem>(), new CloseMenu("История заказов.txt")),
            });

            root.DoWork();
        }
    }
}