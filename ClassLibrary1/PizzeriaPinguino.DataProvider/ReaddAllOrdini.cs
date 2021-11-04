namespace PizzeriaPinguino.DataProvider
{
    public class ReadAllOrdini
    {
        public void All()
        {
            var folderreader = new FolderReader();
            var filelist = folderreader.GetFilesCsv("boh");
            var filereader = new FileReader();
            var filehandler = new FileHandler();
            foreach (var f in filelist)
            {

                var ordini = filereader.Read(f);
                foreach (var ordine in ordini)
                {
                    filehandler.FileSeparator(ordine);
                    //trasformo l'ordine in pizza e lo aggiungo alla lista
                }
            }
            //return lista pizze

        }
    }

}