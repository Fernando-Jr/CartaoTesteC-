using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernando.Interface
{
    interface ICrud
    {
        void inserir(Object voo);

        void editar(Object voo);

        void deletar(int id);

        Entidade.Voo vooPorId(int id);

        List<Object> listaVoo();
    }
}
