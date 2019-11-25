using ExercicioEFCoreCodeFirst;
using IrpfApp.BLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


class BaseDados : ContribuinteDAO
{

    public Declaracao adicionarDec(Declaracao d)
    {
        using (var db = new IrpfContext())
        {
            var dec=d;
            db.Declaracoes.Add(d);
            db.SaveChanges();

            return d;

        }

    }


    public Declaracao buscarCPF(int cpf)
    {
        using (var db = new IrpfContext())
        {
            var decl = (from c in db.Declaracoes

                        where c.ContribuinteID == cpf
                        select c).FirstOrDefault();


            return decl;
        }
    }

    public Contribuinte BuscarCPFContribuinte(int cpf)
    {
        using (var db = new IrpfContext())
        {
            var cont = (from c in db.Contribuintes

                        where c.ContribuinteID == cpf
                        select c).FirstOrDefault();


            return cont;
        }
    }


    public Contribuinte CadastrarContribuinte(Contribuinte c)
    {
        using (var db = new IrpfContext())
        {
            
            db.Contribuintes.Add(c);
            db.SaveChanges();

            return c;

        }

    }

    public Deducao LancarDeducao(Deducao d)
    {
        using (var db = new IrpfContext())
        {

            db.Deducoes.Add(d);
            db.SaveChanges();

            return null;

        }

    }




    public Contribuinte AlterarStatus(bool b)
    {
        //using (var db = new IrpfContext())
        //{

        //    db.Deducoes.
        //    db.SaveChanges();

        //    return null;

        //}

    }
}


    //public List<Declaracao> buscarIdosos()
    //{
    //    throw new NotImplementedException();
    //}

    //public List<Declaracao> buscarTodos()
    //{
    //    throw new NotImplementedException();
    //}

    //public void inserir(Declaracao c)
    //{
    //    throw new NotImplementedException();
    //}


    
