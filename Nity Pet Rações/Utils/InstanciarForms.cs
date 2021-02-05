using Nity_Pet_Rações.Forms.Forcedores;
using System.Linq;
using System.Windows.Forms;

namespace Nity_Pet_Rações.Utils
{
    public static class InstanciarForms
    {
        public static Form VerificarForm(string nomeForm)
        {
            Form form = null;
            switch (nomeForm)
            {
                case "ConsultarFornecedor":
                    form = Application.OpenForms.OfType<ConsultarFornecedor>().FirstOrDefault();
                    if (form == null)
                    {
                        form = new ConsultarFornecedor();
                        form.Show();

                    }
                    else
                    {
                        form.BringToFront();
                        form.Activate();
                        return null;
                    }
                    break;
                case "AdicionarFornecedor":
                    form = Application.OpenForms.OfType<AdicionarFornecedor>().FirstOrDefault();
                    if(form == null)
                    {
                        form = new AdicionarFornecedor();
                        form.ShowDialog();
                    }
                    break;
            }
            return form;
        }
    }
}
