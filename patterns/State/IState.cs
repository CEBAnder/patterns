namespace Patterns.State
{
    public interface IState
    {
        void DoFirstAction(Context context);

        void DoSecondAction(Context context);

        void DoThirdAction(Context context);
    }
}
