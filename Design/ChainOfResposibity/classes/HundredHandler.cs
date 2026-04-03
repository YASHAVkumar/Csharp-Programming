using System;
namespace ChainOfResponsibilityDesignPattern
{
    //Concrete Handler 4
    //The following class implement the Handler abstract class and 
    //Provide Implementation for DispatchNote abstract method
    public class HundredHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            //First Check the Number of 100 Notes To Be Dispatched
            long numberofNotesToBeDispatched = requestedAmount / 100;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred notes are dispatched by HundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred note is dispatched by HundredHandler");
                }
            }
 long pendingAmountToBeProcessed = requestedAmount % 100;
            //No Need to Check the Next Handler
            if (pendingAmountToBeProcessed > 0)
            {
                //For TwoThousandHandler, the next handler is FiveHundredHandler 
                NextHandler.DispatchNote(pendingAmountToBeProcessed);
            }
        }
    }
}