// exchange disks from stick 1 to stick 3 using stick 2 (babies' pyramids)

void Towers(string from = "1", string to = "3", string with = "2", int disksNum = 3)// disksNum - number of disks to transfer
{
    if(disksNum>1) Towers(from, with, to, disksNum-1);
    Console.WriteLine($"{from} >> {to}");
    if(disksNum>1) Towers(with, to, from, disksNum-1);
}

Towers();