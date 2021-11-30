
namespace SoA_Light
{
    class Program
    {
        static void Main(string[] args)
        {
            UserSkills userSkills = new UserSkills();

            userSkills.Jump(4);
            userSkills.SomeMethod();
            userSkills.SomethingElse();

            System.Console.WriteLine(User.Strength);
        }
    }
}
