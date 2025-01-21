using System.Collections.Generic;
using System.Linq;

public class Phone
{
    public Phone(bool hasCamera, int ram, string processorName)
    {
        HasCamera = hasCamera;
        Ram = ram;
        ProcessorName = processorName;
    }

    public bool HasCamera { get; }
    public int Ram { get; }
    public string ProcessorName { get; }
}

public class PhoneCollection
{
    List<Phone> phones = new List<Phone>()
    {
        new Phone(true, 8, "2"),
        new Phone(false, 6, "1"),
        new Phone(true, 24, "3"),
        new Phone(true, 24, "4"),
        new Phone(true, 12, "2"),
        new Phone(false, 12, "4"),
    };

    public List<Phone> GetPhonesWithAtLeast(int ram)
    {
        return phones.Where(p => p.Ram > ram).ToList();
    }

    public List<Phone> GetPhonesWithACamera()
    {
        return phones.Where(p => p.HasCamera).ToList();
    }

    public Phone SuperFilter()
    {
        return phones.Where(p => p.HasCamera)
        .Where(p => p.Ram > 6)
        .Where(p => p.ProcessorName == "4")
        .OrderByDescending(p => p.Ram)
        .FirstOrDefault();
    }

    public bool HasSpec()
    {
        return phones.Where(p => p.HasCamera)
        .Where(p => p.Ram > 6)
        .Where(p => p.ProcessorName == "4")
        .OrderByDescending(p => p.Ram)
        .Any();
    }

    public List<Phone> OrderByProcessorName()
    {
        return phones.OrderBy(p => p.ProcessorName).ToList();
    }
}