using System;
using System.IO;
using UniqueArtLib; // DLL đa năng của bạn

public partial class api : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            // Đọc JSON input từ request body
            string json = "";
            using (StreamReader reader = new StreamReader(Request.InputStream))
            {
                json = reader.ReadToEnd();
            }

            // Parse thủ công
            string input = ExtractValue(json, "input");
            string gridStr = ExtractValue(json, "grid");
            string mirrorStr = ExtractValue(json, "mirror");

            int grid = 9;
            bool mirror = true;
            int.TryParse(gridStr, out grid);
            bool.TryParse(mirrorStr, out mirror);

            // Gọi DLL đa năng
            ArtisticHashArt art = new ArtisticHashArt();
            art.InputText = input;
            art.GridSize = grid;
            art.Mirror = mirror;
            art.Author = "WEB-ADMIN";

            string output = art.GenerateArt();
            string meta = art.Metadata;

            // Trả về JSON cho client
            Response.ContentType = "application/json";
            Response.Write("{\"art\":\"" + EscapeJson(output) + "\", \"meta\":\"" + EscapeJson(meta) + "\"}");
        }
        catch (Exception ex)
        {
            Response.ContentType = "application/json";
            Response.Write("{\"error\":\"" + EscapeJson(ex.Message) + "\"}");
        }
    }

    private string ExtractValue(string json, string key)
    {
        int i = json.IndexOf("\"" + key + "\"");
        if (i == -1) return "";
        i = json.IndexOf(":", i);
        if (i == -1) return "";
        int start = json.IndexOfAny(new char[] { '\"', 't', 'f', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }, i + 1);
        if (start == -1) return "";
        int end = json.IndexOfAny(new char[] { ',', '}', '\n' }, start);
        if (end == -1) end = json.Length;
        string val = json.Substring(start, end - start).Trim().Trim('\"');
        return val;
    }

    private string EscapeJson(string s)
    {
        return s.Replace("\\", "\\\\")
                .Replace("\"", "\\\"")
                .Replace("\r", "")
                .Replace("\n", "\\n");
    }
}
