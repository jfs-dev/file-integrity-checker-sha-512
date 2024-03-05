using System.Security.Cryptography;

namespace file_integrity_checker_sha_512.Services;

public class FileIntegrityService
{
    private static string CalculateHash(string filePath)
    {
        using var sha512 = SHA512.Create();
        using var stream = File.OpenRead(filePath);
        byte[] hash = sha512.ComputeHash(stream);
        
        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
    }

    public static string GetFileHash(string filePath)
    {
        if (!File.Exists(filePath)) throw new FileNotFoundException("O arquivo especificado não existe.", filePath);

        return CalculateHash(filePath);
    }

    public static bool VerifyFileIntegrityChecker(string hashFile, string hashFileCompare)
    {
        return hashFile == hashFileCompare;
    }
}