using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud.Models.ViewModels;
//Obtiene los elementos a partir de Entityframework
using MVCCrud.Models;


namespace MVCCrud.Controllers
{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {

            //Saca la lista
            List<ListTablaViewModel> lst;


            //Uso del contexto entities. Conexion a la BD
            using (CrudEntities db = new CrudEntities())
            {

                //Obtiene el listado de los elementos
                lst = (from d in db.tabla

                       select new ListTablaViewModel

                       {
                           Id = d.id,
                           Nombre = d.nombre,
                           Correo = d.correo

                       }).ToList();
            }    

            //Manda la lista como modelo a su vista
            return View(lst);
        }

        //Metodo nuevo
        public ActionResult Nuevo()
        {

            return View();

        }

            public ActionResult Inicio()
        {
            return View();
        }

        //Metodo nuevo que ejecuta el boton guardar
        [HttpPost]
        public ActionResult Nuevo(TablaViewModel model)
        {
            //El try regresa el error si existe
            try
            {

                //Valida los datanotation que son requeridos y ahi empieza la programacion
                if(ModelState.IsValid)
                {

                 
                    using (CrudEntities db = new CrudEntities())
                    {

                        //Creacion del objeto tabla(o)
                        var oTabla = new tabla();

                        
                        oTabla.nombre = model.Nombre;
                        oTabla.correo = model.Correo;
                        oTabla.fecha_nacimiento = model.Fecha_Nacimiento;

                        //Guarda en la BD la informacion
                        db.tabla.Add(oTabla);
                        db.SaveChanges();

                    }

                    //Regresa a la vista donde esta el listado
                    return Redirect("~/Tabla/");

                }
                return View(model);

            }

            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        
        //Metodo editar

        //int ID recibe al ID
        public ActionResult Editar(int Id)

        {
            //Se manda el modelo a partir de la BD
            TablaViewModel model = new TablaViewModel();
            using(CrudEntities db = new CrudEntities())

            {
                //Se obtienen los elementos de ID
                var oTabla = db.tabla.Find(Id);

                //Llena los modelos ID, NOMBRE, CORREO Y FECHA
                
                //Se manda el ID al modelo para saber cual se va a editar
                model.Id = oTabla.id;
                model.Nombre = oTabla.nombre;
                model.Correo = oTabla.correo;
                model.Fecha_Nacimiento = oTabla.fecha_nacimiento;

                

            }

            return View(model);

        }
        
          
        //Metodo editar con cod. programacion
        [HttpPost]
        public ActionResult Editar(TablaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (CrudEntities db = new CrudEntities())
                    {
                        var oTabla = db.tabla.Find(model.Id);
                        oTabla.nombre = model.Nombre;
                        oTabla.correo = model.Correo;
                        oTabla.fecha_nacimiento = model.Fecha_Nacimiento;

                        db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    return Redirect("~/Home/");
                }
                return View(model);
            }

            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        //Solicitud para eliminar
        [HttpGet]

        public ActionResult Eliminar (int Id)

        {

            using (CrudEntities db = new CrudEntities())
            {

                var oTabla = db.tabla.Find(Id);

                //Elimina la entidad (tabla)
                db.tabla.Remove(oTabla);
                //Guarda
                db.SaveChanges();
            }

            //Redirect al listado
            return Redirect("~/Tabla/");

           
        }

  

    }
 }


 











 