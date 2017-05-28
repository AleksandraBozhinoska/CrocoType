using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace Proekt
{
    public class GameDoc
    {
        public string currentWord;
        public int score = 0;
        public int lives = 3;
        private List<char> chars;
      
        public GameDoc()
        {
            chars = new List<char>();
        }

        public void Draw(Graphics g)
        {
            currentWord = generateWord(getLenght());
            chars = currentWord.ToList();
            Brush b = new SolidBrush(Color.White);
            g.DrawString(currentWord, new Font("Arial",24,FontStyle.Bold), b, 205, 205);
            b.Dispose();
        }

        public int getLenght()
        {
            Assembly _assembly;
            StreamReader _textStreamReader;
            _assembly = Assembly.GetExecutingAssembly();
            _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Proekt.words.txt"));
            string line;
            int count = 0;
            while ((line = _textStreamReader.ReadLine()) != null)
            {
                count++;
            }
            _textStreamReader.Close();
            return count; 
        }

        public string generateWord(int c)
        {
            Random r = new Random();
            int lineNumber = r.Next(1, c + 1);
            Assembly _assembly;
            StreamReader _textStreamReader;
            _assembly = Assembly.GetExecutingAssembly();
            _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Proekt.words.txt"));
            int count = 0;
            string line;
            while ((line = _textStreamReader.ReadLine()) != null)
            {
                count++;
                if(count==lineNumber)
                {
                    break;
                }
            }
            _textStreamReader.Close();
            return line;
        }

        internal bool IsGameOver()
        {
            lives--;
            return lives == 0;
        }

        internal bool CheckHit(char keyValue)
        {
            if (chars.Count > 0)
            {
                if (chars[0].Equals(keyValue))
                {
                    chars.RemoveAt(0);
                    
                    return true;
                }
            }
            return false;
        }

        internal bool CheckEmpty()
        {
            bool empty = chars.Count == 0;
            if (empty) score++;
            return empty;
        }
    }
}
