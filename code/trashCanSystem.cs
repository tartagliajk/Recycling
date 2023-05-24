using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recycling
{
    public class trashCanSystem
    {
        private static trashCanSystem? instance = null;
        private static string trashFilePath = "C:\\Users\\nina.vazae\\Desktop\\recycling\\trashcans.txt";

        private List<trashCan> trashCans = new List<trashCan>();

        public List<trashCan> getCans() { return trashCans; }

        private trashCanSystem()
        {
            loadTrashCans();
        }

        public void addCan(trashCan trashcan)
        {
            trashCans.Add(trashcan);
            save();
        }

        public void save()
        {
            string[] trashCansArr = trashCans.Select(trashcan => $"{trashcan.Id} {trashcan.Name} {trashcan.Item} {trashcan.Color}").ToArray();

            File.WriteAllLines(trashFilePath, trashCansArr);
        }

        public static trashCanSystem GetInstance()
        {
            if (instance == null)
            {
                instance = new trashCanSystem();
            }
            return instance;
        }

        void loadTrashCans()
        {
            string[] trashCansfromDb = File.ReadAllLines(trashFilePath);

            for(var i = 0; i < trashCansfromDb.Length; i++)
            {
                string trashStr = trashCansfromDb[i];
                string[] trashLineTokens = trashStr.Split(" ");
                string trashId = trashLineTokens[0];
                string trashName = trashLineTokens[1];
                string trashItem = trashLineTokens[2];
                string trashColor = trashLineTokens[3];

                trashCan trashcan = new trashCan(trashId, trashName, trashItem, trashColor);
                trashCans.Add(trashcan);
            }
        }
    }
}
