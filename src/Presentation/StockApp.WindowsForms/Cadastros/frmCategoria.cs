using StockApp.Business.Entidades;
using StockApp.Business.Interfaces;

namespace StockApp.WindowsForms.Cadastros
{
    public partial class frmCategoria : Form
    {
        private readonly ICategoriaRepository _categoriaRepositorio;
        public frmCategoria()
        {
            InitializeComponent();
        }
        public frmCategoria(ICategoriaRepository categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novaCategoria = new Categoria();
            novaCategoria.Nome = txtNome.Text;
            novaCategoria.Status = chkStatus.Checked;

            var resultado = _categoriaRepositorio.Incluir(novaCategoria);

            if (resultado)
            {
                MessageBox.Show("Categoria cadastrada com sucesso");
            }
            else
            {
                MessageBox.Show("??????????????????????");
            }
        }
    }
}
