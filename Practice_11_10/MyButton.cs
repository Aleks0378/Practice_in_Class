using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Створити клас MyButton з властивостями
//колір, ширина, висота, текст на кнопке
//Створити подію OnClickButton
//Создать несколько подписчиков данного события,
//которые выполняют некоторый функционал
//Вивести в консоль повідомлення,
//що кнопка була нажата та час, коли це сталось
namespace Practice_11_10
{
    public delegate void OnClickButton();
    internal class MyButton
    {
        public event OnClickButton

        public string Color { get; set; }
        public string Text { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }


    }
}
