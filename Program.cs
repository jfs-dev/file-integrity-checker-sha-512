using file_integrity_checker_sha_512.Services;

var filePath = "Data/";
var filePathEqual = filePath + "Equal/";
var filePathDifferent = filePath + "Different/";

var hashFilePeterParker = FileIntegrityService.GetFileHash(filePath + "PeterParker.txt");
var hashFileMaryJane = FileIntegrityService.GetFileHash(filePath + "MaryJane.txt");

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine(@"SHA-512 Hash dos arquivos na pasta .\Data\");
Console.WriteLine("------------------------------------------");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"PeterParker.txt - { hashFilePeterParker }");
Console.WriteLine($"MaryJane.txt - { hashFileMaryJane }");

var hashEqualFilePeterParker = FileIntegrityService.GetFileHash(filePathEqual + "PeterParker.txt");
var hashEqualFileMaryJane = FileIntegrityService.GetFileHash(filePathEqual + "MaryJane.txt");

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine(@"SHA-512 Hash dos arquivos na pasta .\Data\Equal\");
Console.WriteLine("------------------------------------------------");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"PeterParker.txt - { hashEqualFilePeterParker }");
Console.WriteLine($"MaryJane.txt - { hashEqualFileMaryJane }");

var hashDifferentFilePeterParker = FileIntegrityService.GetFileHash(filePathDifferent + "PeterParker.txt");
var hashDifferentFileMaryJane = FileIntegrityService.GetFileHash(filePathDifferent + "MaryJane.txt");

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine(@"SHA-512 Hash dos arquivos na pasta .\Data\Different\");
Console.WriteLine("----------------------------------------------------");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"PeterParker.txt - { hashDifferentFilePeterParker }");
Console.WriteLine($"MaryJane.txt - { hashDifferentFileMaryJane }");

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Comparando Hash dos arquivos");
Console.WriteLine("----------------------------");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($@"O arquivo .\Data\PeterParker.txt é igual ao arquivo .\Data\Equal\PeterParker.txt? { FileIntegrityService.VerifyFileIntegrityChecker(hashFilePeterParker, hashEqualFilePeterParker) }");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($@"O arquivo .\Data\PeterParker.txt é igual ao arquivo .\Data\Different\PeterParker.txt? { FileIntegrityService.VerifyFileIntegrityChecker(hashFilePeterParker, hashDifferentFilePeterParker) }");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($@"O arquivo .\Data\MaryJane.txt é igual ao arquivo .\Data\Equal\MaryJane.txt? { FileIntegrityService.VerifyFileIntegrityChecker(hashFileMaryJane, hashEqualFileMaryJane) }");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($@"O arquivo .\Data\MaryJane.txt é igual ao arquivo .\Data\Different\MaryJane.txt? { FileIntegrityService.VerifyFileIntegrityChecker(hashFileMaryJane, hashDifferentFileMaryJane) }");