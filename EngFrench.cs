using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace hw
{
    public class EngFrench
    {
        
       public Dictionary<string, string> words = new Dictionary<string, string>();

public Dictionary<string, string> InputData(){

string v;
WriteLine("enter a value of words: ");
v = ReadLine();
int value = int.Parse(v);
        string english;
        string french;



               for (int i = 0; i < value; i++){
                Write("Login{0} --> ", i);
                WriteLine("enter an english word: ");
                english = ReadLine();


                WriteLine("enter the french translate: ");
                french = ReadLine();
                words.Add(english, french);
                Clear();
            }
            return words;

}



public void DeleteWord(){
       string english;
       WriteLine("enter a word to delete: ");
                english = ReadLine();
            words.Remove(english);
            if (!words.ContainsKey(english))
        {
            WriteLine("word " + english + " is not found.");
        }
}




public void ChangeWord(){
     string word;
     WriteLine("enter a word to update: ");
     word = ReadLine();
     string newWord;
     WriteLine("enter a new word to update: ");
     newWord = ReadLine();
          
          if (words.ContainsKey(word))
        {
            string value  = words[word];
            words.Remove(word);
            words.Add(newWord, value);
            WriteLine("word " + word + " successully updated to " + newWord);
        }
        else{
              WriteLine("word " + word + " is not found.");
        }
}


public void ChangeTranslate(){
     string translate;
     WriteLine("enter a translate to update: ");
     translate = ReadLine();
     string newTrans;
     WriteLine("enter a new translate to update: ");
     newTrans = ReadLine();
          
          if (words.ContainsKey(translate))
        {
            string value  = words[translate];
            words.Remove(translate);
            words.Add(newTrans, value);
            WriteLine("translate " + translate + " successully updated to " + newTrans);
        }
        else{
              WriteLine("translate " + translate + " is not found.");
        }
}


public void ShowTranslate(string word)
{
    string translate;
    if (words.TryGetValue(word, out translate))
    {
         WriteLine("translate for the word", word, translate);
    }
    else
    {
          WriteLine("word not found.", word);
    }
}
    }
}