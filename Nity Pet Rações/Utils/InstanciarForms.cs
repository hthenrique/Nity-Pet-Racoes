using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nity_Pet_Rações.Utils
{
    public static class InstanciarForms
    {
        public static Form VerificarForm(Form form, string nomeForm)
        {
            Form instancia = null;
            switch (nomeForm)
            {
                case "ConsultarFornecedor":
                    foreach(Form childForm in form.MdiChildren)
                    {
                        if (childForm.Name.Equals(nomeForm))
                        {
                            instancia = childForm;
                            break;
                        }
                    }
                    if(instancia != null)
                    {
                        instancia.BringToFront();
                        instancia.Activate();
                        return null;
                    }
                    else
                    {
                        instancia = new Forms.Forcedores.ConsultarFornecedor();

                    }
                    break;
            }
            return instancia;
        }
    }
}
