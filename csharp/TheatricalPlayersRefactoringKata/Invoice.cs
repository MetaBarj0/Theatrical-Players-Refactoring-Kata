using System.Collections.Generic;

namespace TheatricalPlayersRefactoringKata
{
    public class Invoice
    {
        public string Customer { get; }
        public IReadOnlyList<Performance> Performances { get; }

        public Invoice(string customer, List<Performance> performance)
        {
            Customer = customer;
            Performances = performance.AsReadOnly();
        }

    }
}
