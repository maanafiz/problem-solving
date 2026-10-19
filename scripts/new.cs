// Create a new problem file from the template.
//
// Usage:   dotnet run scripts/new.cs <number> <slug> <pattern> <difficulty>
// Example: dotnet run scripts/new.cs 49 group-anagrams arrays medium
//
// number     = LeetCode problem number
// slug       = the part of the LeetCode URL after /problems/
// pattern    = folder to put it in; partial names work ("arrays", "dp-1d", "graphs")
// difficulty = easy | medium | hard

if (args.Length != 4)
{
    Console.WriteLine("Usage: dotnet run scripts/new.cs <number> <slug> <pattern> <difficulty>");
    return 1;
}

var root = FindRoot();
var problems = Path.Combine(root, "problems");
int num = int.Parse(args[0]);
string slug = args[1];
string want = args[2].ToLower().Replace("dp", "dynamic-programming");
string difficulty = char.ToUpper(args[3][0]) + args[3][1..].ToLower();

var folders = Directory.GetDirectories(problems).OrderBy(d => d).ToList();
var matches = folders.Where(d => Path.GetFileName(d).Contains(want)).ToList();
if (matches.Count != 1)
{
    Console.WriteLine($"Pattern '{args[2]}' matched {matches.Count} folders. Options:");
    folders.ForEach(f => Console.WriteLine("  " + Path.GetFileName(f)[3..]));
    return 1;
}

var folder = matches[0];
var path = Path.Combine(folder, $"{num:D4}-{slug}.cs");
if (File.Exists(path))
{
    Console.WriteLine($"Already exists: {Path.GetRelativePath(root, path)}");
    return 1;
}

string title = string.Join(" ", slug.Split('-').Select(w => char.ToUpper(w[0]) + w[1..]));
string text = File.ReadAllText(Path.Combine(root, "templates", "Solution.cs"))
    .Replace("{num}", num.ToString())
    .Replace("{title}", title)
    .Replace("{slug}", slug)
    .Replace("{difficulty}", difficulty)
    .Replace("{date}", DateTime.Today.ToString("yyyy-MM-dd"));
File.WriteAllText(path, text);
Console.WriteLine($"Created {Path.GetRelativePath(root, path)}");
return 0;

static string FindRoot()
{
    var dir = new DirectoryInfo(Directory.GetCurrentDirectory());
    while (dir != null && !Directory.Exists(Path.Combine(dir.FullName, "problems")))
        dir = dir.Parent;
    return dir?.FullName ?? throw new Exception("Run this from inside the repo.");
}
