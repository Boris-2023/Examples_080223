// algorythm of directory overview by recursion; all files & folders

string path = @"/home/boris/GB/Programming languages basics C#/Lectures 1/Examples/Example001_HelloConsole";//sets path of the folder
DirectoryInfo di = new DirectoryInfo(path); //info on the directory

Console.WriteLine(di.CreationTime);//e.g. time of creation

FileInfo[] fi = di.GetFiles();//array of files features

for (int i = 0; i < fi.Length; i++)//for all the files in the array/folder
{
    Console.WriteLine(fi[i].Name);//prints name
}

void CatalogInfo(string path, string indent = "")//arguments: path for the folder & a serv symbol for layout inside folder/files
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }

    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }

}

CatalogInfo(path);
