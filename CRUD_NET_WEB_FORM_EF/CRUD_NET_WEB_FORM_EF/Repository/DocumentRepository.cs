using CRUD_NET_WEB_FORM_EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_NET_WEB_FORM_EF.Repository
{
    public class DocumentRepository
    {
        public void Save(Documento documento)
        {
            using (dbRecursosHumanosEntities1 contexto=new dbRecursosHumanosEntities1())
            {
                contexto.Documento.Add(documento);
                contexto.SaveChanges();
            }
        }

        public List<Documento> Get()
        {
            using (dbRecursosHumanosEntities1 contexto = new dbRecursosHumanosEntities1())
            {
                return contexto.Documento.AsNoTracking().ToList(); //consultar sin guardar copia en memoria
            }
        }
    }
}