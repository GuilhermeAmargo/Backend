public class UserComparer : IComparer<Account>
{
    public int Compare(Account a1, Account a2)
    {
        return a1.User.CompareTo(a2.User);
    }
}