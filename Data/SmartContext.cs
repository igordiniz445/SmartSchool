
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Models;

namespace SmartSchool.API.Data
{
    public class SmartContext : DbContext
    {
        public SmartContext(DbContextOptions<SmartContext> contextOptions) : base(contextOptions){}
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDIsciplina> AlunosDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){
            /*Criando o Muito pra Muitos */
            builder.Entity<AlunoDIsciplina>().HasKey(AD => new {AD.AlunoId, AD.DisciplinaId});
        }
    }
}