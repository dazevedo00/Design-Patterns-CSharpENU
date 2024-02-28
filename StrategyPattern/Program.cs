using Strategy_Pattern;

Console.WriteLine("## Strategy - Pattern ## ");
CompressionContext ctx = new(new CompressionRAR());
Console.WriteLine("## File Name ## ");
var fileName = Console.ReadLine();

Console.WriteLine("## 1 RAR, 2 - ZIP, 3 - GZIP  ## ");
int option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 2:
        ctx.SetStrategy(new CompressionZIP());
        break;
    case 3:
        ctx.SetStrategy(new CompressionGZIP());
        break;

    default:
        ctx.SetStrategy(new CompressionRAR());

        break;
}

ctx.CreateCompressedFile(fileName);

Console.ReadLine();
