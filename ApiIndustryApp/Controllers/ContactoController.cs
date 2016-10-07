using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiIndustryApp.Models;

namespace ApiIndustryApp.Controllers
{
    public class ContactoController : ApiController
    {
        public List<Contactos> GetAllContactos()
        {
            return new List<Contactos>
            {
                new Contactos
                {
                    Nombre = "Raul",
                    Correo = "raulc@rsimexico.com",
                    Empresa = "RSI Mexico",
                    FechaRegistro = DateTime.Now,
                    Id = 1,
                    IdUsuario = 2,
                    Telefono = "1028393"
                },
                new Contactos
                {
                    Nombre = "Pablo",
                    Correo = "pablo@sdpoint.com",
                    Empresa = "SDPoint",
                    FechaRegistro = DateTime.Now,
                    Id = 2,
                    IdUsuario = 2,
                    Telefono = "10283931"
                },
            };
        }

        public Contactos GetContactoById(int id)
        {
            switch (id)
            {
                case 1:
                    return new Contactos
                    {
                        Nombre = "Raul",
                        Correo = "raulc@rsimexico.com",
                        Empresa = "RSI Mexico",
                        FechaRegistro = DateTime.Now,
                        Id = 1,
                        IdUsuario = 2,
                        Telefono = "1028393"
                    };
                case 2:
                    return new Contactos
                    {
                        Nombre = "Pablo",
                        Correo = "pablo@sdpoint.com",
                        Empresa = "SDPoint",
                        FechaRegistro = DateTime.Now,
                        Id = 2,
                        IdUsuario = 2,
                        Telefono = "10283931"
                    };
                default:
                    return new Contactos
                    {
                        Nombre = "",
                        Correo = "",
                        Empresa = "",
                        FechaRegistro = DateTime.Now,
                        Id = 0,
                        IdUsuario = 0,
                        Telefono = ""
                    };
            }
        }

        //public Contactos GetContactoByCorreo(string correo)
        //{
        //    switch (correo)
        //    {
        //        case "raulc@rsimexico.com":
        //            return new Contactos
        //            {
        //                Nombre = "Raul",
        //                Correo = "raulc@rsimexico.com",
        //                Empresa = "RSI Mexico",
        //                FechaRegistro = DateTime.Now,
        //                Id = 1,
        //                IdUsuario = 2,
        //                Telefono = "1028393"
        //            };
        //        case "pablo@sdpoint.com":
        //            return new Contactos
        //            {
        //                Nombre = "Pablo",
        //                Correo = "pablo@sdpoint.com",
        //                Empresa = "SDPoint",
        //                FechaRegistro = DateTime.Now,
        //                Id = 2,
        //                IdUsuario = 2,
        //                Telefono = "10283931"
        //            };
        //        default:
        //            return new Contactos
        //            {
        //                Nombre = "",
        //                Correo = "",
        //                Empresa = "",
        //                FechaRegistro = DateTime.Now,
        //                Id = 0,
        //                IdUsuario = 0,
        //                Telefono = ""
        //            };
        //    }
        //}
    }
}
