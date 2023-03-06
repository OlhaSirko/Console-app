double ax = 0; double ay = 0;
double bx = 0; double by = 0;
double cx = 0; double cy = 0;

// Ask the user to enter coordinate x of dot A.
Console.WriteLine("Enter coordinate x of dot A, and then press Enter:");
ax = Convert.ToDouble(Console.ReadLine());

// Ask the user to enter coordinate y of dot A.
Console.WriteLine("Enter coordinate y of dot A, and then press Enter:");
ay = Convert.ToDouble(Console.ReadLine());

// Ask the user to enter coordinate x of dot B.
Console.WriteLine("Enter coordinate x of dot B, and then press Enter:");
bx = Convert.ToDouble(Console.ReadLine());

// Ask the user to enter coordinate y of dot B.
Console.WriteLine("Enter coordinate y of dot B, and then press Enter:");
by = Convert.ToDouble(Console.ReadLine());

// Ask the user to enter coordinate x of dot C.
Console.WriteLine("Enter coordinate x of dot C, and then press Enter:");
cx = Convert.ToDouble(Console.ReadLine());

// Ask the user to enter coordinate y of dot C.
Console.WriteLine("Enter coordinate y of dot C, and then press Enter:");
cy = Convert.ToDouble(Console.ReadLine());

//Find the length of the triangle sides.
double AB = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
double BC = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));
double AC = Math.Sqrt(Math.Pow(ax - cx, 2) + Math.Pow(ay - cy, 2));

Console.WriteLine("Length of AB is: " + Convert.ToString(AB));
Console.WriteLine("Length of BC is: " + Convert.ToString(BC));
Console.WriteLine("Length of AC is: " + Convert.ToString(AC));

//Determine if a triangle is equilateral.
bool equilateral;
if (equilateral = Math.Pow(AB, 2) + Math.Pow(AC, 2) == Math.Pow(BC, 2))
{
    Console.WriteLine("Triangle IS 'Equilateral'");
}
else
{
    Console.WriteLine("Triangle IS NOT 'Equilateral'");
}

//Determine if a triangle is isosceles.
bool isosceles;
if (isosceles = AB == BC || BC == AC || AC == AB)
{
    Console.WriteLine("Triangle IS 'Isosceles'");
}
else
{
    Console.WriteLine("Triangle IS NOT 'Isosceles'");
}

//Determine if a triangle is right.
bool right;
double delta = 0.1;
if (right = Math.Pow(BC, 2) - (Math.Pow(AB, 2) + Math.Pow(AC, 2)) <= delta)
{
    Console.WriteLine("Triangle IS 'Right'");
}
else
{
    Console.WriteLine("Triangle IS NOT 'Right'");
}

//Find the perimeter of the triangle.
double P = AB + BC + AC;
Console.WriteLine("Perimeter: " + Convert.ToString(P));

//Find the even numbers from 0 to the value of the triangle perimeter.
Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
for (int i = 0; i <= P; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
