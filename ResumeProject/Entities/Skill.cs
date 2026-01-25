namespace ResumeProject.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Title { get; set; }     // Development, UI/UX, Photography
        public int Percent { get; set; }       // 85, 95, 70
        public int AboutId { get; set; }        // FK
        public About About { get; set; }
    }
}
