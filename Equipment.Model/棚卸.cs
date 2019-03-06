namespace Equipment.Model
{
    public class 棚卸 : ITMEvent<資産管理, 社員>
    {
        [TMIdentifier]
        string 棚卸番号;

        Date 棚卸日;
    }
}