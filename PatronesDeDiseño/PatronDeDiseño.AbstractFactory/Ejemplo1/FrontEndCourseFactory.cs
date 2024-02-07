namespace PatronDeDiseño.AbstractFactory.Ejemplo1
{
    public class FrontEndCourseFactory : ICourseFactory
    {
        public ICourse CreateBackEndCourse()
        {
            return new BackEndCourse();
        }

        public ICourse CreateFrontEndCourse()
        {
            return new FrontEndCourse();
        }
    }
}
