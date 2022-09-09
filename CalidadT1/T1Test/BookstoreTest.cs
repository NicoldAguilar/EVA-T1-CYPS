using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalidadT1;

namespace T1Test
{
    public class BookstoreTest
    {
        //Prueba 01
        [Test]
        public void Carrito01()
        {
            var librito = new Book();
            var tiendaLibros = new BookStore();
            librito.Name = "Las mil y una noches";
            librito.Price = 20.0M;
            librito.Name = "Maria";
            librito.Price = 38.9m;
            librito.Name = "Indigno de ser humano";
            librito.Price = 52.3m;
            tiendaLibros.AddToCart(librito);
            var carritocompras = tiendaLibros.GetTotal();
            Assert.AreEqual(111.2M,carritocompras);
        }

        //Prueba 012
        [Test]
        public void Carrito02()
        {
            var librito = new Book();
            var tiendaLibros = new BookStore();
            librito.Name = "Harry Potter";
            librito.Price = 80.0M;
            librito.Name = "Harry Potter";
            librito.Price = 80.0m;
            tiendaLibros.AddToCart(librito);
            var carritocompras = tiendaLibros.GetTotal();
            Assert.AreEqual(144.0M, carritocompras);
        }

        //Prueba 03
        [Test]
        public void Carrito03()
        {
            var librito = new Book();
            var tiendaLibros = new BookStore();
            librito.Name = "Las mil y una noches";
            librito.Price = 20.0M;
            librito.Name = "Indigno de ser humano";
            librito.Price = 52.3m;
            tiendaLibros.AddToCart(librito);
            var carritocompras = tiendaLibros.GetTotal();
            Assert.AreEqual(72.3M, carritocompras);
        }

        //Prueba 04
        [Test]
        public void Carrito04()
        {
            var librito = new Book();
            var tiendaLibros = new BookStore();
            librito.Name = "Maria";
            librito.Price = 38.9m;
            librito.Name = "Indigno de ser humano";
            librito.Price = 52.3m;
            tiendaLibros.AddToCart(librito);
            var carritocompras = tiendaLibros.GetTotal();
            Assert.AreEqual(91.2M, carritocompras);
        }

        //Prueba 05
        [Test]
        public void Carrito05()
        {
            var librito = new Book();
            var tiendaLibros = new BookStore();
            librito.Name = "Las mil y una noches";
            librito.Price = 20.0M;
            librito.Name = "Maria";
            librito.Price = 38.9m;
            tiendaLibros.AddToCart(librito);
            var carritocompras = tiendaLibros.GetTotal();
            Assert.AreEqual(58.9M, carritocompras);
        }

        //Prueba 06
        [Test]
        public void Carrito06()
        {
            var librito = new Book();
            var tiendaLibros = new BookStore();
            librito.Name = "Las mil y una noches";
            librito.Price = 20.0M;
            tiendaLibros.AddToCart(librito);
            var carritocompras = tiendaLibros.GetTotal();
            Assert.AreEqual(20.0M, carritocompras);
        }

        //Prueba 07
        [Test]
        public void Carrito07()
        {
            var librito = new Book();
            var tiendaLibros = new BookStore();
            librito.Name = "Las mil y una noches";
            librito.Price = 20.0M;
            librito.Name = "Indigno de ser humano";
            librito.Price = 52.3m;
            tiendaLibros.AddToCart(librito);
            var carritocompras = tiendaLibros.GetTotal();
            Assert.AreEqual(72.3M, carritocompras);
        }

        //Prueba 08
        [Test]
        public void Carrito08()
        {
            var librito = new Book();
            var tiendaLibros = new BookStore();
            librito.Name = "Indigno de ser humano";
            librito.Price = 52.3m;
            tiendaLibros.AddToCart(librito);
            var carritocompras = tiendaLibros.GetTotal();
            Assert.AreEqual(52.3M, carritocompras);
        }

        //Prueba 09
        [Test]
        public void Carrito09()
        {
            var librito = new Book();
            var tiendaLibros = new BookStore();
            librito.Name = "Harry Potter";
            librito.Price = 80.0M;
            librito.Name = "Indigno de ser humano";
            librito.Price = 52.3m;
            tiendaLibros.AddToCart(librito);
            var carritocompras = tiendaLibros.GetTotal();
            Assert.AreEqual(132.3M, carritocompras);
        }

        //Prueba 010
        [Test]
        public void Carrito010()
        {
            var librito = new Book();
            var tiendaLibros = new BookStore();
            librito.Name = "Maria";
            librito.Price = 38.9m;
            tiendaLibros.AddToCart(librito);
            var carritocompras = tiendaLibros.GetTotal();
            Assert.AreEqual(38.9M, carritocompras);
        }
    }
}
