public class PrinterFromHell
{
    
    public void print()
    {
        bool notPrinted = true;
        while(notPrinted)
        {
            try
            {
                pprint();
                notPrinted = false;
            }
            //Kan også bare fange alle exceptions i en men w/e
            catch (OutOfPaperException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OutOfTonerException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (PaperJamException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    private void pprint()
    {
        Random rand = new Random();

        int action = rand.Next(0, 2);

        switch (action)
        {
            case 0:
                throw new OutOfPaperException();
            case 1:
                throw new OutOfTonerException();
            case 2:
                throw new PaperJamException();
            case 3:
                Console.WriteLine("printed"); break;
            default:
                break;
        }


    }
}