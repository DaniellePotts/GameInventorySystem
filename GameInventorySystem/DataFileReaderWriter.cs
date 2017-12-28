using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace GameInventorySystem
{
    /// <summary>
    /// this class lets the player serialize and deserialize both the player data and the shop data. it inherits from IFileWriterReader
    /// and can be converted into a new project easily, also, this makes it easier if the user wishes to read from text files rather then 
    /// data files
    /// </summary>
    public class DataFileReaderWriter : IFileWriterReader
    {
        /// <summary>
        /// serialize a serializeable object. this can be either a player or a shop currently. but it could be any object that inherits
        /// the ISerializableObject interface
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="filePath"></param>
        public void SaveGameData(GameData obj, string filePath)
        {
            if (!ReferenceEquals(null, obj))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream outfile = new FileStream(filePath, FileMode.Create, FileAccess.Write);

                bf.Serialize(outfile, obj);

                outfile.Close();
            }
            else
            {
                NullReferenceException nullReference = new NullReferenceException();
                throw (nullReference);
            }
        }


        /// <summary>
        /// deserialize a file and return an ISerializableObject to be assigned to an object in the main program. we throw a null
        /// file exception if the player file is loaded and it has no data. this is only applicable if it is a player because in 
        /// the system, the user can create and save a player without ever having to access the shop. so, it doesnt matter if the shop
        /// is null when the system is loading from the files. 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public GameData LoadGameData(GameData obj, string filePath)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream infile;

            if (!File.Exists(filePath))
            {
                FileNotLoadedProperlyException filenotfound = new FileNotLoadedProperlyException();
                throw (filenotfound);
            }
            else
            {

               infile = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
                while (infile.Position < infile.Length)
                {

                    obj = (GameData)bf.Deserialize(infile);
                }
            
            }
            
            if(obj.player == null)
            {
                //if the player file is null, then throw exception. if the shop file is null, this is ok.this is something 
                //the system expects, because the user can create a player without ever accessing the shop, thus it is 
                //possible the shop file could be null, but the player one could not be. 
                NullFileException fileIsNull = new NullFileException();
                throw (fileIsNull);
            }

            infile.Close();

            
                return obj;
            
        }
    }
}
