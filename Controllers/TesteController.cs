﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula_MVC.Models;

namespace Aula_MVC.Controllers
{
    public class TesteController : Controller
    {
        private BancoContexto db = new BancoContexto();
        
        // GET: Teste
        public ActionResult Index()
        {
            return View(db.Alunos.ToList());
        }

        public ViewResult Details (int id)
        {
            Aluno aluno = db.Alunos.Find(id);
            return View(aluno);
        }
    }
}