using System.Collections;

public class OfType : IOfType
{
    public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
    {

        foreach (object type in enumerable)
        {
            if (type is T Ttype)
            {
                yield return Ttype ;
            }
        }
        
    }

    public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
    {
        foreach (TSource type in enumerable)
        {
            if (type is TOutput Ttype)
            {
                yield return Ttype ;
            }
        }
    }

    public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
    {
        // get list of thins whit typ TDerived:TBase check if there are TDerived:TBase
        //convert all the item in the list to typ TBase
        //return it as a list
        foreach (TDerived type in derivedItems)
        {
            // i know that all the item are already TBase type so i do not need to check
                yield return type;
            
        }
    }

}