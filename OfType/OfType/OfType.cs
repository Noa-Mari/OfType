using System.Collections;

public class OfType : IOfType
{
    public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
    {
        return enumerable.OfType<T>();
    }

    public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
    {
        return enumerable.OfType<TOutput>();
    }

    public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
    {
        // get list of thins whit typ TDerived:TBase chake if ther are TDerived:TBase
        //convert all the item in the list to typ TBase
        //return it as a list
        return derivedItems.Cast<TBase>();
    }

}