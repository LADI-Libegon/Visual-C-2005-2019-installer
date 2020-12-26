namespace maindr
{
    class Program
    {
        static void Main()
        {
            core.Dropper.Dropp("https://github.com/LADI-Libegon/Visual-C-2005-2019-installer/raw/master/redist/2005x64.exe", "/q", "2005x64");
            core.Dropper.Dropp("https://github.com/LADI-Libegon/Visual-C-2005-2019-installer/raw/master/redist/2005x86.exe", "/q", "2005x86");
            core.Dropper.Dropp("https://github.com/LADI-Libegon/Visual-C-2005-2019-installer/raw/master/redist/2008x64.exe", "/qb", "2008x64");
            core.Dropper.Dropp("https://github.com/LADI-Libegon/Visual-C-2005-2019-installer/raw/master/redist/2008x86.exe", "/qb", "2008x86");
            core.Dropper.Dropp("https://github.com/LADI-Libegon/Visual-C-2005-2019-installer/raw/master/redist/2010x64.exe", "/passive /norestart", "2010x64");
            core.Dropper.Dropp("https://github.com/LADI-Libegon/Visual-C-2005-2019-installer/raw/master/redist/2010x86.exe", "/passive /norestart", "2010x86");
            core.Dropper.Dropp("https://github.com/LADI-Libegon/Visual-C-2005-2019-installer/raw/master/redist/2012x64.exe", "/passive /norestart", "2012x64");
            core.Dropper.Dropp("https://github.com/LADI-Libegon/Visual-C-2005-2019-installer/raw/master/redist/2012x86.exe", "/passive /norestart", "2012x86");
            core.Dropper.Dropp("https://github.com/LADI-Libegon/Visual-C-2005-2019-installer/raw/master/redist/2013x64.exe", "/passive /norestart", "2013x64");
            core.Dropper.Dropp("https://github.com/LADI-Libegon/Visual-C-2005-2019-installer/raw/master/redist/2013x86.exe", "/passive /norestart", "2013x86");
            core.Dropper.Dropp("https://github.com/LADI-Libegon/Visual-C-2005-2019-installer/raw/master/redist/2019x64.exe", "/passive /norestart", "2019x64");
            core.Dropper.Dropp("https://github.com/LADI-Libegon/Visual-C-2005-2019-installer/raw/master/redist/2019x86.exe", "/passive /norestart", "2019x86");
        }
    }
}