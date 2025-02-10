namespace TodoApi.Models
{
    public class TodoItem
{
    public int Id { get; set; }  // Coluna 'id' do tipo int no banco de dados

    public string nome_Loc { get; set; } = string.Empty;  // Coluna 'nome_Loc' do tipo nvarchar
    public string est_Loc { get; set; } = string.Empty;   // Coluna 'est_Loc' do tipo nvarchar
    public string desc_Loc { get; set; } = string.Empty;  // Coluna 'desc_Loc' do tipo nvarchar
    public string ref_Loc { get; set; } = string.Empty;   // Coluna 'ref_Loc' do tipo nvarchar
    public string descritivos_Loc { get; set; } = string.Empty;  // Coluna 'descritivos_Loc' do tipo nvarchar
}

}
