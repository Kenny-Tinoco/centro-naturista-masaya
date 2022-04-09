namespace WPF.Services
{
    public interface IParameterNavigationService<type>
    {
        void Navigate( type parameter );
    }
}
