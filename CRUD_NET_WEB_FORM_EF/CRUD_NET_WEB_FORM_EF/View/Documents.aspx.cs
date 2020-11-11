using CRUD_NET_WEB_FORM_EF.Model;
using CRUD_NET_WEB_FORM_EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_NET_WEB_FORM_EF.View
{
    public partial class Documents : System.Web.UI.Page
    {
        DocumentRepository documentRepository = new DocumentRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            GetDocuments();
        }

        private void GetDocuments()
        {
            gvDocuments.DataSource = documentRepository.Get();
            gvDocuments.DataBind();
        }

        protected void btnSaveOnclick(object sender, EventArgs e)
        {
            Documento documento = new Documento();

            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                documento.Nombre = txtName.Text;
                documentRepository.Save(documento);

                CleanForm();
                GetDocuments();
            }
        }

        private void CleanForm()
        {
            txtName.Text = "";
        }
    }
}