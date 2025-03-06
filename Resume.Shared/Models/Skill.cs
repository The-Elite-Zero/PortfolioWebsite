namespace Resume.Shared.Models
{
    public class Skill
    {
        public const string LANGUAGE = "Language";
        public const string FRAMEWORK = "Framework & Tools";
        public const string DBMS = "DBMS";
        public const string CLOUD = "Cloud";
        public const string DEVOPS = "DevOps";
        public const string DEVSECOPS = "DevSecOps";

        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string? Type { get; set; } = string.Empty;
        public int YearsExperience { get; set; }
        public string? ImgURL { get; set; } = string.Empty;
        public bool? IsTopSkill { get; set; } = false;

        public static readonly Dictionary<string, string> SkillCategories = new()
        {
            { "Languages", LANGUAGE },
            { "Frameworks & Tools", FRAMEWORK },
            { "Database Management", DBMS },
            { "Cloud", CLOUD },
            { "DevOps", DEVOPS },
            { "DevSecOps", DEVSECOPS }
        };

    }
}
