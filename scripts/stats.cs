// Rebuild the Progress section of README.md from the headers of all problem files.
//
// Usage: dotnet run scripts/stats.cs

using System.Text;
using System.Text.RegularExpressions;

var root = FindRoot();
var readmePath = Path.Combine(root, "README.md");
const string Start = "<!-- PROGRESS:START -->", End = "<!-- PROGRESS:END -->";

var perPattern = new List<(string Pattern, List<Problem> Items)>();
foreach (var folder in Directory.GetDirectories(Path.Combine(root, "problems")).OrderBy(d => d))
{
    var items = Directory.GetFiles(folder)
        .Where(f => !Path.GetFileName(f).StartsWith('.'))
        .Select(f => Parse(f, root))
        .OrderBy(p => p.Num)
        .ToList();
    perPattern.Add((Path.GetFileName(folder)[3..], items));
}

var all = perPattern.SelectMany(p => p.Items).ToList();
int Count(string d) => all.Count(p => p.Difficulty.Equals(d, StringComparison.OrdinalIgnoreCase));

var sb = new StringBuilder();
sb.AppendLine($"**Total: {all.Count}** | Easy {Count("Easy")} | Medium {Count("Medium")} | Hard {Count("Hard")}");
sb.AppendLine();
sb.AppendLine("| Pattern | Solved |");
sb.AppendLine("|---|---|");
foreach (var (pattern, items) in perPattern)
    sb.AppendLine($"| {pattern} | {items.Count} |");
sb.AppendLine();
sb.AppendLine("| # | Problem | Difficulty | Pattern | Date | Code |");
sb.AppendLine("|---|---|---|---|---|---|");
foreach (var (pattern, items) in perPattern)
    foreach (var p in items)
    {
        string name = p.Link != "" ? $"[{p.Title}]({p.Link})" : p.Title;
        sb.AppendLine($"| {p.Num} | {name} | {p.Difficulty} | {pattern} | {p.Date} | [code]({p.Path}) |");
    }

var readme = File.ReadAllText(readmePath);
var updated = Regex.Replace(readme, Regex.Escape(Start) + ".*?" + Regex.Escape(End),
    _ => Start + "\n" + sb.ToString().Replace("\r\n", "\n") + End, RegexOptions.Singleline);
File.WriteAllText(readmePath, updated);
Console.WriteLine($"README updated: {all.Count} problems");

static Problem Parse(string file, string root)
{
    var text = File.ReadAllText(file);
    string Field(string name)
    {
        var m = Regex.Match(text, $@"^[\s#/*\-]*{name}:\s*(.+?)\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
        return m.Success ? m.Groups[1].Value : "";
    }
    var t = Regex.Match(text, @"#\s*(\d+)\.\s*(.+)");
    return new Problem(
        t.Success ? int.Parse(t.Groups[1].Value) : 0,
        t.Success ? t.Groups[2].Value.Trim() : Path.GetFileNameWithoutExtension(file),
        Field("Link"), Field("Difficulty") is var d && d != "" ? d : "?",
        Field("Date"),
        Path.GetRelativePath(root, file).Replace('\\', '/'));
}

static string FindRoot()
{
    var dir = new DirectoryInfo(Directory.GetCurrentDirectory());
    while (dir != null && !Directory.Exists(Path.Combine(dir.FullName, "problems")))
        dir = dir.Parent;
    return dir?.FullName ?? throw new Exception("Run this from inside the repo.");
}

record Problem(int Num, string Title, string Link, string Difficulty, string Date, string Path);
