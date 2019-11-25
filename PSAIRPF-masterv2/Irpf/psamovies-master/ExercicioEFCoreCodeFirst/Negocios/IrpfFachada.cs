using ExercicioEFCoreCodeFirst;
using System;
using System.Collections.Generic;
using System.Text;

namespace IrpfApp.BLL
{
    public class IrpfFachada
    {

        private ContribuinteDAO cadContribuinte;

        public IrpfFachada()
        {
            cadContribuinte = new BaseDados();

        }

        internal Declaracao buscarDeclaracao(int cpf)
        {
            ContribuinteDAO declaracoes = new BaseDados();
            Declaracao decl = declaracoes.buscarCPF(cpf);

            return decl;

        }


        internal Declaracao AlterarStatus(bool status)
        {
            ContribuinteDAO declaracoes = new BaseDados();
            Declaracao decl = declaracoes.AlterarStatus(status);

            return decl;
        }



        internal Deducao LancarDeducao(Deducao ded)
        {
            ContribuinteDAO deducao = new BaseDados();
            Deducao decl = deducao.LancarDeducao(ded);

            return decl;
        }
        internal Contribuinte CadastrarContribuinte(Contribuinte c)
        {
            ContribuinteDAO con= new BaseDados();
            Contribuinte cc = con.CadastrarContribuinte(c);

            return cc;
        }


        internal Contribuinte buscarContribuinte(int cpf)
        {
            ContribuinteDAO contribuintes = new BaseDados();
            Contribuinte cont = contribuintes.BuscarCPFContribuinte(cpf);

            return cont;
        }

        internal Declaracao adicionarDeclaracao(Declaracao d)
        {
            ContribuinteDAO dec = new BaseDados();
            Declaracao de = dec.adicionarDec(d);

            return de;
        }
    }




    //public void adicionarDeclaracao(Declaracao d) //throws IrpfException
    //{
    //  //  cadContribuinte.ad

    //}

    //public List<DeclaracaoIrpf> getContribuintes()
    //{
    //    try
    //    {
    //        return cadContribuinte.buscarTodos();
    //    }
    //    catch (Exception e)
    //    {
    //        throw new IrpfException(e);
    //    }
    //}

    //public List<DeclaracaoIrpf> getContribuintesIdosos()
    //{
    //    try
    //    {
    //        return cadContribuinte.buscarIdosos();
    //    }
    //    catch (Exception e)
    //    {
    //        throw new IrpfException(e);
    //    }
    //}

//    public double calcula(TipoCalculo t, String cpf)
//    {
//        Declaracao contribuinte;
//        try
//        {
//            contribuinte = contribuinte.buscarCPF(cpf);
//        }
//        catch (DAOException ex)
//        {
//            throw new IrpfException("Erro: " + ex.Message);
//        }
//        if (contribuinte == null)
//        {
//            throw new IrpfException("CPF inexistente: " + cpf);
//        }
//        CalculoIrpf ir = CalculoIrpfFactory.createInstance(t);
//        //contribuinte.defineCalculo(ir);
//        //return contribuinte.getImpostoDevido();
//    }
//}


