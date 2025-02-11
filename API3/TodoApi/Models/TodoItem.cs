namespace TodoApi.Models
{
    public class TodoItem
    {
        public int Id { get; set; }  

        public string nome_Loc { get; set; } = string.Empty;  
        public string est_Loc { get; set; } = string.Empty;   
        public string desc_Loc { get; set; } = string.Empty;  
        public string ref_Loc { get; set; } = string.Empty;   
        public string descritivos_Loc { get; set; } = string.Empty;  
    }

}
