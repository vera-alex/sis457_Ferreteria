﻿using CadFerreteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnFerreteria
{
    internal class ProductoCln
    {
        public static int insertar(Producto producto)
        {
            using (var context = new LabFerreteriaEntities())
            {
                context.Producto.Add(producto);
                context.SaveChanges();
                return producto.id;
            }
        }

        public static int actualizar(Producto producto)
        {
            using (var context = new LabFerreteriaEntities())
            {
                var existente = context.Producto.Find(producto.id);
                existente.codigo = producto.codigo;
                existente.descripcion = producto.descripcion;
                existente.marca = producto.marca;
                existente.unidadMedida = producto.unidadMedida;
                existente.precioVenta = producto.precioVenta;
                existente.stock = producto.stock;
                existente.usuarioRegistro = producto.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuario)
        {
            using (var context = new LabFerreteriaEntities())
            {
                var producto = context.Producto.Find(id);
                producto.estado = -1;
                producto.usuarioRegistro = usuario;
                return context.SaveChanges();
            }
        }

        public static Producto obtenerUno(int id)
        {
            using (var context = new LabFerreteriaEntities())
            {
                return context.Producto.Find(id);
            }
        }

        public static List<Producto> listar()
        {
            using (var context = new LabFerreteriaEntities())
            {
                return context.Producto.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paProductoListar_Result> listarPa(string parametro)
        {
            using (var context = new LabFerreteriaEntities())
            {
                return context.paProductoListar(parametro).ToList();
            }
        }
    }
}
