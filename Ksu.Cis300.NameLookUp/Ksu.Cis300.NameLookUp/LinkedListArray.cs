using Ksu.Cis300.NameLookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ksu.Cis300.NameLookUp
{
    public class LinkedListArray
    {
        private static LinkedListCell<NameInformation>[] _lists = new LinkedListCell<NameInformation>[26];
        /// <summary>
        /// gets the beginning of the linked list cells that contain the desired names
        /// </summary>
        /// <param name="namePrefix">prefix of desired names</param>
        /// <returns></returns>
        public LinkedListCell<NameInformation> FindFirstCell(string namePrefix)
        {
            LinkedListCell<NameInformation> first = _lists[namePrefix[0] - 'A'];
            if (first != null)
            {
                while (!first.Data.Name.StartsWith(namePrefix))
                {
                    first = first.Next;
                }
                return first;
            }
            else return null;
        }

        public LinkedListCell<NameInformation> InsertNameInformation(NameInformation info, LinkedListCell<NameInformation> cell)
        {
            string name = info.Name;
            
            if (cell == null)
            {
                LinkedListCell<NameInformation> tempCell = new LinkedListCell<NameInformation>();
                tempCell.Data = info;
                return tempCell;
            }
            else if (cell.Data.Name.CompareTo(name) >= 0) ///might be backward
            {
                LinkedListCell<NameInformation> moveOverCell = new LinkedListCell<NameInformation>();
                moveOverCell.Next = cell;
                moveOverCell.Data = info;
                cell = moveOverCell;
                return cell;
            }
            else
            {
                LinkedListCell<NameInformation> inBetweenCell = new LinkedListCell<NameInformation>();
                LinkedListCell<NameInformation> beforeInBetween = new LinkedListCell<NameInformation>();
                LinkedListCell<NameInformation> originalList = new LinkedListCell<NameInformation>();
                inBetweenCell.Data = info;
                beforeInBetween = cell;
                while (beforeInBetween.Next != null)
                {
                    int compare = beforeInBetween.Next.Data.Name.CompareTo(name);
                    
                    if (compare > 0)
                    {
                        beforeInBetween = beforeInBetween.Next;
                    }
                    else
                    {
                        cell.Next = beforeInBetween;
                        inBetweenCell.Next = beforeInBetween.Next;
                        beforeInBetween.Next = inBetweenCell;


                    }
                }
                return null;
               

            }
        }

        public void LoadFile(string filename)
        {
           LinkedListCell<NameInformation>[] tempList = _lists;
           try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] splitLine = sr.ReadLine().Split('\t');
                        string name = splitLine[0];
                        float frequency = float.Parse(splitLine[1]);
                        float cumulativeFrequency = float.Parse(splitLine[2]);
                        int rank = Convert.ToInt32(splitLine[3]);
                        NameInformation newInfo = new NameInformation(name, frequency, rank, cumulativeFrequency);
                        tempList[name[0] - 'A'] = InsertNameInformation(newInfo, tempList[name[0] - 'A']);
                    }
                    MessageBox.Show("File loaded");
                }
                _lists = tempList;
            }
            catch (Exception ex)
            {
                throw new System.Exception("Error reading file, no information was changed." + ex);
            }
        }
    }
}
