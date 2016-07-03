using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DBContext;
using WindowsFormsApplication1.EFModels;

namespace WindowsFormsApplication1
{
    public static class HelperMethods
    {
        public static async void RemovePartFromDB(int partID, string destination, string reason, int techID)
        {
            using (var context = new InventoryContext())
            {
                var partToUpdate = await context.Part.Where(x => x.QuickID == partID).FirstOrDefaultAsync();
                var transaction = new Transaction();


                if (partToUpdate.Quantity.ToInt32() <= 0)
                {
                    MessageBox.Show($"The quantity of {partToUpdate.PartNumber}-{partToUpdate.Description} has a quantity of 0 or less and cannot be checked out.");

                }
                else
                {
                    transaction.QuickID = partID;
                    transaction.Quantity = -1;
                    transaction.Destination = destination;
                    transaction.TechID = techID;
                    transaction.TransactionType = 0;
                    transaction.Reason = reason;
                    transaction.TimeStamp = DateTime.Now;

                    context.Transaction.Add(transaction);


                    partToUpdate.TransactionID = transaction.TransactionID;
                    var quantity = partToUpdate.Quantity.ToInt32();
                    partToUpdate.Quantity = (quantity - 1).ToString();

                    context.Part.Attach(partToUpdate);
                    var entry = context.Entry(partToUpdate);

                    entry.Property(e => e.Quantity).IsModified = true;
                    entry.Property(e => e.TransactionID).IsModified = true;


                    context.SaveChanges();
                }
            }

        }


    }
}
