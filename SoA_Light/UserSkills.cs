
namespace SoA_Light
{
    class UserSkills
    {
        private int count;

        public void Jump(int count)
        {
           this.count = count;
           User.Strength = count;
        }

        public void SomeMethod() 
        {
            count = 17;
        }

        public void SomethingElse()
        {
            System.Console.WriteLine(count);
        }
    }
}
