using Nity_Pet_Rações.Forms.Forcedores;
using System.Linq;
using System.Windows.Forms;

namespace Nity_Pet_Rações.Utils
{
    public static class InstanciarForms
    {
        public static Form VerificarForm(Principal principal, string nomeForm)
        {
            Form instancia = null;
            switch (nomeForm)
            {
                case "ConsultarFornecedor":
                    foreach(Form childForm in principal.MdiChildren)
                    {
                        if (childForm.Name.Equals(nomeForm))
                        {
                            instancia = childForm;
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
                        instancia = new ConsultarFornecedor();
                        
                    }
                    break;
            }
            return instancia;
        }
    }
}
