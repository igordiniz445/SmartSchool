namespace SmartSchool.API.Models
{
    public class AlunoDIsciplina
    {
        public AlunoDIsciplina() { }

        public AlunoDIsciplina(int alunoId, int disciplinaId)
        {
            this.AlunoId = alunoId;
            this.DisciplinaId = disciplinaId;
        }
        public int AlunoId { get; set; }
        public int DisciplinaId { get; set; }

        public Aluno Aluno { get; set; }
        public Disciplina Disciplin { get; set; }
    }
}