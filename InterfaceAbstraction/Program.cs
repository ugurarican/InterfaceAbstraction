//Çalışan örneklerini oluşturuyoruz.
using InterfaceAbstraction;

IWorker softwareDeveloper = new SoftwareDeveloper
{
    Name = "Uğur",
    Surname = "Arican",
    Department = "Yazılım Geliştirme"
};

IWorker projectManager = new ProjectManager
{
    Name = "İsa",
    Surname = "Hakkı",
    Department = "Proje Yönetimi"
};

IWorker salesRepresentative = new SalesRepresentative
{
    Name = "Cansu",
    Surname = "Melik",
    Department = "Satış Danışmanı"
};

//Görevleri çağırma
Console.WriteLine($"{softwareDeveloper.Name} {softwareDeveloper.Surname}: ");
softwareDeveloper.Duty();

Console.WriteLine($"{projectManager.Name} {projectManager.Surname}: ");
projectManager.Duty();

Console.WriteLine($"{salesRepresentative.Name} {salesRepresentative.Surname}: ");
salesRepresentative.Duty();
